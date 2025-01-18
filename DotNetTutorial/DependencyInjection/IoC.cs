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
            services.AddTransient<ITransientService, TransientService>();
            services.AddScoped<IScopedService, ScopedService>();
            services.AddSingleton<ISingletonService, SingletonService>();
            services.AddScoped<IMessageService, EmailService>();
            services.AddScoped<IMessageService, SmsService>();
            services.AddScoped<INotificationService, NotificationService>();
            return services;
        }
    }
}
