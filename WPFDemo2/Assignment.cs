using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo2
{
    class Assignment
    {
        public string Title { get; set; }

        private int score;
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                if(value>=0 && value <= 100)
                {
                    score = value;
                }
                else { throw new ArgumentOutOfRangeException();
                }
            }
        }

        public override string ToString()
        {
            return Title+ " " +Score;
        }
    }
}
