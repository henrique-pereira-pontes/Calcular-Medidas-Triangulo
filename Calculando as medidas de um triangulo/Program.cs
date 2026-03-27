//Resolvendo o problema sem orientação à objetos

using System;

double xA;
double xB;
double xC;

double yA;
double yB;
double yC;

Console.WriteLine("Entre com as medidas do triângulo X:");
    xA = double.Parse(Console.ReadLine());
    xB = double.Parse(Console.ReadLine());
    xC = double.Parse(Console.ReadLine());


Console.WriteLine("Entre com as medidas do triângulo Y:");
    yA = double.Parse(Console.ReadLine());
    yB = double.Parse(Console.ReadLine());
    yC = double.Parse(Console.ReadLine());

    double p = (xA + xB + xC) / 2;
    double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));


    p = (yA + yB + yC) / 2;
    double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

 Console.WriteLine("Área de X = " + areaX);
 Console.WriteLine("Área de Y = " + areaY);

if (areaX > areaY)
{
    Console.WriteLine("A área X é maior");
}
else
{
    Console.WriteLine("A área Y é maior");

}