public class CarType<T>
{
    internal T carobj;
    internal DateOnly startDate, endDate;
    internal int Units;
    internal decimal advPayment;

    internal CarType(T carobj, DateOnly startDate, DateOnly endDate, decimal advPayment)
    {
        this.carobj = carobj;
        this.advPayment = advPayment;
        this.startDate = startDate;
        this.endDate = endDate;
    }

    internal CarType(T carobj)
    {
        this.carobj = carobj;
    }

    internal int CalculateDays()
    {
        int year = endDate.Year - startDate.Year;
        int month = endDate.Month - startDate.Month;
        int day = endDate.Day - startDate.Day;
        return year + month + day;
    }
}

internal class RentedVehicle<T>
{
    List<CarType<T>> Vehiclelist;
    internal RentedVehicle()
    {
        Vehiclelist = new List<CarType<T>>();
    }
    internal void AddVehicle(T carobj)
    {
        CarType<T> c = new CarType<T>(carobj);
    }
    internal void GiveForRent(T carobj, DateOnly startDate, DateOnly endDate, decimal adv_pay)
    {
        CarType<T> c = new CarType<T>(carobj, startDate, endDate, adv_pay);
        Vehiclelist.Add(c);
    }
    internal decimal CalculateRent(T carobj, int Units)
    {
        foreach (CarType<T> c in Vehiclelist)
        {
            if (c.carobj!.Equals(carobj))
            {
                c.Units = Units;
                return ((IVehicle)carobj).CalculateRent(Units) - c.advPayment;
            }
        }
        return 0;
    }
    internal decimal CalculateTotalRentToday(T carobj, int TrentedVehicleaelUnits)
    {
        foreach (CarType<T> c in Vehiclelist)
        {
            if (c.carobj!.Equals(carobj))
            {
                return (((IVehicle)carobj).CalculateRent(TrentedVehicleaelUnits) - c.advPayment) / c.CalculateDays();
            }
        }
        return 0;
    }
    internal void GetCheckListRentedVehicle()
    {
        foreach (CarType<T> c in Vehiclelist)
        {
            ((IVehicle)c.carobj!).getDetails();
            Console.Write($"Rented From {c.startDate} to {c.endDate}\n");
        }
    }
    internal bool CheckVehiclesInMaintenance(T carobj)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);
        foreach (CarType<T> c in Vehiclelist)
        {
            IVehicle car = ((IVehicle)c.carobj!);
            if (c.carobj!.Equals(carobj) && car.getLastMaintenanceDate().CompareTo(today) > 0)
                return true;
        }
        return false;
    }
    internal void ShowAvailableByDate(DateOnly date)
    {
        Console.Write($"\nAvailable Vehicles on {date} : ");
        foreach (CarType<T> c in Vehiclelist)
        {
            if (c.startDate.CompareTo(date) > 0)
            {
                ((IVehicle)c.carobj!).getDetails();
            }
        }
    }
}