using Gallio.Framework.Pattern;
using MbUnit.Framework;

namespace Daptiv.MbUnit
{
	public class ExampleDecoratorAttribute:TestDecoratorAttribute
	{
		protected override void Initialize(PatternTestInstanceState testInstanceState)
		{
			base.Initialize(testInstanceState);
			GallioLogging.LogInfo("ExampleDecorator Initialize!");

		}

		protected override void SetUp(PatternTestInstanceState testInstanceState)
		{
			base.SetUp(testInstanceState);
			GallioLogging.LogInfo("ExampleDecorator Setup");
		}

		protected override void Execute(PatternTestInstanceState testInstanceState)
		{
			GallioLogging.LogInfo("ExampleDecorator Before Execute");
			base.Execute(testInstanceState);
			GallioLogging.LogInfo("ExampleDecorator After Execute");
		}

		protected override void Dispose(PatternTestInstanceState testInstanceState)
		{
			GallioLogging.LogInfo("ExampleDecorator Before dispose");
			base.Dispose(testInstanceState);
			GallioLogging.LogInfo("ExampleDecorator After dispose");
		}

		protected override void TearDown(PatternTestInstanceState testInstanceState)
		{
			GallioLogging.LogInfo("ExampleDecorator Before teardown");
			base.TearDown(testInstanceState);
			GallioLogging.LogInfo("ExampleDecorator After teardown");
		}
	}

}
