using Microsoft.Extensions.DependencyInjection;

namespace UUID
{

    public static class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            var result = serviceProvider.GetService<IFindSequence>().FindMaxSequence(args[0]);
            Console.WriteLine(result);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IFindSequence, FindSequence>();
        }
    }
}
