﻿// Listing 14.10 The contents of the TypeBroker.cs file in the Services folder

namespace Platform.Services
{
	public static class TypeBroker
	{
		private static IResponseFormatter formatter = new TextResponseFormatter();

		public static IResponseFormatter Formatter => formatter;
	}
}
