
// --------------------------- 1 -------------------------------------

int funStatus(int num1, int num2)
{
    if (num1 == num2)
    {
        return num1 + num2;
    }
    
    else if (num1 > num2)
    {
        return num1 - num2;
    }

    else if (num2 > num1)
    {
        return num2 - num1;
    }
    return 0;
}

int result = funStatus(100, 100);

Console.WriteLine(result);