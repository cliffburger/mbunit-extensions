using Gallio.Framework;
using MbUnit.Framework;

namespace Daptiv.MbUnit.Tests.StructureExamples
{
	
	public class ParameterTestSuiteExample:TestSuite
	{
		public const string Key = "param";

		public ParameterTestSuiteExample():base("Parameterized")
		{
			//_parameter = parameter;

			// TODO: Add via reflection
			Children.Add(new TestCase("Test1", Test1));
			Children.Add(new TestCase("Test2", Test2));
		}

		protected override void OnSetupSelf()
		{
			TestLog.WriteLine("Use OnSetupSelf like Fixture Setup" + Browser);
			TestLog.WriteLine(string.Format("This fixture will use Browser: {0} Culture: {1}", Browser, Culture));
		}

		public void Test1()
		{
			TestLog.WriteLine(string.Format("Running Test 1 Browser: {0} Culture: {1}", Browser, Culture));
		}

		public void Test2()
		{
			TestLog.WriteLine(string.Format("Running Test 2 Browser: {0} Culture: {1}", Browser, Culture));
		}

		private string Browser
		{
			get { return Metadata.GetValue(MetaDataKeys.Browser); }
		}

		private string Culture
		{
			get { return Metadata.GetValue(MetaDataKeys.Culture); }
		}

	}
}
