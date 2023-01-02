using System;
using System.Runtime.CompilerServices;
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
		public bool Autoplay
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
		public TimeRanges Buffered
		{
			get { return GetValue<TimeRanges>(); }
		}

		/// <summary>
		///		Sets or returns whether the audio/video should display controls (like play/pause etc.)
		/// </summary>
		public bool Controls
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}

		/// <summary>
		///		Returns the URL of the current audio/video
		/// </summary>
		public string CurrentSrc
		{
			get { return GetValue<string>(); }
		}

		/// <summary>
		///		Sets or returns the current playback position in the audio/video (in seconds)
		/// </summary>
		public int CurrentTime
		{
			get { return GetValue<int>(); }
			set { SetValue(value); }
		}

		/// <summary>
		///		Sets or returns whether the audio/video should be muted by default
		/// </summary>
		public bool DefaultMuted
		{
			get { return GetValue<bool>(); }
		}

		/// <summary>
		///		Sets or returns the default speed of the audio/video playback
		/// </summary>
		public double DefaultPlaybackRate
		{
			get { return GetValue<double>(); }
		}

		/// <summary>
		///		Returns the length of the current audio/video (in seconds)
		/// </summary>
		public int Duration
		{
			get { return GetValue<int>(); }
		}

		/// <summary>
		///		Returns whether the playback of the audio/video has ended or not
		/// </summary>
		public bool HasEnded
		{
			get { return GetValue<bool>("ended"); }
		}

		/// <summary>
		///		Sets or returns whether the audio/video should start over again when finished
		/// </summary>
		public bool Loop
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}

		/// <summary>
		///		Sets or returns the group the audio/video belongs to (used to link multiple audio/video elements)
		/// </summary>
		public string MediaGroup
		{
			get { return GetValue<string>(); }
			set { SetValue(value); }
		}

		/// <summary>
		///		Sets or returns whether the audio/video is muted or not
		/// </summary>
		public bool Muted
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}

		/// <summary>
		///		Returns the current network state of the audio/video
		/// </summary>
		public NetworkStateTypes NetworkState
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
		public bool Paused
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
		public double PlaybackRate
		{
			get { return GetValue<double>(); }
			set { SetValue(value); }
		}

		/// <summary>
		///		Returns a TimeRanges object representing the played parts of the audio/video
		/// </summary>
		public TimeRanges Played
		{
			get { return GetValue<TimeRanges>(); }
		}

		/// <summary>
		///		Sets or returns whether the audio/video should be loaded when the page loads
		/// </summary>
		public PreloadTypes Preload
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
		public string Poster
		{
			get { return GetValue<string>(); }
			set { SetValue(value); }
		}

		/// <summary>
		///		Returns the current ready state of the audio/video
		/// </summary>
		public ReadyState ReadyState
		{
			get { return GetValue<ReadyState>(); }
		}

		/// <summary>
		/// 	Returns a TimeRanges object representing the seekable parts of the audio/video
		/// </summary>
		public TimeRanges Seekable
		{
			get { return GetValue<TimeRanges>(); }
		}

		/// <summary>
		///		Returns whether the user is currently seeking in the audio/video
		/// </summary>
		public bool IsSeeking
		{
			get { return GetValue<bool>("seeking"); }
		}

		/// <summary>
		///		Sets or returns the current source of the audio/video element
		/// </summary>
		public string Src
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
		public TextTracks TextTracks
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
		public double Volume
		{
			get { return GetValue<double>(); }
			set { SetValue(value); }
		}

		protected virtual T GetValue<T>([CallerMemberName] string name = null)
		{
			var payloadName = VideoStateOptionsExt.FormatAsPayload(name);
			if (jsModule is IJSInProcessObjectReference inProcessModule)
			{
				return inProcessModule.Invoke<T>("getProperty", videoRef, payloadName);
			}

			throw new Exception($"Synchronous access to property {name} is only allowed in WebAssembly - use Get{name}Async() instead.");
		}

		protected virtual void SetValue<T>(T value, [CallerMemberName] string name = null)
		{
			var payloadName = VideoStateOptionsExt.FormatAsPayload(name);
			if (jsModule is IJSInProcessObjectReference inProcessModule)
			{
				inProcessModule.InvokeVoid("setProperty", videoRef, payloadName, value);
				return;
			}

			throw new Exception($"Synchronous access to property {name} is only allowed in WebAssembly - use Set{name}Async() instead.");
		}
	}
}