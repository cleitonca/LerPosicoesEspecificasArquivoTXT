
// Linha que deseja ler
int numeroLinha = 3;

// Colunas que deseja ler
int colunaInicio = 1;
int colunaFim = 18;

try
{
    // Ler todas as linhas do arquivo
    string[] lines = File.ReadAllLines(@"D:\Estudo de Desenvolvimento\CSharp\LerArquivoTXT\Arquivo.txt");

    // Verifica se a linha solicitada existe
    if (numeroLinha <= lines.Length)
    {
        // Pega a linha solicitada
        string line = lines[numeroLinha - 1];

        // Verifica se as colunas solicitadas são válidas
        if (colunaInicio >= 0 && colunaInicio < line.Length && colunaFim > colunaInicio && colunaFim <= line.Length)
        {
            // Pega o trecho desejado da linha
            string specificInformation = line.Substring(colunaInicio - 1, colunaFim - colunaInicio + 1);

            Console.WriteLine("");
            Console.WriteLine("A informação nessa linha e posições é: \n" +
                "--------------------------------------\n" 
                + specificInformation);
        }
        else
        {
            Console.WriteLine("As colunas solicitadas são inválidas.");
        }
    }
    else
    {
        Console.WriteLine("A linha solicitada não existe.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Ocorreu um erro ao ler o arquivo: " + ex.Message);
}

Console.WriteLine("--------------------------------------");

Console.WriteLine("\nDigite uma tecla para sair!");
Console.ReadKey();