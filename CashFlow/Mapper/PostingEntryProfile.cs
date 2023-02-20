using AutoMapper;
using CashFlow.Domain.Entities;
using CashFlow.ViewModels;

namespace CashFlow.Mapper
{
    public class PostingEntryProfile : Profile
    {
        public PostingEntryProfile()
        {
            CreateMap<PostingEntryViewModel, PostingEntry>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id)
                )
                .ForMember(
                    dest => dest.OperationType,
                    opt => opt.MapFrom(src => $"{src.OperationType}")
                )
                .ForMember(
                    dest => dest.OperationCurrency,
                    opt => opt.MapFrom(src => $"{src.OperationCurrency}")
                )
                .ForMember(
                    dest => dest.OperationValue,
                    opt => opt.MapFrom(src => $"{src.OperationValue}")
                )
                .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(src => $"{src.Description}")
                )
                .ForMember(
                    dest => dest.Observation,
                    opt => opt.MapFrom(src => $"{src.Observation}")
                )          
                .ForMember(
                    dest => dest.OperationDate,
                    opt => opt.MapFrom(src => $"{src.OperationDate}")
                );


            CreateMap<PostingEntry, PostingEntryViewModel>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Id)
                )
                .ForMember(
                    dest => dest.OperationType,
                    opt => opt.MapFrom(src => $"{src.OperationType}")
                )
                .ForMember(
                    dest => dest.OperationCurrency,
                    opt => opt.MapFrom(src => $"{src.OperationCurrency}")
                )
                .ForMember(
                    dest => dest.OperationValue,
                    opt => opt.MapFrom(src => $"{src.OperationValue}")
                )
                .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(src => $"{src.Description}")
                )
                .ForMember(
                    dest => dest.Observation,
                    opt => opt.MapFrom(src => $"{src.Observation}")
                )
                .ForMember(
                    dest => dest.OperationDate,
                    opt => opt.MapFrom(src => $"{src.OperationDate}")
                );

        }
    }
}