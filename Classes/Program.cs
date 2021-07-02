using Moq;

using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            var scoreProcessor = new ScoreProcessor();

           // Mock<IScorer> scorerMock = new Mock<IScorer>();
           // scorerMock.Setup(x => x.ScroreA).Returns(10);
           // scorerMock.Setup(x => x.ScroreB).Returns(6);


            var totalScore = scoreProcessor.Process(new Scorer(new SQLDBScoreRepository()));

            Console.WriteLine($"Total score is {totalScore}");
        }
    }    
}
