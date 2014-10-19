using System;

namespace Game
{
	public class AggressiveWeapons:Armory, IAggressiveWeapons
	{
		private double _touchChance;
		private int _priority;
		public int tryTouch;

		/*GETTER & SETTER */
		public double touchChance{
			get{
				return this._touchChance;
			}

			set{
				this._touchChance = value;
			}
		}

		public int priority{
			get{
				return this._priority;
			}
			set{
				this._priority = value;
			}
		}
		public AggressiveWeapons (string A_name, int A_equipmentPoints, double A_touchChance, int A_priority):base(A_name,A_equipmentPoints)
		{
			this.touchChance = A_touchChance;
			this.priority = A_priority;
		}

		public Boolean TryAttack(){
			Random hasard = new Random();
			this.tryTouch = hasard.Next (101);
			if (this.tryTouch <= this.touchChance) {
				return true;
			} else {
				return false;
			}
		}

		public bool aggressive(){
			return true;
		}
	}
}

