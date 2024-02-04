using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Volo.Abp.Grpc.Core;

[DependsOn(typeof(AbpAutoMapperModule))]
public class AbpGrpcCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<AbpGrpcCoreModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<AbpGrpcCoreModule>(validate: true);
        });
    }
}
