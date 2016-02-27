using System;
using Screens.Elements;

namespace Screens.Database
{
	public class ScreenElementRecord
	{
		public Guid Id { get; set; }
		public int ElementType { get; set; }
		public Guid ParentElementId { get; set; }

		public ScreenElement CreateElement(IScreenElementRepository elementRepository)
		{
			if (ElementType == 0)
				return new ContainerElement(elementRepository);

			return new FieldElement(elementRepository);
		}
	}
}