using System;

namespace Game
{
	public class HybrideWeapons:AggressiveWeapons, IDefensiveWeapons
	{
		private double _paradeChance;

		/*GETTER & SETTER */
		public double paradeChance{
			get{
				return this._paradeChance;
			}

			set{
				this._paradeChance = value;
			}
		}

		public HybrideWeapons (string A_name, int A_equipmentPoints, double A_paradeChance, double A_touchChance, int A_priority):base(A_name,A_equipmentPoints,A_touchChance, A_priority)
		{
			this.paradeChance = A_paradeChance;
		}

		public Boolean TryDef(){
			Random hasard = new Random();
			this.tryTouch = hasard.Next (101);
			if (this.tryTouch <= this.paradeChance) {
				return true;
			} else {
				return false;
			}
		}

		public bool defensive(){
			return true;
		}
	}
}

