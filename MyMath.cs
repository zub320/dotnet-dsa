public class MyMath
{
public static bool IsPrime (int number)
{
    bool IsPrime = true;

    if(number < 2)
    {
        return false;
    }

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            IsPrime = false;
            break;
        }
    }

    return IsPrime;
  }
}