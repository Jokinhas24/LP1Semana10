namespace ArcadeLog
{
    public class Score : IComparable<Score>
    {
        private int points;
        public string Name {get;}
        public int Points
        {
            get;
            set
            {
                if (points < 0) {points = 0;}
                if (points > 10000) {points = 9999;}
            }
        }
        public string Medal {get;
            set
                {
                    if (points >= 7000) {Medal = "Gold";}
                    if (points >= 4000) {Medal = "Silver";}
                    else {Medal = "Bronze";}
                }
        }
        public Score (string name, int points)
        {
            Name = name;
            Points = points;
        }

        public int CompareTo(Score other)
        {
            return Points.CompareTo(other.Points);
        }

        public override string ToString()
        {
            return $"{Name} [{Medal}]: {Points}.";
        }
    }
}
