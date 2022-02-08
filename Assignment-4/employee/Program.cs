class Program
{
    static void Main(string[] args)
    {
        //Question 1
        {
            Console.WriteLine("\nQuestion 1:\n");
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp2.Property_Initializer = ("A", "B", -500d);

            Console.WriteLine($"\nEmployee 1 -> {emp1}");
            Console.WriteLine($"Employee 2 -> {emp2}");

            Console.WriteLine($"\nYearly Salary of {emp1.First_Name} is {emp1.Salary * 12}");
            Console.WriteLine($"Yearly Salary of {emp2.First_Name} is {emp2.Salary * 12}");

            Console.WriteLine($"\n{emp1.First_Name}, Your salary after raise is {emp1.giveRaise(10d) * 12}");
            Console.WriteLine($"{emp2.First_Name}, Your salary after raise is {emp2.giveRaise(10d) * 12}");

            Console.WriteLine("\nQuestion 2:\n");

            PermanentEmployee pm1 = new PermanentEmployee("Tushar", "Gangani", 40000, 5000, 4000, 2000, new DateTime(2019, 11, 12, 10, 00, 00), new DateTime(2014, 2, 7, 11, 00, 00));
            Console.WriteLine(pm1);
            Console.WriteLine($"\n{pm1.First_Name}, Your salary after raise is {pm1.giveRaise(8d) * 12}");

            PermanentEmployee pm2 = new PermanentEmployee("Tushar", "Gangani", 58000, 6000, 3000, 5000, new DateTime(2018, 10, 20, 11, 00, 00), new DateTime(2015, 6, 7, 12, 00, 00));
            Console.WriteLine(pm2);
            Console.WriteLine($"\n{pm2.First_Name}, Your salary after raise is {pm2.giveRaise(5000) * 12}");
        }
    }
}
