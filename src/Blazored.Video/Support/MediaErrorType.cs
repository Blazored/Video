namespace Blazored.Video.Support
{
	public enum MediaErrorType
	{
		MEDIA_ERR_ABORTED = 1, // fetching process aborted by user
		MEDIA_ERR_NETWORK = 2, // error occurred when downloading
		MEDIA_ERR_DECODE = 3, // error occurred when decoding
		MEDIA_ERR_SRC_NOT_SUPPORTED = 4, // audio/video not supported
	}
}
