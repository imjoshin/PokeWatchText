﻿using System;

namespace PokewatchUtility.DataTypes
{
	public sealed class Location : IEquatable<Location>
	{
		public double Longitude { get; set; }
		public double Latitude { get; set; }

		public bool Equals(Location other)
		{
			return Math.Abs(Longitude - other.Longitude) < .00001 && Math.Abs(Latitude - other.Latitude) < .00001;
		}
	}
}
