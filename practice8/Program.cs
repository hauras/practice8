using System;

public static class practice8
{
    public static void Main(string[] args)
    {
        int year = 2016;

        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) //4로 나눠지고 100으로 나눠지지 않거나  400으로 나누어지면 윤년
        {
            Console.WriteLine(year + "년은 윤년입니다");
        }
        else
            Console.WriteLine(year + "년은 윤년이 아닙니다.");

    }

}


