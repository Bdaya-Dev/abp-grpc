using Volo.Abp.FeatureManagement.Grpc.Core;
using Volo.Abp.Modularity;

namespace Volo.Abp.FeatureManagement.Grpc.Client;

[DependsOn(typeof(AbpFeatureManagementGrpcCoreModule))]
public class AbpFeatureManagementGrpcClientModule : AbpModule
{

}
