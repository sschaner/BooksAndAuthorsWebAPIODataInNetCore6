namespace BooksAndAuthors.api.Extensions
{
    using BooksAndAuthors.Contracts;
    using BooksAndAuthors.LoggerService;

    public static class ServiceExtensions
    {
        /// <summary>
        /// Configures the cors.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

        /// <summary>
        /// Configures the IIS integration.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {
            });

        /// <summary>
        /// Configures the logger service.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

    }
}
