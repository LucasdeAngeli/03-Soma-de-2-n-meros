using System;

//Faça um Programa que peça dois números e imprima a soma;

class MainClass {
  public static void Main (string[] args) {

    float num1, num2, total;

    Console.WriteLine ("Informe o 1º número: ");
    num1 = float.Parse(Console.ReadLine());
    Console.WriteLine ("Informe o 2º número: ");
    num2 = float.Parse(Console.ReadLine());

    //Soma
    total = num1 + num2;

    Console.Write ("A soma é: {0}", total);
  }
}