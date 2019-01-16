﻿using System.Runtime.Serialization;


namespace Nest
{
	[StringEnum]
	public enum GeoTree
	{
		[EnumMember(Value = "geohash")]
		Geohash,

		[EnumMember(Value = "quadtree")]
		Quadtree
	}
}
