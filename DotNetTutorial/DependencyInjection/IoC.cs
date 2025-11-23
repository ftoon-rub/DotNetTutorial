using DotNetTutorial.DependencyInjection.Interfaces;
using DotNetTutorial.DependencyInjection.Lifecycle;
using DotNetTutorial.DependencyInjection.Services;

namespace DotNetTutorial.DependencyInjection
{
    public static class IoC
    {
        /// <summary>
        /// Registering dependencies in IoC container
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterCustomService( this IServiceCollection services)
        {
            services.AddScoped<IMessageService, EmailService>();
            services.AddScoped<IMessageService, SmsService>();
            services.AddScoped<INotificationService, NotificationService>();

            services.AddScoped<IInstance, TransientService>();
            services.AddScoped<IInstance, ScopedService>();
            services.AddScoped<IInstance, SingletonService>();
            services.AddScoped<IFirstCallServie, FirstCallServie>();
            services.AddScoped<ISecondCallServie, SecondCallServie>();
            return services;
        }
    }
}
