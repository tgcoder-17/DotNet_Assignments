class test
{
    public static void Main()
    {
        List<customer> customer = new List<customer>();
        customer.Add(new customer("A01", "Surat"));
        customer.Add(new customer("A02", "Rajkot"));
        customer.Add(new customer("A03", "Dubai"));
        customer.Add(new customer("B04", "London"));
        customer.Add(new customer("B05", "New York"));
        customer.Add(new customer("C06", "Germani"));
        customer.Add(new customer("C07", "London"));
        customer.Add(new customer("C08", "Surat"));

        var custSelectQuery = from cust in customer
                              select cust;

        Console.WriteLine("Customer list:");
        foreach (var cust in custSelectQuery)
        {
            Console.WriteLine(cust);

        }

        Console.WriteLine("\nCustomer in London City:");
        var custLondonQuery =
        from cust in customer
        where cust.customerCity == "London"
        select cust;
        foreach (var cust in custLondonQuery)
        {
            Console.WriteLine(cust);

        }

        Console.WriteLine("\nTotal customers::");
        int totalcust = custSelectQuery.Count();
        Console.WriteLine(totalcust);

        Console.WriteLine("\nCustomer ID start with A:");
        var custAQuery = from cust in customer
                         where cust.customerId.StartsWith("A")
                         select cust;

        foreach (var cust in custAQuery)
        {
            Console.WriteLine(cust);
        }

    }
}