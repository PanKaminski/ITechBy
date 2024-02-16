namespace Domain.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool TryGetValue<T>(this IEnumerable<T> enumerable, Predicate<T> condition, out T value)
        {
            value = enumerable.FirstOrDefault(item => condition(item));

            return value is not null;
        }

        public static bool TryGetSingleValue<T>(this IEnumerable<T> enumerable, Predicate<T> condition, out T value)
        {
            if (enumerable.Count(item => condition(item)) > 1)
            {
                value = default;
                return false;
            }

            return enumerable.TryGetValue(condition, out value);
        }

        public static void Shuffle<T>(this T[] array)
        {
            Random random = new Random();

            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);

                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}
