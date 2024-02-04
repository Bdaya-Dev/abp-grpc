using AutoMapper;
using Volo.Abp.V8;

namespace Volo.Abp.Grpc.Core.Profiles;

public class CoreProfile : Profile
{
    public CoreProfile()
    {
        CreateMap<decimal, DecimalValue>()
            .ConvertUsing((src) => DecimalValue.FromDecimal(src));
        CreateMap<DecimalValue, decimal>()
            .ConvertUsing((src) => src.ToDecimal());
    }
}