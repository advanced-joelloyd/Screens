﻿using System;
using System.Collections.Generic;
using System.Linq;
using Screens.Database;
using Screens.Elements;
using Xunit;

namespace Screens.Tests.TransformingTableDataToTree
{
	public class BlankScreen
	{
		[Fact]
		public void HasOneRootContainer()
		{
			var screenId = Guid.NewGuid();
			var repo = 
				new FakeScreenElementRepository()
				.WithScreen(screenId, new List<ScreenElementRecord>
				{
					new ScreenElementRecord { ElementType = 0 }
				});

			var screen = new Screen(screenId, repo);

			Assert.Equal(1, screen.Elements.Count());
			Assert.IsType<ContainerElement>(screen.Elements.Single());
		}
	}
}
