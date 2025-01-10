using System;

public class Class1
{
	public Class1()
	{
        Arithmetic arithmeticObj = new Arithmetic();

        arithmeticObj.Add(60, 20);
        Console.WriteLine("Addition of two number " + arithmeticObj.Add(60, 20));


        arithmeticObj.Sub(60, 20);
        Console.WriteLine("Subtraction of two number " + arithmeticObj.Sub(60, 20));

        arithmeticObj.Mul(6, 8);
        Console.WriteLine("Multiplication of two number " + arithmeticObj.Mul(6, 8));

        arithmeticObj.Div(60, 20);
        Console.WriteLine("Division of two number " + arithmeticObj.Div(60, 20));

            public string GetMessage()
    {
        return "IT RockStar Team";
    }
}
}
