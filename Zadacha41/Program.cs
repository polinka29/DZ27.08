// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

Console.WriteLine("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int [] array = new int [M];
int count = 0;
for (int i = 0; i < M; i++)
{
  Console.Write($"Введите число {i+1}: ");
  array[i] = Convert.ToInt32(Console.ReadLine());
  if (array [i] > 0 )
  {
  count = count + 1;
  }
}
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Чисел больше 0: {count}");


 