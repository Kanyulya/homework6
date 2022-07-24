// Напишите программу, которая найдет точку пересечения двух прямых, 
// заданных уравнениями y=k1*x+b1, y=k2*x+b2
// значения задаются пользователем
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите b1");
double b1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите k1");
double k1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите b2");
double b2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите k2");
double k2= Convert.ToInt32(Console.ReadLine());
if(k1!=k2){
double x = (b1-b2)/(k2-k1);
double y = k2*x+b2;
Console.WriteLine("{" + x + "," + y + "}");}
else{
    Console.WriteLine("Прямые не пересекаются");
}

// решение, показанное на семинаре

// double x0, y0;
// void getCoordinates(double k1, double k2, double b1, double b2){
//     double x = (b1-b2)/(k2-k1);
//     double y = k1*x+b1;
// }
