using System;

namespace Game
{
	public class DefensiveWeapons:Armory,IDefensiveWeapons
	{
		private double _paradeChance;
		public int tryTouch;

		/*GETTER & SETTER */
		public double paradeChance{
			get{
				return this._paradeChance;
			}

			set{
				this._paradeChance = value;
			}
		}
		public DefensiveWeapons (string A_name, int A_equipmentPoints, double A_paradeChance):base(A_name,A_equipmentPoints)
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

