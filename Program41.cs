/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/

int GetNumber(string message){
  int result = 0;

  while (true)
  {
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine() , out result))
    {
      break;
    }
    else
    {
      Console.WriteLine("You've entered incorrect number, please try again");
    }
  }
  return result;
}

int[] CreateRandomArray(int demension)
{
  int[] array = new int[demension];

  for (int i = 0; i < demension; i++)
  {
    array[i] = GetNumber("Please enter next number:");
  }

  return array;
}

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]}, ");
  }
}

int CounterPositiveNumbers(int[] array)
{
  int summ = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if( array[i] > 0)
    {
      summ ++;
    }
  }

  return summ;
}



int demension = GetNumber("Enter demension of the array");
int[] array = CreateRandomArray(demension);
int positiveCounter = CounterPositiveNumbers(array);

PrintArray(array);
Console.Write($"  -> {positiveCounter}");
