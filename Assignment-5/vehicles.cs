using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Type
{
    Petrol,
    Diesel
}

enum RentType
{
    PerKM,
    PerDay
}

//Indica Class
class Indica
{
    Type type;
    RentType renttype;
    int seater;
    int rentperunit;
    int age;
    string number;
    DateTime lastmaintainencedate;

    internal Type Type
    {
        get;
        set;
    }
    internal RentType RentType
    {
        get;
        set;
    }
    internal int Seater
    {
        get => seater;
        set => seater = value;
    }
    internal int RentPerUnit
    {
        get => rentperunit;
        set => rentperunit = value;
    }
    internal int Age
    {
        get => age;
        set => age = value;
    }
    internal string Number
    {
        get => number;
        set => number = value;
    }
    internal DateTime LastMaintainenceDate
    {
        get => lastmaintainencedate;
        set => lastmaintainencedate = value;
    }
}

//Qualis
class Qualis
{
    Type type;
    RentType renttype;
    int seater;
    int rentperunit;
    int age;
    string number;
    DateTime lastmaintainencedate;

    internal Type Type
    {
        get;
        set;
    }
    internal RentType RentType
    {
        get;
        set;
    }
    internal int Seater
    {
        get => seater;
        set => seater = value;
    }
    internal int RentPerUnit
    {
        get => rentperunit;
        set => rentperunit = value;
    }
    internal int Age
    {
        get => age;
        set => age = value;
    }
    internal string Number
    {
        get => number;
        set => number = value;
    }
    internal DateTime LastMaintainenceDate
    {
        get => lastmaintainencedate;
        set => lastmaintainencedate = value;
    }
}

//Davidharley
class Davidharley
{
    RentType renttype;
    int rentperunit;
    int age;
    string number;
    DateTime lastmaintainencedate;

    internal RentType RentType
    {
        get;
        set;
    }
    internal int RentPerUnit
    {
        get => rentperunit;
        set => rentperunit = value;
    }
    internal int Age
    {
        get => age;
        set => age = value;
    }
    internal string Number
    {
        get => number;
        set => number = value;
    }
    internal DateTime LastMaintainenceDate
    {
        get => lastmaintainencedate;
        set => lastmaintainencedate = value;
    }
}

//MBenzEclass
class MBenzEclass
{
    int seater;
    RentType renttype;
    int rentperunit;
    int age;
    string number;
    DateTime lastmaintainencedate;

    internal RentType RentType
    {
        get;
        set;
    }
    internal int Seater
    {
        get => seater;
        set => seater = value;
    }
    internal int RentPerUnit
    {
        get => rentperunit;
        set => rentperunit = value;
    }
    internal int Age
    {
        get => age;
        set => age = value;
    }
    internal string Number
    {
        get => number;
        set => number = value;
    }
    internal DateTime LastMaintainenceDate
    {
        get => lastmaintainencedate;
        set => lastmaintainencedate = value;
    }
}
