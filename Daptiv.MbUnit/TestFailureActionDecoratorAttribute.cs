using Gallio.Framework;
using Gallio.Model;
using MbUnit.Framework;

namespace Daptiv.MbUnit
{
	public class TestFailureActionDecoratorAttribute : TestDecoratorAttribute
	{
		protected override void TearDown(Gallio.Framework.Pattern.PatternTestInstanceState testInstanceState)
		{
			base.TearDown(testInstanceState);
			if(TestContext.CurrentContext.Outcome.Status == TestStatus.Failed)
			{
				GallioLogging.LogInfo("TestFailureActionDecoratorAttribute: Bang!");
			}
			else
			{
				GallioLogging.LogInfo("TestFailureActionDecoratorAttribute: " + TestContext.CurrentContext.Outcome.ToString());
			}
		}
	}
}
