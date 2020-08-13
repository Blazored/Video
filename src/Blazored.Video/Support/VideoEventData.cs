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
		public string Name { get; set; } = VideoEvents.NotSet.ToString();
		public VideoEvents EventName =>
			(VideoEvents)Enum.Parse(typeof(VideoEvents), Name, true);
		public VideoState State { get; set; }
	}
}
