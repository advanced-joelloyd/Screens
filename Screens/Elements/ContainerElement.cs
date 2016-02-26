using System;
using System.Collections.Generic;

namespace Screens.Elements
{
	public class ContainerElement : IScreenElement
	{
		public IEnumerable<IScreenElement> Elements { get; set; } = new List<IScreenElement>();
		public Guid Id { get; }
	}
}