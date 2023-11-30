using System;
using System.Collections.Generic;

class Advogado
{
    private string cpf;
    private string cna;

    public string Nome { get; set; }
    public DateTime Dat_nascimento { get; set; }

    public string Cpf
    {
        get { return cpf; }
        set
        {
            if (!ValidarCpfUnico(value))
            {
                throw new InvalidOperationException($"Erro: CPF {value} já existe.");
            }
            cpf = value;
        }
    }

    public string Cna
    {
        get { return cna; }
        set
        {
            if (!ValidarCnaUnico(value))
            {
                throw new InvalidOperationException($"Erro: CNA {value} já existe.");
            }
            cna = value;
        }
    }

    private static List<string> cpfsExistentes = new List<string>();

    private bool ValidarCpfUnico(string novoCpf)
    {
        return !cpfsExistentes.Contains(novoCpf);
    }

    private bool ValidarCnaUnico(string novoCna)
    {
        List<string> cnasExistentes = new List<string> { "OAB123", "OAB456" };
        return !cnasExistentes.Contains(novoCna);
    }

    public Advogado(string nome, DateTime dat_nascimento, string cpf, string cna)
    {
        Nome = nome;
        Dat_nascimento = dat_nascimento;
        Cpf = cpf;
        Cna = cna;
        cpfsExistentes.Add(cpf);
    }

    public int CalcularIdade() {
        DateTime hoje = DateTime.Now;
        int idade = hoje.Year - Dat_nascimento.Year;

        if (hoje.Month < Dat_nascimento.Month || (hoje.Month == Dat_nascimento.Month && hoje.Day < Dat_nascimento.Day))
        {
            idade--;
        }

        return idade;
    }
}

class Cliente
{
    private string cpf;

    public string Nome { get; set; }

    public DateTime Dat_nascimento { get; set; }

    string EstadoCivil { get; set; }
    string Profissao { get; set; }

    public string Cpf
    {
        get { return cpf; }
        set
        {
            if (!ValidarCpfUnico(value))
            {
                throw new InvalidOperationException($"Erro: CPF {value} já existe.");
            }
            cpf = value;
        }
    }

    private static List<string> cpfsExistentes = new List<string>();

    private bool ValidarCpfUnico(string novoCpf)
    {
        return !cpfsExistentes.Contains(novoCpf);
    }

    public Cliente(string nome, string cpf,DateTime dat_nascimento, string estadocivil, string profissao)
    {
        Nome = nome;
        Cpf = cpf;
        Dat_nascimento = dat_nascimento;
        EstadoCivil = estadocivil;
        Profissao = profissao;
        cpfsExistentes.Add(cpf);
    }

    public int CalcularIdade() {
        DateTime hoje = DateTime.Now;
        int idade = hoje.Year - Dat_nascimento.Year;

        if (hoje.Month < Dat_nascimento.Month || (hoje.Month == Dat_nascimento.Month && hoje.Day < Dat_nascimento.Day))
        {
            idade--;
        }

        return idade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Advogado> advogados = new List<Advogado>();
        List<Cliente> clientes = new List<Cliente>();

        advogados.Add(new Advogado("Pedro", new DateTime(1990, 1, 1), "12345578901", "AE238V"));
        clientes.Add(new Cliente("João", "12345578901",new DateTime(1990, 1, 1) , "Solteiro", "Marceneiro"));

        try
        {
            clientes.Add(new Cliente("João", "12345578901", new DateTime(1990, 1, 1), "Solteiro", "Marceneiro"));
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }

        foreach (Cliente cliente in clientes)
        {
            Console.WriteLine($"Cliente: {cliente.Nome}, CPF: {cliente.Cpf}");
        }

        try
        {
            advogados.Add(new Advogado("Maria", new DateTime(1985, 5, 10), "98765432101", "OAB456"));
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }

        foreach (Advogado advogado in advogados)
        {
            Console.WriteLine($"Advogado: {advogado.Nome}, CPF: {advogado.Cpf}, CNA: {advogado.Cna}, Idade: {advogado.CalcularIdade()}, Nascimento: {advogado.Dat_nascimento.ToString("dd/MM/yyyy")}");
        }
        
        
        Console.WriteLine("Digite uma idade minima e na sequencia uma idade Maxima.");
        int idadeMinima = 45;
        int idadeMaxima = 100;

        List<Advogado> advogadosComIdade = advogados.FindAll(a => a.CalcularIdade() >= idadeMinima && a.CalcularIdade() <= idadeMaxima);

        Console.WriteLine($"\nAdvogados com idade entre {idadeMinima} e {idadeMaxima} anos:");

        foreach (Advogado advogado in advogadosComIdade){
            Console.WriteLine($"Advogado: {advogado.Nome}, CPF: {advogado.Cpf}, CNA: {advogado.Cna}, Idade: {advogado.CalcularIdade()}, Nascimento: {advogado.Dat_nascimento.ToString("dd/MM/yyyy")}");
        }
       

        

    }
        }
