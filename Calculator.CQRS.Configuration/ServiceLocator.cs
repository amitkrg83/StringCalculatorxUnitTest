using System;
using StructureMap;
using Calculator.CQRS.Messaging;
using System.Threading;

namespace Calculator.CQRS.Configuration
{
        public sealed class ServiceLocator
        {
            private static ICommandBus _commandBus;
            private static bool _isInitialized;
            private static readonly object _lockThis = new object();

            static ServiceLocator()
            {
                if (!_isInitialized)
                {
                    lock (_lockThis)
                    {
                        ContainerBootstrapper.BootstrapStructureMap();
                        _commandBus = ObjectFactory.GetInstance<ICommandBus>();
                        _isInitialized = true;
                    }
                }


            }



            public static ICommandBus CommandBus
            {
                get { return _commandBus; }
            }

        }


        static class ContainerBootstrapper
        {
            public static void BootstrapStructureMap()
            {

                ObjectFactory.Initialize(x =>
                {
                    x.For(typeof(IRepository<>)).Singleton().Use(typeof(Repository<>));
                    x.For<IEventStorage>().Singleton().Use<InMemoryEventStorage>();
                    x.For<IEventBus>().Use<EventBus>();
                    x.For<ICommandHandlerFactory>().Use<StructureMapCommandHandlerFactory>();
                    x.For<IEventHandlerFactory>().Use<StructureMapEventHandlerFactory>();
                    x.For<ICommandBus>().Use<CommandBus>();
                    x.For<IEventBus>().Use<EventBus>();
                });
            }
        }

    internal static class ObjectFactory
    {
        private static readonly Lazy<Container> _containerBuilder =
                new Lazy<Container>(defaultContainer, LazyThreadSafetyMode.ExecutionAndPublication);

        public static IContainer Container
        {
            get { return _containerBuilder.Value; }
        }

        private static Container defaultContainer()
        {
            return new Container(x =>
            {
                // default config
            });
        }
    }
}
}
