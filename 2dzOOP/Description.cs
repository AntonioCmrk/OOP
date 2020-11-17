using System;
using System.Collections.Generic;
using System.Text;

namespace _2dzOOP
{
    public class Description
    {
        private int epideNumber;
        private TimeSpan timeSpan;
        private string episodeName;

        public Description(int epideNumber, TimeSpan timeSpan, string episodeName)
        {
            this.epideNumber = epideNumber;
            this.timeSpan = timeSpan;
            this.episodeName = episodeName;
        }
    }
}
