using NUnit.Framework;

namespace Part_Two
{

   public class Tests
   {
      [Test]
      public void TestAddTwoNumbers()
      {
         var calc = new Calculator(10, 50, Operation.Add);
         Assert.That(calc.Calculate(), Is.EqualTo(60));
      }

      [Test]
      public void TestSubtractTwoNumbers()
      {
         var calc = new Calculator(10, 50, Operation.Subtract);
         Assert.That(calc.Calculate(), Is.EqualTo(-40));
      }

      [Test]
      public void TestMultiplyTwoNumbers()
      {
         var calc = new Calculator(10, 50, Operation.Multiply);
         Assert.That(calc.Calculate(), Is.EqualTo(500));
      }
      
      [Test]
      public void TestMultiplyNegativeNumbers()
      {
         var calc = new Calculator(-10, -5, Operation.Multiply);
         Assert.That(calc.Calculate(), Is.EqualTo(50));
      }

      [Test]
      public void TestDivideTwoNumbers()
      {
         var calc = new Calculator(10, 50, Operation.Divide);
         Assert.That(calc.Calculate(), Is.EqualTo(0.2));
      }
      
      [Test]
      public void TestFloatingPointPrecision()
      {
         var calc = new Calculator(1, 3, Operation.Divide);
         Assert.That(calc.Calculate(), Is.EqualTo(0.3333).Within(0.0001));
      }


      [Test]
      public void TestDivisionByZeroThrows()
      {
         var calc = new Calculator(10, 0, Operation.Divide);
         Assert.Throws<DivideByZeroException>(() => calc.Calculate());
      }

      [Test]
      public void TestStringOperation()
      {
         var calc = new Calculator(10, 50, "+");
         Assert.That(calc.Calculate(), Is.EqualTo(60));
      }
      
      [Test]
      public void TestInvalidSymbolThrows()
      {
         Assert.Throws<ArgumentException>(() => Calculator.FromSymbol("%"));
      }
      
      [Test]
      public void TestInvalidOperationThrows()
      {
          var calc = new Calculator(10, 50, (Operation)999);
          Assert.Throws<ArgumentException>(() => calc.Calculate());
      }
      
      [Test]
      public void TestSymbolAndEnumConstructorsMatch()
      {
          var calc1 = new Calculator(10, 20, Operation.Add);
          var calc2 = new Calculator(10, 20, "+");
          Assert.That(calc1.Calculate(), Is.EqualTo(calc2.Calculate()));
      }
   }
}