using System;

public class exercicio5
{

    public static void rodar()
    {

        double salario, mediaSalario = 0, maiorSalario = 0; //declaração das variáveis referentes aos cálculos de salário.
        int filhos, totalFilhos = 0, totalPessoas = 0, pessoasAteCem = 0; //declaração das variáveis referentes as entradas de dados inteiros.
        double mediaFilhos = 0, percAteCem = 0; //declaração das variáveis que podem retornar resultados decimais.

        while (true)
        { //Utilizado o While para ler os dados de salário e número de filhos de cada habitante, até que seja inserido um valor negativo para o salário, o que indica o encerramento do loop.
            Console.Write("Digite o salário (ou um valor negativo para sair): "); //solicitação da entrada de dados
            salario = double.Parse(Console.ReadLine()); //leitura do salário, que executará enquanto salário não for negativo (salário < 0).

            if (salario < 0)
            { //condição de encerramento do loop após entrada dos valores solicitados. (Eu não soube usar outro processo que não fosse o break pra isso)
                break;
            }

            Console.Write("Digite o número de filhos: "); //solicitação do número de filhos, que também será executado após a solicitação do salário em todos os casos.
            filhos = int.Parse(Console.ReadLine()); //leitura dos valores referentes aos filhos, onde a primeira variável receberá os valores

            totalFilhos += filhos; //os valores da primeira variável serão armazenados na segunda variável "totalFilhos" para que possibilite a entrada de outros dados. 
            totalPessoas++; //totalPessoas será a quantidade de vezes que o loop é executado, contabilizando o número de pessoas na pesquisa.
            mediaSalario += salario; //"mediaSalario" será a variável que vai receber e armazenar os valores de salário, permitindo a entrada de outros dados.

            if (salario > maiorSalario)
            {
                //aqui é onde será feita a atualização do maior salário à partir da entrada, o que garante que sempre substituirá, caso o valor informado seja maior que o anterior, para que seja respondida a questão c;
                maiorSalario = salario;
            }

            if (salario <= 100)
            {
                //Esta condição estabelece a contagem de salários que vão até R$100,00. 
                pessoasAteCem++;
            }
        }

        if (totalPessoas > 0)
        {
            //Aqui é onde estabelecemos as condições para execução dos cálculos solicitados. Desde que o total de pessoas seja maior que zero, este conjunto será executado (Após sair do loop).
            mediaSalario /= totalPessoas; //aqui é onde é executado o cálculo para retorno de média salarial dentre o número total de pessoas.
            mediaFilhos = (double)totalFilhos / totalPessoas; //aqui é onde será feito o cálculo de média de filhos, onde foi aplicado o double para o "totalFilhos" para que permita que a operação seja feita, já que poderá retornar valores quebrados.
        }

        percAteCem = (double)pessoasAteCem / totalPessoas * 100; //Aqui é executado o cálculo para determinar a quantidade de pessoas que possuem salário de até R$100,00

        Console.WriteLine("Média do salário da população: " + mediaSalario); //Após isso são aplicados os retornos ao usuário.
        Console.WriteLine("Média do número de filhos: " + mediaFilhos);
        Console.WriteLine("Maior salário: " + maiorSalario);
        Console.WriteLine("Percentual de pessoas com salário até R$100,00: " + percAteCem + "%");
    }
}
