using AutoMapper;
using HastaneRandevu.Entity.Concrete;
using HastaneRandevu.MVC.Models.DTOs;

namespace HastaneRandevu.MVC.AutoMapperProfile
{
    public class RandevuProfile:Profile
    {
        public RandevuProfile()
        {
            CreateMap<HastaCreateDTO,Hasta>();
            CreateMap<HastaUpdateDTO,Hasta>();
        }
    }
}
