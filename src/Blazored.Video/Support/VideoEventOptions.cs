using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazored.Video.Support
{
	/// <summary>
	/// Not currently being used - the idea was for a way to supply callbacks
	/// for events in a batch 
	/// <code>
	/// new VideoEventOptions { Play = OnPlay, Pause = OnPause, TimeUpdated = OnTimeUpdated }
	/// </code>
	/// </summary>
	public struct VideoEventOptions
	{
		/// <summary>
		/// Fires when the loading of an audio/video is aborted
		/// </summary>
		public Action<VideoState> Abort { get; set; }
		/// <summary>
		/// Fires when the browser can start playing the audio/video
		/// </summary>
		public Action<VideoState> CanPlay { get; set; }
		/// <summary>
		/// Fires when the browser can play through the audio/video without stopping for buffering
		/// </summary>
		public Action<VideoState> CanPlayThrough { get; set; }
		/// <summary>
		/// Fires when the duration of the audio/video is changed
		/// </summary>
		public Action<VideoState> DurationChange { get; set; }
		/// <summary>
		/// Fires when the current playlist is empty
		/// </summary>
		public Action<VideoState> Emptied { get; set; }
		/// <summary>
		/// Fires when the current playlist is ended
		/// </summary>
		public Action<VideoState> Ended { get; set; }
		/// <summary>
		/// Fires when an error occurred during the loading of an audio/video
		/// </summary>
		public Action<VideoState> Error { get; set; }
		/// <summary>
		/// Fires when the browser has loaded the current frame of the audio/video
		/// </summary>
		public Action<VideoState> LoadedData { get; set; }
		/// <summary>
		/// Fires when the browser has loaded meta data for the audio/video
		/// </summary>
		public Action<VideoState> LoadedMetadata { get; set; }
		/// <summary>
		/// Fires when the browser starts looking for the audio/video
		/// </summary>
		public Action<VideoState> LoadStart { get; set; }
		/// <summary>
		/// Fires when the audio/video has been paused
		/// </summary>
		public Action<VideoState> Pause { get; set; }
		/// <summary>
		/// Fires when the audio/video has been started or is no longer paused
		/// </summary>
		public Action<VideoState> Play { get; set; }
		/// <summary>
		/// Fires when the audio/video is playing after having been paused or stopped for buffering
		/// </summary>
		public Action<VideoState> Playing { get; set; }
		/// <summary>
		/// Fires when the browser is downloading the audio/video
		/// </summary>
		public Action<VideoState> Progress { get; set; }
		/// <summary>
		/// Fires when the playing speed of the audio/video is changed
		/// </summary>
		public Action<VideoState> RateChange { get; set; }
		/// <summary>
		/// Fires when the user is finished moving/skipping to a new position in the audio/video
		/// </summary>
		public Action<VideoState> Seeked { get; set; }
		/// <summary>
		/// Fires when the user starts moving/skipping to a new position in the audio/video
		/// </summary>
		public Action<VideoState> Seeking { get; set; }
		/// <summary>
		/// Fires when the browser is trying to get media data, but data is not available
		/// </summary>
		public Action<VideoState> Stalled { get; set; }
		/// <summary>
		/// Fires when the browser is intentionally not getting media data
		/// </summary>
		public Action<VideoState> Suspend { get; set; }
		/// <summary>
		/// Fires when the current playback position has changed
		/// </summary>
		public Action<VideoState> TimeUpdate { get; set; }
		/// <summary>
		/// Fires when the volume has been changed
		/// </summary>
		public Action<VideoState> VolumeChange { get; set; }
		/// <summary>
		/// Fires when the video stops because it needs to buffer the next frame
		/// </summary>
		public Action<VideoState> Waiting { get; set; }
	}
}
