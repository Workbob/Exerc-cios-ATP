using System;


public class exercicio1
{
    public static void rodar()
    {

        int p = 0, n = 0, z = 0; //declaradas as variáveis referentes aos positivos, negativos e zeros
        int i = 0; //declaração de "i" para o comando while iniciando em zero.

        Console.WriteLine("Entre com uma sequência de valores (separados por espaços)"); //solicita ao usuário a entrada de dados
        string[] entrada = Console.ReadLine().Split(' '); //o programa lê a string digitada pelo usuário e considera a separação da string por espaços em branco, dadas por "('')", como solicitado pelo comando ".Split"




        while (i < entrada.Length){ //O while me diz que enquanto i for menor que o tamanho da entrada (array) ele testa as seguintes condições.
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

        Console.WriteLine("Quantidade de valores positivos:" + p); //retorna ao usuário a quantidade de valores positivos.
        Console.WriteLine("Quantidade de valores negativos:" + n); //retorna ao usuário a quantidade de valores negativos.
        Console.WriteLine("Quantidade de zeros:" + z); //retorna ao usuário a quantidade de zeros.
    }
}


