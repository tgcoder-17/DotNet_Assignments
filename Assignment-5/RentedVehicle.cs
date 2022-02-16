// Create a class RentedVehicle<T> where T we will use classes like Indica, Qualis, David Harley, Mercedes Benz E class

// RentedVehicle<T> has fields startdateofrent,enddateofrent,noofkmstravelled,advancepayment

// Given below are some methods that RentedVehicle<T> will implement

// · GiveForRent – noofkms,startdate,enddate,advancepayment

// · CalculateRent – noofkms,noofdays,

// · CalculateTotalRentToday

// · GetCheckListREntedandAvailableVehicle

// · GetCheckListvehilcesinmaintainence

// · ShowAvailabilityforbookingforgivendate

class RentedVehicle<T>
{
    DateTime startDateofRent;
    DateTime endDateofRent;
    float noofKmsTravelled;
    int advancepayment;
    public T vehicleObj;

    public RentedVehicle(T VehicleObj)
    {
        vehicleObj = VehicleObj;
    }
    public int giveForRent()
    {
        return 1;
    }
}