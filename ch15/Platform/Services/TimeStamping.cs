﻿// Listing 14.30 The contents of the TimeStamping.cs file in the Services folder

namespace Platform.Services
{
	public interface ITimeStamper
	{
		string TimeStamp { get; }
	}

	public class DefaultTimeStamper : ITimeStamper
	{
		public string TimeStamp
		{
			get => DateTime.Now.ToShortTimeString();
		}
	}
}
