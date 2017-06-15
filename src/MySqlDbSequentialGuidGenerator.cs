using System;

namespace iayos.sequentialguid
{
	public class MySqlDbSequentialGuidGenerator : ISequentialGuidGenerator
	{
		public Guid NewSequentialGuid()
		{
			return SequentialGuidGenerator.NewSequentialGuid(SequentialGuidType.SequentialAsString);
		}
	}
}