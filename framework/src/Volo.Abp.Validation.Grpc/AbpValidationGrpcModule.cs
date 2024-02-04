using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Grpc.Core;
using Volo.Abp.Modularity;

namespace Volo.Abp.Validation;

[DependsOn(
    typeof(AbpValidationModule),
    typeof(AbpGrpcCoreModule), 
    typeof(AbpAutoMapperModule)
)]
public class AbpValidationGrpcModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<AbpValidationGrpcModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<AbpValidationGrpcModule>(validate: true);
        });
    }
}
