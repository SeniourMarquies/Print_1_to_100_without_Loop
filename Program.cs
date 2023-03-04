


PrintToHundred(1);
Console.WriteLine("------------------------------------------");
PrintHundred(0, 100);


void PrintToHundred(int n)
{
    if (n == 0)
        return;
    if (n < 0) return;
    if(n <= 100)
    {
        Console.WriteLine(n);
        n++;
        PrintToHundred(n);
    }
}
void PrintHundred(int startNum, int endNum)
{
   
   
    if (startNum <= endNum)
    {
        Console.WriteLine(startNum);
        startNum++;
        PrintHundred(startNum, endNum);
    }
}