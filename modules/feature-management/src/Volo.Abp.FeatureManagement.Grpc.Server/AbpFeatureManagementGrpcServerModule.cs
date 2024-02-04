using Volo.Abp.FeatureManagement.Grpc.Core;
using Volo.Abp.Modularity;

namespace Volo.Abp.FeatureManagement.Grpc.Server;

[DependsOn(typeof(AbpFeatureManagementGrpcCoreModule))]
public class AbpFeatureManagementGrpcServerModule
{

}
