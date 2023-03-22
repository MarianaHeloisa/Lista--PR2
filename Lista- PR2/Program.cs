using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista__PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 exercicio

            //double laranja, preco;

            //Console.WriteLine(" quantas laranjas voce comprou?: ");
            //laranja = double.Parse(Console.ReadLine());

            //if (laranja >= 12)
            //    preco = laranja * 0.28;

            //else 
            //    preco = laranja * 0.35;

            //Console.WriteLine(" o preço total das laranjas é: " + preco );
            //Console.ReadKey();

            //-------------------------------------------------------------------------------------------------------------------------------

            //2 exercicio 

            //int anoN;

            //Console.WriteLine("Em que voce nasceu?: ");
            //anoN = int.Parse(Console.ReadLine());

            //if (anoN <= 2007)
            //    Console.WriteLine("Você poderá votar ");

            //else
            //    Console.WriteLine("Você nao poderá votar ");
            //Console.ReadKey();

            //-------------------------------------------------------------------------------------------------------------------------------

            //3 exercicio

            //double L1, L2, L3;

            //Console.WriteLine("qual a medida do lado 1: ");
            //L1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("qual a medida do lado 2: ");
            //L2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("qual a medida do lado 3: ");
            //L3 = double.Parse(Console.ReadLine());

            //if (L1 == L2 && L2 == L3 && L1 == L3)
            //    Console.WriteLine("o triangulo é o equilatero");

            //else if  (L1 < L2 + L3 && L3 < L2 + L1 && L1 < L3 + L2) 
            //Console.WriteLine("o triangulo é o isósceles");

            //else

            // Console.WriteLine("o triangulo é o escaleno");
            //    Console.ReadKey(); 

            //-----------------------------------------------------------------------------------------------------------------------------------

            //4 exercicio

            //double A, B, C, delta, raiz1, raiz2;

            //Console.Write("digite o valor de A:");
            //A = double.Parse(Console.ReadLine());

            //Console.Write("digite o valor de B: ");
            //B = double.Parse(Console.ReadLine());

            //Console.Write("digite o valor C: ");
            //C = double.Parse(Console.ReadLine());

            //delta = (B * B) - 4 * A * C;

            //if (delta == 0)
            //    Console.WriteLine("nao tem raiz! ");

            //else if (delta > 0)
            //    Console.WriteLine("tem uma raiz!");

            //else
            //    Console.WriteLine("tem duas raizes!");

            //raiz1 = -B + (Math.Sqrt(delta) / 2 * A);

            //raiz2 = -B - (Math.Sqrt(delta) / 2 * A);

            //Console.ReadKey();

            //---------------------------------------------------------------------------------------------------------------------------------

            //5 exercicio 

            //int numero;

            //Console.Write("digite um numero: ");
            //numero = int.Parse(Console.ReadLine());

            //if(numero % 3 == 0 && numero % 5 == 0)
            //{
            //    Console.WriteLine("o numero é divisil por 3 e 5");
            //}
            //else
            //{
            //    if (numero % 3 == 0)
            //    { Console.WriteLine(" o numero é divisivel por 3 "); }

            //    else
            //    {
            //        if (numero % 5 == 0)
            //        {
            //            Console.WriteLine(" o numero é divisivel por 5");

            //        } else
            //        {
            //            Console.WriteLine(" o numero nao é divisivel por 3 nem por 5!");

            //        }
            //    }

            //}
            //Console.ReadKey();

            //------------------------------------------------------------------------------------------------------------------------------------

            //6 exercicio

            //double num1, num2, num3;

            //Console.Write("digite um numero: ");
            //num1 = double.Parse(Console.ReadLine());

            //Console.Write("digite um numero: ");
            //num2 = double.Parse(Console.ReadLine());

            //Console.Write("digite um  numero: ");
            //num3 = double.Parse(Console.ReadLine());    

            // if ((num1 == 90) || (num2 == 90) || (num3 == 90))
            //     Console.WriteLine("o triângulo é um triângulo retângulo ");

            // else if ((mum1 > 90) || (num2 > 90) || (num3 > 90))
            //     Console.WriteLine("o triângulo é um triângulo obtusângulo ");
            // else
            //     Console.WriteLine("o triângulo é um triângulo de três ângulos agudos");
            // Console.ReadKey();

            //---------------------------------------------------------------------------------------------------------------------------------------

            //7 exercicio 

            // int a, b, c;

            // Console.Write("qual o valor do numero ");
            // a = int.Parse(Console.ReadLine());

            // Console.Write("qual o valor do numero ");
            // b = int.Parse(Console.ReadLine());

            // Console.Write("qual o valor do numero ");
            // c = int.Parse(Console.ReadLine());

            // se (a < b && b < c)
            //   Console.WriteLine(a +" "+ b+" " + c);

            // else if (a < b && b > c)
            // Console.WriteLine(a + " " + c + " "+b);

            // else if (b < a && a < c)
            // Console.WriteLine(b + " " + a + " "+c);

            //   else if (b < a && a > c)
            // Console.WriteLine(b + " " + c + " "+a);

            // else if (c < a && a < b)
            // Console.WriteLine(c + " " + a + " "+b);

            // else if (c < a && a > c)
            // Console.WriteLine(c + " " + b + " "+a);
            // Console.ReadKey();

            //---------------------------------------------------------------------------------------------------------------------------------------------

            //8 exercicio 

            // int ano;

            // Console.WriteLine("escreve um ano: ");
            // ano = int.Parse(Console.ReadLine());

            // if (ano % 4 == 0)
            // {
            //      Console.WriteLine("O ano é bissexto");
            // }
            // senão
            // {
            //      Console.WriteLine("O ano não é bissexto");
            // }
            // Console.ReadKey();

            //-----------------------------------------------------------------------------------------------------------------------------------------------

            //9 exercicio 

            // duplo a, b, r;
            // char apli;

            // Console.Write("escreve um valor para a: ");
            //   a = double.Parse(Console.ReadLine());

            // Console.Write("escreve um valor para b: ");
            //    b = double.Parse(Console.ReadLine());

            // Console.Write("escreve uma operação: ");
            //   apli = char.Parse(Console.ReadLine());

            // if (apli == '+')
            //   {
            //       Console.WriteLine(a + b);
            //   }
            //   else if (apli == '-')
            //   {
            //       Console.WriteLine(a - b);
            //   }
            //   else if (apli == '*')
            //   {
            //       Console.WriteLine(a * b);
            //   }
            //     else if (apli == '/')
            //     {
            //      Console.WriteLine(a / b);
            //     }
            // console.ReadKey();

            //------------------------------------------------------------------------------------------------------------------------------------------------

            //10 exercico 

            // Na linguagem C#, é possível gerar números aleatórios usando a classe Random. Esta classe permite gerar números inteiros e reais aleatórios usando diferentes métodos.
            // Para gerar números inteiros aleatórios em C#, basta criar uma instância da classe Random e chamar o método Next() da seguinte forma:

            // Aleatório random = new Random();
            // int randomInt = random.Next();

            // Para gerar números aleatórios reais em C#, é possível usar o método NextDouble(), que retorna um número aleatório entre 0 e 1, Se quiser gerar um número aleatório dentro de um intervalo específico, basta multiplicar o resultado pelo tamanho do intervalo e somar o valor mínimo

            // Aleatório random = new Random();
            // double randomDouble = Random.NextDouble();

            // Em ambos os casos, é importante criar uma única instância da classe Random e reutilizá-la para gerar números aleatórios diferentes.
            // Isso porque, se você criar várias instâncias em sucessão rápida, elas podem gerar números semelhantes, tornando a distribuição menos aleatória.
        }
    }
}
