using System;
using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Factories;
using Microsoft.Extensions.DependencyInjection;
using RubikCubeSimulator.Implementations;
using RubikCubeSimulator.Interfaces;
using RubikCubeSimulator.Models;

namespace RubikCubeSimulator
{
    
    internal class Program
    {
        private static IServiceProvider _serviceProvider;

        private static void ConfigureServices()
        {
            _serviceProvider = new ServiceCollection()
                .AddSingleton<ICubicle, Cubicle>()
                .AddSingleton<IRightFace, RightFace>()
                .AddSingleton<ILeftFace, LeftFace>()
                .AddSingleton<IUpFace, UpFace>()
                .AddSingleton<IDownFace, DownFace>()
                .AddSingleton<IBottomFace, BottomFace>()
                .AddSingleton<IFrontFace, FrontFace>()
                .AddSingleton<IRubikCube, RubikCube>()
                .AddSingleton<IRubikCubeHandler, RubikCubeHandler>()
                .AddSingleton<ICubeFactory, CubeFactory>()
                .BuildServiceProvider();
        }
        
        static void Main()

        {
            ConfigureServices();
           
            var rubikCubeHandler = _serviceProvider.GetRequiredService<IRubikCubeHandler>();

            rubikCubeHandler.Execute(CommandEnum.F);
            rubikCubeHandler.Execute(CommandEnum.Ra);
            rubikCubeHandler.Execute(CommandEnum.U);
            rubikCubeHandler.Execute(CommandEnum.Ba);
            rubikCubeHandler.Execute(CommandEnum.L);
            rubikCubeHandler.Execute(CommandEnum.Da);

            rubikCubeHandler.Print();

            Console.ReadLine();
        }
    }
}
