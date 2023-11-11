Console.WriteLine("Hello, World!");

#region Teste de Tipos de Dados 
    int tipoInteiro;
    double tipoDouble;
    string tipoString;
    long tipoLong;
    tipoInteiro = int.MaxValue;
    tipoLong = long.MaxValue; 

    tipoString = "100";

    tipoInteiro = int.Parse(tipoString);

    Console.WriteLine("O máximo inteiro é: " + tipoInteiro);
    Console.WriteLine("O máximo longo é: " + tipoLong);

#endregion


#region Operadores
    tipoDouble = tipoInteiro + tipoLong;
    // tipoInteiro = tipoDouble + tipoLong; Não há conversão implícita
    // tipoLong = tipoDouble + tipoInteiro

    tipoInteiro = 10 > 5 ? 1 : 0;

    Console.WriteLine(tipoInteiro);

#endregion