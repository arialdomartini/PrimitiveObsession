﻿using System;
using System.Configuration;
using Autofac;
using PrimitiveObsession.IoC;

namespace PrimitiveObsession
{
    class Program
    {
        static void Main()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var pistonCount = appSettings["PistonCount"];
            var tireCount = appSettings["TireCount"];

            var builder = new ContainerBuilder();
            builder.RegisterModule(new PrimitiveObsessionModule(tireCount, pistonCount));

            using (var container = builder.Build())
            {
                var engineBuilder = container.Resolve<IEngineBuilder>();

                Console.WriteLine(engineBuilder.Build());
            }

            Console.WriteLine("Engine is ready!");
            Console.ReadLine();
        }
    }
}
