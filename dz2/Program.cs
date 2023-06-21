// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int comp = m;

if (m > n) 
{
  m = n; 
  n = comp;
}

PrintSum(m, n, comp=0);

void PrintSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.WriteLine($"Сумма натуральных элементов = {sum} ");
    return;
  }
  PrintSum(m, n - 1, sum);
}

int InputNumbers(string input) 
{
  Console.WriteLine(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}