// See https://aka.ms/new-console-template for more information


using Part_Two;

var calc = new Calculator(1, 2, "+");
Console.WriteLine($"1+2={calc.Calculate()}" );

var calc4 = new Calculator(4, 2, Operation.Subtract);
Console.WriteLine($"4-2={calc4.Calculate()}");
    

var calc2 = new Calculator(2, 2, "*");
Console.WriteLine($"2*2={calc2.Calculate()}" );

var calc3 = new Calculator(3, 2, "/");
Console.WriteLine($"3/2={calc3.Calculate()}" );

