using System;
using System.Collections.Generic;


class Advogado{

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
    
   
      private bool ValidarCpfUnico(string novoCpf){
    
        List<string> cpfsExistentes = new List<string> { "12345678901", "98765432101" };

        return !cpfsExistentes.Contains(novoCpf);
    }

    private bool ValidarCnaUnico(string novoCna)
    {
        
        List<string> cnasExistentes = new List<string> { "OAB123", "OAB456" };

        return !cnasExistentes.Contains(novoCna);
    }

    public Advogado(string nome, DateTime dat_nascimento, string cpf, string cna){

        Nome = nome;
        Dat_nascimento = dat_nascimento;
        Cpf = cpf;
        Cna = cna;

    }

}



class Cliente{

     public string Nome {set ; get;}
     private string cpf;
     string EstadoCivil {set; get;}
     string Profissao {set; get;}

      public string Cpf {
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

        private bool ValidarCpfUnico(string novoCpf){
    
        List<string> cpfsExistentes = new List<string> { "12345678901", "98765432101" };

        return !cpfsExistentes.Contains(novoCpf);
    }



     public Cliente(string nome, string cpf, string estadocivil, string profissao){
                Nome = nome;
                Cpf = cpf;
                EstadoCivil = estadocivil;
                Profissao = profissao;
    }

}

class Program{

    static void Main(string[] args){
            
        List<Advogado> advogados = new List<Advogado>();
        List<Cliente> cliente = new List<Cliente>();

        advogados.Add(new Advogado("Pedro", DateTime.Now, "12345578901", "AE238V"));
        cliente.Add(new Cliente("João", "12345578991", "Solteiro", "Marceneiro"));

        try
        {   
            cliente.Add(new Cliente("João", "12345578991", "Solteiro", "Marceneiro"));   
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }

        // Exemplo de impressão
        foreach (Cliente client in cliente)
        {
            Console.WriteLine($"Nome: {client.Nome}, CPF: {client.Cpf},");
        }


     try
        {   
            advogados.Add(new Advogado("Maria", DateTime.Now, "98765432101", "OAB456"));   
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }

        // Exemplo de impressão
        foreach (Advogado advogado in advogados)
        {
            Console.WriteLine($"Advogado: {advogado.Nome}, CPF: {advogado.Cpf}, CNA: {advogado.Cna}");
        }


    }
}


