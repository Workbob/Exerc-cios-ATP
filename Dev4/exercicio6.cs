using System;

public class exercicio6
{

    public static void rodar()
    {

        Console.WriteLine("Digite o valor de n para realizar o seguinte cálculo: S = 1 + 1/2 + 1/3 + 1/4 + ... + 1/n");

        double a=1, b=2, i=0, S = 0, N; //declaração e atribuição das variáveis. 

        N = double.Parse(Console.ReadLine()); //Variável que irá armazenar a entrada do usuário, referente à quantidade de vezes que ele quer que a condioção seja executada.

        while(i <= N) { //Condição que indica que o loop será executado enquanto o incremento for menor ou igual ao valor solicitado pelo usuário.

              S = S + (a/b); //cálculo responsável por realizar a progressão dentro do conjunto
              b = b + 1; //regra que exprime o cresciemento de b (divisor) para o cálculo em questão
              i++; //incremento.
        }

        S = a + S; //Cálculo responsável por atribuir à variável S o valor final, que seria a soma inicial + o que foi solicitado no bloco "while".

        Console.WriteLine("O resultado de S é " + S); //retorna resultado ao usuário.
    }
}