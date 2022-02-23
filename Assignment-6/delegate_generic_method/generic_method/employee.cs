public enum Designations
{
    CEO = 5,
    CFO = 4,
    SDE = 3,
    BA = 2,
    PM = 1
}
class Employee
{
    int empid;
    public float salary;
    public string name;
    public Designations designation;
    public Employee(int EmpId, float Salary, string Name, Designations
    designation)
    {
        this.empid = EmpId;
        this.salary = Salary;
        this.name = Name;
        this.designation = designation;
    }
    internal static bool CompareSalary(Employee e1, Employee e2)
    {
        return e1.salary < e2.salary;
    }
    internal static bool CompareNames(Employee e1, Employee e2)
    {
        if (e1.name.CompareTo(e2.name) == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    internal static bool CompareDesignations(Employee e1, Employee e2)
    {
        return e1.designation < e2.designation;
    }
}