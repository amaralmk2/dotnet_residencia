class Advogado{

    public string Nome {set ; get;}
    public DateTime Dat_nascimento {set; get;}
    public string cpf {set; get;}
    public string Cna {set; get;}

    public Advogado(string nome, DateTime dat_nascimento, string cpf, string cna){
                Nome = nome;
                Dat_nascimento = dat_nascimento;
                cpf = cpf;
                cna = cna;
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
            
        Lista<Advogado> advogados = new Lista<Advogado>();
        Lista<Cliente> cliente = new Lista<Cliente>();

    }
}


