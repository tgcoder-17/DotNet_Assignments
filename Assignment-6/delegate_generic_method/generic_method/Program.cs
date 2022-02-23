public class Test
{
    public static void Main(string[] args)
    {
        List<Employee> emplist = new List<Employee>(30);
        emplist.Add(new Employee(03, 1905000, "Tushar", Designations.CEO));
        emplist.Add(new Employee(01, 1000000, "Gaurav", Designations.BA));
        emplist.Add(new Employee(02, 905000, "Harsh", Designations.CFO));
        emplist.Add(new Employee(04, 20999, "Shivani", Designations.PM));
        emplist.Add(new Employee(05, 98000, "Nikunj", Designations.SDE));
        emplist.Add(new Employee(06, 5300, "Rahil", Designations.PM));
        SelectionSort.Sort<Employee>(emplist,
        Employee.CompareDesignations);
        Console.WriteLine("Sorted by Designation : ");
        foreach (Employee e1 in emplist)
        {
            Console.WriteLine(e1.name + " : " + e1.designation);
        }
        SelectionSort.Sort<Employee>(emplist, Employee.CompareSalary);
        Console.WriteLine("\nSorted by Salary : ");
        foreach (Employee e1 in emplist)
        {
            Console.WriteLine(e1.name + " : " + e1.salary);
        }
    }
}