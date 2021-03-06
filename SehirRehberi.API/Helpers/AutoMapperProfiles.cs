﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SehirRehberi.API.Dtos;
using SehirRehberi.API.Models;

namespace SehirRehberi.API.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, CityForListDto>()
                .ForMember(dest=>dest.PhotoUrl, opt =>
                {
                    opt.MapFrom(src=>src.Photos.FirstOrDefault(p=>p.IsMain).Url);
                });

            CreateMap<Product, CityForDetailDto>();
            CreateMap<Catalog, CatalogForReturnDto>();
            CreateMap<PhotoForCreationDto,Photo>();
            CreateMap<PhotoForReturnDto, Photo > ();
        }
    }
}
