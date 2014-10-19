using System;
using System.Collections.Generic;
using System.Linq;
namespace Game
{
	public class Gladiator
	{
		private string _name;
		private List<Armory> _bagContent;
		private int _equipmentsPoints;
		private int _positionInTeam;

		/*GETTER & SETTER */
		public string name{
			get{
				return this._name;
			}
			set{
				if (value != string.Empty) {
					this._name = value;
				}
			}
		}

		public List<Armory> bagContent{
			get{
				return this._bagContent;
			}
		}

		public int equipmentsPoints{
			get{
				return this._equipmentsPoints;
			}
			set{
				this._equipmentsPoints = value;
			}
		}

		public int positionInTeam{
			get{
				return this._positionInTeam;
			}
			set{
				if (value > 0 && value <= 3) {
					this._positionInTeam = value;
				}
			}
		}

		/*Constructor*/
		public Gladiator (string G_name, int G_positionInTeam)
		{
			this._bagContent= new List<Armory> ();
			this.name = G_name;
			this.positionInTeam = G_positionInTeam;
			this.equipmentsPoints = 10;
		}
			
		/*Substract points */ 
		public int substractPoints(int I_price){
			return this.equipmentsPoints- I_price;
		}

		/*Buy an item */
		public List<Armory> buyItem(Armory I_weapon){
			if (this.substractPoints (I_weapon.equipmentPoints)>=0) {
				this._bagContent.Add (I_weapon);
				this.equipmentsPoints = this.substractPoints (I_weapon.equipmentPoints);
				Console.Write (I_weapon.name + " as been buy. Rest : "+this.equipmentsPoints+"\n");
			} else {
				Console.Write ("You can't buy "+I_weapon.name+" you have not enought points ("+this.equipmentsPoints+")\n");
			}
			return this.bagContent;
		}
	}
}

