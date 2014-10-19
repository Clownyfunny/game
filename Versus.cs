using System;

namespace Game
{
	public class Versus
	{
		private Team _team1;
		private Team _team2;

		public Team team1{
			get{
				return this._team1;
			}
			set {
				this._team1 = value;
			}
		}

		public Team team2{
			get{
				return this._team2;
			}
			set {
				this._team2 = value;
			}
		}
		public Versus (Team T_team1,Team T_team2)
		{
			this.team1 = T_team1;
			this.team2 = T_team2;
		}

		public void createDual(){
			 
		}
	}
}

