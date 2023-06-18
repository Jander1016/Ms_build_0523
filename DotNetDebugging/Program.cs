using System.Diagnostics;

int result = Fibonacci(6);
Console.WriteLine(result);
static int Fibonacci(int value)
{
  int number1= 0;
  int number2= 1;
  int sum;

  Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
  Debug.WriteLine($"We are looking for the {value}th number");

  for (int i = 2; i <= value; i++)
  {
    sum = number1 + number2;
    number1= number2;
    number2= sum;
    Debug.WriteLineIf(sum == 1,$"sum is 1, number1 is {1}, number2 is {2}");
  }
  // If n2 is 5 continue, else break.
  Debug.Assert(number2 == 5, "The return value is not 5 and it should be.");

  return value == 0 ? number1 : number2;

}
