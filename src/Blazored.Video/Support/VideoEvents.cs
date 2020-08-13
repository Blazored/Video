using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazored.Video.Support
{
	/// <summary>
	/// All the events supported by this component
	/// </summary>
	public enum VideoEvents
	{
		/// <summary>
		/// Value has not been set
		/// </summary>
		NotSet ,
		/// <summary>
		/// Fires when the loading of an audio/video is aborted
		/// </summary>
		Abort ,
		/// <summary>
		/// Fires when the browser can start playing the audio/video
		/// </summary>
		CanPlay ,
		/// <summary>
		/// Fires when the browser can play through the audio/video without stopping for buffering
		/// </summary>
		CanPlayThrough ,
		/// <summary>
		/// Fires when the duration of the audio/video is changed
		/// </summary>
		DurationChange ,
		/// <summary>
		/// Fires when the current playlist is empty
		/// </summary>
		Emptied ,
		/// <summary>
		/// Fires when the current playlist is ended
		/// </summary>
		Ended ,
		/// <summary>
		/// Fires when an error occurred during the loading of an audio/video
		/// </summary>
		Error ,
		/// <summary>
		/// Fires when the browser has loaded the current frame of the audio/video
		/// </summary>
		LoadedData ,
		/// <summary>
		/// Fires when the browser has loaded meta data for the audio/video
		/// </summary>
		LoadedMetadata ,
		/// <summary>
		/// Fires when the browser starts looking for the audio/video
		/// </summary>
		LoadStart ,
		/// <summary>
		/// Fires when the audio/video has been paused
		/// </summary>
		Pause ,
		/// <summary>
		/// Fires when the audio/video has been started or is no longer paused
		/// </summary>
		Play ,
		/// <summary>
		/// Fires when the audio/video is playing after having been paused or stopped for buffering
		/// </summary>
		Playing ,
		/// <summary>
		/// Fires when the browser is downloading the audio/video
		/// </summary>
		Progress ,
		/// <summary>
		/// Fires when the playing speed of the audio/video is changed
		/// </summary>
		RateChange ,
		/// <summary>
		/// Fires when the user is finished moving/skipping to a new position in the audio/video
		/// </summary>
		Seeked ,
		/// <summary>
		/// Fires when the user starts moving/skipping to a new position in the audio/video
		/// </summary>
		Seeking ,
		/// <summary>
		/// Fires when the browser is trying to get media data, but data is not available
		/// </summary>
		Stalled ,
		/// <summary>
		/// Fires when the browser is intentionally not getting media data
		/// </summary>
		Suspend ,
		/// <summary>
		/// Fires when the current playback position has changed
		/// </summary>
		TimeUpdate ,
		/// <summary>
		/// Fires when the volume has been changed
		/// </summary>
		VolumeChange ,
		/// <summary>
		/// Fires when the video stops because it needs to buffer the next frame
		/// </summary>
		Waiting ,
	}
}
