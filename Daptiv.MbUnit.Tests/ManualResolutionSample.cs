using Daptiv.MbUnit.Tests.SampleServices;
using MbUnit.Framework;

namespace Daptiv.MbUnit.Tests
{
	[TestFixture]
	public class ManualResolutionSample
	{
		public ITuskService Service { get; set; }

		[FixtureSetUp]
		public void FixtureSetup()
		{
			Service = AssemblySetup.Resolve<ITuskService>();
		}

		[Test]
		public void GetCreaturesWithTusksTest()
		{
			Assert.IsNotNull(Service);
			Assert.IsNotEmpty(Service.GetCreaturesWithTusks());
		}
	}
}
