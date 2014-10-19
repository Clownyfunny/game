using System;

namespace Game
{
	public class Filets:AggressiveWeapons, IObstructWeapons
	{
		public Filets (string A_name, int A_equipmentPoints, double A_touchChance, int A_priority):base(A_name,A_equipmentPoints, A_touchChance, A_priority)
		{
		}
		public bool obstruct(){
			return true;
		}
	}
}

