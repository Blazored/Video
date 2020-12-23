using System.Collections.Generic;

namespace Blazored.Video.Support
{
	public class TimeRanges : List<TimeRange>
	{
	}

	public class TimeRange
	{
		public int Index { get; set; }
		public double Start { get; set; }
		public double End { get; set; }
	}
}
