Funcionario f;

Console.WriteLine("Digite os dados do funcionário");
Console.Write("Código: ");
f.Codigo = int.Parse(Console.ReadLine());

Console.Write("Nome: ");
f.Nome = Console.ReadLine();

Console.Write("Salário: ");
f.Salario = double.Parse(Console.ReadLine());

Console.WriteLine("\nInformações Registradas");
Console.WriteLine($"Código...{f.Codigo}");
Console.WriteLine($"Nome...{f.Nome}");
Console.WriteLine($"Salário R$...{f.Salario}");
struct Funcionario
{
    public int Codigo;
    public string Nome;
    public double Salario;
}
