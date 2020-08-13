namespace Blazored.Video.Support
{
	public enum NetworkState
	{
		NETWORK_EMPTY = 0, // audio/video has not yet been initialized
		NETWORK_IDLE = 1, // audio/video is active and has selected a resource, but is not using the network
		NETWORK_LOADING = 2, // browser is downloading data
		NETWORK_NO_SOURCE = 3, // no audio/video source found
	}
}