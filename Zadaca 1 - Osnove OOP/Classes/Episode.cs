using System;
using System.Collections.Generic;

namespace Classes
{
    public class Episode
    {
        public int Viewers;
        public double maxScore;
        public double averageScore;
        public Episode()
        { 
            Viewers = 0;
            maxScore = 0;
            averageScore = 0;
        }
        public Episode(int v, double mS, double aS)
        {
            Viewers = v;
            maxScore = mS;
            averageScore = aS;
        }
        public void AddView(double rS)
        {
            Viewers++;
            if (maxScore < rS)  
            {
                maxScore = rS;
            }
        }
        public double GetMaxScore() 
        {
            averageScore = averageScore + maxScore;
            return maxScore;
        }
        public double GetAverageScore() 
        {
            return averageScore = averageScore / Viewers;
        }
        public double GetViewerCount() 
        {
            return Viewers;
        }
    }
}
