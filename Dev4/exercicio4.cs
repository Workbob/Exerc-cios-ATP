using System;

public class exercicio4
{

    public static void rodar()
    {

        double a = 1, b = 1, i = 0, E = 0, N; //declaração das variáveis.

        Console.WriteLine("Digite o valor de n para realizar o seguinte cálculo: E = 1 + 1 / 1! + 1 / 2! + 1 / 3! + .... + 1 / N!");
        //solicita a entrada para o usuário, o que vai determinar a quantidade de vezes que o cálculo acontecerá.
        N = double.Parse(Console.ReadLine()); //atribui à variável N, o valor informado pelo usuário, lendo o mesmo.

        while (i < N) //Inicia um loop que executa enquanto o valor de i for menor que o valor de N. Esse loop calcula o valor de cada termo da série e acumula esses valores em E.
        {

            double fatorial = 1; //declara uma nova variável "fatorial" e atribui o valor inicial à mesma. Essa variável é usada para calcular o fatorial de cada termo da série.
            for (int j = 1; j <= b; j++) //inicia um loop que executa enquanto o valor de j for menor ou igual ao valor de b. Esse loop calcula o fatorial de cada termo da série.
            {
                fatorial *= j; //multiplica o valor atual de fatorial pelo valor atual de j a cada iteração do loop interno, o que atualiza o valor de fatorial com o fatorial do número atual.
            }
            E += a / fatorial; //calcula o valor do termo atual da série e adiciona esse valor a E, usando o valor atual de a dividido pelo fatorial do número atual.
            b++; //incrementa o valor de b a cada iteração do loop externo (Atualiza o número que será calculado)
            i++; //Esta incrementação conta quantas iterações foram realizadas.
        }

        E += a; //Apenas adiciona o valor de 'a' à variável E.

        Console.WriteLine("O resultado de E é " + E);
    }
}