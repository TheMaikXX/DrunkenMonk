﻿using System;
using DrunkenMonk.Data;
using DrunkenMonk.Data.Enums;
using NLog;

namespace DrunkenMonk.ConsoleHelpers
{
	public static class SimulationExtension
	{
		private static readonly Logger logger = LogManager.GetCurrentClassLogger();

		public static Position GetFinalPosition(this Simulation simulation)
		{
			logger.Trace($"{nameof(GetFinalPosition)} method called");

			switch (simulation.Direction)
			{
				case Direction.Down:
					{
						return new Position(simulation.BasePosition.X, simulation.BasePosition.Y + simulation.Difference);
					}
				case Direction.Left:
					{
						return new Position(simulation.BasePosition.X - simulation.Difference, simulation.BasePosition.Y);
					}
				case Direction.Right:
					{
						return new Position(simulation.BasePosition.X + simulation.Difference, simulation.BasePosition.Y);
					}
				case Direction.Up:
					{
						return new Position(simulation.BasePosition.X, simulation.BasePosition.Y - simulation.Difference);
					}
				default:
				{
					throw new ArgumentOutOfRangeException(nameof(simulation.Direction));
				}
			}
		}
	}
}