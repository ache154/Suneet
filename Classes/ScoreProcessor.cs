using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ScoreProcessor
    {
        public int Process(IScorer scorer)
        {
            // Logic to calc total score
            return scorer.ScroreA + scorer.ScroreB;
        }
    }
}