using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Blazored.Video.Support
{
	/// <summary>
	/// Not in active use - JSON.stringify doesn't give us the TextTracks for some reason
	/// It just outputs {} every time.
	/// TODO: figure out a way to get complex objects back from JS
	/// </summary>
	public class TextTrack
	{
		/// <summary>
		/// get the type of the text track (can be: "subtitles", "caption", "descriptions", "chapters", or "metadata")
		/// </summary>
		public string Kind { get; set; }
		/// <summary>
		/// get the label of the text track
		/// </summary>
		public string Label { get; set; }
		/// <summary>
		/// get the language of the text track
		/// </summary>
		public string Language { get; set; }
		/// <summary>
		/// get or set if the track is active ("disabled"|"hidden"|"showing")
		/// </summary>
		public string Mode { get; set; }
		/// <summary>
		/// get a list of cues as a List&lt;<see cref="TextTrackCueList"/>&gt; object
		/// </summary>
		public List<TextTrackCue> Cues { get; set; }
		/// <summary>
		/// get the currently active text track cues as a List&lt;<see cref="TextTrackCueList"/>&gt; object
		/// </summary>
		public List<TextTrackCue> ActiveCues { get; set; } 
	}

	public class TextTracks : List<TextTrack>
	{

	}
}