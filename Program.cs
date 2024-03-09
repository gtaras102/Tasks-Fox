// ЗАДАЧА 1: Прості масиви вивід у консоль:
// Заповніть масив випадковими числами від 1 до 100
// і виведіть максимальне, мінімальне та середнє значення.

/*
int[] numbers = new int[100];
Random rnd = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, 101);

    Console.Write(numbers[i] + ", ");
}

int max = 0;
int min = 0;
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max) 
    {
        max = numbers[i];       
    }

    if (numbers[i] < min)
    {
        min = numbers[i];        
    }  

    sum += numbers[i];
}
    Console.WriteLine($"\nНайбільше число {max}");
    Console.WriteLine($"Найменше число {min}");
    Console.WriteLine($"Середнє число {sum / 100}");
*/


// ЗАДАЧА 2: ВКЛАДЕНІ ЦИКЛИ
// Напишіть програму, яка виводить на консоль прості числа
// в проміжку від (2, 100). Використовуйте для розвязання цієї 
// задачі оператор "%" (залищок від ділення) і цикли.
//Как получить простое число?
/*Натуральное число, большее 1, называется простым, если оно ни на что не 
делится, кроме себя и 1 . Другими словами, n > 1 – простое, если при 
его делении на любое число кроме 1 и n есть остаток. Например, 5 
это простое число, оно не может быть разделено без остатка на 2 , 3 и 4 .*/


int[] numbers = new int[101];

for (int i = 2; i < numbers.Length; i++)
{   
    int count = 0;
    for (int j = 2; j < i; j++)
    {   
        if (i % j == 0)
        {
        count++; 
        break;      
        }
        if (count == 0) 
        {
            Console.Write(i + ", ");
        }
    }
}

for (int i = 2; i < numbers.Length; i++)
{
  int count = 0; 
  for (int j = 2; j < i; j++)
  {
    if (i % j == 0)
    {
      count++;
      break;
    }
  }
  if (count == 0)
  {
    Console.Write(i + ", ");
  }
}

