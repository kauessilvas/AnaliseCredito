Console.Clear();

double valorEmprestimo = 0;
int qtdParcelas = 0;
double rendaMensal = 0;


Console.WriteLine("==== Analise de Crédito ====");
while (true)
{
    Console.Write("Digite o valor do empréstimo: ");
    string inputEmprestimo = Console.ReadLine()!;

    Console.Write("Digite a quantidade de parcelas: ");
    string inputParcelas = Console.ReadLine()!;

    Console.Write("Digite a renda mensal: ");
    string inputRenda = Console.ReadLine()!;

    bool valido = double.TryParse(inputEmprestimo, out valorEmprestimo)
                  && int.TryParse(inputParcelas, out qtdParcelas)
                  && double.TryParse(inputRenda, out rendaMensal);

    if (valido && valorEmprestimo > 0 && qtdParcelas > 0 && rendaMensal > 0)
    {
        double valorParcela = valorEmprestimo / qtdParcelas;
        double limiteParcela = rendaMensal * 0.3;

        if(valorParcela > limiteParcela) {
            Console.WriteLine("\nParcela excede o limite permitido.\n");
        }
        else {
            Console.WriteLine("\nEmpréstimo Aprovado!!!\n");
            break;
        }
    }
    else
    {
        Console.WriteLine("\nAlgum dos valores digitados é inválido. Tente novamente.\n");
    }
}
