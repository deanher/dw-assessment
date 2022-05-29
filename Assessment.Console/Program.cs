// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");
Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
                       {
                       });