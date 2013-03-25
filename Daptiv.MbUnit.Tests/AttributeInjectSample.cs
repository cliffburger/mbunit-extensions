using Daptiv.MbUnit.Tests.SampleServices;
using MbUnit.Framework;

namespace Daptiv.MbUnit.Tests
{
	[TestFixture]
	[AutofacInjectionTestDecorator]
	public class AttributeInjectSample
	{
		public ITuskService Service { get; set; }

		public AttributeInjectSample()
		{
			GallioLogging.LogInfo("At object construction the service is " + (Service == null ? "Null" : "Instantiated"));
		}

		[FixtureSetUp]
		public void FixtureSetup()
		{
			GallioLogging.LogInfo("At fixture setup the service is " + (Service == null ? "Null" : "Instantiated"));
		}
		
		[Test]
		public void GetCreaturesWithTusksTest()
		{
			Assert.IsNotNull(Service);
			Assert.IsNotEmpty(Service.GetCreaturesWithTusks());
		}
	}
}
