// Задача 27: Напишите метод, который принимает на вход число и выдаёт 
//сумму цифр в числе.452 -> 11 82 -> 10 9012 -> 12
int SumNumbers(int number)
{
    int a = number;
    int result = 0;
    while(a > 0)
    {
        result += a % 10;
        a /= 10;        
    }
    return result;
}

Console.WriteLine(SumNumbers(452));