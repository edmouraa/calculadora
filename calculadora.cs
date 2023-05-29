using System;
using System.Collections.Generic;
using System.text;
using System.Threading.Tasks;

namespace Calculado
{
    internal class Program
    {
        static void Main{string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer:");
            Consolee.WriteLine("1- Adição");
            Consolee.WriteLine("2- Subtração");
            Consolee.WriteLine("3- Multiplicação");
            Consolee.WriteLine("4- Divisão \n");

            int operação = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero: ");
            int num1 - int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 - int.Parse(Console.ReadLine());

            int resultado;

           switch (operação)
          {

            case 1:

            resultado = Adição(num1, num2);
            break;
          }

           case 2:

            resultado = Subtracao(num1, num2);
            break;
           }

           case 3:

            resultado = Multiplicacao(num1, num2);
            break;

           }

           case 4:

            resultado = Divisao(num1, num2);
            break;
           }

        default:
        Console.WriteLine("Numero invalido, digite outro numero.")
        break;
        }
        Console.WriteLine("O resultado da operação com os números é {0} e {1} é: {2}", num1, num2, resultado);

        Console.ReadLine();
    }






    public static int Adição (int numero1, int numero2){
        {
            int result = numero1 + numero2;
        return result;

        public static int Subtracao (int numero1, int numero2){
        {
            int result = numero1 + numero2;
        return result;

        public static int Multiplicacao (int numero1, int numero2){
        {
            int result = numero1 + numero2;
        return result;

        public static int Divisao (int numero1, int numero2){
        {
            int result = numero1 + numero2;
        return result;

          }
       }
    }