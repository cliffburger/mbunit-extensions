using System.Collections.Generic;

namespace Daptiv.MbUnit.Tests.SampleServices
{
	public interface ITuskService
	{
		IEnumerable<TuskedCreature> GetCreaturesWithTusks();
	}
}
