using System;
using EgeRoro.Business.Abstract;
using EgeRoro.Business.Concreate;
using EgeRoro.Entity.Identity;
using EgeRoroData.Abstract;
using EgeRoroData.Concreate;
using EgeRoroData.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Connection string ile her iki DbContext'i yapýlandýrýn


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<Context>();

builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<Context>()
    .AddDefaultTokenProviders();


builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddScoped<ServiceManager>();

builder.Services.AddScoped<IFleetDal, EfFleetDal>();
builder.Services.AddScoped<FleetManager>();

builder.Services.AddScoped<IGalleryDal, EfGalleryDal>();
builder.Services.AddScoped<GalleryManager>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
