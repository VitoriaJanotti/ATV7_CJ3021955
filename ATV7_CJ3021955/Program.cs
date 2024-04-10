namespace ATV7_CJ3021955
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int opc_geral;

            do
            {

                do
                {

                    Console.WriteLine("MENU DE EXERCÍCIOS\n0- SAIR\n1- EXERCÍCIO DA SALA DE AULA\n2- EXERCÍOCIO 1 - LISTA\n3- EXERCÍCIO 2 - LISTA\n4- EXERCÍCIO 3 - LISTA\n5- EXERCÍCIO 4 - LISTA\n6- EXERCÍCIO 5 - LISTA\n7- EXERCÍCIO 6 - LISTA\n8- EXERCÍCIO 7 ");

                    Console.WriteLine("\nESCREVA O NÚMERO DA OPÇÃO EQUIVALENTE A ATIVIDADE DESEJADA");

                    opc_geral = int.Parse(Console.ReadLine());

                } while (opc_geral > 7 || opc_geral < 0);

                switch (opc_geral)

                {
                    case 0:

                        Console.WriteLine("OBRIGADO POR USAR O PROGRAMA");

                        break;

                    case 1:

                        Console.WriteLine("ATIVIDADE DA SALA DE AULA");
                        Console.WriteLine("HOJE NÃO TEVE ATIVIDADE DE AULA");

                        break;

                    case 2:

                        Console.WriteLine("EXERCÍCIO 1 - LISTA");

                        int i = 1, m;

                        Console.WriteLine("digite um número inteiro aleatório: ");
                        m = int.Parse(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("{0}", i);
                            i++;

                        } while (i <= m);

                        break;

                    case 3:

                        Console.WriteLine("EXERCÍCIO 2 - LISTA");

                        int num, i1 = 0;

                        Console.WriteLine("digite um num inteiro");
                        num = int.Parse(Console.ReadLine());

                        do
                        {
                            if (i1 % 2 == 0)
                            {
                                Console.WriteLine(i1);
                            }
                            i1++;

                        } while (i1 <= num);

                        break;

                    case 4:

                        Console.WriteLine("EXERCÍCIO 3 - LISTA");

                        int i2, num1 = 1000;

                        Console.WriteLine("digite um numero inteiro");
                        i2 = int.Parse(Console.ReadLine());
                        do
                        {
                            if (i2 % 2 == 0)
                            {
                                Console.WriteLine(i2);
                            }
                            i2++;

                        } while (i2 <= num1);

                        break;

                    case 5:
                        //FAZER A SOMA
                        Console.WriteLine("EXERCÍCIO 4 - LISTA");

                        int n1, a1 = 1;
                        int soma = 200;

                        Console.WriteLine("Digite um número");
                        n1 = int.Parse(Console.ReadLine());
                        do
                        {
                            if (n1 < 0)
                            {
                                Console.WriteLine("número inválido");
                            }
                            else
                            {
                                Console.WriteLine(a1);
                            }
                            a1++;
                        } while (a1 < soma);

                        break;

                    case 6:
                        //NÃO CONTOU OS DIVISORES 
                        Console.WriteLine("EXERCÍCIO 5 - LISTA");

                        int v, p1 = 0;

                        Console.WriteLine("Digite um número:");
                        v = int.Parse(Console.ReadLine());

                        do
                        {

                        }
                        while (p1 <= v);
                        {
                            if (v % p1 == 0)
                            {
                                Console.WriteLine(p1);
                            }
                            p1++;
                        }

                        break;

                    case 7:
                        //ARRUMAR TOTALMENTE 
                        Console.WriteLine("EXERCÍCIO 6 - LISTA");


                        int j1 = 0, v2;

                        Console.WriteLine("Digite um valor");
                        v2 = int.Parse(Console.ReadLine());

                        do
                        {
                            if (v2 < v2)
                            {
                                Console.WriteLine("o número maior é = {0}", v2);
                            }

                            if (v2 > v2)
                            {
                                Console.WriteLine("o número menor é = {0}", v2);
                            }

                            j1++;
                        } while (j1 < 11);

                        break;

                    case 8:

                        int t = 0, l3;
                        int r1 = 0, p3 = 0;

                        Console.WriteLine("Digite um valor");
                        l3 = int.Parse(Console.ReadLine());

                        do
                        {
                            if (l3 <= 0)
                                break;

                            if (t % 2 != 0)
                            {
                                r1 = r1 + t;
                            }

                            if (t % 2 == 0)
                            {
                                p3 = p3 + t;
                            }

                            Console.WriteLine("soma dos números ímpares = {0}", r1);
                            Console.WriteLine("soma dos números pares = {0}", p3);

                            t++;
                        } while (t < 10);
                        break;

                }

            } while (opc_geral != 0);
        }
    }
}