internal class PermanentEmployee : Employee
{
    double housing_rent_allowance;
    double dearness_allowance;
    double provident_fund;

    DateTime joining_date;
    DateTime retirement_date;

    internal PermanentEmployee(string f_name, string l_name, double sal, double hra, double da, double pf, DateTime join_date, DateTime retire_date) : base(f_name, l_name, sal)
    {
        this.housing_rent_allowance = hra;
        this.dearness_allowance = da;
        this.provident_fund = pf;
        this.joining_date = join_date;
        this.retirement_date = retire_date;
        base.Salary = base.Salary + HRA + DA;
    }

    //Properties
    internal double HRA
    {
        get => this.housing_rent_allowance;
    }

    internal double DA
    {
        get => this.dearness_allowance;
    }

    internal double PF
    {
        get => this.provident_fund;
    }

    internal DateTime JD
    {
        get => this.joining_date;
        set => this.joining_date = value;
    }

    internal DateTime RD
    {
        get => this.retirement_date;
        set => this.retirement_date = value;
    }

    //Overriden + Overloaded
    internal override double giveRaise(double raise)
    {
        return base.Salary = base.Salary + ((base.Salary * raise) / 100) + this.HRA + this.DA;
    }

    //Overloaded
    internal double giveRaise(int raise)
    {
        return base.Salary = base.Salary + raise + this.HRA + this.DA;
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nJoining Date : {this.JD} , Retirement Date : {this.RD}";
    }
}