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
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoEventData> EventFiredEvent { get; set; }

		/// <summary>
		/// Fires when the loading of an audio/video is aborted
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> AbortEvent { get; set; }
		/// <summary>
		/// Fires when the browser can start playing the audio/video
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> CanPlayEvent { get; set; }
		/// <summary>
		/// Fires when the browser can play through the audio/video without stopping for buffering
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> CanPlayThroughEvent { get; set; }
		/// <summary>
		/// Fires when the duration of the audio/video is changed
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> DurationChangeEvent { get; set; }
		/// <summary>
		/// Fires when the current playlist is empty
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> EmptiedEvent { get; set; }
		/// <summary>
		/// Fires when the current playlist is ended
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> EndedEvent { get; set; }
		/// <summary>
		/// Fires when an error occurred during the loading of an audio/video
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> ErrorEvent { get; set; }
		/// <summary>
		/// Fires when the browser has loaded the current frame of the audio/video
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> LoadedDataEvent { get; set; }
		/// <summary>
		/// Fires when the browser has loaded meta data for the audio/video
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> LoadedMetadataEvent { get; set; }
		/// <summary>
		/// Fires when the browser starts looking for the audio/video
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> LoadStartEvent { get; set; }
		/// <summary>
		/// Fires when the audio/video has been paused
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> PauseEvent { get; set; }
		/// <summary>
		/// Fires when the audio/video has been started or is no longer paused
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> PlayEvent { get; set; }
		/// <summary>
		/// Fires when the audio/video is playing after having been paused or stopped for buffering
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> PlayingEvent { get; set; }
		/// <summary>
		/// Fires when the browser is downloading the audio/video
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> ProgressEvent { get; set; }
		/// <summary>
		/// Fires when the playing speed of the audio/video is changed
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> RateChangeEvent { get; set; }
		/// <summary>
		/// Fires when the user is finished moving/skipping to a new position in the audio/video
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> SeekedEvent { get; set; }
		/// <summary>
		/// Fires when the user starts moving/skipping to a new position in the audio/video
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> SeekingEvent { get; set; }
		/// <summary>
		/// Fires when the browser is trying to get media data, but data is not available
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> StalledEvent { get; set; }
		/// <summary>
		/// Fires when the browser is intentionally not getting media data
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> SuspendEvent { get; set; }
		/// <summary>
		/// Fires when the current playback position has changed
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> TimeUpdateEvent { get; set; }
		/// <summary>
		/// Fires when the volume has been changed
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> VolumeChangeEvent { get; set; }
		/// <summary>
		/// Fires when the video stops because it needs to buffer the next frame
		/// </summary>
		/// <remarks>Will call StateHasChanged() on the Action target.</remarks>
		[Parameter] public EventCallback<VideoState> WaitingEvent { get; set; }

		bool EventFiredEventRequired => EventFiredEvent.HasDelegate;
		bool AbortEventRequired => AbortEvent.HasDelegate;
		bool CanPlayEventRequired => CanPlayEvent.HasDelegate;
		bool CanPlayThroughEventRequired => CanPlayThroughEvent.HasDelegate;
		bool DurationChangeEventRequired => DurationChangeEvent.HasDelegate;
		bool EmptiedEventRequired => EmptiedEvent.HasDelegate;
		bool EndedEventRequired => EndedEvent.HasDelegate;
		bool ErrorEventRequired => ErrorEvent.HasDelegate;
		bool LoadedDataEventRequired => LoadedDataEvent.HasDelegate;
		bool LoadedMetadataEventRequired => LoadedMetadataEvent.HasDelegate;
		bool LoadStartEventRequired => LoadStartEvent.HasDelegate;
		bool PauseEventRequired => PauseEvent.HasDelegate;
		bool PlayEventRequired => PlayEvent.HasDelegate;
		bool PlayingEventRequired => PlayingEvent.HasDelegate;
		bool ProgressEventRequired => ProgressEvent.HasDelegate;
		bool RateChangeEventRequired => RateChangeEvent.HasDelegate;
		bool SeekedEventRequired => SeekedEvent.HasDelegate;
		bool SeekingEventRequired => SeekingEvent.HasDelegate;
		bool StalledEventRequired => StalledEvent.HasDelegate;
		bool SuspendEventRequired => SuspendEvent.HasDelegate;
		bool TimeUpdateEventRequired => TimeUpdateEvent.HasDelegate;
		bool VolumeChangeEventRequired => VolumeChangeEvent.HasDelegate;
		bool WaitingEventRequired => WaitingEvent.HasDelegate;

	}
}
