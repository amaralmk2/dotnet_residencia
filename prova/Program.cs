using System;
using System.Collections.Generic;

class Advogado{

    public string Nome {set ; get;}
    public DateTime Dat_nascimento {set; get;}
    
   public string Cpf
    {
        get { return Cpf; }
        set
        {
            if (!ValidarCpfUnico(value))
            {
                throw new InvalidOperationException($"Erro: CPF {value} já existe.");
            }
            Cpf = value;
        }
    }
   
      private bool ValidarCpfUnico(string novoCpf){
    
        List<string> cpfsExistentes = new List<string> { "12345678901", "98765432101" };

        return !cpfsExistentes.Contains(novoCpf);
    }

}

class Cliente{

     public string Nome {set ; get;}
     public string Cpf {set; get;}
     string EstadoCivil {set; get;}
     string Profissao {set; get;}
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

        advogados.Add(new Advogado("Pedro", DateTime.Now, "06518468548", "AE238V"));

    }
}


