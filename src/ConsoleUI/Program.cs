// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();



using var serviceProvider = services.BuildServiceProvider();

//serviceProvider.GetService<ConsoleApp>();