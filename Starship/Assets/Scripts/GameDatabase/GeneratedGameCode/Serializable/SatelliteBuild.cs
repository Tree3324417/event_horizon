//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System;
using GameDatabase.Enums;
using GameDatabase.Model;

namespace GameDatabase.Serializable
{
	[Serializable]
	public class SatelliteBuildSerializable : SerializableItem
	{
		public int SatelliteId;
		public bool NotAvailableInGame;
		public DifficultyClass DifficultyClass;
		public InstalledComponentSerializable[] Components;
	}
}
