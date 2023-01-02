using System;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using static Bunit.ComponentParameterFactory;

namespace Blazored.Video.Tests
{
	public class DisplayTests : TestContext
	{
		public DisplayTests()
		{
			Services.AddLogging();
			JSInterop.SetupModule("./_content/Blazored.Video/blazoredVideo.js");
		}

		[Fact]
		public void VideoTagRenders()
		{
			// Arrange			
			// Act
			var cut = RenderComponent<BlazoredVideo>(
				);

			// Assert
			Assert.Equal(1, cut.FindAll("video").Count);
		}
		[Fact]
		public void VideoTagRendersWithChildContent()
		{
			// Arrange			
			// Act
			var cut = RenderComponent<BlazoredVideo>(
				ChildContent("<source src=\"videos/elephants2.mp4\" type=\"video/mp4\" />")
				);

			// Assert
			Assert.Equal(1, cut.FindAll("video").Count);
			Assert.Equal(1, cut.FindAll("source").Count);
		}
		[Fact]
		public void VideoTagRendersWithChildContentAndAttributes()
		{
			// Arrange			
			// Act
			var cut = RenderComponent<BlazoredVideo>(
				("id","test1"),
				("class","testclass"),
				ChildContent("<source src=\"videos/elephants2.mp4\" type=\"video/mp4\" />")
				);

			// Assert
			Assert.Equal(1, cut.FindAll("video[id='test1']").Count);
			Assert.Equal(1, cut.FindAll("video[class='testclass']").Count);
		}
	}
}