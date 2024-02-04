using AutoMapper;
using Volo.Abp.Validation.StringValues;
using StringValuesV8 = Volo.Abp.Validation.StringValues.V8;
namespace Volo.Abp.Validation.Grpc;

public class ValidationProfile : Profile
{
    public ValidationProfile()
    {
        CreateMap<IStringValueType, StringValuesV8.StringValueType>();
        CreateMap<StringValuesV8.StringValueType, IStringValueType>()
            .ForMember(x => x.Name, o => o.MapFrom(x => x.Name));

        CreateMap<StringValuesV8.StringValueType, ToggleStringValueType>()
            .IncludeBase<StringValuesV8.StringValueType, IStringValueType>();

        CreateMap<StringValuesV8.StringValueType, FreeTextStringValueType>()
            .IncludeBase<StringValuesV8.StringValueType, IStringValueType>();

        CreateMap<StringValuesV8.StringValueType, SelectionStringValueType>()
            .IncludeBase<StringValuesV8.StringValueType, IStringValueType>()
            .ForMember(x => x.ItemSource, o =>
            {
                o.MapFrom(x => x.Selection);
                // o.Condition(x=>x is )
            });
    }
}