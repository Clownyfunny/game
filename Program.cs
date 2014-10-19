using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Tournament colise = new Tournament();
			/*Weapons creation*/

			Armory smallShield = new DefensiveWeapons ("Petit bouclier rond", 5, 20);
			Armory bigShield = new DefensiveWeapons ("Bouclier rectangulaire", 8, 30);
			Armory helmet = new DefensiveWeapons ("Casque", 2, 10);
			Armory dagger = new AggressiveWeapons ("Dague", 2, 60, 5);
			Armory sword = new AggressiveWeapons ("Epée", 5, 70, 4);
			Armory spear = new AggressiveWeapons ("Lance", 7, 50, 2);
			Armory trident = new HybrideWeapons ("Trident", 7, 10, 40, 3);
			Armory filet = new Filets ("Filet", 7, 30, 1);


			/*players creation*/

			Player player1 = new Player("Harry", "Covert", "player1");
			Player player2 = new Player ("Oliver", "Tom", "player2");
			Player player3 = new Player ("Anne", "Hilation", "player3");
			Player player4 = new Player ("Robert", "Patisserie", "player4");

			/*team creation*/
			player1.createTeam ("Equipe A", "Ceci est l'équipe A");
			player2.createTeam ("Equipe B", "Ceci est l'équipe B");
			player3.createTeam ("Equipe C", "Ceci est l'équipe C");
			player4.createTeam ("Equipe D", "Ceci est l'équipe D");

			/* gladiators creation*/
			player1.teams [0].addGladiator ("A", 1);
			player1.teams [0].addGladiator ("B", 2);
			player1.teams [0].addGladiator ("C", 3);
			player2.teams [0].addGladiator ("D", 1);
			player2.teams [0].addGladiator ("E", 2);
			player2.teams [0].addGladiator ("F", 3);
			player3.teams [0].addGladiator ("G", 1);
			player3.teams [0].addGladiator ("H", 2);
			player3.teams [0].addGladiator ("I", 3);
			player4.teams [0].addGladiator ("J", 1);
			player4.teams [0].addGladiator ("K", 2);
			player4.teams [0].addGladiator ("L", 3);

			/* gladiators buy weapons */
			player1.teams [0].gladiators [0].buyItem (smallShield);
			player1.teams [0].gladiators [0].buyItem (sword);
			player1.teams [0].gladiators [1].buyItem (trident);
			player1.teams [0].gladiators [2].buyItem (dagger);
			player1.teams [0].gladiators [2].buyItem (dagger);
			player2.teams [0].gladiators [0].buyItem (filet);
			player2.teams [0].gladiators [0].buyItem (dagger);
			player2.teams [0].gladiators [1].buyItem (trident);
			player2.teams [0].gladiators [2].buyItem (smallShield);
			player2.teams [0].gladiators [2].buyItem (sword);
			player3.teams [0].gladiators [0].buyItem (smallShield);
			player3.teams [0].gladiators [0].buyItem (sword);
			player3.teams [0].gladiators [1].buyItem (trident);
			player3.teams [0].gladiators [2].buyItem (dagger);
			player3.teams [0].gladiators [2].buyItem (dagger);
			player4.teams [0].gladiators [0].buyItem (smallShield);
			player4.teams [0].gladiators [0].buyItem (sword);
			player4.teams [0].gladiators [1].buyItem (trident);
			player4.teams [0].gladiators [2].buyItem (dagger);
			player4.teams [0].gladiators [2].buyItem (dagger);

			/*create tournament*/
			colise.addTeam(player1.teams [0]);
			colise.addTeam(player2.teams [0]);
			colise.addTeam(player3.teams [0]);
			colise.addTeam(player4.teams [0]);
			//colise.startGames ();
		}
	}
}
