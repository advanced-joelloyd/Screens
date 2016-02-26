using System.Collections.Generic;
using System.Linq;
using Screens.Database;
using Screens.Elements;

namespace Screens
{
	public class ScreenElementFactory
	{
		private readonly IScreenElementRepository _elementRepository;

		public ScreenElementFactory(IScreenElementRepository elementRepository)
		{
			_elementRepository = elementRepository;
		}

		public IScreenElement Create(ScreenElementRecord record)
		{
			var element = CreateElement(record);
			element.Elements = GetChildElements(element);

			return element;
		}

		private IEnumerable<IScreenElement> GetChildElements(IScreenElement element)
		{
			return _elementRepository.GetChildElements(element.Id).Select(CreateElement);
		}

		private static IScreenElement CreateElement(ScreenElementRecord record)
		{
			if (record.ElementType == 0)
				return new ContainerElement();

			return new FieldElement();
		}
	}
}