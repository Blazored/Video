using System;
using System.Collections.Generic;

namespace Blazored.Video;

/// <summary>
///		Contains the list of sources to be played back by a <see cref="VideoQueue"/>.
/// </summary>
public class VideoItemData
{
	public VideoItemData()
	{
		VideoSourceData = new List<VideoSourceData>();
		Id = Guid.NewGuid().ToString("N");
	}

	internal string Id { get; }

	/// <summary>
	///		The <see cref="VideoSourceData"/> that can be used to playback a source.
	/// </summary>
	public IList<VideoSourceData> VideoSourceData { get; set; }
}