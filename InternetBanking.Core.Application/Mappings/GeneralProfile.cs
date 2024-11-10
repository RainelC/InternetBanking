using AutoMapper;
using InternetBanking.Core.Application.ViewModels.Beneficiary;
using InternetBanking.Core.Application.ViewModels.Products;
using InternetBanking.Core.Application.ViewModels.Transaction;
using InternetBanking.Core.Application.ViewModels.Users;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Beneficiary, BeneficiaryViewModel>()
                .ReverseMap();

            CreateMap<Beneficiary, SaveBeneficiaryViewModel>()
                .ReverseMap();

            CreateMap<Product, ProductViewModel>()
                .ReverseMap();

            CreateMap<Product, SaveProductViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.User, opt => opt.Ignore());


            CreateMap<Transaction, TransactionViewModel>()
                .ReverseMap();

            CreateMap<Transaction, SaveTransactionViewModel>()
                .ReverseMap();

            CreateMap<User, UserViewModel>()
              .ReverseMap();

            CreateMap<User, SaveUserViewModel>()
                .ForMember(dest => dest.ConfirmPassword, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Products, opt => opt.Ignore());
        }
    }
}
