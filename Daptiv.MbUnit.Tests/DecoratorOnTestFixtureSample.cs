using System;
using MbUnit.Framework;

namespace Daptiv.MbUnit.Tests
{
	[TestFixture]
	[ExampleDecorator]
	public class DecoratorOnTestFixtureSample
	{
		public DecoratorOnTestFixtureSample()
		{
			GallioLogging.LogInfo("DecoratorOnTestFixtureSample constructor.");
		}

		[FixtureSetUp]
		public void BaseSetup()
		{
			GallioLogging.LogInfo("Public BaseSetup");
		}

		[Test]
		public void Test1()
		{
			GallioLogging.LogInfo("In test 1!");
		}

		[Test]
		public void Test2()
		{
			GallioLogging.LogInfo("In test 2!");
		}

		[FixtureTearDown]
		private void TearDown()
		{
			GallioLogging.LogInfo("In FixtureTearDown");
		}
	}

}
