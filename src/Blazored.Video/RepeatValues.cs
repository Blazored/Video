namespace Blazored.Video;

/// <summary>
///		Defines methods for a <see cref="VideoQueue"/> to behave when a video source was played to its end.
/// </summary>
public enum RepeatValues
{
	/// <summary>
	///		Defines no repetition after the queue reached its end.
	/// </summary>
	No,

	/// <summary>
	///		Will repeat the current loaded video forever.
	/// </summary>
	Once,

	/// <summary>
	///		Loops back to the first video after the last one ended.
	/// </summary>
	Loop
}