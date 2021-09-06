﻿using BasonManagement.Web.Areas.Admin.Models;
using AutoMapper;
using System.Security.Claims;

namespace BasonManagement.Web.Areas.Admin.Mappings
{
    public class ClaimsProfile : Profile
    {
        public ClaimsProfile()
        {
            CreateMap<Claim, RoleClaimsViewModel>().ReverseMap();
        }
    }
}