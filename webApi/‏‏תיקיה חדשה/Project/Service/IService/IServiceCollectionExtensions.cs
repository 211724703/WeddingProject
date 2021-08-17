
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Repository.Models;

using Repositories;
using Service;

namespace Services
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
          //  services.AddDbContext<DB>(opt => opt.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DB\myDataBase\myDataBase\dataBase.mdf;Integrated Security=True;Connect Timeout=30"));

            services.AddScoped<ICustomersService, CustomerService>();
            services.AddScoped<IFeedbackServise, FeedbackServise>();
            services.AddScoped<ISadottypeService, SadottypeService>();
            services.AddScoped<ISadottypeofworkerService, SadottypeofworkerService>();
            services.AddScoped<IStatusServicecs, StatusService>();
            services.AddScoped<ITasksbyratingService, TasksbyratingService>();
            services.AddScoped<ITypeofworkerService, TypeofworkerService>();
            services.AddScoped<ITypetouserService, TypetouserService>();
            services.AddScoped<IValuestosadeofworkerService, ValuestosadeofworkerService>();
            services.AddScoped<IWorkersServise, WorkersServise>();
            services.AddScoped<IWorkersregistrationServise, WorkersregistrationServise>();
            services.AddScoped<IWorkertoweddingServise, WorkertoweddingServise>();
   

            services.AddRepositories();
            return services;

           }
    }
}
