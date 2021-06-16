
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
   





            //ככה את כותבת לכל הסרויסים שיהיו לך

            //לכל אחד יוצרים כזה סרוויס חדש או שלכוםלכתוב פה?
            //לכל סרוויס שורה חדשה
            //כמו שאני כתבתי פה מלא שורות

            //services.AddScoped<IBlockingForGroupService, BlockingForGroupService>();
            //services.AddScoped<IAppsInBlockService, AppsInBlockService>();
            //services.AddScoped<IAppsInCategoriesService, AppsInCategoriesService>();
            //services.AddScoped<IAreaCodeService, AreaCodeService>();
            //services.AddScoped<IBlockingForGroupService, BlockingForGroupService>();
            //services.AddScoped<IBlocksService, BlocksService>();
            //services.AddScoped<IBrowsingEmployeeInGroupService, BrowsingEmployeeInGroupService>();
            //services.AddScoped<ICategoriesService, CategoriesService>();
            //services.AddScoped<IDepartmentsService, DepartmentsService>();
            //services.AddScoped<IEmpDepartInGroupService, EmpDepartInGroupService>();
            //services.AddScoped<IEmployeeInGroupService, EmployeeInGroupService>();
            //services.AddScoped<IEmployeeInJobsService, EmployeeInJobsService>();
            //services.AddScoped<IEmployeeService, EmployeeService>();
            //services.AddScoped<IGroupsService, GroupsService>();
            //services.AddScoped<IJobsService, JobsService>();
            //services.AddScoped<IPermitionsService, PermitionsService>();  
            //services.AddScoped<ITemporaryBrowsingGroupTimeService, TemporaryBrowsingGroupTimeService>();
            //services.AddScoped<IUnallowCategoryForBlackService, UnallowCategoryForBlackService>();

            services.AddRepositories();
            return services;

           }
    }
}
