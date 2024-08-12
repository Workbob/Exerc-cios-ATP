using System;

public class exercicio7
{

    public static void rodar()
    {

        int L, a = 0, b = 1, c; //declaração e atribuição das variáveis. 

        Console.WriteLine("Informe o número de elementos da sequência de fibonacci que você deseja");
        
        L = int.Parse(Console.ReadLine()); //Variável que irá armazenar a entrada do usuário para a quantidade de elementos da sequência de fibonacci que desejar.

        Console.Write("{0} {1} ", a, b); //são impressos os valores iniciais das variáveis, que não possuem nenhum cálculo ou incremento.

        for (int i = 2; i <= L; i++) { //estabelecido o valor inicial em 2, já que os valores iniciais da sequiência já foram informados anteriormente e serão apresentados ao usuário antes das condições.
            c = a + b; //cálculo que dará a variável c, o valor da soma dos valores para estabelecer o próximo valor da sequência em questão.
            Console.Write("{0} ", c); //retornará o valor 3, resultado da soma inicial do valor de inicialização + valor inicial de b (que seria 1).
            a = b;
            b = c;
        //As variáveis a e b são atualizadas para os próximos números da sequência. A variável a recebe o valor da variável b, e a variável b recebe o valor da variável c. 
        }


    }
}    