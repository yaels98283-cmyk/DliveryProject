using AutoMapper;
using Delivery.Core.DTOs;
using Delivery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Delivers, DeliversDTO>().ReverseMap();
            CreateMap<Packages, PackagesDTO>().ReverseMap();
            CreateMap<Recipients, RecipientsDTO>().ReverseMap();
        }
    }
}
