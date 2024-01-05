using System;
using System.ComponentModel;

class Exercicios
{
    static void Main()
    {
        //Teste exercicios
        //Exercicio1();
        //Exercicio2();
        //Exercicio3();
        //Exercicio4();
        // Exercicio5();
        // Exercicio6();
        // Exercicio7();
        // Exercicio8();
    }


    public static void Exercicio1()
    {
        //Mostrar no terminal uma mensagem de "Hello, World!"
        Console.WriteLine("Hello, World!");
    }

    public static void Exercicio2()
    {
        //Pedir ao usuário o nome dele e retornar uma mensagem de "Olá (nome)!"
        string nome;

        Console.WriteLine("Informe seu nome ");
        nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}!");
    }

    public static void Exercicio3()
    {
        //Ler o nome e o salário de uma pessoa e exibir uma mensagem de "(nome), (salario)"
        string nome;
        int salario;

        Console.WriteLine("Informe seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Informe seu salário: ");
        salario = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Funcionário: {nome}\nSalário: {salario}");
    }


    public static void Exercicio4()
    {
        //Soma entre dois numeros

        int numero1;
        int numero2;
        int resultado;

        Console.WriteLine("Informe o primeiro número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo número: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        resultado = numero1 + numero2;

        Console.WriteLine($"A soma entre {numero1} e {numero2} é: {resultado}");

    }
    public static void Exercicio5()
    {
        //Calcular a media de dois valores
        int nota1;
        int nota2;
        int media;

        Console.WriteLine("Informe sua primeira nota: ");
        nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe sua segunda nota: ");
        nota2 = Convert.ToInt32(Console.ReadLine());
        media = (nota1 + nota2) / 2;
        Console.WriteLine($"Nota 1: {nota1} \nNota 2: {nota2}\nMédia: {media}");
    }
    public static void Exercicio6()
    {
        int numero;
        int antecessor;
        int sucessor;

        Console.WriteLine("Informe um número: ");
        numero = Convert.ToInt32(Console.ReadLine());
        antecessor = numero - 1;
        sucessor = numero + 1;
        Console.WriteLine($"Número: {numero}\nSucessor: {sucessor}\nAntecessor: {antecessor}");
    }
    public static void Exercicio7()
    {
        decimal numero;
        decimal dobronumero;
        decimal tercapartenumero;

        Console.WriteLine("Informe um número");
        numero = Convert.ToDecimal(Console.ReadLine());
        dobronumero = numero * 2;
        tercapartenumero = numero / 3;

        Console.WriteLine($"Numero: {numero}\nDobro: {dobronumero}\n Terça parte: {tercapartenumero:.#####}");
    }

    public static void Exercicio8()
    {
        decimal metros;
        decimal quilometros;
        decimal centimetros;
        decimal hectometro;
        decimal decametro;
        decimal milimetro;
        decimal decimetro;


        Console.WriteLine("Informe uma distância em metros: ");
        metros = Convert.ToDecimal(Console.ReadLine());
        quilometros = metros / 1000;
        centimetros = metros * 100;
        hectometro = metros / 100;
        decametro = metros / 10;
        milimetro = metros * 1000;
        decimetro = metros * 10;

        Console.WriteLine($"Metros: {metros}\nQuilometros: {quilometros}\nCentimetros: {centimetros}\nHectometro {hectometro}\nDecametro: {decametro}\nMilimetro: {milimetro}\nDecimetro: {decimetro}");
    }

}