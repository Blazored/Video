using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Blazored.Video
{
	public partial class BlazoredVideo
	{
		public async Task StartPlayback()
		{
			await JS.InvokeVoidAsync("BlazoredVideo.invoke", videoRef, "play");
		}

		public async Task PausePlayback()
		{
			await JS.InvokeVoidAsync("BlazoredVideo.invoke", videoRef, "pause");
		}

		public async Task ReloadControl()
		{
			await JS.InvokeVoidAsync("BlazoredVideo.invoke", videoRef, "load");
		}

		public async Task<bool> CanPlayMediaType(string mediaType)
		{
			return await JS.InvokeAsync<bool>("BlazoredVideo.invoke", videoRef, "canPlayType", mediaType);
		}
	}
}