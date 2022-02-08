internal class Employee
{
    string first_name;
    string last_name;
    double monthly_salary;

    //Default Constructor
    internal Employee()
    {
        first_name = "Tushar";
        last_name = "Gangani";
        monthly_salary = 30000;
    }

    //Parameterized Constructor
    internal Employee(string f_name, string l_name, double sal)
    {
        this.first_name = f_name;
        this.last_name = l_name;
        this.monthly_salary = sal;
    }

    //Properties
    internal string First_Name
    {
        get => this.first_name;
        set => this.first_name = value;
    }

    internal string Last_Name
    {
        get => this.last_name;
        set => this.last_name = value;
    }

    internal double Salary
    {
        get => this.monthly_salary;
        set => this.monthly_salary = value < 0 ? 0.0 : value;
    }

    internal (string, string, double) Property_Initializer
    {
        get => (this.first_name, this.last_name, this.monthly_salary);
        set
        {
            if (value.Item3 > 0)
            {
                this.first_name = value.Item1;
                this.last_name = value.Item2;
                this.monthly_salary = value.Item3;
            }
            else
            {
                this.first_name = value.Item1;
                this.last_name = value.Item2;
                this.monthly_salary = 0.0;
            }
        }
    }

    internal virtual double giveRaise(double raise)
    {
        this.monthly_salary = this.monthly_salary + ((monthly_salary * raise) / 100);
        return this.monthly_salary;
    }

    public override string ToString()
    {
        return $"First Name : {this.first_name} , Last Name : {this.last_name} , Monthly Salary : {this.monthly_salary}";
    }
}
