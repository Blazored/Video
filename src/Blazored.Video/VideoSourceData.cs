using System;
using System.Collections.Generic;

namespace Blazored.Video;

/// <summary>
///		Defines one source to load a video from.
/// </summary>
public class VideoSourceData
{
	public VideoSourceData()
	{
		Id = Guid.NewGuid().ToString("N");
	}

	public VideoSourceData(string source, string type) : this()
	{
		Source = source;
		Type = type;
	}

	internal string Id { get; }

	/// <summary>
	///		The source URI from which to playback.
	/// </summary>
	public string Source { get; set; }

	/// <summary>
	///		The mime type of the <see cref="Source"/> URI. Optional.
	/// </summary>
	public string Type { get; set; }

	/// <summary>
	///		Custom attributes to be rendered into the source element
	/// </summary>
	public IDictionary<string, object> AdditionalAttributes { get; set; }
}