
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Repositories
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddDbContext<DB>(opt => opt.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\אילה\DATABASEEE.MDF;Integrated Security=True;Connect Timeout=30")); 
              services.AddScoped<ICustomersRepository, CustomersRepository>();
              services.AddScoped<IFeedbackRepository, FeedbackRepository>();
              services.AddScoped<ISadottypeofworkerRepository, SadottypeofworkerRepository>();
              services.AddScoped<ISadottypeRepository, SadottypeRepository>();


            services.AddScoped<IStatusRepository, StatusRepository>();
            services.AddScoped<ITasksbyratingRepository, TasksbyratingRepository>();
            services.AddScoped<ITypeofworkerRepository, TypeofworkerRepository>();
            services.AddScoped<ITypetouserRepository, TypetouserRepository>();

            services.AddScoped<IValuestosadeofworkerRepository, ValuestosadeofworkerRepository>();
            services.AddScoped<IWorkersregistrationRepository, WorkersregistrationRepository>();
            services.AddScoped<IWorkersRepository, WorkersRepository>();
            services.AddScoped<IWorkertoweddingRepository, WorkertoweddingRepository>();
            





    
            return services;

           }
    }
}
