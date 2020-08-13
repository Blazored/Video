using Bunit;
using Bunit.TestDoubles.JSInterop;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using static Bunit.ComponentParameterFactory;

namespace Blazored.Video.Tests
{
	public class DisplayTests : TestContext
	{
		public DisplayTests()
		{
			Services.AddMockJSRuntime();
			Services.AddLogging();
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
				ChildContent("<source src=\"https://res.cloudinary.com/blazoredgitter/video/upload/v1557015491/samples/elephants.mp4\" type=\"video/mp4\" />")
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
				ChildContent("<source src=\"https://res.cloudinary.com/blazoredgitter/video/upload/v1557015491/samples/elephants.mp4\" type=\"video/mp4\" />")
				);

			// Assert
			Assert.Equal(1, cut.FindAll("video[id='test1']").Count);
			Assert.Equal(1, cut.FindAll("video[class='testclass']").Count);
		}

		[Fact]
		public void ScripTagRenders()
		{
			// Arrange			
			// Act
			var cut = RenderComponent<BlazoredVideo>(
				);

			// Assert
			Assert.Equal(1, cut.FindAll("script").Count);
		}

		[Fact]
		public void ScripTagIsRemovedAfterInitialRender()
		{
			// Arrange			
			// Act
			var cut = RenderComponent<BlazoredVideo>(
				);
			cut.Render();
			// Assert
			Assert.Equal(0, cut.FindAll("script").Count);
		}
	}
}