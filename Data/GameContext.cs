﻿using System.Collections.Generic;
using DrunkenMonk.Data.Base;

namespace DrunkenMonk.Data
{
	public class GameContext
	{
		public Player Player { get; set; }

		public IEnumerable<Enemy> Enemies { get; set; }

		public Canvas Square { get; set; }

		public Canvas ScoreBoard { get; set; }
	}
}