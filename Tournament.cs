using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
	public class Tournament
	{
		public List<Team> _teamsInTournament;
		public int increment = 0;
		public Team teamTamp;
		public int incTeam1;
		public int incTeam2;
		public Tournament ()
		{
			this._teamsInTournament = new List<Team>();
		}

		public List<Team> addTeam(Team A_team){
			this._teamsInTournament.Add(A_team);
			Console.WriteLine ("The team " + A_team.name + " has been added to the tournament");	
			return this._teamsInTournament;
		}

		public void startGames(){
			while (this._teamsInTournament.Count > 1) {
				foreach (Team t_team in this._teamsInTournament) {
					if (increment == 0) {
						teamTamp = t_team;
						increment++;
					} else {
						createDual (teamTamp, t_team);
						increment = 0;
					}
				}
			}
		}

		public void createDual(Team t1, Team t2){
			incTeam1 = 0;
			incTeam2 = 0;
		}
	}
}

