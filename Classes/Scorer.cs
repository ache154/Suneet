using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Scorer : IScorer
    {
        private IScoreRepository _scoreRepository;

        public Scorer(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }

        public int ScroreA => _scoreRepository.GetScoreA();

        public int ScroreB => _scoreRepository.GetScoreB();
    }
}
