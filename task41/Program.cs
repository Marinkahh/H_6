// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine());
int count=0;
int[] masArr = new int[m];
FillArray(masArr);
PrintArray(masArr);

void FillArray(int[] arr)
{
for(int i=0; i<m; i++)
{
    Console.WriteLine("Введите число " + (i+1) + ": ");
    int num = int.Parse(Console.ReadLine());
    masArr[i]=num;
    if(num>0)
    {
        count++;
    }
}
}
void PrintArray(int[] arr)
{
for(int i=0; i<m; i++)
{
    Console.Write($"{masArr[i]}, ");
}
Console.WriteLine($"-> {count}");
}



