using Coworking.Api.Application.Configuration;
using Coworking.Api.Application.Contracts.Services;
using Coworking.Api.Application.Services;
using Coworking.Api.DataAccess.Contracts.Repositories;
using Coworking.Api.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Coworking.Api.CrossCutting.Register
{
    public static class IOCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            RegisterRepositories(services);
            RegisterServices(services);
            RegisterOthers(services);

            return services;
        }

        private static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<IBookingRepository, BookingRepository>();
            services.AddTransient<IOfficeRepository, OfficeRepository>();
            services.AddTransient<IRoomRepository, RoomRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }

        private static IServiceCollection RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IAdminService, AdminService>();
            services.AddTransient<IBookingService, BookingService>();
            services.AddTransient<IOfficeService, OfficeService>();
            services.AddTransient<IRoomService, RoomService>();
            services.AddTransient<IServiceService, ServiceService>();
            services.AddTransient<IUserService, UserService>();

            return services;
        }

        private static IServiceCollection RegisterOthers(IServiceCollection services)
        {
            services.AddTransient<IAppConfig, AppConfig>();

            return services;
        }
    }
}
