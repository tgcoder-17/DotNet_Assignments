using System;

class Test
{
    public static void Main(String[] args)
    {
        RentedVehicle<Indica> v1 = new RentedVehicle<Indica>(new Indica());
        Console.WriteLine(v1.vehicleObj.RentType);
    }
}
