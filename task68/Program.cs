
/*Задача 68: Напишите программу вычисления
 функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
*/ 


Console.WriteLine("введите первое положительное значение "); 

int firstNumber = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("введите второе положительное значение N"); 

int secondNumber = Convert.ToInt32(Console.ReadLine()); 

int AckermanMethod(int firstNumber, int SumNumber);

 if ((firstNumber == 1) && (secondNumber == 1))
 {

return 1;

 }

if (firstNumber > 1) 
{
return AckermanMethod(firstNumber - 1, firstNumber) + secondNumber; 
}
else
{
return AckermanMethod(firstNumber, secondNumber - 1) + 1; 
} 

System.Console.WriteLine(AckermanMethod(firstNumber));
