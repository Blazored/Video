using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Blazored.Video;

/// <summary>
///		A source that a <see cref="VideoQueue"/> will display as an option.
/// </summary>
public class VideoSource : ComponentBase
{
	public VideoSource()
	{
		_videoSourceData = new VideoSourceData();
	}

	/// <summary>
	///		The source URI from which to playback.
	/// </summary>
	[Parameter]
	public string Source
	{
		get => _videoSourceData.Source;
		set => _videoSourceData.Source = value;
	}

	/// <summary>
	///		The mime type of the <see cref="Source"/> URI. Optional.
	/// </summary>
	[Parameter]
	public string Type
	{
		get => _videoSourceData.Type;
		set => _videoSourceData.Type = value;
	}

	[CascadingParameter]
	public VideoItem VideoItem { get; set; }

	[Parameter(CaptureUnmatchedValues = true)]
	public IDictionary<string, object> AdditionalAttributes { get; set; }

	private VideoSourceData _videoSourceData;

	protected override void OnInitialized()
	{
		VideoItem.VideoItemData.VideoSourceData.Add(_videoSourceData);
	}
}