using System;


public class exercicio2
{
    public static void rodar()
    {

        int p = 0, n = 0, z = 0; //declaradas as variáveis referentes aos positivos, negativos e zeros
        int i = 0; //declaração de "i" para o comando while iniciando em zero.

        Console.WriteLine("Entre com uma sequência de valores (separados por espaços)"); //solicita ao usuário a entrada de dados
        string[] entrada = Console.ReadLine().Split(' '); //o programa lê a string digitada pelo usuário e considera a separação da string por espaços em branco, dadas por "('')", como solicitado pelo comando ".Split"




        while (i < entrada.Length)
        { //O while me diz que enquanto i for menor que o tamanho da entrada (array) ele testa as seguintes condições.
          //a condição de saída do laço seria quando "i" for igual ou maior que o tamanho da entrada.

            int valor = int.Parse(entrada[i]); //A variável "valor" guarda o valor da entrada na posição "i" e é convertido para inteiro.

            if (valor > 0) //condição para o valor armazenado sendo maior que zero
            {
                p++; //retorno na variável "p" (positivo)

            }
            else if (valor < 0)
            {
                n++; //retorno na variável "n" (negativo)
            }
            else
            {
                z++; //retorno na variável "z" (zeros)
            }
            i++; //Faz com que as condições percorram todo o conjunto de entrada do usuário, que é o que possibilita a contagem dos valores de entrada.

        }


        int total = p + n + z; //a soma do total de unidades de números informados na array de entrada, para conseguir meu 100%
        double porcp = (double)p / total * 100; //declarada uma nova variável em double e convertido o valor das variáveis anteriores também para double.
        double porcn = (double)n / total * 100; //Assim calculada a quantidade de valores (positivos, negativos ou zeros) dividido pela minha quantidade de 100%
        double porcz = (double)z / total * 100; // Multiplicado por 100 para definir a porcentagem.

        Console.WriteLine("Quantidade de valores positivos é {0} e a porcentagem referente é {1:F2}%", p, porcp); //retorna ao usuário a quantidade de valores positivos + porcentagem referente.
        Console.WriteLine("Quantidade de valores negativos {0} e a porcentagem referente é {1:F2}%", n, porcn); //retorna ao usuário a quantidade de valores negativos + porcentagem referente.
        Console.WriteLine("Quantidade de zeros é de {0} e a porcentagem referente é {1:F2}%", z, porcz); //retorna ao usuário a quantidade de zeros + porcentagem referente.
    }
}