//Resolvendo o problema com orientação à objetos

using Calculando_as_medidas_de_um_triangulo_com_POO;
using System;

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();


Console.WriteLine("Entre com as medidas do triângulo X:");
    x.A = double.Parse(Console.ReadLine());
    x.B = double.Parse(Console.ReadLine());
    x.C = double.Parse(Console.ReadLine());


Console.WriteLine("Entre com as medidas do triângulo Y:");
    y.A = double.Parse(Console.ReadLine());
    y.B = double.Parse(Console.ReadLine());
    y.C = double.Parse(Console.ReadLine());


double areaX = x.Area();

double areaY = y.Area(); 

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