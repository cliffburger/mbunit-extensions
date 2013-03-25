using System;
using Gallio.Framework.Pattern;
using MbUnit.Framework;

namespace Daptiv.MbUnit
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public class AutofacInjectionTestDecoratorAttribute : TestDecoratorAttribute
	{
		/// <summary>
		/// This action will be executed against the test class.
		/// </summary>
		public static Action<object> ResolveAction { get; set; }

		protected override void Initialize(PatternTestInstanceState testInstanceState)
		{
			base.Initialize(testInstanceState);
			ResolveAction(testInstanceState.FixtureInstance);
		}
	}
}
