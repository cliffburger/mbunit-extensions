using MbUnit.Framework;

namespace Daptiv.MbUnit.Tests
{
	[TestFixture]
	public class BaseTest
	{
		protected object _initializeMe;

		[FixtureSetUp]
		public void BaseFixtureSetup()
		{
			GallioLogging.LogInfo("Public BaseTest.BaseFixtureSetup");
			_initializeMe = new object();
		}

		[FixtureSetUp]
		private void FixtureSetup()
		{
			GallioLogging.LogInfo("private BaseTest.FixtureSetup");
		}

		[Test]
		public void Test1()
		{
			GallioLogging.LogInfo("In public test from base class");
		}

		[Test]
		private void PrivateTest()
		{
			GallioLogging.LogInfo("In private test from base class");
		}

		[FixtureTearDown]
		private void FixtureTearDown()
		{
			GallioLogging.LogInfo("Private BaseTest.FixtureTearDown");
		}

		[FixtureTearDown]
		public void BaseTearDown()
		{
			GallioLogging.LogInfo("Public BaseTest.BaseTearDown");
		}
	}

	[TestFixture]
	public class DerivedTest : BaseTest
	{
		[FixtureSetUp]
		private void FixtureSetUp()
		{
			GallioLogging.LogInfo("In private DerivedTest.FixtureSetUp");
		}

		[FixtureSetUp]
		public void DerivedTestFixtureSetUp()
		{			
			GallioLogging.LogInfo("In public DerivedTest.DerivedTestFixtureSetUp");
			Assert.IsNotNull(_initializeMe, "Base class initialization did not run!");
		}

		[Test]
		public void TestDerived()
		{
			GallioLogging.LogInfo("In public test on derived class");
		}

		[Test]
		private void PrivateTest()
		{
			GallioLogging.LogInfo("In private test from base class");
		}

		[FixtureTearDown]
		private void FixtureTearDown()
		{
			GallioLogging.LogInfo("In derived FixtureTearDown");
		}
	}
}
