// See https://aka.ms/new-console-template for more information
Calculator MyCaculator = new Calculator();
var ValueOne = 50;
var ValueTwo = 30;
Console.WriteLine("ValueOne is: " + ValueOne + " and " + "ValueTwo is: " + ValueTwo);
Console.WriteLine("See the results below for calculator functions");
MyCaculator.Add(ValueOne, ValueTwo);
MyCaculator.Substract(ValueOne, ValueTwo);
MyCaculator.Multiply(ValueOne, ValueTwo);