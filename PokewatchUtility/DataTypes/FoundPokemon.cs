﻿using System;
using POGOProtos.Enums;

namespace PokewatchUtility.DataTypes
{
	public sealed class FoundPokemon : IEquatable<FoundPokemon>
	{
		public PokemonId Kind { get; set; }
		public Location Location { get; set; }
		public int LifeExpectancy { get; set; }

		public bool Equals(FoundPokemon other)
		{
			return Kind == other.Kind && Location.Equals(other.Location);
		}
	}
}
