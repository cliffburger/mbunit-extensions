using System;
using Gallio.Common.Reflection;
using Gallio.Framework;
using MbUnit.Framework;
using Test = Gallio.Model.Tree.Test;

namespace Daptiv.MbUnit.Tests
{
	[TestFixture]
	[Explicit("An abandon experiment")]
	public class SampleOfAddingTests
	{
		[Test]
		public void TestThatAddsTests()
		{
			foreach (string testCase in new[] { "A", "B", "C" })
			{
				TestContext.CurrentContext.Test.AddChild(CreateCase(testCase));
			}

		}


		private Test CreateCase(string testCase)
		{
			return new Test(testCase, WrapMethod());

		}

		private ICodeElementInfo WrapMethod()
		{
			throw new NotImplementedException();
			// NOTE: Lots of work to do here.
		}
	}
}
