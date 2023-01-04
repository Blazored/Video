using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blazored.Video.Support;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using static System.Net.Mime.MediaTypeNames;

namespace Blazored.Video
{
	/// <summary>
	///		Provides a structured way to queue a number of video sources for sequential playback.
	/// </summary>
	public class VideoQueue : ComponentBase
	{
		private bool _playAfterRender = false;
		private bool _playAfterRenderLoop = false;

		public VideoQueue()
		{
			Delay = 0;
			Repeat = RepeatValues.No;
			VideoItems = new List<VideoItem>();
		}

		/// <summary>
		///		Specifies the delay between source changes.
		/// </summary>
		[Parameter]
		public int Delay { get; set; }

		/// <summary>
		///		Defines how the <see cref="VideoQueue"/> should behave.
		/// </summary>
		[Parameter]
		public RepeatValues Repeat { get; set; }

		/// <summary>
		///		Provides easy access to the queued elements. Can be set instead of <see cref="VideoItem"/>'s.
		/// </summary>
		[Parameter]
		public string[] QueueData { get; set; }

		/// <summary>
		///		Should contain a number of <see cref="VideoItem"/>'s to provide a playlist of sources.
		/// </summary>
		[Parameter]
		public RenderFragment ChildContent { get; set; }

		/// <summary>
		///		Will be invoked when ether the current item is repeated or a next item is selected to be played.
		/// </summary>
		[Parameter]
		public EventCallback OnNextPlayed { get; set; }

		/// <summary>
		///		Will be invoked when there is no other item to play.
		/// </summary>
		[Parameter]
		public EventCallback OnPlaylistEnded { get; set; }

		[CascadingParameter]
		public BlazoredVideo BlazoredVideo { get; set; }

		public IList<VideoItem> VideoItems { get; }
		public VideoItem CurrentItem { get; private set; }

		/// <summary>
		///		Skips the current item and plays the next in queue.
		/// </summary>
		/// <returns></returns>
		public ValueTask PlayNext()
		{
			return TryPlayItem(VideoItems
				.SkipWhile(e => e.Id != CurrentItem.Id)
				.Skip(1)
				.FirstOrDefault());
		}

		/// <summary>
		///		Skips the current item and plays the previous in queue.
		/// </summary>
		/// <returns></returns>
		public ValueTask PlayPrevious()
		{
			return TryPlayItem(VideoItems
				.Reverse()
				.SkipWhile(e => e.Id != CurrentItem.Id)
				.Skip(1)
				.FirstOrDefault());
		}

		/// <summary>
		///		Starts the playback of the given <see cref="VideoItem"/>.
		/// </summary>
		/// <param name="value"></param>
		public async Task Play(VideoItem value)
		{
			await BlazoredVideo.PausePlayback();
			_playAfterRender = true;
			CurrentItem = value;
			await OnNextPlayed.InvokeAsync();
			StateHasChanged();
		}

		/// <summary>
		///		Adds a new item into the queue at its end and updates the <see cref="CurrentItem"/> if necessary.
		/// </summary>
		/// <param name="videoItem"></param>
		public void AddVideoItem(VideoItem videoItem)
		{
			if (VideoItems.Any(f => f.Id == videoItem.Id))
			{
				return;
			}
			VideoItems.Add(videoItem);
			if (VideoItems.Count == 1)
			{
				CurrentItem = videoItem;
			}
			StateHasChanged();
		}

		private async ValueTask TryPlayItem(VideoItem next)
		{
			await BlazoredVideo.PausePlayback();
			if (Repeat is RepeatValues.Loop && next is null)
			{
				_playAfterRender = true;
				CurrentItem = VideoItems.FirstOrDefault();
				StateHasChanged();
				await OnNextPlayed.InvokeAsync();
			}
			else if (next is not null)
			{
				_playAfterRender = true;
				CurrentItem = next;
				StateHasChanged();
				await OnNextPlayed.InvokeAsync();
			}
			else
			{
				await OnPlaylistEnded.InvokeAsync();
				await BlazoredVideo.PausePlayback();
			}
		}

		protected override void OnInitialized()
		{
			if (QueueData is { Length: > 0 })
			{
				foreach (var queueItem in QueueData)
				{
					var item = new VideoItem();
#pragma warning disable BL0005
					item.Source = queueItem;
#pragma warning restore BL0005
					VideoItems.Add(item);
				}
			}

			if (BlazoredVideo.EndedEvent.HasDelegate)
			{
				throw new InvalidOperationException("Cannot subscribe to 'BlazoredVideo.EndedEvent' as it is already in use. Please unsubscribe from the event.");
			}

#pragma warning disable BL0005
			BlazoredVideo.EndedEvent = new EventCallback<VideoState>(this, OnPlaybackEnded);
#pragma warning restore BL0005
		}

		private async ValueTask OnPlaybackEnded(VideoState videoState)
		{
			if (Delay != 0)
			{
				await Task.Delay(Delay);
			}

			if (Repeat is RepeatValues.Once)
			{
				await BlazoredVideo.SetCurrentTimeAsync(0);
				if (await BlazoredVideo.GetPausedAsync())
				{
					await BlazoredVideo.StartPlayback();
				}

				await OnNextPlayed.InvokeAsync();
			}
			else
			{
				await PlayNext();
			}
		}

		protected override void BuildRenderTree(RenderTreeBuilder builder)
		{
			builder.OpenRegion(0);
			builder.OpenComponent<CascadingValue<VideoQueue>>(1);
			builder.AddAttribute(2, nameof(CascadingValue<VideoQueue>.Value), this);
			builder.AddAttribute(3, nameof(CascadingValue<VideoQueue>.IsFixed), true);
			builder.AddAttribute(4, nameof(CascadingValue<VideoQueue>.ChildContent), (RenderFragment)((cBuilder) =>
			{
				cBuilder.AddContent(5, ChildContent);
			}));

			builder.CloseComponent();
			builder.CloseRegion();

			if (CurrentItem is null)
			{
				return;
			}

			foreach (var item in CurrentItem.VideoSources)
			{
				builder.OpenRegion(10);
				builder.OpenElement(11, "source");
				builder.AddAttribute(12, "src", item.Source);
				if (!string.IsNullOrWhiteSpace(item.Type))
				{
					builder.AddAttribute(13, "type", item.Type);
				}

				if (item.AdditionalAttributes is { Count: > 0 })
				{
					builder.AddMultipleAttributes(14, item.AdditionalAttributes);
				}
				builder.CloseElement();
				builder.CloseRegion();
			}
		}

		protected override async Task OnAfterRenderAsync(bool firstRender)
		{
			//the dual render cycle is necessary because only after the first cycle the source elements are created and updated into the parent control
			//after that first cycle the items are loaded and in the 2nd cycle we can call Play with the updated sources
			if (_playAfterRender)
			{
				_playAfterRenderLoop = true;
				_playAfterRender = false;
				StateHasChanged();
				return;
			}

			if (_playAfterRenderLoop)
			{
				_playAfterRenderLoop = false;
				await BlazoredVideo.ReloadControl();
				await BlazoredVideo.StartPlayback();
			}
		}
	}
}
