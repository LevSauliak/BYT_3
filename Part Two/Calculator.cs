namespace Part_Two
{

    public enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    public class Calculator
    {

        public double Val1 { get; set; }
        public double Val2 { get; set; }
        public Operation Operation { get; set; }

        public static Operation FromSymbol(string symbol) => symbol switch
        {
            "+" => Operation.Add,
            "-" => Operation.Subtract,
            "*" => Operation.Multiply,
            "/" => Operation.Divide,
            _ => throw new ArgumentException("Invalid symbol")
        };

        public Calculator(double val1, double val2, string symbol) : this(val1, val2, FromSymbol(symbol))
        {
        }

        public Calculator(double val1, double val2, Operation operation)
        {
            Val1 = val1;
            Val2 = val2;
            Operation = operation;
        }

        public double Calculate()
        {
            return Operation switch
            {
                Operation.Add => Val1 + Val2,
                Operation.Subtract => Val1 - Val2,
                Operation.Multiply => Val1 * Val2,
                Operation.Divide => Val2 != 0
                    ? Val1 / Val2
                    : throw new DivideByZeroException(),
                _ => throw new ArgumentException("Invalid operation")
            };
        }
    }
    
    
}