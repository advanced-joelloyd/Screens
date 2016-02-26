using System;
using System.Collections.Generic;
using System.Linq;
using Screens.Database;
using Xunit;

namespace Screens.Tests.TransformingTableDataToTree
{
	public class ScreenWithAField
	{
		[Fact]
		public void HasAFieldInTheRootContainer()
		{
			var rootId = Guid.NewGuid();
			var repository = new FakeScreenElementRepository(new List<ScreenElementRecord>
			{
				new ScreenElementRecord { ElementType = 0, Id = rootId },
				new ScreenElementRecord { ElementType = 3, Id = Guid.NewGuid(), ParentElementId = rootId }
			});
			var screenId = Guid.NewGuid();
			var screen = new Screen(screenId, repository);
			var root = screen.Elements.Single();
			Assert.Equal(1, root.Elements.Count());
		}
	}
}
