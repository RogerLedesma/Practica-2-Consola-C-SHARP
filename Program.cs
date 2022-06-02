using System;

namespace Ejercicios_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 18” o “No es mayor a 18”//
            Console.WriteLine("1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 18” o “No es mayor a 18");

            int edad;

            Console.WriteLine("Ingresar la edad : ");
            edad = int.Parse(Console.ReadLine());

                if (edad > 18)  
                {
                   Console.WriteLine("Es mayor a 18 años");
                }
                else Console.WriteLine("Es menor de 18 años");


            // 2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero,
            // “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero//
            Console.WriteLine("2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero");

            int n;

            Console.WriteLine("Ingresar un numero : ");
            n = int.Parse(Console.ReadLine());

                if (n > 0)
                {
                    Console.WriteLine("El numero es POSITIVO");
                }
                else if (n == 0)
                {
                    Console.WriteLine("El numero es igual a CERO");
                }
                else
                {
                    Console.WriteLine("El numero es NEGATIVO");
                }


            // 3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
            //    Si el importe es menor a ARS 1000, no hay descuento.
            //    Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10 %.
            //    Si el importe es ARS 5000 o más, aplica un descuento del 18 %.
            //    Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.

            Console.WriteLine("3.Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:");
            Console.WriteLine("Si el importe es menor a ARS 1000, no hay descuento.");
            Console.WriteLine("Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10 %.");
            Console.WriteLine("Si el importe es ARS 5000 o más, aplica un descuento del 18 %.");
            Console.WriteLine("Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.");


            int importedeVenta;
            float resultado;

            Console.WriteLine("Ingresar el precio del producto : ");
            importedeVenta = int.Parse(Console.ReadLine());

                if (importedeVenta >= 5000)
                {
                    resultado = (importedeVenta * 0.82f) ;
                }
                else if (importedeVenta >= 1000 && importedeVenta < 5000)
                {
                    resultado = importedeVenta * 0.90f;
                }
                 else
                {
                    resultado = importedeVenta;
                }

            Console.WriteLine(" El precio final con el descuento es : $ " + resultado);


            // 4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos. //
            Console.WriteLine("4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos. ");

            int n1, n2, n3, n4, mayor = 0;

            Console.WriteLine("Ingresar un numero : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar un numero : ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar un numero : ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar un numero : ");
            n4 = int.Parse(Console.ReadLine());

                if (n1 > mayor)
                {
                    mayor = n1;
                }

                if (n2 > mayor)
                {
                    mayor = n2;
                }
            
                if (n3 > mayor)
                {
                   mayor = n3;
                }

                if (n4 > mayor)
                {
                    mayor = n4;

                }

            Console.WriteLine("El numero mayor es : " + mayor);

            //5.Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100 //
            Console.WriteLine("5.Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100 ");

            int na, nb, nc, nd;

                Console.WriteLine("Ingresar un numero : ");
                na = int.Parse(Console.ReadLine());

                    if (na > 100)
                    {
                       Console.WriteLine("Este numero " + na + " es mayor a 100 ");
                    }

                Console.WriteLine("Ingresar otro numero : ");
                nb = int.Parse(Console.ReadLine());

                    if (nb > 100)
                    {
                        Console.WriteLine("Este numero " + nb + " es mayor a 100 ");
                    }

                Console.WriteLine("Ingresar otro numero ");
                nc = int.Parse(Console.ReadLine());

                    if (nc > 100)
                    {
                        Console.WriteLine("Este numero " + nc + " es mayor a 100 ");
                    }

                Console.WriteLine("Ingresar otro numero ");
                nd = int.Parse(Console.ReadLine());

                    if (nd > 100)
                    {
                        Console.WriteLine("Este numero " + nd + " es mayor a 100 ");
                    }



        }
    }
}
