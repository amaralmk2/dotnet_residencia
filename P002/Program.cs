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
    private List<Tarefa> tarefas;
    private static int AdcId = 1;

     public GerenciaTarefa(){
        tarefas = new List<Tarefa>();
    }

   public void AdicionarTarefa(string nome, DateTime data){
        Tarefa novaTarefa = new Tarefa(nome, data, AdcId++);
        tarefas.Add(novaTarefa);
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }


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
                    
                    Console.Write("Digite o nome da tarefa: ");
                    string ?nomeTarefa = Console.ReadLine();

                    Console.Write("Digite a data da tarefa (formato: dd/mm/yyyy): ");
                    DateTime dataTarefa = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                    gerenciador.AdicionarTarefa(nomeTarefa, dataTarefa);
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