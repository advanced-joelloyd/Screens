using System;

namespace Screens.Database
{
	public class ScreenElementRecord
	{
		public Guid Id { get; set; }
		public int ElementType { get; set; }
		public Guid ParentElementId { get; set; }
	}
}