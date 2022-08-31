/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

/* string ranNum;
Console.WriteLine("Введите пятизначное число: ");
ranNum = Console.ReadLine();
Console.WriteLine( Sunasad(ranNum));

string Sunasad(string ranNum)
{
    if((ranNum[0] == ranNum[4]) && (ranNum[1] == ranNum[3]))

   {
    return "Введеное число является палиндромом";
   }

else
 {
   return "Введеное число не является палиндромом"; 
 }
} */



//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


/* int n;
Console.WriteLine("Введите число N: ");
n = Convert.ToInt32(Console.ReadLine());
kub(n);

void kub(int n)
{
  int index = 1;
  int kub = 0;
while (index <= 1);
{
  kub = index*index*index;
  Console.Write(kub + " ");
  index++;

}
}
 */


/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
 */


 int x1 = Coordinate("x", "A");
 int y1 = Coordinate("y", "A");
 int z1 = Coordinate("z", "A");
 int x2 = Coordinate("x", "B");
 int y2 = Coordinate("x", "B");
 int z2 = Coordinate("x", "B");

 (int, int, int ) a = (1, 2, 3);

 double rast = Math.Round((Rasstoyanie(x1, y1, z1, x2, y2, z2)), 2);
 Console.WriteLine($"Длина отрезка {rast}");

 int Coordinate(string coor, string tochka)
 {
    Console.Write($"Введите координату {coor} точки {tochka}: ");
    int vvod = Convert.ToInt32(Console.ReadLine());
    return vvod;
 }

double Rasstoyanie (double arg1, double arg2, double arg3, double arg4, double arg5, double arg6)
 {
    double answer = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
    return answer;
 }