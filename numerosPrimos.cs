using System;

class numerosPrimos{
    static void Main(){
        Console.WriteLine("Ingresa un numero");
        int numero = Convert.ToInt32(Console.ReadLine());
        /*Condicional donde se determina si el numero es igual o menor a 1
        De ser asi el numero no es un numero primo*/
        if (numero <= 1) {
            Console.WriteLine("El numero no es primo");
            return;
        }
        bool esPrimo = true;
        /*Se crea un for donde se basa en si el numero tiene raiz.
        De esta forma se determina si el numero es divisible entre si mismo.*/
        for (int i = 2; i <= Math.Sqrt(numero); i++) {
            if (numero % i == 0) {
                esPrimo = false;
                break;
            }
        }
        //Condicional donde determina si el numero es primo o no.
        if (esPrimo) {
            Console.WriteLine("El numero es un numero primo");
        } else {
            Console.WriteLine("El numero no es un numero primo");
        }
    }
}
