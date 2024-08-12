using System;

public class exercicio9
{

    public static void rodar()
    {

        //estabelecidas as variáveis que receberão cálculo e valores quebrados (double) e as que resultarão ou serão entradas inteiras (int).
        double precoCompra, precoVenda;
        int lucroMenor10 = 0, lucroEntre10e20 = 0, lucroMaior20 = 0;
        double valorTotalCompra = 0, valorTotalVenda = 0;

        do //executa o bloco independentemente da condição.
        {
            Console.Write("Preço de compra: "); //solicita o preço de compra ao usuário.
            precoCompra = double.Parse(Console.ReadLine()); //entrada do usuário.

            if (precoCompra != 0) //condição para execução é que o valor do preço de compra seja diferente de zero.
            {
                Console.Write("Preço de venda: "); //solicita o preço de venda ao usuário.
                precoVenda = double.Parse(Console.ReadLine()); //entrada do usuário.

                double lucro = (precoVenda - precoCompra) / precoCompra * 100; //cálculo responsável por determinar o lucro unitário dos produtos.

                if (lucro < 10) //condição que solicita a quantidade de valores cujo lucro é menor que (10/100) ou 10%
                {
                    lucroMenor10++;
                }
                else if (lucro <= 20) //condição que solicita a quantidade de valores cujo lucro está entre 10% e 20%.
                {
                    lucroEntre10e20++;
                }
                else //qualquer outro valor, será enquadrado no lucro maior que 20%.
                {
                    lucroMaior20++;
                }

                valorTotalCompra += precoCompra; //aqui iremos armazenar em outra variável o valor total em compras, que será resultado do total informado na variável de preço de compra.
                valorTotalVenda += precoVenda; //E aqui será feito o mesmo processo, porém com o preço de venda.
            }

        } while (precoCompra != 0); //enquanto o preço de compra for diferente de zero ele irá executar o loop.

        double lucroTotal = (valorTotalVenda - valorTotalCompra) / valorTotalCompra * 100; //cálcuclo responsável por retornar em porcentagem o lucro total do processo.

        Console.WriteLine("Quantidade de mercadorias com lucro menor que 10%: " + lucroMenor10); //Retorna ao usuário a quantidade de mercadorias com lucro menor que 10%
        Console.WriteLine("Quantidade de mercadorias com lucro entre 10% e 20%: " + lucroEntre10e20); //Retorna ao usuário a quantidade de mercadorias com lucro entre 10 e 20%.
        Console.WriteLine("Quantidade de mercadorias com lucro maior que 20%: " + lucroMaior20); //Retorna ao usuário a quantidade de mercadorias com lucro maior que 20%
        Console.WriteLine("Valor total de compra: {0}", valorTotalCompra); //Retorna ao usuário o valor total em compras.
        Console.WriteLine("Valor total de venda: {0}", valorTotalVenda); //Retorna ao usuário o valor total em vendas.
        Console.WriteLine("Lucro total: {0:F2}%", lucroTotal); //Estabelece o lucro total em porcentagem.


    }
}