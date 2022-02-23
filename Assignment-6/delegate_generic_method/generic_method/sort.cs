class SelectionSort
{
    static public void Sort<T>(IList<T> sortArray, Func<T, T, bool> comparision)
    {
        bool swapped = true;
        do
        {
            int position, i, j;
            swapped = false;
            for (i = 0; i < sortArray.Count - 1; i++)
            {
                position = i;
                for (j = i; j < sortArray.Count; j++)
                {
                    if (comparision(sortArray[position], sortArray[j]))
                    {
                        position = j;
                    }
                }
                if (position != i)
                {
                    T temp = sortArray[i];
                    sortArray[i] = sortArray[i + 1];
                    sortArray[i + 1] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
    }
}