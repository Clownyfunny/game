using System;

namespace Game
{
	public interface IAggressiveWeapons
	{
		double touchChance{ get; set; }
		int priority{ get; set; }
		bool aggressive();
	}
}

