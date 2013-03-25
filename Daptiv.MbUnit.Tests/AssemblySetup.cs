using Daptiv.MbUnit.Tests.SampleServices;
using MbUnit.Framework;
using Autofac;

namespace Daptiv.MbUnit.Tests
{
	[AssemblyFixture]
	public class AssemblySetup
	{
		private static IContainer _container;

		public static IContainer Container
		{
			get { return _container; }
		}

		[FixtureSetUp]
		public void RunBeforeAnyTests()
		{
			_container = InitializeContainer();

			AutofacInjectionTestDecoratorAttribute.ResolveAction = InjectProperties;
		}

		private IContainer InitializeContainer()
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<TuskService>().As<ITuskService>().InstancePerDependency();

			return builder.Build();
		}

		public static T Resolve<T>()
		{
			return Container.Resolve<T>();
		}

		private static void InjectProperties<T>(T service)
		{
			Container.InjectProperties(service);
		}
	}
}