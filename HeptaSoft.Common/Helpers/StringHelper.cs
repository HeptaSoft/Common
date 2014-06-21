using System.Linq;

namespace HeptaSoft.Common.Helpers
{
    public static class StringHelper
    {
        public static bool AllNullOrEmpty(params string[] values)
        {
            return values.All(string.IsNullOrEmpty);
        }

        public static bool AllNullOrWhiteSpace(params string[] values)
        {
            return values.All(string.IsNullOrWhiteSpace);
        }

        public static bool AnyNullOrEmpty(params string[] values)
        {
            return values.Any(string.IsNullOrEmpty);
        }

        public static bool AnyNullOrWhiteSpace(params string[] values)
        {
            return values.Any(string.IsNullOrWhiteSpace);
        }
    }
}
