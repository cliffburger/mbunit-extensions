using System.Collections.Generic;

namespace Daptiv.MbUnit.Tests.SampleServices
{
	public class NullTuskService : ITuskService
	{
		public IEnumerable<TuskedCreature> GetCreaturesWithTusks()
		{
			return null;
		}
	}
}