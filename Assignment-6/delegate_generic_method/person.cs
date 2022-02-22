class Person
{
    string name;
    int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public override string ToString()
    {
        return $"Name: {this.name}, Age: {this.age}";
    }

}