using SharpPro.Repository.Implementation;
using SharpPro.Repository.InterFace;
using Microsoft.Extensions.DependencyInjection;
using CsharpPro.Repository.Implementation;

namespace CsharpPro;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        var serviceProvider = new ServiceCollection()
           .AddTransient<ICustomerRepository, CustomerRepository>()
           .AddTransient<IProductRepository, ProductRepository>()
           .AddTransient<IOrderRepository, OrderRepository>()
           .AddTransient<IAddressRepository, AddressRepository>()
           .BuildServiceProvider();
        ApplicationConfiguration.Initialize();
        Application.Run(new LoginForm());

    }
}

