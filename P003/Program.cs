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
            Console.WriteLine("2 - Consultar produto por Cod.");
            Console.WriteLine("3 - Atualizar estoque de Prod");
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
                int cod_temporario;
                Boolean flag_temp = false;


                foreach(Estoque key in lista){
                    Console.WriteLine($"Produto: {key.Nome_prod}, Codigo do produto: {key.Cod_prod}, Quantidade: {key.Qtd_prod}, Preço: {key.Preco_prod}");
                }
                
                Console.WriteLine("Escreva o cod correspondente que deseja buscar do produto.");
                cod_temporario = int.Parse(Console.ReadLine());

                List<Estoque> prod_corresp = lista.Where(x => cod_temporario == x.Cod_prod)
                .Select(x => new Estoque(x.Cod_prod,x.Qtd_prod,x.Nome_prod,x.Preco_prod))
                .ToList();

                foreach(Estoque key in prod_corresp){
                    Console.WriteLine($"Produto: {key.Nome_prod}, Codigo do produto: {key.Cod_prod}, Quantidade: {key.Qtd_prod}, Preço: {key.Preco_prod}");
                }
            }

            
            if(op == 3){
                
                int id, Qtd_atualizada;

                foreach(Estoque key in lista){
                    Console.WriteLine($"Cod.Produto: {key.Cod_prod} - Produto: {key.Nome_prod} - Estoque atual: {key.Qtd_prod}");
                }

                Console.WriteLine("Insira o ID do produto que deseja atualizar o estoque.");
                id = int.Parse(Console.ReadLine());

                foreach(Estoque key in lista){
                    Console.WriteLine($"Produto Selecionado: {key.Nome_prod} - Estoque Atual: {key.Qtd_prod}");
                }
                
                Console.WriteLine("Insira agora o novo estoque desse produto: ");
                Qtd_atualizada = int.Parse(Console.ReadLine());

                List<Estoque> novo_estoque = lista.Select(x => x.Cod_prod == id ? new Estoque(x.Cod_prod, Qtd_atualizada, x.Nome_prod, x.Preco_prod) : x).ToList();

                for(int i=0; i < 2; i++){
                    lista[i] = novo_estoque[i];
                }

                foreach(Estoque key in novo_estoque){
                    Console.WriteLine($"Produto Selecionado: {key.Nome_prod} - Estoque Atual: {key.Qtd_prod}");
                }
                Console.WriteLine();
                foreach(Estoque key in lista){
                    Console.WriteLine($"Produto Selecionado: {key.Nome_prod} - Estoque Atual: {key.Qtd_prod}");
                }

            }



            if(op == 4){
            flag = true;
            }
            
        }while(!flag);

    }
}