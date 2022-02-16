class Test
{
    public static void Main(String[] args)
    {
        Indica indica = new Indica("Petrol", 5, "GJ-05-MN-1104", IVehicle.Renttype.Day, 10, 13, new DateOnly(2020, 02, 16));
        MercedesBenz mBenz1 = new MercedesBenz("Diesel", 7, "GJ-05-FG-9878", IVehicle.Renttype.KM, 3, 17, new DateOnly(2021, 07, 28));
        Qualis qaualis = new Qualis("Diesel", 7, "GJ-05-BC-9101", IVehicle.Renttype.KM, 7, 5, new DateOnly(2021, 07, 11));
        HarleyDavid harley = new HarleyDavid("CNG", 4, "MH-05-MR-0210", IVehicle.Renttype.KM, 15, 14, new DateOnly(2022, 02, 28));
        MercedesBenz mBenz2 = new MercedesBenz("Petrol", 7, "GJ-05-TK-7850", IVehicle.Renttype.KM, 3, 17, new DateOnly(2020, 12, 16));
        RentedVehicle<IVehicle> rentedVehicle = new RentedVehicle<IVehicle>();

        rentedVehicle.AddVehicle(indica);
        rentedVehicle.AddVehicle(mBenz1);
        rentedVehicle.AddVehicle(qaualis);
        rentedVehicle.AddVehicle(harley);
        rentedVehicle.AddVehicle(mBenz2);

        rentedVehicle.GiveForRent(indica, new DateOnly(2021, 12, 20), new DateOnly(2021, 12, 29), 0);
        rentedVehicle.GiveForRent(harley, new DateOnly(2022, 07, 10), new DateOnly(2022, 07, 15), 500);
        rentedVehicle.GiveForRent(mBenz1, new DateOnly(2022, 09, 05), new DateOnly(2022, 09, 19), 1500);

        Console.Write("\nTotal rent per day for the given car : ");
        harley.getDetails();
        Console.Write("\n");
        Console.Write($"Total rent per day : {rentedVehicle.CalculateTotalRentToday(mBenz2, 5):C2}\n\n");
        Console.Write("Vehicles available before 29-March-2022 : ");
        rentedVehicle.ShowAvailableByDate(new DateOnly(2022, 03, 29));
        Console.Write("\n");
        Console.Write("Currently Rented Vehicles :");
        rentedVehicle.GetCheckListRentedVehicle();
    }
}
