using System;
using System.Collections.Generic;

namespace Screens.Database
{
	public interface IScreenElementRepository
	{
		ScreenElementRecord GetRootElement(Guid screenId);
		IEnumerable<ScreenElementRecord> GetChildElements(Guid elementId);
	}
}	