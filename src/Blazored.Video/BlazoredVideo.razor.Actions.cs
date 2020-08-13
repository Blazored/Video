using Blazored.Video.Support;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazored.Video
{
	public partial class BlazoredVideo
	{
		/// <summary>
		/// This parameter allows you to subscribe to all events in one go
		/// The "EventName" property of <see cref="VideoEventData"/> contains the <see cref="VideoEvents"/>
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoEventData> EventFired { get; set; }

		/// <summary>
		/// Fires when the loading of an audio/video is aborted
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> Abort { get; set; }
		/// <summary>
		/// Fires when the browser can start playing the audio/video
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> CanPlay { get; set; }
		/// <summary>
		/// Fires when the browser can play through the audio/video without stopping for buffering
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> CanPlayThrough { get; set; }
		/// <summary>
		/// Fires when the duration of the audio/video is changed
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> DurationChange { get; set; }
		/// <summary>
		/// Fires when the current playlist is empty
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> Emptied { get; set; }
		/// <summary>
		/// Fires when the current playlist is ended
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> Ended { get; set; }
		/// <summary>
		/// Fires when an error occurred during the loading of an audio/video
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> Error { get; set; }
		/// <summary>
		/// Fires when the browser has loaded the current frame of the audio/video
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> LoadedData { get; set; }
		/// <summary>
		/// Fires when the browser has loaded meta data for the audio/video
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> LoadedMetadata { get; set; }
		/// <summary>
		/// Fires when the browser starts looking for the audio/video
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> LoadStart { get; set; }
		/// <summary>
		/// Fires when the audio/video has been paused
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> Pause { get; set; }
		/// <summary>
		/// Fires when the audio/video has been started or is no longer paused
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> Play { get; set; }
		/// <summary>
		/// Fires when the audio/video is playing after having been paused or stopped for buffering
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> Playing { get; set; }
		/// <summary>
		/// Fires when the browser is downloading the audio/video
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> Progress { get; set; }
		/// <summary>
		/// Fires when the playing speed of the audio/video is changed
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> RateChange { get; set; }
		/// <summary>
		/// Fires when the user is finished moving/skipping to a new position in the audio/video
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> Seeked { get; set; }
		/// <summary>
		/// Fires when the user starts moving/skipping to a new position in the audio/video
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> Seeking { get; set; }
		/// <summary>
		/// Fires when the browser is trying to get media data, but data is not available
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> Stalled { get; set; }
		/// <summary>
		/// Fires when the browser is intentionally not getting media data
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> Suspend { get; set; }
		/// <summary>
		/// Fires when the current playback position has changed
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> TimeUpdate { get; set; }
		/// <summary>
		/// Fires when the volume has been changed
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> VolumeChange { get; set; }
		/// <summary>
		/// Fires when the video stops because it needs to buffer the next frame
		/// </summary>
		/// <remarks>Will not call StateHasChanged() on the Action target.</remarks>
		[Parameter] public Action<VideoState> Waiting { get; set; }

		bool EventFiredRequired => EventFired is object;
		bool AbortRequired => Abort is object;
		bool CanPlayRequired => CanPlay is object;
		bool CanPlayThroughRequired => CanPlayThrough is object;
		bool DurationChangeRequired => DurationChange is object;
		bool EmptiedRequired => Emptied is object;
		bool EndedRequired => Ended is object;
		bool ErrorRequired => Error is object;
		bool LoadedDataRequired => LoadedData is object;
		bool LoadedMetadataRequired => LoadedMetadata is object;
		bool LoadStartRequired => LoadStart is object;
		bool PauseRequired => Pause is object;
		bool PlayRequired => Play is object;
		bool PlayingRequired => Playing is object;
		bool ProgressRequired => Progress is object;
		bool RateChangeRequired => RateChange is object;
		bool SeekedRequired => Seeked is object;
		bool SeekingRequired => Seeking is object;
		bool StalledRequired => Stalled is object;
		bool SuspendRequired => Suspend is object;
		bool TimeUpdateRequired => TimeUpdate is object;
		bool VolumeChangeRequired => VolumeChange is object;
		bool WaitingRequired => Waiting is object;

	}
}
