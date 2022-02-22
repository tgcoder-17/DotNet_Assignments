using System;
class Sorting
{
    public static T[] selectionSort<T>(T[] unsortedList, Func<T, T, bool> compare) where T : IComparable
    {
        T[] sortedList = unsortedList.ToArray();
        for (int i = 0; i < sortedList.Length - 1; ++i)
        {
            T minElement = sortedList[i];
            int minLocation = i;

            for (int j = i + 1; j < sortedList.Length; ++j)
            {
                if (compare(sortedList[j], minElement) < 0)
                {
                    minElement = sortedList[j];
                    minLocation = j;
                }
            }

            if (minLocation != i)
            {
                T temp = sortedList[minLocation];
                sortedList[minLocation] = sortedList[i];
                sortedList[i] = temp;
            }
        }
        return sortedList;
    }
}