// Listing 14.36 Adding a property in the IResponseFormatter.cs file in the Services folder

namespace Platform.Services
{
	public interface IResponseFormatter
	{
		Task Format(HttpContext context, string content);

		public bool RichOutput => false;
	}
}
