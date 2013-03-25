using System.Collections.Generic;

namespace Daptiv.MbUnit.Tests.SampleServices
{
	public class TuskService : ITuskService
	{
		public IEnumerable<TuskedCreature> GetCreaturesWithTusks()
		{
			return new[]
			       	{
			       		new TuskedCreature {Creature = "Warthog ", Pointiness = "Sometimes", UpwardCurve = true},
			       		new TuskedCreature {Creature = "Mule Deer", Pointiness = "Quite", UpwardCurve = false},
			       		new TuskedCreature {Creature = "Walrus", Pointiness = "Sort of", UpwardCurve = false},
			       		new TuskedCreature {Creature = "Narwal", Pointiness = "Ouch", UpwardCurve = null}
			       	};
		}
	}
}