using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Blazored.Video.Support;
using Microsoft.JSInterop;

namespace Blazored.Video
{
	/// <summary>
	///		Implements all properties of an video object according to:
	///		https://www.w3schools.com/tags/ref_av_dom.asp
	/// </summary>
	public partial class BlazoredVideo
	{
		/// <summary>
		///		Sets or returns whether the audio/video should start playing as soon as it is loaded
		/// </summary>
		public Task<bool> Autoplay
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}
		
		/// <summary>
		///		Returns an AudioTrackList object representing available audio tracks
		/// </summary>
		[Obsolete("No Browser supports this api yet", true)]
		public AudioTrackList AudioTracks
		{
			get { throw new NotSupportedException("No Browser supports this api yet"); }
		}

		/// <summary>
		///		Returns a TimeRanges object representing the buffered parts of the audio/video
		/// </summary>
		public Task<TimeRanges> Buffered
		{
			get { return GetValue<TimeRanges>(); }
		}

		/// <summary>
		///		Sets or returns whether the audio/video should display controls (like play/pause etc.)
		/// </summary>
		public Task<bool> Controls
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}

		/// <summary>
		///		Returns the URL of the current audio/video
		/// </summary>
		public Task<string> CurrentSrc
		{
			get { return GetValue<string>(); }
		}

		/// <summary>
		///		Sets or returns the current playback position in the audio/video (in seconds)
		/// </summary>
		public Task<int> CurrentTime
		{
			get { return GetValue<int>(); }
			set { SetValue(value); }
		}

		/// <summary>
		///		Sets or returns whether the audio/video should be muted by default
		/// </summary>
		public Task<bool> DefaultMuted
		{
			get { return GetValue<bool>(); }
		}

		/// <summary>
		///		Sets or returns the default speed of the audio/video playback
		/// </summary>
		public Task<double> DefaultPlaybackRate 
		{
			get { return GetValue<double>(); }
		}

		/// <summary>
		///		Returns the length of the current audio/video (in seconds)
		/// </summary>
		public Task<int> Duration
		{
			get { return GetValue<int>(); }
		}

		/// <summary>
		///		Returns whether the playback of the audio/video has ended or not
		/// </summary>
		public Task<bool> HasEnded
		{
			get { return GetValue<bool>("ended"); }
		}

		/// <summary>
		///		Sets or returns whether the audio/video should start over again when finished
		/// </summary>
		public Task<bool> Loop
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}

		/// <summary>
		///		Sets or returns the group the audio/video belongs to (used to link multiple audio/video elements)
		/// </summary>
		public Task<string> MediaGroup
		{
			get { return GetValue<string>(); }
			set { SetValue(value); }
		}

		/// <summary>
		///		Sets or returns whether the audio/video is muted or not
		/// </summary>
		public Task<bool> Muted
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}

		/// <summary>
		///		Returns the current network state of the audio/video
		/// </summary>
		public Task<NetworkStateTypes> NetworkState
		{
			get { return GetValue<NetworkStateTypes>(); }
		}

		/// <summary>
		/// https://www.w3schools.com/tags/av_prop_networkstate.asp
		/// </summary>
		public enum NetworkStateTypes
		{
			Empty,
			Idle,
			Loading,
			NoSource
		}

		/// <summary>
		///		Returns whether the audio/video is paused or not
		/// </summary>
		public Task<bool> Paused
		{
			get { return GetValue<bool>(); }
		}

		/// <summary>
		///		Sets or returns the speed of the audio/video playback 
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
		public Task<double> PlaybackRate 
		{
			get { return GetValue<double>(); }
			set { SetValue(value); }
		}

		/// <summary>
		///		Returns a TimeRanges object representing the played parts of the audio/video
		/// </summary>
		public Task<TimeRanges> Played
		{
			get { return GetValue<TimeRanges>(); }
		}

		/// <summary>
		///		Sets or returns whether the audio/video should be loaded when the page loads
		/// </summary>
		public Task<PreloadTypes> Preload
		{
			get { return GetValue<PreloadTypes>(); }
		}

		public enum PreloadTypes
		{
			Auto,
			Metadata,
			None
		}

		/// <summary>
		/// The poster attribute specifies an image to be shown while the video is downloading, or until the user hits the play button. If this is not included, the first frame of the video will be used instead.
		/// </summary>
		public Task<string> Poster
		{
			get { return GetValue<string>(); }
			set { SetValue(value); }
		}
		
		/// <summary>
		///		Returns the current ready state of the audio/video
		/// </summary>
		public Task<ReadyState> ReadyState
		{
			get { return GetValue<ReadyState>(); }
		}

		/// <summary>
		/// 	Returns a TimeRanges object representing the seekable parts of the audio/video
		/// </summary>
		public Task<TimeRanges> Seekable
		{
			get { return GetValue<TimeRanges>(); }
		}

		/// <summary>
		///		Returns whether the user is currently seeking in the audio/video
		/// </summary>
		public Task<bool> IsSeeking
		{
			get { return GetValue<bool>("seeking"); }
		}

		/// <summary>
		///		Sets or returns the current source of the audio/video element
		/// </summary>
		public Task<string> Src
		{
			get { return GetValue<string>(); }
			set { SetValue(value); }
		}
		
		[Obsolete("No Browser supports this api yet", true)]
		public DateTime StartDate
		{
			get { throw new NotSupportedException("No Browser supports this api yet"); }
		}

		/// <summary>
		///		Returns a TextTrackList object representing the available text tracks
		/// </summary>
		public Task<TextTracks> TextTracks
		{
			get { return GetValue<TextTracks>(); }
		}
		
		[Obsolete("No Browser supports this api yet", true)]
		public VideoTracks VideoTracks
		{
			get { throw new NotSupportedException("No Browser supports this api yet"); }
		}

		/// <summary>
		///		Sets or returns the volume of the audio/video
		/// </summary>
		public Task<double> Volume 
		{
			get { return GetValue<double>(); }
			set { SetValue(value); }
		}

		protected virtual Task<T> GetValue<T>([CallerMemberName]string name = null)
		{
            try
            {
                name = char.ToLower(name[0]) + name.Substring(1);
                if (JS is IJSInProcessRuntime inProcessRuntime)
                    {
                        return Task.FromResult(inProcessRuntime.Invoke<T>("BlazoredVideo.getProperty", videoRef, name));
                }

                return JS.InvokeAsync<T>("BlazoredVideo.getProperty", videoRef, name).AsTask();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error:{ex.GetBaseException().Message}");
            }
            return Task.FromResult(default(T));
        }

		protected virtual void SetValue<T>(T value, [CallerMemberName]string name = null)
		{
			name = char.ToLower(name[0]) + name.Substring(1);
			if (JS is IJSInProcessRuntime inProcessRuntime)
			{
				inProcessRuntime.InvokeVoid("BlazoredVideo.setProperty", videoRef, name, value);
				return;
			}

			JS.InvokeVoidAsync("BlazoredVideo.setProperty", videoRef, name, value).GetAwaiter().GetResult();
		}
	}
}