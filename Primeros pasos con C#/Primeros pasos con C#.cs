//Primeros pasos con C#
Console.WriteLine("This is the first line");
Console.WriteLine("This is the second line");

//Realizacion de operaciones basicas con numeros en C#
int fahrenheit=94;
decimal value=fahrenheit-32;
value=value*5/9;
Console.WriteLine("The temperature is " + value+ " Celsius.");
//Correct way
int fahrenheit=94;
decimal celsius=(fahrenheit-32)*(5m/9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");