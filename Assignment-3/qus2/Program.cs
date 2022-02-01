﻿// Part 1:
string str;

Console.WriteLine("Enter String:");
str = Console.ReadLine();

Console.WriteLine($"String : {str}\nLength of String: {str.Length}");

// Part:2
string sentance;
Console.WriteLine("Enter Sentance:");
str = Console.ReadLine();

if(str.EndsWith('.')){
    Console.WriteLine("This is declarative sentance");
}
else if(str.EndsWith('?')){
    Console.WriteLine("This is interrogatory sentance");
}
else if(str.EndsWith('!')){
    Console.WriteLine("This is exclamation sentance");
}
else {
    Console.WriteLine("This is unknown sentance");
}

// Part:3
string fullName;
Console.WriteLine("Enter your Name:");
fullName = Console.ReadLine();

String[] name = fullName.Split(' ');

if(name.Length==1){
    Console.WriteLine($"Your Name: {name[0]}");
}
else {
    Console.WriteLine($"Your Name: {name[1]}, {name[0]}");
}

