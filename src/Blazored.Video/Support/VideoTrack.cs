using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Blazored.Video.Support
{
	/// <summary>
	/// Not in active use - JSON.stringify doesn't give us the VideoTracks for some reason
	/// It just outputs {} every time.
	/// TODO: figure out a way to get complex objects back from JS
	/// </summary>
	public class VideoTrack
	{
		/// <summary>
		/// get the id of the audio track
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// get the type of the audio track(can be: "alternative", "description", "main", "translation", "commentary", or "" (empty string)) 
		/// </summary>
		public string Kind { get; set; }
		/// <summary>
		/// get the label of the audio track 
		/// </summary>
		public string Label { get; set; }
		/// <summary>
		/// get the language of the audio track
		/// </summary>
		public string Language { get; set; }
		/// <summary>
		/// get or set if the track is active(true|false)
		/// </summary>
		public bool Selected { get; set; }
	}

	public class VideoTracks : List<VideoTrack>
	{

	}
}
