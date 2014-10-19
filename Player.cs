using System;
using System.Collections.Generic;
using System.Linq;
namespace Game
{
	public class Player
	{
		private string _firstname;
		private string _name;
		private string _inscriptionDate;
		private string _gamerId;
		private List<Team> _teams;


		/* GETTER & SETTER for private variables*/

		public string firstname{
			get{
				return this._firstname;
			}
			set{
				if (value != string.Empty) {
					this._firstname = value;
				}
			}
		}

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

		public string inscriptionDate{
			get{
				return this._inscriptionDate;
			}
			set{
				if (value != string.Empty) {
					this._inscriptionDate = value;
				}
			}
		}

		public string gamerId{
			get{
				return this._gamerId;
			}
			set{
				if (value != string.Empty) {
					this._gamerId = value;
				}
			}
		}

		public List<Team> teams{
			get {
				return this._teams;
			}
		}
			
		/* Player's constructor */

		public Player (string P_firstname, string P_name, string P_gamerId)
		{
			this.firstname = P_firstname;
			this.name = P_name;
			this.gamerId = P_gamerId;
			this.inscriptionDate = DateTime.Now.ToString ("h:mm:ss tt");
			this._teams = new List<Team> ();
			Console.WriteLine ("The player : " + P_gamerId + " has been created.");

		}
		/* Create a team and add her in list */
		public List<Team> createTeam(string T_name, string T_description){
			if (this.teams.Count < 5) {
				this._teams.Add (new Team (T_name, T_description));
				Console.WriteLine ("The team " + T_name + " has been created.");
			} else
				Console.WriteLine ("You can't create more than 5 team");
			return this.teams;

		}
	}
}

