using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Blazored.Video.Support;
using Microsoft.JSInterop;

namespace Blazored.Video
{
	public partial class BlazoredVideo
	{
		/// <summary>
		/// Tell the video player to start playback
		/// </summary>
		public ValueTask StartPlayback() => DoInvokeAsync(method: "play");

		/// <summary>
		/// Tell the video player to pause playback
		/// </summary>
		public ValueTask PausePlayback() => DoInvokeAsync(method: "pause");

		/// <summary>
		/// Tell the video player to (Re)load the video
		/// </summary>
		public ValueTask ReloadControl() => DoInvokeAsync(method: "load");

		/// <summary>
		/// Check whether the supplied mediaType can be played
		/// </summary>
		/// <returns>True/False</returns>
		public ValueTask<bool> CanPlayMediaType(string mediaType) => DoInvokeAsync<bool>(method: "canPlayType", mediaType);

		/// <summary>
		///		Gets whether the audio/video should start playing as soon as it is loaded
		/// </summary>
		public ValueTask<bool> GetAutoplayAsync() => GetValueAsync<bool>();
		/// <summary>
		///		Sets whether the audio/video should start playing as soon as it is loaded
		/// </summary>
		public ValueTask SetAutoplayAsync(bool value) => SetValueAsync(value);

		/// <summary>
		///		Returns an AudioTrackList object representing available audio tracks
		/// </summary>
		[Obsolete("No Browser supports this api yet", true)]
		public AudioTrackList GetAudioTracksAsync() => throw new NotSupportedException("No Browser supports this api yet");

		/// <summary>
		///		Returns a TimeRanges object representing the buffered parts of the audio/video
		/// </summary>
		public ValueTask<TimeRanges> GetBufferedAsync() => GetValueAsync<TimeRanges>();

		/// <summary>
		///		returns whether the audio/video should display controls (like play/pause etc.)
		/// </summary>
		public ValueTask<bool> GetControlsAsync() => GetValueAsync<bool>();
		/// <summary>
		///		Sets whether the audio/video should display controls (like play/pause etc.)
		/// </summary>
		public ValueTask SetControlsAsync(bool value) => SetValueAsync(value);

		/// <summary>
		///		Returns the URL of the current audio/video
		/// </summary>
		public ValueTask<string> GetCurrentSrcAsync() => GetValueAsync<string>();

		/// <summary>
		///		returns the current playback position in the audio/video (in seconds)
		/// </summary>
		public ValueTask<double> GetCurrentTimeAsync() => GetValueAsync<double>();
		/// <summary>
		///		Sets the current playback position in the audio/video (in seconds)
		/// </summary>
		public ValueTask SetCurrentTimeAsync(double value) => SetValueAsync(value);

		/// <summary>
		///		returns whether the audio/video should be muted by default
		/// </summary>
		public ValueTask<bool> GetDefaultMutedAsync() => GetValueAsync<bool>();
		/// <summary>
		///		Sets whether the audio/video should be muted by default
		/// </summary>
		public ValueTask SetDefaultMutedAsync(bool value) => SetValueAsync(value);

		/// <summary>
		///		returns the default speed of the audio/video playback
		/// </summary>
		public ValueTask<double> GetDefaultPlaybackRateAsync() => GetValueAsync<double>();
		/// <summary>
		///		Sets the default speed of the audio/video playback
		/// </summary>
		public ValueTask SetDefaultPlaybackRateAsync(double value) => SetValueAsync(value);

		/// <summary>
		///		Returns the length of the current audio/video (in seconds)
		/// </summary>
		public ValueTask<int> GetDurationAsync() => GetValueAsync<int>();

		/// <summary>
		///		Returns whether the playback of the audio/video has ended or not
		/// </summary>
		public ValueTask<bool> GetHasEndedAsync() => GetValueAsync<bool>("ended");

		/// <summary>
		///		returns whether the audio/video should start over again when finished
		/// </summary>
		public ValueTask<bool> GetLoopAsync() => GetValueAsync<bool>();
		/// <summary>
		///		Sets whether the audio/video should start over again when finished
		/// </summary>
		public ValueTask SetLoopAsync(bool value) => SetValueAsync(value);

		/// <summary>
		///		returns the group the audio/video belongs to (used to link multiple audio/video elements)
		/// </summary>
		public ValueTask<string> GetMediaGroupAsync() => GetValueAsync<string>();
		/// <summary>
		///		Sets the group the audio/video belongs to (used to link multiple audio/video elements)
		/// </summary>
		public ValueTask SetMediaGroupAsync(string value) => SetValueAsync(value);

		/// <summary>
		///		returns whether the audio/video is muted or not
		/// </summary>
		public ValueTask<bool> GetMutedAsync() => GetValueAsync<bool>();
		/// <summary>
		///		Sets whether the audio/video is muted or not
		/// </summary>
		public ValueTask SetMutedAsync(bool value) => SetValueAsync(value);

		/// <summary>
		///		Returns the current network state of the audio/video
		/// </summary>
		public ValueTask<NetworkStateTypes> GetNetworkStateAsync() => GetValueAsync<NetworkStateTypes>();

		/// <summary>
		///		Returns whether the audio/video is paused or not
		/// </summary>
		public ValueTask<bool> GetPausedAsync() => GetValueAsync<bool>();

