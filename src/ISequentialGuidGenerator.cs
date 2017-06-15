using System;

namespace iayos.sequentialguid
{
	public interface ISequentialGuidGenerator
	{
		Guid NewSequentialGuid();
	}
}