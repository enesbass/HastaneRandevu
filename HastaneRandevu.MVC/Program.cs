using HastaneRandevu.DAL.Context;
using HastaneRandevu.MVC.AutoMapperProfile;
using HastaneRandevu.MVC.Extensions;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace HastaneRandevu.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //----------Benim yazdiklarim--------------
            //json dosyas?ndaki tanimlamayi sqldbcontext nesnesine tanittik.
            builder.Services.AddDbContext<SqlDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("Randevu")));
            //----------Benim yazdiklarim--------------

            //----------Benim yazdiklarim--------------
            //Extensionda manager sinifina mvcye register ettigimiz kismi calistirdik.
            builder.Services.AddRandevuServisleri();
            //----------Benim yazdiklarim--------------

            //----------Benim yazdiklarim--------------
            // AutoMapper Servislerini ayaga kaldirir
            builder.Services.AddAutoMapper(typeof(RandevuProfile));
            //----------Benim yazdiklarim--------------


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}