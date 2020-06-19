using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DormManagementApp;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DormManagementWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc(opt =>
            {
                #region 配置全局路由
                opt.UseCentralRoutePrefix(new RouteAttribute("[controller]/[action]"));
                #endregion

            }).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddDbContext<SystemDbContext>(optionsBuilder => {
                var dataAppSetting = Configuration.GetSection("ConnectionSetting").Get<string>();
                if (dataAppSetting == null)
                {
                    throw new Exception("未配置数据库连接");
                }

                //switch (dataAppSetting.DbType)
                //{
                //    case 1:
                //        //server连接，EnableRetryOnFailure表示失败支持重试；
                //        optionsBuilder.(dataAppSetting.UserConnectionString, option => option.EnableRetryOnFailure());
                //        break;
                //    default:
                //        optionsBuilder.UseMySQL(dataAppSetting.UserConnectionString);
                //        break;
                //}
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllers();
                endpoints.MapDefaultControllerRoute();
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller=WeatherForecast}/{action=Index}/{id?}");

            });
        }
    }
}
