using System;

class Estoque{

    public int Cod_prod {set; get;}
    public int Qtd_prod {set; get;}
    public String Nome_prod {set; get;}
    public double Preco_prod {set; get;}

    public Estoque(int cod_prod, int qtd_prod, string nome_prod, double preco_prod){
        
        Cod_prod = cod_prod;
        Qtd_prod = qtd_prod;
        Nome_prod = nome_prod;
        Preco_prod = preco_prod;

    }
}


class Program{

    static void Main(String[] args){
        Boolean flag = false;
        int op;
        List<Estoque> lista = 
        new List<Estoque>();

        do{
            Console.WriteLine("<------------------>");
            Console.WriteLine("1 - Cadastrat Produto");
            op = int.Parse(Console.ReadLine());

            if(op == 1){

            }

            flag = true;
        }while(!flag);

    }
}