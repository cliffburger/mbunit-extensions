using Gallio.Framework;
using MbUnit.Framework;

namespace Daptiv.MbUnit.Tests.StructureExamples
{
	[TestFixture]
	public class ParameterTestFixtureExample:TestSuite
	{
		public ParameterTestFixtureExample()
			: base(typeof(ParameterTestFixtureExample).Name)
		{
			// TODO: Add via reflection
			Children.Add(new TestCase("Test1", Test1));
			Children.Add(new TestCase("Test2", Test2));
		}
		
		[FixtureSetUp]
		protected override void OnSetupSelf()
		{
			TestLog.WriteLine("Use OnSetupSelf like Fixture Setup ");
			TestLog.WriteLine(string.Format("This fixture will use Browser: {0} Culture: {1}", Browser, Culture));
		}

		[Test]
		public void Test1()
		{
			TestLog.WriteLine(string.Format("Running Test 1 Browser: {0} Culture: {1}", Browser, Culture));
		}

		[Test]
		public void Test2()
		{
			TestLog.WriteLine(string.Format("Running Test 2 Browser: {0} Culture: {1}", Browser, Culture));
		}

		private string Browser
		{
			get
			{
				return Metadata.GetValue(MetaDataKeys.Browser) ?? "Chrome (default)";
			}
		}

		private string Culture
		{
			get
			{
				return Metadata.GetValue(MetaDataKeys.Culture) ?? "pr";
			}
		}
	}
}