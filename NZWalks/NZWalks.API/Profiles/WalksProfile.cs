﻿using AutoMapper;

namespace NZWalks.API.Profiles
{
    public class WalksProfile : Profile
    {
        public WalksProfile()
        {
            CreateMap<Models.DTO.Walk, Models.Domain.Walk>().ReverseMap();  
            CreateMap<Models.Domain.WalkDifficulty, Models.DTO.WalkDifficulty>().ReverseMap();

            CreateMap<Models.DTO.AddWalkRequest, Models.Domain.Walk>();
            CreateMap<Models.DTO.UpdateWalkRequest, Models.Domain.Walk>();
        }
    }
}
