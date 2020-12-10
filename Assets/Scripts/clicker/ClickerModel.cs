namespace clicker
{
    public class ClickerModel
    {
        private int score = 0;
        public int GetScore()
        {
            return this.score;
        }
        public void AddScore(int amount = 1)
        {
            this.score += amount;
        }
    }
}