using System.Collections.Generic;
using Gallio.Framework;
using MbUnit.Framework;

namespace Daptiv.MbUnit.Tests.StructureExamples
{
	public class TestFactoryExample
	{
		[StaticTestFactory, Parallelizable(TestScope.Descendants)]
		public static IEnumerable<Test> StaticFactory()
		{
			return new Test[]
			{
				GetParameterTestSuiteExample("internet explorer","en"), 
				GetParameterTestFixtureExample("firefox", "fr"),
				GetTestCase("test")
			};
		}

		[DynamicTestFactory, Parallelizable(TestScope.Descendants)]
		public static IEnumerable<Test> DynamicFactory()
		{
			return new Test[]
			{
				GetParameterTestSuiteExample("internet explorer","en"), 
				GetParameterTestFixtureExample("firefox", "fr"),
				GetTestCase("test")
			};
		}
		private static ParameterTestSuiteExample GetParameterTestSuiteExample(string browser, string culture)
		{
			var suite = new ParameterTestSuiteExample();
			suite.Metadata.Add(MetaDataKeys.Browser, browser);
			suite.Metadata.Add(MetaDataKeys.Culture, culture);
			return suite;	
		}

		private static ParameterTestFixtureExample GetParameterTestFixtureExample(string value, string culture)
		{
			var suite = new ParameterTestFixtureExample();
			suite.Metadata.Add(MetaDataKeys.Browser, value);
			suite.Metadata.Add(MetaDataKeys.Culture, culture);
			return suite;
		}

		private static TestCase GetTestCase(string name)
		{

			return new TestCase(
				name,
				() => TestLog.WriteLine(name));

		}
	}
}
