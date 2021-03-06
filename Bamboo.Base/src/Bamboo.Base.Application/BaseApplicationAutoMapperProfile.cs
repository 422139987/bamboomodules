﻿using AutoMapper;
using Bamboo.Base.Dtos;
using Bamboo.Base.Entities;

namespace Bamboo.Base
{
    public class BaseApplicationAutoMapperProfile : Profile
    {
        public BaseApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Bank, BankDto>();
        }
    }
}