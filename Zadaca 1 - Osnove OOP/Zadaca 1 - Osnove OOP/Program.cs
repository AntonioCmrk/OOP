﻿using System;
using Classes;

namespace Zadaca_1___Osnove_OOP
{
	class Program
    {
		static void Main(string[] args)
        {
			Episode ep1, ep2;
			ep1 = new Episode();
			ep2 = new Episode(10, 64.39, 8.7);
			int viewers = 10;
			for (int i = 0; i < viewers; i++)
			{
				ep1.AddView(GenerateRandomScore());
				Console.WriteLine(ep1.GetMaxScore());
			}
			if (ep1.GetAverageScore() > ep2.GetAverageScore())
			{
				Console.WriteLine($"Viewers: {ep1.GetViewerCount()}");
			}
			else
			{
				Console.WriteLine($"Viewers: {ep2.GetViewerCount()}");
			}
		}
		private static readonly Random random = new Random();
		static double GenerateRandomScore() 
		{
			var next = random.NextDouble();
			return 0 + (next * (10 - 0));
		}
    }
}
