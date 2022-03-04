using Library.DataAccess;
using Library.DataAccess.Abstract;
using Library.DataAccess.Concrete;
using Library.Entities.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi
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
            services.AddSingleton<IBookRepository,BookRepository>();
            services.AddSingleton<ILibraryBase<Category>, LibraryBase<Category>>();
            services.AddSingleton<ILibraryBase<Book>, LibraryBase<Book>>();
            services.AddSingleton<ILibraryBase<Member>, LibraryBase<Member>>();
            services.AddSingleton<IMemberRepository, MemberRespository>();
            services.AddSingleton<ILibraryBase<BookStatus>, LibraryBase<BookStatus>>();
            services.AddSingleton<IBookStatusRepository, BookStatusRepository>();
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
            app.UseMiddleware<GlobalErrorHandlingMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