		/// <summary>
		///		returns the speed of the audio/video playback 
		/// <example>
		/// <para>
		///		1.0 is normal speed,
		///		0.5 is half speed (slower),
		///		2.0 is double speed (faster),
		///		-1.0 is backwards; normal speed,
		///		-0.5 is backwards; half speed,
		/// </para>
		/// </example>
		/// </summary>
		public ValueTask<double> GetPlaybackRateAsync() => GetValueAsync<double>();
		/// <summary>
		///		Sets the speed of the audio/video playback 
		/// <example>
		/// <para>
		///		1.0 is normal speed,
		///		0.5 is half speed (slower),
		///		2.0 is double speed (faster),
		///		-1.0 is backwards; normal speed,
		///		-0.5 is backwards; half speed,
		/// </para>
		/// </example>
		/// </summary>
		public ValueTask SetPlaybackRateAsync(double value) => SetValueAsync(value);

		/// <summary>
		///		Returns a TimeRanges object representing the played parts of the audio/video
		/// </summary>
		public ValueTask<TimeRanges> GetPlayedAsync() => GetValueAsync<TimeRanges>();

		/// <summary>
		///		returns whether the audio/video should be loaded when the page loads
		/// </summary>
		public ValueTask<PreloadTypes> GetPreloadAsync() => GetValueAsync<PreloadTypes>();
		/// <summary>
		///		Sets whether the audio/video should be loaded when the page loads
		/// </summary>
		public ValueTask SetPreloadAsync(PreloadTypes value) => SetValueAsync(value);

		/// <summary>
		/// The poster attribute specifies an image to be shown while the video is downloading, or until the user hits the play button. If this is not included, the first frame of the video will be used instead.
		/// </summary>
		public ValueTask<string> GetPosterAsync() => GetValueAsync<string>();
		/// <summary>
		/// The poster attribute specifies an image to be shown while the video is downloading, or until the user hits the play button. If this is not included, the first frame of the video will be used instead.
		/// </summary>
		public ValueTask SetPosterAsync(string value) => SetValueAsync(value);

		/// <summary>
		///		Returns the current ready state of the audio/video
		/// </summary>
		public ValueTask<ReadyState> GetReadyStateAsync() => GetValueAsync<ReadyState>();

		/// <summary>
		/// 	Returns a TimeRanges object representing the seekable parts of the audio/video
		/// </summary>
		public ValueTask<TimeRanges> GetSeekableAsync() => GetValueAsync<TimeRanges>();

		/// <summary>
		///		Returns whether the user is currently seeking in the audio/video
		/// </summary>
		public ValueTask<bool> GetIsSeekingAsync() => GetValueAsync<bool>("seeking");

		/// <summary>
		///		returns the current source of the audio/video element
		/// </summary>
		public ValueTask<string> GetSrcAsync() => GetValueAsync<string>();
		/// <summary>
		///		Sets the current source of the audio/video element
		/// </summary>
		public ValueTask SetSrcAsync(string value) => SetValueAsync(value);

		[Obsolete("No Browser supports this api yet", true)]
		public DateTime GetStartDateAsync() => throw new NotSupportedException("No Browser supports this api yet");

		/// <summary>
		///		Returns a TextTrackList object representing the available text tracks
		/// </summary>
		public ValueTask<TextTracks> GetTextTracksAsync() => GetValueAsync<TextTracks>();

		[Obsolete("No Browser supports this api yet", true)]
		public VideoTracks GetVideoTracksAsync() => throw new NotSupportedException("No Browser supports this api yet");

		/// <summary>
		///		returns the volume of the audio/video
		/// </summary>
		public ValueTask<double> GetVolumeAsync() => GetValueAsync<double>();
		/// <summary>
		///		Sets the volume of the audio/video
		/// </summary>
		public ValueTask SetVolumeAsync(double value) => SetValueAsync(value);

		protected virtual ValueTask<T> GetValueAsync<T>([CallerMemberName] string name = null)
		{
			var payloadName = VideoStateOptionsExt.FormatGetSetAsyncAsPayload(name);
			if (jsModule is IJSInProcessObjectReference inProcessModule)
			{
				return ValueTask.FromResult(inProcessModule.Invoke<T>("getProperty", videoRef, payloadName));
			}

			return jsModule.InvokeAsync<T>("getProperty", videoRef, payloadName);
		}

		protected virtual ValueTask SetValueAsync<T>(T value, [CallerMemberName] string name = null)
		{
			var payloadName = VideoStateOptionsExt.FormatGetSetAsyncAsPayload(name);
			if (jsModule is IJSInProcessObjectReference inProcessModule)
			{
				inProcessModule.InvokeVoid("setProperty", videoRef, payloadName, value);
				return ValueTask.CompletedTask;
			}

			return jsModule.InvokeVoidAsync("setProperty", videoRef, payloadName, value);
		}
		protected virtual ValueTask DoInvokeAsync(string method)
		{
			if (jsModule is IJSInProcessObjectReference inProcessModule)
			{
				inProcessModule.InvokeVoid("invoke", videoRef, method);
				return ValueTask.CompletedTask;
			}
			return jsModule.InvokeVoidAsync("invoke", videoRef, method);
		}
		protected virtual ValueTask<T> DoInvokeAsync<T>(string method, params object[] parameters)
		{
			if (jsModule is IJSInProcessObjectReference inProcessModule)
			{
				return ValueTask.FromResult(inProcessModule.Invoke<T>("invoke", videoRef, method, parameters));
			}
			return jsModule.InvokeAsync<T>("invoke", videoRef, method, parameters);
		}
	}
}