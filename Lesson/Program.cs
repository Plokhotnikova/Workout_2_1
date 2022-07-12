/*  Task 1
int num1, num2;
string result;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2) result = "Yes";
else result = "No";

Console.WriteLine(result);
*/

/* Task 2
Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine()); 

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

// 1234 / 10 -> 123 - это результат деления на 10
// 1234 / 100 -> 12 - это результат деления на 100
// 1234 % 10 -> 4  - это остаток от деления
// 1234 % 100 -> 34  - это остаток от деления на 100
// 1234 / 10 % 100 -> 23
// 138374638837 - чтобы отделить первые три цифры, нужно сделать цикл
// пока число не станет <= 999 

int a = 138374638837;
while(a > 999)
{
    a /=10; // то же самое, что и а = а / 10;
}









