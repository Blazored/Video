using System;

namespace Blazored.Video.Support
{
	/// <summary>
	/// This is the class used for every event
	/// The "name" will match a VideoEvents enum value
	/// The "data" is whatever was requested for this event using VideoStateOptions 
	/// </summary>
	public class VideoEventData
	{
		/// <summary>
		/// The video element id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// The <see cref="EventName"/> as a string
		/// </summary>
		public string Name { get; set; } = VideoEvents.NotSet.ToString();
		/// <summary>
		/// The <see cref="VideoEvents"/> Event name
		/// </summary>
		public VideoEvents EventName =>
			(VideoEvents)Enum.Parse(typeof(VideoEvents), Name, true);
		/// <summary>
		/// The video player state
		/// </summary>
		public VideoState State { get; set; }
		/// <summary>
		/// Reference to the component
		/// </summary>
		public BlazoredVideo Video { get; set; }
	}
}
