internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade de horas trabalhadas no mês: ");
        int horasTrabalhadasNoMes = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o salário por hora: ");
        double salarioHora = double.Parse(Console.ReadLine());

        const int totalHorasSemanais = 40;
        const int totalHorasMensais = 4;

        int horasRegulares = Math.Min(horasTrabalhadasNoMes,totalHorasSemanais * totalHorasMensais);
        int horasExtras = Math.Max(horasTrabalhadasNoMes - horasRegulares, 0);

        double salarioRegular = horasRegulares * salarioHora;
        double salarioExtra = horasExtras * salarioHora * 1.5;

        double salarioTotal = salarioRegular * salarioExtra;
        Console.WriteLine("O salário do funcionário é: " + salarioTotal);


    }
}