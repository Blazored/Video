namespace Blazored.Video.Support
{
	public enum ReadyState
	{
		HAVE_NOTHING = 0,		// no information whether or not the audio/video is ready
		HAVE_METADATA = 1,		// metadata for the audio/video is ready
		HAVE_CURRENT_DATA = 2,  // data for the current playback position is available, but not enough data to play next frame/millisecond
		HAVE_FUTURE_DATA = 3,   // data for the current and at least the next frame is available
		HAVE_ENOUGH_DATA = 4,   // enough data available to start playing
	}
}