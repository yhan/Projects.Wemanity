using System.Linq;

namespace WorkflowManager.Q.Wemanity
{
    public static class CompareIntArray
    {
        public static bool CompareTo(this int[] target, int[] other)
        {
            if (target == null || other == null) return false;
            if (target.Length != other.Length) return false;
         
            var res = false;
            foreach (var ele in other)
            {
                res =  target.Contains(ele);
                if (!res) return false;
            }
            return res;
        }
    }
}