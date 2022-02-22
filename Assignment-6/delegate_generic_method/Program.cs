using System;
class Test
{
    public static void Main(string[] args)
    {
        int[] a1 = new int[] { 1, 12, 41, 11, 34, -10, -4 };
        double[] a2 = new double[] { 29.4, 10.2, 0.4, 22, 39.0 };

        Console.WriteLine("Integer Array before sort:");
        int[] an = Sorting.selectionSort(a1, (int x, int y){
            return x < y;
        });
        Console.WriteLine("Interger Sorting:");
        foreach (var item in an)
        {
            Console.Write($"{item} ");
        }

        Person p1 = new Person("Tushar", 20);
        Console.WriteLine(p1);
    }
}
