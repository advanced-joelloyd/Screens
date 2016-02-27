using System;
using System.Collections.Generic;
using System.Linq;
using Screens.Database;

namespace Screens.Elements
{
	public abstract class ScreenElement
	{
		private readonly IScreenElementRepository _elementRepository;

		protected ScreenElement(IScreenElementRepository elementRepository)
		{
			_elementRepository = elementRepository;
		}

		public IEnumerable<ScreenElement> Elements => _elementRepository
															.GetChildElements(Id)
															.Select(record => record.CreateElement(_elementRepository));
		public Guid Id { get; set; }

		public static ScreenElement FromRecord(ScreenElementRecord record, IScreenElementRepository elementRepository)
		{
			if (record.ElementType == 0)
				return new ContainerElement(elementRepository);

			return new FieldElement(elementRepository);
		}
	}
}
