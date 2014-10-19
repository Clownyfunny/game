using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
	public class Team
	{
		private string _name;
		private string _description;
		public int playedGames;
		public int winsGames;
		public int losesGames;
		private List<Gladiator> _gladiators;

		/* GETTER & SETTER */

		public List<Gladiator> gladiators{
			get{
				return this._gladiators;
			}
		}

		public string name{
			get{
				return this._name;
			}
			set {
				if (value != string.Empty) {
					this._name = value;
				}
			}
		}

		public string description{
			get{
				return this._description;
			}
			set {
				if (value != string.Empty) {
					this._description = value;
				}
			}
		}

		/*Team's constructor */

		public Team (string P_name, string P_description)
		{
			this.name = P_name;
			this.description = P_description;
			this.playedGames = 0;
			this.winsGames = 0;
			this.losesGames = this.playedGames - this.winsGames;
			this._gladiators = new List<Gladiator> ();
		}

		/* calculate percent of victory*/
		public double calculateRatio ()
		{
			return this.winsGames * (100 / this.playedGames);
		}

		/* Add a gladiator in team*/
		public List<Gladiator> addGladiator(string G_name, int G_positionInTeam){
			if (this.gladiators.Count >= 0 & this.gladiators.Count < 3) {
				this._gladiators.Add (new Gladiator (G_name, G_positionInTeam));
				this._gladiators = (this.gladiators.Cast<Gladiator> ().OrderBy (g => g.positionInTeam)).ToList();
				Console.WriteLine ("The gladiator " + G_name + " has been created in team : " + this.name);
			}
			else
				Console.WriteLine ("You cant create an other gladiator in the team : "+this.name);
			return this.gladiators;
		}
	}
}

