using System.Text.Json.Serialization;

namespace Blazored.Video.Support
{
	/// <summary>
	/// Not in active use - JSON.stringify doesn't give us the TextTracks/TextTrackCues for some reason
	/// It just outputs {} every time.
	/// TODO: figure out a way to get complex objects back from JS
	/// </summary>
	public class TextTrackCue
	{
		/// <summary>
		/// A string representing the text track cue alignment, as follows. If it is start alignment: the string "start". If it is middle alignment: the string "middle". If it is end alignment: the string "end". If it is left alignment: the string "left". If it is right alignment: the string "right". Default is "middle".
		/// </summary>
		public string Align { get; set; }
		/// <summary>
		/// The text track cue end time, in seconds.
		/// </summary>
		public double EndTime { get; set; }

		/// <summary>
		/// Gets or sets a text track cue identifier.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// The text track cue line position. In the case of the value being auto, the string “auto” is returned.
		/// </summary>
		public string Line { get; set; }

		/// <summary>
		/// Returns the pause-on-exit flag on a TextTrackCue. When the flag is true, playback will pause when it reaches the cue’s endTime.
		/// </summary>
		public bool PauseOnExit { get; set; }

		/// <summary>
		/// The text track cue text position.
		/// </summary>
		public double Position { get; set; }

		/// <summary>
		/// The text track cue size.
		/// </summary>
		public double Size { get; set; }

		/// <summary>
		/// Returns the text track cue snap-to-lines flag setting.
		/// </summary>
		public string SnapToLines { get; set; }

		/// <summary>
		/// The text track cue start time, in seconds.
		/// </summary>
		public double StartTime { get; set; }

		/// <summary>
		/// The text track cue text in raw, unparsed form.
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// Returns the TextTrack object to which this text track cue belongs, if any, or null otherwise.
		/// </summary>
		public TextTrack Track { get; set; }

		/// <summary>
		/// A string representing the text track cue writing direction, as follows. If it is horizontal: The empty string. If it is vertical growing left: The string "rl". If it is vertical growing right: The string "lr".
		/// </summary>
		public string Vertical { get; set; }
	}
}