using System;
using System.Collections.Generic;

namespace Screens.Elements
{
	public class FieldElement : IScreenElement
	{
		public IEnumerable<IScreenElement> Elements { get; set; }
		public Guid Id { get; }
	}
}