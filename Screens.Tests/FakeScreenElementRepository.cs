using System;
using System.Collections.Generic;
using System.Linq;
using Screens.Database;
using Screens.Elements;

namespace Screens.Tests
{
	public class FakeScreenElementRepository : IScreenElementRepository
	{
		private readonly List<ScreenElementRecord> _elements;

		public FakeScreenElementRepository(List<ScreenElementRecord> elements)
		{
			_elements = elements;
		}

		public ScreenElementRecord GetRootElement(Guid screenId)
		{
			return _elements.Single(r => r.ParentElementId == Guid.Empty);
		}

		public IEnumerable<ScreenElementRecord> GetChildElements(Guid elementId)
		{
			return _elements.Where(e => e.ParentElementId == elementId);
		}
	}
}