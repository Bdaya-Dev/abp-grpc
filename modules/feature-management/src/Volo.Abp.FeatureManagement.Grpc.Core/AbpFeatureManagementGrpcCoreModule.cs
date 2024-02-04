using Volo.Abp.Modularity;

namespace Volo.Abp.FeatureManagement.Grpc.Core;

[DependsOn(typeof(AbpFeatureManagementApplicationContractsModule))]
public class AbpFeatureManagementGrpcCoreModule : AbpModule
{

}
