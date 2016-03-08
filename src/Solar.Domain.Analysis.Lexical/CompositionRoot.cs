﻿using System.Reflection;
using LightInject;
using Solar.Infrastructure.Common.DependencyInjection.Composition;
using Solar.Infrastructure.Common.DependencyInjection.Extensions;
using Solar.Infrastructure.Common.DependencyInjection.Registration;
using Solar.Infrastructure.Common.Interfaces.DomainLayer;

namespace Solar.Domain.Analysis.Lexical
{
    internal class CompositionRoot : ISolarCompositionRoot
    {
        private static readonly Assembly ThisAssembly = typeof(CompositionRoot).Assembly;

        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IEntityBehaviorService>(ThisAssembly, LifeTimeFactory.PerContainer);
            serviceRegistry.Register<IDomainService>(ThisAssembly, LifeTimeFactory.PerContainer);
        }
    }
}