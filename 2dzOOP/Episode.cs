using System;
using System.Collections.Generic;
using System.Text;

namespace _2dzOOP
{
    public class Episode
    {
        private int Viewers;
        private double maxScore;
        private double averageScore;
        private Description description;
        public Episode()
        {
            Viewers = 0;
            maxScore = 0;
            averageScore = 0;
            description = null;


        }
        public Episode(int Viewers, double maxScore, double averageScore)
        {
            this.Viewers = Viewers;
            this.maxScore = maxScore;
            this.averageScore = averageScore;
            description = null;


        }
        public Episode(int Viewers, double maxScore, double averageScore, Description description)
        {
            this.Viewers = Viewers;
            this.maxScore = maxScore;
            this.averageScore = averageScore;
            this.description = description;


        }
        public double MaxScore
        {
            get { return maxScore; }
            set { this.MaxScore = maxScore; }
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
            averageScore += maxScore;
            return maxScore;
        }
        public double GetAverageScore()
        {
            return averageScore /= Viewers;
        }
        public double GetViewerCount()
        {
            return Viewers;
        }
    }
}
