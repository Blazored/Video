using System.Collections.Generic;
using System.Text;

namespace Blazored.Video.Support
{
    /// <summary>
    /// Used to define what data to return with an event
    /// <code>
    /// new VideoStateOptions { CurrentTime = true }
    /// </code>
    /// </summary>
    public struct VideoStateOptions
    {
        /// <summary>
        /// Returns the entire object
        /// </summary>
        public bool All { get; set; }
        /// <summary>
        /// Returns an AudioTrackList object representing available audio tracks
        /// </summary>
        public bool AudioTracks { get; set; }
        /// <summary>
        /// Returns whether the audio/video should start playing as soon as it is loaded
        /// </summary>
        public bool Autoplay { get; set; }
        /// <summary>
        /// Returns a TimeRanges object representing the buffered parts of the audio/video
        /// </summary>
        public bool Buffered { get; set; }
        /// <summary>
        /// Returns whether the audio/video should display controls (like play/pause etc.)
        /// </summary>
        public bool Controls { get; set; }
        /// <summary>
        /// Returns the CORS settings of the audio/video
        /// </summary>
        public bool CrossOrigin { get; set; }
        /// <summary>
        /// Returns the URL of the current audio/video
        /// </summary>
        public bool CurrentSrc { get; set; }
        /// <summary>
        /// Returns the current playback position in the audio/video (in seconds)
        /// </summary>
        public bool CurrentTime { get; set; }
        /// <summary>
        /// Returns whether the audio/video should be muted by default
        /// </summary>
        public bool DefaultMuted { get; set; }
        /// <summary>
        /// Returns the default speed of the audio/video playback
        /// </summary>
        public bool DefaultPlaybackRate { get; set; }
        /// <summary>
        /// Returns the length of the current audio/video (in seconds)
        /// </summary>
        public bool Duration { get; set; }
        /// <summary>
        /// Returns whether the playback of the audio/video has ended or not
        /// </summary>
        public bool Ended { get; set; }
        /// <summary>
        /// Returns a MediaError object representing the error state of the audio/video
        /// </summary>
        public bool Error { get; set; }
        /// <summary>
        /// Returns whether the audio/video should start over again when finished
        /// </summary>
        public bool Loop { get; set; }
        /// <summary>
        /// Returns the group the audio/video belongs to (used to link multiple audio/video elements)
        /// </summary>
        public bool MediaGroup { get; set; }
        /// <summary>
        /// Returns whether the audio/video is muted or not
        /// </summary>
        public bool Muted { get; set; }
        /// <summary>
        /// Returns the current network state of the audio/video
        /// </summary>
        public bool NetworkState { get; set; }
        /// <summary>
        /// Returns whether the audio/video is paused or not
        /// </summary>
        public bool Paused { get; set; }
        /// <summary>
        /// Returns the speed of the audio/video playback
        /// </summary>
        public bool PlaybackRate { get; set; }
        /// <summary>
        /// Returns a TimeRanges object representing the played parts of the audio/video
        /// </summary>
        public bool Played { get; set; }
        /// <summary>
        /// Returns whether the audio/video should be loaded when the page loads
        /// </summary>
        public bool Preload { get; set; }
        /// <summary>
        /// Returns the current ready state of the audio/video
        /// </summary>
        public bool ReadyState { get; set; }
        /// <summary>
        /// Returns a TimeRanges object representing the seekable parts of the audio/video
        /// </summary>
        public bool Seekable { get; set; }
        /// <summary>
        /// Returns whether the user is currently seeking in the audio/video
        /// </summary>
        public bool Seeking { get; set; }
        /// <summary>
        /// Returns the current source of the audio/video element
        /// </summary>
        public bool Src { get; set; }
        /// <summary>
        /// Returns a Date object representing the current time offset
        /// </summary>
        public bool StartDate { get; set; }
        /// <summary>
        /// Returns a TextTrackList object representing the available text tracks
        /// </summary>
        public bool TextTracks { get; set; }
        /// <summary>
        /// Returns a VideoTrackList object representing the available video tracks
        /// </summary>
        public bool VideoTracks { get; set; }
        /// <summary>
        /// Returns the volume of the audio/video
        /// </summary>
        public bool Volume { get; set; }
    }
    public static class VideoStateOptionsExt
    {
        public static string GetPayloads(this VideoStateOptions options)
        {
            var list = new StringBuilder("{");

            // doesn't serialize in the browser
            // sb.Append(options.All || options.AudioTracks, FormatAsPayload(nameof(options.AudioTracks)));
            list.Append(options.All || options.Autoplay, FormatAsPayload(nameof(options.Autoplay)));
            // doesn't serialize in the browser
            // sb.Append(options.All || options.Buffered, FormatAsPayload(nameof(options.Buffered)));
            list.Append(options.All || options.Controls, FormatAsPayload(nameof(options.Controls)));
            list.Append(options.All || options.CrossOrigin, FormatAsPayload(nameof(options.CrossOrigin)));
            list.Append(options.All || options.CurrentSrc, FormatAsPayload(nameof(options.CurrentSrc)));
            list.Append(options.All || options.CurrentTime, FormatAsPayload(nameof(options.CurrentTime)));
            list.Append(options.All || options.DefaultMuted, FormatAsPayload(nameof(options.DefaultMuted)));
            list.Append(options.All || options.DefaultPlaybackRate, FormatAsPayload(nameof(options.DefaultPlaybackRate)));
            list.Append(options.All || options.Duration, FormatAsPayload(nameof(options.Duration)));
            list.Append(options.All || options.Ended, FormatAsPayload(nameof(options.Ended)));
            list.Append(options.All || options.Error, FormatAsPayload(nameof(options.Error)));
            list.Append(options.All || options.Loop, FormatAsPayload(nameof(options.Loop)));
            list.Append(options.All || options.MediaGroup, FormatAsPayload(nameof(options.MediaGroup)));
            list.Append(options.All || options.Muted, FormatAsPayload(nameof(options.Muted)));
            list.Append(options.All || options.NetworkState, FormatAsPayload(nameof(options.NetworkState)));
            list.Append(options.All || options.Paused, FormatAsPayload(nameof(options.Paused)));
            list.Append(options.All || options.PlaybackRate, FormatAsPayload(nameof(options.PlaybackRate)));
            list.Append(options.All || options.Played, FormatAsPayload(nameof(options.Played)));
            list.Append(options.All || options.Preload, FormatAsPayload(nameof(options.Preload)));
            list.Append(options.All || options.ReadyState, FormatAsPayload(nameof(options.ReadyState)));
            list.Append(options.All || options.Seekable, FormatAsPayload(nameof(options.Seekable)));
            list.Append(options.All || options.Seeking, FormatAsPayload(nameof(options.Seeking)));
            list.Append(options.All || options.Src, FormatAsPayload(nameof(options.Src)));
            list.Append(options.All || options.StartDate, FormatAsPayload(nameof(options.StartDate)));
            // doesn't serialize in the browser
            // sb.Append(options.All || options.TextTracks, FormatAsPayload(nameof(options.TextTracks)));
            // sb.Append(options.All || options.VideoTracks, FormatAsPayload(nameof(options.VideoTracks)));
            list.Append(options.All || options.Volume, FormatAsPayload(nameof(options.Volume)));

            if (list.Length == 1)
            {
                return string.Empty;
            }

            list.Append("}");
            return list.ToString();

            static string FormatAsPayload(string name)
            {
                var payload = $"this.{VideoStateOptionsExt.FormatAsPayload(name)}";
                return $"{name}: {payload}";
            }
        }
        public static StringBuilder Append(this StringBuilder sb, bool condition, string value)
            => condition ? (sb.Length > 1 ? sb.Append(",").Append(value) : sb.Append(value)) : sb;
        public static void Append<T>(this List<T> sb, bool condition, T value)
        {
            if (condition) sb.Add(value);
        }
        public static string[] GetPayload(this VideoStateOptions options)
        {
            var list = new List<string>();

            //list.Append(options.All || options.AudioTracks, FormatAsPayload(nameof(options.AudioTracks)));
            list.Append(options.All || options.Autoplay, FormatAsPayload(nameof(options.Autoplay)));
            //list.Append(options.All || options.Buffered, FormatAsPayload(nameof(options.Buffered)));
            list.Append(options.All || options.Controls, FormatAsPayload(nameof(options.Controls)));
            list.Append(options.All || options.CrossOrigin, FormatAsPayload(nameof(options.CrossOrigin)));
            list.Append(options.All || options.CurrentSrc, FormatAsPayload(nameof(options.CurrentSrc)));
            list.Append(options.All || options.CurrentTime, FormatAsPayload(nameof(options.CurrentTime)));
            list.Append(options.All || options.DefaultMuted, FormatAsPayload(nameof(options.DefaultMuted)));
            list.Append(options.All || options.DefaultPlaybackRate, FormatAsPayload(nameof(options.DefaultPlaybackRate)));
            list.Append(options.All || options.Duration, FormatAsPayload(nameof(options.Duration)));
            list.Append(options.All || options.Ended, FormatAsPayload(nameof(options.Ended)));
            list.Append(options.All || options.Error, FormatAsPayload(nameof(options.Error)));
            list.Append(options.All || options.Loop, FormatAsPayload(nameof(options.Loop)));
            list.Append(options.All || options.MediaGroup, FormatAsPayload(nameof(options.MediaGroup)));
            list.Append(options.All || options.Muted, FormatAsPayload(nameof(options.Muted)));
            list.Append(options.All || options.NetworkState, FormatAsPayload(nameof(options.NetworkState)));
            list.Append(options.All || options.Paused, FormatAsPayload(nameof(options.Paused)));
            list.Append(options.All || options.PlaybackRate, FormatAsPayload(nameof(options.PlaybackRate)));
            //list.Append(options.All || options.Played, FormatAsPayload(nameof(options.Played)));
            list.Append(options.All || options.Preload, FormatAsPayload(nameof(options.Preload)));
            list.Append(options.All || options.ReadyState, FormatAsPayload(nameof(options.ReadyState)));
            //list.Append(options.All || options.Seekable, FormatAsPayload(nameof(options.Seekable)));
            list.Append(options.All || options.Seeking, FormatAsPayload(nameof(options.Seeking)));
            list.Append(options.All || options.Src, FormatAsPayload(nameof(options.Src)));
            list.Append(options.All || options.StartDate, FormatAsPayload(nameof(options.StartDate)));
            //list.Append(options.All || options.TextTracks, FormatAsPayload(nameof(options.TextTracks)));
            //list.Append(options.All || options.VideoTracks, FormatAsPayload(nameof(options.VideoTracks)));
            list.Append(options.All || options.Volume, FormatAsPayload(nameof(options.Volume)));

            return list.ToArray();

        }
        internal static string FormatAsPayload(string name)
            => $"{char.ToLower(name[0])}{name[1..]}";
        internal static string FormatGetSetAsyncAsPayload(string name)
            => FormatAsPayload(name[3..^5]);
    }
}
