int numerator, denom, whole_no;
float float_div;

Console.WriteLine("Enter Numerator : ");
numerator = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Denominator : ");
denom = Convert.ToInt32(Console.ReadLine());

int int_div = numerator / denom;
int int_rem = numerator % denom;

Console.WriteLine("Integer division result = {0} with a remainder {1}", int_div, int_rem);
float_div = (float)numerator / denom;
Console.WriteLine("Floating point division result = {0}", float_div);

if (numerator >= denom){
    whole_no = numerator / denom;
    numerator = numerator % denom;
    Console.WriteLine("The result as a mixed fraction is {0} {1}/{2}", whole_no, numerator, denom);
}
else if (numerator % denom == 0){
    whole_no = numerator / denom;
    Console.WriteLine("The result as a mixed fraction is {0}", whole_no);
}
