//Properties with Backing Fields
class TimePeriod
{
    private double _seconds;

    public double Hours
    {
        get { return _seconds / 3600; }
        set
        {
            if (value < 0 || value > 24)
                throw new ArgumentOutOfRangeException(
                $"{nameof(value)} must be between 0 and 24.");

            _seconds = value * 3600;
        }
    }
}

//Expression body definition
public class Person
{
    private string _firstName;
    private string _lastName;

    public Person(string first, string last)
    {
        _firstName = first;
        _lastName = last;
    }

    public string Name => $"{_firstName} {_lastName}";
}

//Example
public class SaleItem
{
    string _name;
    decimal _cost;

    public SaleItem(string name, decimal cost)
    {
        _name = name;
        _cost = cost;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public decimal Price
    {
        get => _cost;
        set => _cost = value;
    }
}

//Auto-implemented properties
public class SalesItem
{
    public string Name
    { get; set; }

    public decimal Price
    { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        Console.WriteLine($"Tushar Gangani : {now}\n");

        //Properties
        //Properties with Backing Fields
        {
            Console.WriteLine("\nProperties and its variants: \n");
            Console.WriteLine("Properties with backing fields");
            TimePeriod t = new TimePeriod();
            // The property assignment causes the 'set' accessor to be called.
            t.Hours = 24;

            // Retrieving the property causes the 'get' accessor to be called.
            Console.WriteLine($"Time in hours: {t.Hours}");
        }

        //Expression body definition
        {
            Console.WriteLine("\nExpression body definition");
            var person = new Person("Magnus", "Hedlund");
            Console.WriteLine(person.Name);
        }

        //Example
        {
            Console.WriteLine("\nExample");
            var item = new SaleItem("Shoes", 19.95m);
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
        }

        //Auto-implemented properties
        {
            Console.WriteLine("\nAuto-implemented properties");
            var item = new SalesItem { Name = "Shoes", Price = 19.95m };
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
        }
    }
}