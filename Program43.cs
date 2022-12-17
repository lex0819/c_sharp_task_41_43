/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

/* Мат база
a1*x + b1*y + c1 = 0
a2*x + b2*y + c2 = 0   две прямые

координаты точки пересечения
x = -(c1*b2 - c2*b1)/(a1*b2 - a2*b1)
y = -(c1*a2 - c2*a1)/(a1*b2 - a2*b1)

сперва проверить (a1*b2 - a2*b1) != 0
если ноль, то точки пересечения не существует

в задаче b1 = b2 = -1
*/

double GetNumber(string message){
  double result = 0;

  while (true)
  {
    Console.WriteLine(message);
    if (double.TryParse(Console.ReadLine() , out result))
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

string GetCrossPoint(double k1, double b1, double k2, double b2)
{
  if((k2 - k1) == 0)
  {
    return "Cross Point does not exist.";
  }
  else
  {
    double x = -(b2 - b1)/(k2 - k1);
    double y = -(b1*k2 - b2*k1)/(k2 - k1);

    return $"Cross Point has coordinates ({x}, {y}).";
  }
}

double b1 = GetNumber("Enter b1 for first line");
double k1 = GetNumber("Enter k1 for first line");
double b2 = GetNumber("Enter b2 for second line");
double k2 = GetNumber("Enter k2 for second line");
string answer = GetCrossPoint(k1, b1, k2, b2);
Console.WriteLine(answer);
