using System;
using System.Collections.Generic;
using Screens.Database;
using Screens.Elements;

namespace Screens
{
	public class Screen
	{
		private readonly IScreenElementRepository _elementRepository;
		private readonly Guid _screenId;

		public Screen(Guid screenId, IScreenElementRepository elementRepository)
		{
			_elementRepository = elementRepository;
			_screenId = screenId;
		}

		public IEnumerable<ScreenElement> Elements
		{
			get
			{
				var root = _elementRepository.GetRootElement(_screenId);
				yield return root.CreateElement(_elementRepository);
			}
		}
	}
}