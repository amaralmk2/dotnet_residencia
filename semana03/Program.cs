#region   
/*
   var tupla1 = (idade: 25, nome: "Alexandre");

   List<(int idade, string nome)> list = new();
   list.Add(tupla1);
  
    Console.WriteLine($"Nome: {tupla1.nome}, {tupla1.idade}");
*/
#endregion

#region     
/*
//não vou usar essa
var tupla01 = (10, 20);
Console.WriteLine($"Tupla1: {tupla01.Item1}, {tupla01.Item2}");

var tupla02 = (x: 5, y: 30);
Console.WriteLine($"Tupla2: {tupla02.x}, {tupla02.y}");

//só faz sentido usar essa pra que as outras?
var tupla03 = (id: 10, name: "Alexandre", born: new DateTime(1993,11,02));
Console.WriteLine($"Tupla3: {tupla03.name}, {tupla03.id}, {tupla03.born}");

List<(int id, string name, DateTime born)> list = new();
list.Add(tupla03);
list.Add((25, "Joana", new DateTime(1993,11,02)));
list.Add((30, "Alexandre", new DateTime(1993,12,010)));
list.ForEach(x => Console.WriteLine($"Tupla 04: {x.id}, {x.name}, {x.born.ToShortDateString()}"));

#endregion


#region 

List<(string, int)> pessoa = new List<(string, int)>{
    ("pedro", 25),
    ("Maria", 30),
    ("Alexandre", 180)
};

double alturaMedia = pessoa.Average(pessoa => pessoa.Item2);

Console.WriteLine($"A altura média das pessoas nessa lista é: {alturaMedia} cm");

*/
#endregion

#region 

var pessoa = ("Maria", 17);
var pessoa2 = ("joao", 16);
var pessoa3 = ("mario", 22);
var pessoa4 = ("jose", 21);

List<(string, int)> pessoas = new List<(string, int)>();

    pessoas.Add(pessoa);
    pessoas.Add(pessoa2);
    pessoas.Add(pessoa3);
    pessoas.Add(pessoa4);

    int maisVelho = 0;

for(int i =0; i < pessoas.Count; i++){
    if(pessoas[i].Item2 > pessoas[maisVelho].Item2){
        maisVelho = i;
    }
}

Console.WriteLine($"A pessoa mais velha é Nome: {pessoas[maisVelho].Item1}, Idade: {pessoas[maisVelho].Item2}");


#endregion

#region 



#endregion