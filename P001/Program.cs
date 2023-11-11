#region

int anoCarro = 2012;
long kmRodados = 10000000L;
double litroGasolina = 20.5;

Console.WriteLine(" O carro tem " + kmRodados + "KM rodados" + "| tem " + litroGasolina + " L de combustivel " +"| O ano do carro é: "+ anoCarro);

#endregion

#region 

double variavel;
int var;

variavel = 20.9;

var = (int)variavel;

Console.WriteLine("A variavel ficou com o valor: "+ var);

#endregion

#region 

int x=10, y=3;

int result = x+y;

Console.WriteLine(x + " + "+ y+ " = "+(x+y));
Console.WriteLine(x+" - "+ y + " = "+(x-y));
Console.WriteLine(x+" * "+ y + " = "+(x*y));
Console.WriteLine(x+" / "+ y + " = "+(x/y));


#endregion

#region 

int a=5, b=8;

if(a>b){
    Console.WriteLine(a +" é maior que "+ b);
}else{
    Console.WriteLine(b + " é maior que "+ a);
}

#endregion

#region 

string str1 = "Hello";
string str2 = "World";


if(str1==str2){
    Console.WriteLine("as strings são iguais");
}else{
    Console.WriteLine("As strings não são iguais");
}

#endregion

#region 

bool condicao1 = true;
bool condicao2 = false;

if(condicao1 == true && condicao2 == true){
    Console.WriteLine("Ambas as condicoes são verdadeiras");
}else{
    Console.WriteLine("Ambas ou alguma das condições não são verdadeiras");
}

#endregion

#region 

int num1 = 7, num2 = 3, num3 = 10;

if(num1 > num2){
   Console.WriteLine(num1 + " > "+ num2);
}if(num3 == (num1+num2)){
   Console.WriteLine(num3 + " = " + "A soma de "+ num1 +" + "+num2);
}

#endregion