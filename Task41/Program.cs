// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int PlayGame(int num)
{
    int count = 0;
    int num2 = 0; 
    for (int i = 1; i <= num; i++)
    {
        
        Console.Write("Input number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        if (num2 > 0) count++;
    }
    return count;
}

Console.Write("My friend, how many numbers do you want to enter?: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The answer is accepted. The game begins!");
Console.WriteLine($"The number of positive numbers is {PlayGame(num)}");