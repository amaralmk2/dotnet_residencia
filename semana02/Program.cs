#region 

string[] colecao = {"item1", "item2", "item3", "item4"};

foreach(string item in colecao){
    Console.WriteLine(item);
}

#endregion

#region 

for(int i = 0; i <= 30; i++ ){
    if(i %3 == 0){
        Console.WriteLine(i);
    }else if(i %4 == 0){
        Console.WriteLine(i);
    }
}

#endregion

#region 

int fib1 = 0, fib2 = 1, fib3;

while( fib1 <= 100){

    Console.WriteLine(fib1);
    fib3 = fib1 + fib2;
    fib1 = fib2;
    fib2 = fib3;
}
#endregion

#region ReadLine Example

Console.WriteLine("Informe uma string");
string? str = Console.ReadLine();
Console.WriteLine($"A string foi: {str}");

#endregion

#region 

string data = "02/11/1993";


string dataSeparada = data.Split('/');
Console.WriteLine(dataSeparada);


#endregion