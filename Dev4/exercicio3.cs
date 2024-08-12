using System;

public class exercicio3
{


    public static void rodar()
    {

        int a39 = 0, b25 = 0; //declaração das variáveis para estabelecer as condições mais tarde.
        int[] valores = new int[10]; //"int[]" serve para iniciar a array com espaço vazio para receber os valores da nova array com limite de 10 números.

        Console.WriteLine("Digite 10 números (separados por espaços)"); //solicitação ao usuário

        String[] entrada = Console.ReadLine().Split(' '); //a variável "entrada" sendo usada apenas para armazenar a String e "split" para permitir a separação por espaços na string.

        for (int i = 0; i < 10; i++)
        { //estabelece o início, as condições e a progressão.

            valores[i] = int.Parse(entrada[i]); //converte os valores de entrada da array para inteiro.

            if (valores[i] % 3 == 0 && valores[i] % 9 == 0 && valores[i] % 2 == 0 && valores[i] % 5 == 0)
            //estabelece as condições de entrada no loop para os valores.
            {

                Console.WriteLine("{0} é divisível por 3, 9, 2 e 5", valores[i]); 
                a39++;
                b25++;
                //imprime os valores que são divisíveis por todo o conjunto na primeira condição.
            }
            else if (valores[i] % 3 == 0 && valores[i] % 9 == 0)
            {

                Console.WriteLine("{0} é divisível por 3 e 9", valores[i]);
                a39++;
                //imprime os valores que são divisíveis apenas por 3 e por 0.
            }
            else if (valores[i] % 2 == 0 && valores[i] % 5 == 0)
            {

                Console.WriteLine("{0} é divisível por 2 e 5", valores[i]);
                b25++;
                //imprime os valores que são divisíveis apenas por 2 e 5.
            }
            else
            {

                Console.WriteLine("{0} não é divisível pelos valores", valores[i]);
                //imprime os valores que não são divisíveis por nenhuma das condições acima.
            }
        }

        Console.WriteLine("{0} número(s) divisível(is) por 3 e 9", a39); //imprime a quantidade de valores que são divisíveis por 3 e 9
        Console.WriteLine("{0} número(s) divisível(is) por 2 e 5", b25); //imprime a quantidade de valores que são divisíveis por 2 e 5
    }
}