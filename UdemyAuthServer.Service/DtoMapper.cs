using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyAuthServer.Core.Dto;
using UdemyAuthServer.Core.Entities;

namespace UdemyAuthServer.Service
{
    internal class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, User>().ReverseMap();
        }
    }
}