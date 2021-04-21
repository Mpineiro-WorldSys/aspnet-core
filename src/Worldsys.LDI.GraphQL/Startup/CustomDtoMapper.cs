﻿using AutoMapper;
using Worldsys.LDI.Authorization.Users;
using Worldsys.LDI.Dto;

namespace Worldsys.LDI.Startup
{
    public static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<User, UserDto>()
                .ForMember(dto => dto.Roles, options => options.Ignore())
                .ForMember(dto => dto.OrganizationUnits, options => options.Ignore());
        }
    }
}