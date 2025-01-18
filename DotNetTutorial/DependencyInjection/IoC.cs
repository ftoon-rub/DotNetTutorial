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
            return services;
        }
    }
}
