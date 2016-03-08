﻿using System.Reflection;
using LightInject;
using Solar.Domain.Grammar.Lexis.ValueObjects.TokenTypes;
using Solar.Infrastructure.Common.DependencyInjection.Composition;
using Solar.Infrastructure.Common.DependencyInjection.Extensions;
using Solar.Infrastructure.Common.DependencyInjection.Registration;
using Solar.Infrastructure.Common.Interfaces;
using Solar.Infrastructure.Common.Interfaces.DomainLayer;

namespace Solar.Domain.Grammar
{
    internal class CompositionRoot : ISolarCompositionRoot
    {
        private static readonly Assembly ThisAssembly = typeof(CompositionRoot).Assembly;

        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IEntityBehaviorService>(ThisAssembly, LifeTimeFactory.PerContainer);
            serviceRegistry.Register<IDomainService>(ThisAssembly, LifeTimeFactory.PerContainer);
            serviceRegistry.Register<IDirectory>(ThisAssembly, LifeTimeFactory.PerContainer);
            serviceRegistry.Register<ITokenType>(ThisAssembly, LifeTimeFactory.PerContainer);
        }
    }
}