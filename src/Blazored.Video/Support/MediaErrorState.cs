namespace Blazored.Video.Support
{
	/// <summary>
	/// Presents media error object.
	/// </summary>
	public class MediaErrorState
	{
		public MediaErrorType Code { get; set; }

		public string Message { get; set; }

		public override string ToString()
		{
			return this.Code.ToString();
		}
	}
}
