﻿using HastaneRandevu.BL.Abstract;
using HastaneRandevu.BL.Concrete;
using HastaneRandevu.DAL.Context;
using HastaneRandevu.DAL.Repository.Abstract;
using HastaneRandevu.DAL.Repository.Concrete;
using HastaneRandevu.MVC.Extensions;
using Microsoft.EntityFrameworkCore;

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
            // hata alıyorum
            builder.Services.AddRandevuServisleri();
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