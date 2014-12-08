namespace Bookcase
{
    using System.Collections.Generic;
    using System.Linq;

    public class WoodenBoardResultsEquality : IEqualityComparer<WoodenBoardResults>
    {
        public bool Equals(WoodenBoardResults x, WoodenBoardResults y)
        {
            return ScrambledEquals(x.WoodenBoards, y.WoodenBoards, new WoodenBoardEquality());
        }

        public int GetHashCode(WoodenBoardResults obj)
        {
            return 0;
        }

        public static bool ScrambledEquals<T>(IEnumerable<T> list1, IEnumerable<T> list2, IEqualityComparer<T> comparer)
        {
            var cnt = new Dictionary<T, int>(comparer);
            foreach (T s in list1)
            {
                if (cnt.ContainsKey(s))
                {
                    cnt[s]++;
                }
                else
                {
                    cnt.Add(s, 1);
                }
            }

            foreach (T s in list2)
            {
                if (cnt.ContainsKey(s))
                {
                    cnt[s]--;
                }
                else
                {
                    return false;
                }
            }
            return cnt.Values.All(c => c == 0);
        }
    }
}