using System;
using System.Collections.Generic;
using System.Linq;
using Screens.Database;

namespace Screens.Tests
{
	public class FakeScreenElementRepository : IScreenElementRepository
	{
		private readonly Dictionary<Guid, List<ScreenElementRecord>> _screens = new Dictionary<Guid, List<ScreenElementRecord>>();

		public FakeScreenElementRepository WithScreen(Guid screenId, List<ScreenElementRecord> elements)
		{
			_screens[screenId] = elements;
			return this;
		}

		public ScreenElementRecord GetRootElement(Guid screenId)
		{
			return _screens[screenId].Single(r => r.ParentElementId == Guid.Empty);
		}

		public IEnumerable<ScreenElementRecord> GetChildElements(Guid elementId)
		{
			return _screens.SelectMany(s => s.Value).Where(e => e.ParentElementId == elementId);
		}
	}
}