class Tarefa
{
    public string Nome { get; set; }
    public DateTime Data { get; set; }
    public int Id {get; set; }

    public Tarefa(string nome, DateTime data, int id)
    {
        Nome = nome;
        Data = data;
        Id = id;
    }
}

class GerenciaTarefa{
    //private List<Tarefa> tarefas;

}
class Program
{
    static void Main()
    {
        GerenciaTarefa gerenciador = new GerenciaTarefa();

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Visualizar Tarefas");
            Console.WriteLine("3. Sair");

            string ?escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    
                    break;

                case "2":
                    break;

                case "3":
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}