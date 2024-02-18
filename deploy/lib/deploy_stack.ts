import {
  EcsConstruct,
  getEnv,
  getResourceName,
  ServiceVisibility,
} from "@cashrewards/cdk-lib";
import { Stack, StackProps } from "aws-cdk-lib";
import { Construct } from "constructs";
import * as s3 from 'aws-cdk-lib/aws-s3'
import { Topic } from "aws-cdk-lib/aws-sns";
import { PolicyStatement } from "aws-cdk-lib/aws-iam";
import { Table } from 'aws-cdk-lib/aws-dynamodb';

export class DotnetStack extends Stack {
  constructor(scope: Construct, id: string, props?: StackProps) {
    super(scope, id, props);

    const ecsConstruct = new EcsConstruct(this, getResourceName(getEnv("PROJECT_NAME")), {
      environmentName: getEnv("ENVIRONMENT_NAME"),
      serviceName: getEnv("PROJECT_NAME"),
      visibility: ServiceVisibility.PUBLIC,
      imageTag: getEnv("VERSION"),
      pathPattern: "api/offers",
      healthCheckPath: "api/offers/health-check",
      minCapacity: +getEnv("minCapacity"),
      maxCapacity: 10,
      desiredCount: +getEnv("desiredCount"),
      scalingRule: {
        cpuScaling: {
          targetUtilizationPercent: 40,
          scaleInCooldown: 60,
          scaleOutCooldown: 60
        },
        memoryScaling: {
          targetUtilizationPercent: 99,
          scaleInCooldown: 60,
          scaleOutCooldown: 60
        }
      },
      environment: {
        SQLServerHostWriter: getEnv("SQLServerHostWriter"),
        SQLServerHostReader: getEnv("SQLServerHostReader"),
        ShopGoDBName: getEnv("ShopGoDBName"),
        AuroraHostWriter: getEnv("AuroraHostWriter"),
        AuroraHostReader: getEnv("AuroraHostReader"),
        DocumentDBHostWriter: getEnv("DocumentDBHostWriter"),
        DocumentDBHostReader: getEnv("DocumentDBHostReader"),
        RedisHost: getEnv("RedisHost"),
        CLODBName: getEnv("CLODBName"),
        Environment: getEnv("Environment"),
        LOG_LEVEL: getEnv("LOG_LEVEL"),
        MERCHANT_PREFERENCES_BUCKET: getEnv("PrivateSharedStorageBucket"),
        MERCHANT_PREFERENCES_PATH: getEnv("MerchantPreferencesPath"),
        "AWS:UserPoolId": getEnv("UserPoolId"),
        "Config:PopularStoreInfoTable": getEnv("PopularStoreInfoTable")
      },
      secrets: {
        "ConnectionStrings:ShopGoReadOnlyConnectionString": getEnv(
          "ShopGoReadOnlyConnectionStringSsmParam"
        ),
        DocumentDbUsername: getEnv("DocumentDbUsernameSsmParam"),
        DocumentDbPassword: getEnv("DocumentDbPasswordSsmParam"),
        UnleashApiKey: getEnv("UnleashApiKeySsmParam")
      }
    });

    const privateSharedBucket = s3.Bucket.fromBucketName(
      this, 
      getResourceName("PrivateSharedStorageBucket"), 
      getEnv("PrivateSharedStorageBucket"));
    privateSharedBucket.grantRead(ecsConstruct.taskRole);

    const topic = Topic.fromTopicArn(this, "OfferTopicArn", getEnv("OfferTopicArn"));
    topic.grantPublish(ecsConstruct.taskRole);
    ecsConstruct.taskRole.addToPrincipalPolicy(new PolicyStatement({
      actions: [ "SNS:ListTopics" ],
      resources: [ "*" ]
    }));

    const dynamoTable = Table.fromTableName(this, 'PopularStoreDynamoTable', getEnv("PopularStoreInfoTable"));
    dynamoTable.grantReadData(ecsConstruct.taskRole);
  }
}
