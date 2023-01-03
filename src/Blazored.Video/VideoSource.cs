using System;
using Microsoft.AspNetCore.Components;

namespace Blazored.Video;

/// <summary>
///		A source that a <see cref="VideoQueue"/> will display as an option.
/// </summary>
public class VideoSource : ComponentBase
{
	public VideoSource()
	{
		Id = Guid.NewGuid().ToString("N");
	}

	internal string Id { get; }

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

	[CascadingParameter]
	public VideoItem VideoItem { get; set; }

	protected override void OnInitialized()
	{
		VideoItem.VideoSources.Add(this);
	}
}