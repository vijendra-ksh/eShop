using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using eShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using eShop.Repositories;
namespace eShop
{
public class Startup
{
public IConfiguration Configuration { get;}
public Startup(IConfiguration configurationParam)
{
    Configuration = configurationParam;
}
public void ConfigureServices(IServiceCollection services)
{
services.AddDbContext<AppDbContext>(options=>
options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
services.AddControllersWithViews();
services.AddScoped<ICategoryRepository, CategoryRepository>();
services.AddScoped<IProductRepository, ProductRepository>();
}
                
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
if (env.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
endpoints.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
    );
});
}
}
}
