internal interface IVehicle
{
    internal enum Renttype
    {
        KM, Day
    }
    internal decimal CalculateRent(int Units);
    internal void getDetails();
    internal DateOnly getLastMaintenanceDate();
}

internal class Indica : IVehicle
{
    internal string? type, number;
    internal IVehicle.Renttype renttype;
    internal int age, rentperunit, seater;
    internal DateOnly last_maintenance_date;

    internal Indica(string type, int seater, string number, IVehicle.Renttype rentType, int age, int rentperunit, DateOnly last_maintenance_date)
    {
        this.type = type;
        this.seater = seater;
        this.number = number;
        renttype = rentType;
        this.age = age;
        this.rentperunit = rentperunit;
        this.last_maintenance_date = last_maintenance_date;
    }

    public decimal CalculateRent(int Units)
    {
        return (decimal)rentperunit * Units;
    }

    public void getDetails()
    {
        Console.Write("\nBrand         : Indica \n");
        Console.Write($"Car Number    : {number}\n");
        Console.Write($"Total Seats   : {seater}\n");
        Console.Write($"Type          : {type}\n");
        Console.Write($"Car age       : {age} Years\n");
        Console.Write($"Rent per unit : Rs {rentperunit}\n");
    }

    public DateOnly getLastMaintenanceDate()
    {
        return last_maintenance_date;
    }
}

internal class Qualis : IVehicle
{
    internal string? type, number;
    internal IVehicle.Renttype renttype;
    internal int age, rentperunit, seater;
    internal DateOnly last_maintenance_date;

    internal Qualis(string type, int seater, string number, IVehicle.Renttype rentType, int age, int rentperunit, DateOnly last_maintenance_date)
    {
        this.type = type;
        this.seater = seater;
        this.number = number;
        renttype = rentType;
        this.age = age;
        this.rentperunit = rentperunit;
        this.last_maintenance_date = last_maintenance_date;
    }

    public decimal CalculateRent(int Units)
    {
        return (decimal)rentperunit * Units;
    }

    public void getDetails()
    {
        Console.Write("\nBrand         : Qualis \n");
        Console.Write($"Car Number    : {number}\n");
        Console.Write($"Total Seats   : {seater}\n");
        Console.Write($"Type          : {type}\n");
        Console.Write($"Car age       : {age} Years\n");
        Console.Write($"Rent per unit : Rs {rentperunit}\n");
    }

    public DateOnly getLastMaintenanceDate()
    {
        return last_maintenance_date;
    }
}

internal class HarleyDavid : IVehicle
{
    internal string? type, number;
    internal IVehicle.Renttype renttype;
    internal int age, rentperunit, seater;
    internal DateOnly last_maintenance_date;

    internal HarleyDavid(string type, int seater, string number, IVehicle.Renttype rentType, int age, int rentperunit, DateOnly last_maintenance_date)
    {
        this.type = type;
        this.seater = seater;
        this.number = number;
        renttype = rentType;
        this.age = age;
        this.rentperunit = rentperunit;
        this.last_maintenance_date = last_maintenance_date;
    }

    public decimal CalculateRent(int Units)
    {
        return (decimal)rentperunit * Units;
    }

    public void getDetails()
    {
        Console.Write("\nBrand         : HarleyDavid \n");
        Console.Write($"Car Number    : {number}\n");
        Console.Write($"Total Seats   : {seater}\n");
        Console.Write($"Type          : {type}\n");
        Console.Write($"Car age       : {age} Years\n");
        Console.Write($"Rent per unit : Rs {rentperunit}\n");
    }

    public DateOnly getLastMaintenanceDate()
    {
        return last_maintenance_date;
    }
}

internal class MercedesBenz : IVehicle
{
    internal string? type, number;
    internal IVehicle.Renttype renttype;
    internal int age, rentperunit, seater;
    internal DateOnly last_maintenance_date;

    internal MercedesBenz(string type, int seater, string number, IVehicle.Renttype rentType, int age, int rentperunit, DateOnly last_maintenance_date)
    {
        this.type = type;
        this.seater = seater;
        this.number = number;
        renttype = rentType;
        this.age = age;
        this.rentperunit = rentperunit;
        this.last_maintenance_date = last_maintenance_date;
    }

    public decimal CalculateRent(int Units)
    {
        return (decimal)rentperunit * Units;
    }

    public void getDetails()
    {
        Console.Write("\nBrand         : MercedesBenz \n");
        Console.Write($"Car Number    : {number}\n");
        Console.Write($"Total Seats   : {seater}\n");
        Console.Write($"Type          : {type}\n");
        Console.Write($"Car age       : {age} Years\n");
        Console.Write($"Rent per unit : Rs {rentperunit}\n");
    }

    public DateOnly getLastMaintenanceDate()
    {
        return last_maintenance_date;
    }
}