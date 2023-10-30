using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1CalculatorExercise.Classes;

namespace Week1CalculatorExercise.Classes
{
    public abstract class CalculatorBase
    {
        public abstract void Add(int ValueOne, int ValueTwo);
        public abstract void Substract(int ValueOne, int ValueTwo);
        public abstract void Multiply(int ValueOne, int ValueTwo);

    }
}

public class Calculator : CalculatorBase 
{
    public override void Add(int ValueOne, int ValueTwo)
    {
        var AddedValue = ValueOne + ValueTwo;
        Console.WriteLine("Added value is: " + AddedValue);
    }

    public override void Substract(int ValueOne, int ValueTwo)
    {
        var SubstractedValue = ValueOne - ValueTwo;
        Console.WriteLine("Substracted value is: " + SubstractedValue);
    }
    public override void Multiply(int ValueOne, int ValueTwo)
    {
        var MultipliedValue = ValueOne * ValueTwo;
        Console.WriteLine("Multiplied value is: " + MultipliedValue);
    }
}