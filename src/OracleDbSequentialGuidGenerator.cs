using System;

namespace iayos.sequentialguid
{
	public class OracleDbSequentialGuidGenerator : ISequentialGuidGenerator
	{
		public Guid NewSequentialGuid()
		{
			return SequentialGuidGenerator.NewSequentialGuid(SequentialGuidType.SequentialAsBinary);
		}
	}
}