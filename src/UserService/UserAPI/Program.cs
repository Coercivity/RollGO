namespace UserAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();

                    webBuilder.UseKestrel((context, options) =>
                    {
                        options.ListenAnyIP(context.Configuration.GetValue<int>("Port"), listenOptions =>
                        {
                            if (!context.HostingEnvironment.IsDevelopment())
                            {
                                listenOptions.UseHttps(context.Configuration["Certificates:Path"]!, context.Configuration["Certificates:Password"]);
                            }
                            else
                            {
                                listenOptions.UseHttps();
                            }
                        });
                    });
                });
    }
}