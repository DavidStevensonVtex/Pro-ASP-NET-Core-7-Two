﻿// Listing 14.14 Changing the TypeBroker.cs file in the Services folder

namespace Platform.Services
{
	public static class TypeBroker
	{
		private static IResponseFormatter formatter = new HtmlResponseFormatter();

		public static IResponseFormatter Formatter => formatter;
	}
}
