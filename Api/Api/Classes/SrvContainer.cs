using Api.Services;
using Lib.Base;
namespace Api.Classes
{
    public static class SrvContainer
    {
        public static IServiceCollection AddInjectionOprionApi(IServiceCollection services)
        {
            services.AddAutoMapper(cfg => 
            { cfg.AddProfile<MappingConf>(); });
            services.AddScoped<ICategoryService, CategoryServices>();
            services.AddScoped<IProductService, ProductServices>();
            return services;
        }
    }
}
