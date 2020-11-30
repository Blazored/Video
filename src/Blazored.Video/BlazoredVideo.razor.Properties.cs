using System;
using System.Runtime.CompilerServices;
using Blazored.Video.Support;
using Microsoft.JSInterop;

namespace Blazored.Video
{
	public partial class BlazoredVideo
	{
		public bool Autoplay
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}

		public object AudioTracks
		{
			get { throw new NotSupportedException("No Browser supports this api yet"); }
		}

		public TimeRanges[] Buffered
		{
			get { throw new NotImplementedException("The Buffered Property is not yet implemented"); }
		}

		public class TimeRanges
		{
			public int Length { get; set; }

			public int Start(int index)
			{
				throw new NotImplementedException();
			}

			public int End(int index)
			{
				throw new NotImplementedException();
			}
		}

		public bool Controls
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}

		public string CurrentSrc
		{
			get { return GetValue<string>(); }
			set { SetValue(value); }
		}

		public int CurrentTime
		{
			get { return GetValue<int>(); }
			set { SetValue(value); }
		}

		public bool DefaultMuted
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}

		public double DefaultPlaybackRate 
		{
			get { return GetValue<double>(); }
			set { SetValue(value); }
		}

		public int Duration
		{
			get { return GetValue<int>(); }
			set { SetValue(value); }
		}

		public bool HasEnded
		{
			get { return GetValue<bool>("ended"); }
			set { SetValue(value); }
		}

		public bool Loop
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}

		public string MediaGroup
		{
			get { return GetValue<string>(); }
			set { SetValue(value); }
		}

		public bool Muted
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}

		public NetworkStateTypes NetworkState
		{
			get { return GetValue<NetworkStateTypes>(); }
			set { SetValue((int)value); }
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

		public bool Paused
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}

		public double PlaybackRate 
		{
			get { return GetValue<double>(); }
			set { SetValue(value); }
		}

		public TimeRanges[] Played
		{
			get { throw new NotImplementedException("The Played Property is not yet implemented"); }
		}

		public bool Preload
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}
		
		public ReadyState ReadyState
		{
			get { return GetValue<ReadyState>(); }
			set { SetValue(value); }
		}

		public bool Seekable
		{
			get { return GetValue<bool>(); }
			set { SetValue(value); }
		}

		public bool IsSeeking
		{
			get { return GetValue<bool>("seeking"); }
			set { SetValue(value); }
		}

		public string Src
		{
			get { return GetValue<string>(); }
			set { SetValue(value); }
		}

		public DateTime StartDate
		{
			get { throw new NotSupportedException("No Browser supports this api yet"); }
		}

		public object TextTracks
		{
			get { throw new NotSupportedException("No Browser supports this api yet"); }
		}

		public object VideoTracks
		{
			get { throw new NotSupportedException("No Browser supports this api yet"); }
		}

		public double Volume 
		{
			get { return GetValue<double>(); }
			set { SetValue(value); }
		}

		private T GetValue<T>([CallerMemberName]string name = null)
		{
			name = char.ToLower(name[0]) + name.Substring(1);
			if (JS is IJSInProcessRuntime inProcessRuntime)
			{
				return inProcessRuntime.Invoke<T>("Blazored.getProperty", videoRef, name);
			}

			return JS.InvokeAsync<T>("Blazored.getProperty", videoRef, name).GetAwaiter().GetResult();
		}

		private void SetValue<T>(T value, [CallerMemberName]string name = null)
		{
			name = char.ToLower(name[0]) + name.Substring(1);
			if (JS is IJSInProcessRuntime inProcessRuntime)
			{
				inProcessRuntime.InvokeVoid("Blazored.setProperty", videoRef, name, value);
				return;
			}

			JS.InvokeVoidAsync("Blazored.setProperty", videoRef, name, value).GetAwaiter().GetResult();
		}
	}
}