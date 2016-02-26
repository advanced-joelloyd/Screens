using System;
using System.Collections.Generic;

namespace Screens.Elements
{
	public interface IScreenElement
	{
		IEnumerable<IScreenElement> Elements { get; set; }
		Guid Id { get; }
	}
}