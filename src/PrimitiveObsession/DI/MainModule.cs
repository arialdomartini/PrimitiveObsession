﻿using Autofac;

namespace PrimitiveObsession.DI
{
    public class MainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EngineBuilder>().As<IEngineBuilder>();
            builder.RegisterType<TireBuilder>().As<ITireBuilder>();
        }
    }
}
