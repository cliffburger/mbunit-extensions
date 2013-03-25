using System;
using MbUnit.Framework;

namespace Daptiv.MbUnit.Tests
{
	[TestFixture]
	public class DecoratorOnTestSample
	{
		[Test]
		[ExampleDecorator]
		public void Test1()
		{
			GallioLogging.LogInfo("In test 1!");
		}

		[Test]
		[ExampleDecorator]
		public void Test2()
		{
			GallioLogging.LogInfo("In test 2!");
		}
	}
}