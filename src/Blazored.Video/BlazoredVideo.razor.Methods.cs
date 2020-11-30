using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Blazored.Video
{
	public partial class BlazoredVideo
	{
		public async Task StartPlayback()
		{
			await JS.InvokeVoidAsync("Blazored.invoke", videoRef, "play");
		}

		public async Task PausePlayback()
		{
			await JS.InvokeVoidAsync("Blazored.invoke", videoRef, "pause");
		}

		public async Task ReloadControl()
		{
			await JS.InvokeVoidAsync("Blazored.invoke", videoRef, "load");
		}

		public async Task<bool> CanPlayMediaType(string mediaType)
		{
			return await JS.InvokeAsync<bool>("Blazored.invoke", videoRef, "canPlayType", mediaType);
		}
	}
}