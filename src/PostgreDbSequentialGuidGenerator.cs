using System;

namespace iayos.sequentialguid
{
	public class PostgreDbSequentialGuidGenerator : ISequentialGuidGenerator
	{
		public Guid NewSequentialGuid()
		{
			return SequentialGuidGenerator.NewSequentialGuid(SequentialGuidType.SequentialAsString);
		}
	}
}