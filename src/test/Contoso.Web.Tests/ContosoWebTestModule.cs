using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Contoso.EntityFrameworkCore;
using Contoso.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Contoso.Web.Tests
{
    [DependsOn(
        typeof(ContosoWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ContosoWebTestModule : AbpModule
    {
        public ContosoWebTestModule(ContosoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ContosoWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ContosoWebMvcModule).Assembly);
        }
    }
}