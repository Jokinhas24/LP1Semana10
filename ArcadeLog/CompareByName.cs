using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArcadeLog
{
    public class CompareByName : IComparer<Score>
    {
        private bool ascending;
        public CompareByName(bool ascending)
        {
            this.ascending = ascending;
        }
        public int Compare(Score score, Score other)
        {
            if (score == null || other == null) return 0;

            int result = score.Name.CompareTo(other.Name);

            return ascending ? result : -result;
        }
    }
}