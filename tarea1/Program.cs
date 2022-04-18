// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



int edad1 = 0;
decimal peso1;
Double altura1;
string edad;
String nombre;
string peso;
string altura;

Console.WriteLine("HOLA PARA INICIAR INGRESA TUS DATOS");
Console.WriteLine("NOMBRE:");
nombre = Console.ReadLine();
Console.WriteLine("EDAD:");
edad = Console.ReadLine();

try {
    edad1 = int.Parse(edad);
    if (edad1 < 0) {
        Console.WriteLine("INGRESE EDAD QUE CORRESPONDE");
        Console.WriteLine("EDAD:");
        edad = Console.ReadLine();
        edad1 = int.Parse(edad);
    }
}
catch {
    Console.WriteLine("INGRESE SOLO NUMEROS SIN LETRAS , O .");
    Console.WriteLine("EDAD:");
    edad = Console.ReadLine().Replace(' ', '0');
    edad1 = int.Parse(edad.Replace(' ','0'));
}
    
   
    if (edad1 < 0)
    {
        Console.WriteLine("INGRESE EDAD QUE CORRESPONDE");
        Console.WriteLine("EDAD:");
        edad = Console.ReadLine().Replace(' ','0');
        edad1 = int.Parse(edad);
    }

Console.WriteLine("PESO");
peso=Console.ReadLine().Replace('.',',');
    try{
    peso1 = decimal.Parse(peso);
    if (peso1 <= 0)
    {
        Console.WriteLine("EL PESO DEBE SER MAYOR A CERO");
        Console.WriteLine("PESO");
        peso = Console.ReadLine().Replace('.', ',').Replace(' ', '0');
        peso1 = decimal.Parse(peso);
    }
    }
    catch{
    Console.WriteLine("NO INGRESE LETRAS");
    Console.WriteLine("PESO:");
    peso = Console.ReadLine().Replace('.', ',').Replace(' ', '0');
    peso1 = decimal.Parse(peso);
    if (peso1 <= 0)
    {
    Console.WriteLine("EL PESO DEBE SER MAYOR A CERO");
    Console.WriteLine("PESO");
    peso = Console.ReadLine().Replace('.', ',').Replace(' ', '0');
    peso1 = decimal.Parse(peso);
}
}
Console.WriteLine("ALTURA:");
altura = Console.ReadLine().Replace('.', ',').Replace(' ', '0');
try
{
    altura1 = double.Parse(altura);
    if (altura1>3 || altura1<0)
    {
        Console.WriteLine("SU ALTURA ES MAYOR AL A LA DEL HOMBRE MAS ALTO DEL MUNDO O ES DEMACIADO PEQUEÑO, INGRESE NUEVAMENTE");
        altura = Console.ReadLine().Replace('.', ',').Replace(' ', '0');
        altura1 = double.Parse(altura);
    }
}
catch
{
    Console.WriteLine("NO INGRESE LETRAS");
    Console.WriteLine("ALTURA:");
    altura = Console.ReadLine().Replace('.', ',').Replace(' ', '0');
    altura1 = double.Parse(altura);
    if (altura1 < 3 || altura1 > 0)
    {
        Console.WriteLine("SU ALTURA ES MAYOR AL A LA DEL HOMBRE MAS ALTO DEL MUNDO O ES DEMACIADO PEQUEÑO, INGRESE NUEVA MENTE");
        altura = Console.ReadLine().Replace('.', ',').Replace(' ', '0');
        altura1 = double.Parse(altura);
    }
}
double peso2 = double.Parse(peso);
double imc = peso2 / (altura1*altura1);




Console.Clear();



Console.WriteLine("DATOS USUARIO");
Console.WriteLine("nombre : "+ nombre);
Console.WriteLine("EDAD   : "+ edad1);
Console.WriteLine("PESO   : "+ peso1);
Console.WriteLine("ALTURA : "+ altura1);
Console.WriteLine("IMC    : "+ imc);

if (imc <= 18.5){
    Console.WriteLine("IMC BAJO PESO");
}
if (imc >= 18.5 && imc <= 24.9)
{
    Console.WriteLine("IMC NORMAL");
}
if (imc >= 25 && imc <= 29.9)
{
    Console.WriteLine("IMC SOBRE PESO");
}
if (imc >= 30 )
{
    Console.WriteLine("IMC OBESO");
}




