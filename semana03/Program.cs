#region 
   

   var tupla1 = (idade: 25, nome: "Alexandre");

   List<(int idade, string nome)> list = new();
   list.Add(tupla1);
  
    Console.WriteLine($"Nome: {tupla1.nome}, {tupla1.idade}");

#endregion