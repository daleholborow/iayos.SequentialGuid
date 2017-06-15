using System;

namespace iayos.sequentialguid
{
	public class MsSqlDbSequentialGuidGenerator : ISequentialGuidGenerator
	{
		public Guid NewSequentialGuid()
		{
			return SequentialGuidGenerator.NewSequentialGuid(SequentialGuidType.SequentialAtEnd);
		}
	}
}