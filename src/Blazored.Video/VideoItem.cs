using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Blazored.Video;

/// <summary>
///		Defines a Source from which the <see cref="VideoQueue"/> will schedule playback.
/// </summary>
public sealed class VideoItem : ComponentBase, IDisposable
{
	public VideoItem()
	{
		VideoItemData = new VideoItemData();
	}

	/// <summary>
	///		The source URI from which to playback.
	/// </summary>
	[Parameter]
	public string Source { get; set; }

	/// <summary>
	///		The mime type of the <see cref="Source"/> URI. Optional.
	/// </summary>
	[Parameter]
	public string Type { get; set; }

	[CascadingParameter()]
	public VideoQueue VideoQueue { get; set; }

	[Parameter]
	public RenderFragment ChildContent { get; set; }

	public VideoItemData VideoItemData { get; set; }

	protected override void BuildRenderTree(RenderTreeBuilder builder)
	{
		if (ChildContent == null)
		{
			return;
		}

		builder.OpenComponent<CascadingValue<VideoItem>>(0);
		builder.AddAttribute(1, nameof(CascadingValue<VideoItem>.Value), this);
		builder.AddAttribute(2, nameof(CascadingValue<VideoItem>.IsFixed), true);
		builder.AddAttribute(3, nameof(CascadingValue<VideoItem>.ChildContent), (RenderFragment)((cBuilder) =>
		{
			cBuilder.AddContent(4, ChildContent);
		}));
		builder.CloseComponent();
	}

	protected override void OnInitialized()
	{
		if (!string.IsNullOrWhiteSpace(Source))
		{
			VideoItemData.VideoSourceData.Add(new VideoSourceData(Source, Type));
		}

		VideoQueue.AddVideoItem(VideoItemData);
	}

	public void Dispose()
	{
		VideoQueue.VideoItems.Remove(VideoItemData);
	}
}