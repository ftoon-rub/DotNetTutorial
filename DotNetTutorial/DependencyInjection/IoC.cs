using DotNetTutorial.DependencyInjection.Lifecycle;

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
            services.AddScoped<IInstance, TransientService>();
            services.AddScoped<IInstance, ScopedService>();
            services.AddScoped<IInstance, SingletonService>();
            services.AddScoped<IMessageService, EmailService>();
            services.AddScoped<IMessageService, SmsService>();
            services.AddScoped<INotificationService, NotificationService>();
            return services;
        }
    }
}
