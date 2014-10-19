using System;

namespace Game
{
	public abstract class Armory
	{
		private string _name;
		private int _equipmentPoints;

		/* GETTER & SETTER */ 
		public string name {
			get {
				return this._name;
			}
			set {
				if (value != string.Empty) {
					this._name = value;
				}
			}
		}

		public int equipmentPoints{
			get {
				return this._equipmentPoints;
			}
			set {
				this._equipmentPoints = value;
			}
		}
		protected Armory (string A_name, int A_equipementPoints)
		{
			this.name = A_name;
			this.equipmentPoints = A_equipementPoints;
		} 
	}
}

