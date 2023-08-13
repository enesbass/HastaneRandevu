using HastaneRandevu.BL.Abstract;
using HastaneRandevu.BL.Concrete;
using HastaneRandevu.DAL.Repository.Abstract;
using HastaneRandevu.DAL.Repository.Concrete;

namespace HastaneRandevu.MVC.Extensions
{
    public static class AddRandevuServis
    {
        public static IServiceCollection AddRandevuServisleri(this IServiceCollection services)
        {
            services.AddScoped<IBolumRepository, BolumRepository>();
            services.AddScoped<IBolumManager, BolumManager>();

            services.AddScoped<IDoktorRepository, DoktorRepository>();
            services.AddScoped<IDoktorManager, DoktorManager>();

            services.AddScoped<IHastaRepository, HastaRepository>();
            services.AddScoped<IHastaManager, HastaManager>();
            
            services.AddScoped<IRandevuRepository, RandevuRepository>();
            services.AddScoped<IRandevuManager, RandevuManager>();

            return services;
        }
    }
}
