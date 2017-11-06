namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int player1Score = 0;
        private int player2Score = 0;
        private string player1Name;
        private string player2Name;
        public static readonly string PLAYER1 = "player1";
        public static readonly string PLAYER2 = "player2";

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
            string scoreInWords = "";
            int tempScore = 0;
            if (player1Score == player2Score)
            {
                switch (player1Score)
                {
                    case 0:
                        scoreInWords = "Love-All";
                        break;
                    case 1:
                        scoreInWords = "Fifteen-All";
                        break;
                    case 2:
                        scoreInWords = "Thirty-All";
                        break;
                    default:
                        scoreInWords = "Deuce";
                        break;

                }
            }
            else if (player1Score >= 4 || player2Score >= 4)
            {
                var minusResult = player1Score - player2Score;
                if (minusResult == 1) scoreInWords = $"Advantage {PLAYER1}";
                else if (minusResult == -1) scoreInWords = $"Advantage {PLAYER2}";
                else if (minusResult >= 2) scoreInWords = $"Win for {PLAYER1}";
                else scoreInWords = $"Win for {PLAYER2}";
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = player1Score;
                    else { scoreInWords += "-"; tempScore = player2Score; }
                    switch (tempScore)
                    {
                        case 0:
                            scoreInWords += "Love";
                            break;
                        case 1:
                            scoreInWords += "Fifteen";
                            break;
                        case 2:
                            scoreInWords += "Thirty";
                            break;
                        case 3:
                            scoreInWords += "Forty";
                            break;
                    }
                }
            }
            return scoreInWords;
        }
    }
}
