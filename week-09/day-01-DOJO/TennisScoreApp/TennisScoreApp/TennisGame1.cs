using TennisScoreApp;

namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private static readonly string PLAYER1 = "player1";
        private static readonly string PLAYER2 = "player2";
        private static readonly int MIN_WIN_SCORE = 4;
        private int player1Score = 0;
        private int player2Score = 0;
        private string player1Name;
        private string player2Name;
        public string scoreInWords = "";


        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == PLAYER1)
                player1Score += 1;
            else
                player2Score += 1;
        }

        public string GetScore()
        {
            if (player1Score == player2Score)
            {
                switch (player1Score)
                {
                    case 0:
                        scoreInWords = $"{ResultRelatedWords.Love.ToString()}-{ResultRelatedWords.All.ToString()}";
                        break;
                    case 1:
                        scoreInWords = $"{ResultRelatedWords.Fifteen.ToString()}-{ResultRelatedWords.All.ToString()}";
                        break;
                    case 2:
                        scoreInWords = $"{ResultRelatedWords.Thirty.ToString()}-{ResultRelatedWords.All.ToString()}";
                        break;
                    default:
                        scoreInWords = ResultRelatedWords.Deuce.ToString();
                        break;

                }
            }
            else if (player1Score >= MIN_WIN_SCORE || player2Score >= MIN_WIN_SCORE)
            {
                var minusResult = player1Score - player2Score;
                if (minusResult == 1) scoreInWords = $"Advantage {PLAYER1}";
                else if (minusResult == -1) scoreInWords = $"Advantage {PLAYER2}";
                else if (minusResult >= 2) scoreInWords = $"Win for {PLAYER1}";
                else scoreInWords = $"Win for {PLAYER2}";
            }
            else
            {
                scoreInWords = $"{TemporaryScoreInWords(player1Score)}-{TemporaryScoreInWords(player2Score)}";
            }
            return scoreInWords;
        }

        public string TemporaryScoreInWords(int tempScore)
        {
            string tempScoreInWords = "";
            switch (tempScore)
            {
                case 0:
                    tempScoreInWords += ResultRelatedWords.Love.ToString();
                    break;
                case 1:
                    tempScoreInWords += ResultRelatedWords.Fifteen.ToString();
                    break;
                case 2:
                    tempScoreInWords += ResultRelatedWords.Thirty.ToString();
                    break;
                case 3:
                    tempScoreInWords += ResultRelatedWords.Forty.ToString();
                    break;
            };
            return tempScoreInWords;
        }
    }
}
