using System;
using System.Collections.Generic;
using System.Text;

namespace _2dzOOP
{
    public static class TvUtilities
    {

        public static Episode Parse(string episodesInputs)
        {
            string[] items = episodesInputs.Split(',');
            Description description = new Description(int.Parse(items[3]), TimeSpan.Parse(items[4]), items[5]);
            Episode split = new Episode(int.Parse(items[0]), double.Parse(items[1]), double.Parse(items[2]), description);
            return split;
        }
        public static void Sort(Episode[] episodes)
        {
            int i, j;
            Episode temp;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10 - i - 1; j++)
                {
                    if (episodes[j].MaxScore > episodes[j + 1].MaxScore)
                    {
                        temp = episodes[j];
                        episodes[j] = episodes[j + 1];
                        episodes[j + 1] = temp;

                    }
                }
            }
        }
    }
}
