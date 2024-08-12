using System;

public class exercicio10
{

    public static void rodar()
    {

        
        
        int candA = 0, candB = 0, candC = 0, candD = 0, votonul = 0, votoembranco = 0, totaldevotos = 0; //dados os valores inteiros que serão informados pelo usuário

        do //imprime para o usuário o bloco de código a seguir e solicita o retorno.
        {
            Console.Write("Informe o número do seu candidato (Ou '5' para nulo e '6' para votar em branco): "); 
            totaldevotos = int.Parse(Console.ReadLine()); 

            if (totaldevotos != 0) //estabelece que o loop será gerado enquanto a variável totaldevotos for diferente de zero.
            {

                if (totaldevotos == 1) //estabelece a condição para computar o voto para o candidato A.
                {
                    candA++; //realiza a contabilização destas entradas.
                }
                else if (totaldevotos == 2) //estabelece a condição para computar o voto para o candidato B.
                {
                    candB++; //realiza a contabilização destas entradas.
                }
                else if (totaldevotos == 3) //estabelece a condição para computar o voto para o candidato C.
                {
                    candC++; //realiza a contabilização destas entradas.
                }
                else if (totaldevotos == 4) //estabelece a condição para computar o voto para o candidato D.
                {
                    candD++; //realiza a contabilização destas entradas.
                }
                else if (totaldevotos == 5){ //estabelece a condição para computar o voto nulo.

                    votonul++; //realiza a contabilização destas entradas.

                }
                else if (totaldevotos == 6){ //estabelece a condição para computar o voto em branco.

                    votoembranco++; //realiza a contabilização destas entradas.
                    
                }
                else{

                    Console.WriteLine("Informe apenas o número do candidato ou o valor para o voto nulo ou em branco"); //para que não retorne crash no programa, e sim mantenha-se no loop sem contrabilizar, caso o usuário digite algum número incorreto.
                }

    
            }

        } while (totaldevotos != 0); //encerra o loop e a condição de ser diferente de 0.

        Console.WriteLine("Total de votos do candidato A é de " + candA);
        Console.WriteLine("Total de votos do candidato B é de " + candB);
        Console.WriteLine("Total de votos do candidato C é de " + candC);
        Console.WriteLine("Total de votos do candidato D é de " + candD);
        Console.WriteLine("Total de votos nulos é de " + votonul);
        Console.WriteLine("Total de votos em branco é de " + votoembranco);
        //imprime para o usuário os valores e a contabilização dos votos em questão.
    }
}