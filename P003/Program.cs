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

    public void IncrementaCod(){
        Cod_prod++;
    }
}


class Program{

    static void Main(String[] args){
        Boolean flag = false;
        int op, qtd_prod, cod_prod;
        double preco_prod;
        String nome_prod, ch;

        List<Estoque> lista = 
        new List<Estoque>();

        do{
            Console.WriteLine("<------------------>");
            Console.WriteLine("1 - Cadastrat Produto");
            Console.WriteLine("Teste listar produto.");
            op = int.Parse(Console.ReadLine());

            if(op == 1){
                Boolean flag_temp = false;
                do{

                Console.WriteLine("Digite o nome do produto");
                nome_prod = Console.ReadLine();

                Console.WriteLine("Insira o preco do produto");
                preco_prod = double.Parse(Console.ReadLine());

                Console.WriteLine("Insira a quantidade de produtos");
                qtd_prod = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira o codigo do produto");
                cod_prod = int.Parse(Console.ReadLine());
                
                lista.Add(new Estoque(cod_prod , qtd_prod, nome_prod, preco_prod));

                Console.WriteLine("Deseja Adiconar mais produtos?");
                ch = Console.ReadLine();

                if(ch == "sim" || ch == "SIM"){
                    flag_temp = true;
                }else{
                    flag_temp = false;
                }

                }while(flag_temp == true);

            }

            if(op == 2){

                foreach(Estoque key in lista){
                    Console.WriteLine($"Produto: {key.Nome_prod}, Codigo do produto: {key.Cod_prod}, Quantidade: {key.Qtd_prod}, Preço: {key.Preco_prod}");
                }

            }

            if(op == 3){
            flag = true;
            }
            
        }while(!flag);

    }
}