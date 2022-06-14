using System;
using Exercicos_de_Pogramação__Seção_5_;
{


    Console.WriteLine("Digite o nome do usuario ");
    var nome = Console.ReadLine();

    Console.WriteLine("Digite o numero de sua conta");
    var conta = double.Parse(Console.ReadLine());

    Dados p = new Dados(nome, conta);
    Console.WriteLine(p);

    var r = "Deseja realizar um saque, um depósito ou sair do programa? \n" +
        "Caso deseje saque digite 'saque' \n" +
        "Caso deseje depósito digite 'dep' \n" +
        "Caso deseje sair digite sair! \n ";

    Console.WriteLine(r);
    var resposta = Console.ReadLine();

    if (resposta == "saque")
    {
        Console.WriteLine("Digite o valor a ser sacado da conta! \n");
        var saque = double.Parse(Console.ReadLine());
        p.Saque(saque);

        Console.WriteLine(p);

    }

    else if (resposta == "dep")
    {
        Console.WriteLine("Digite o valor a ser depositado") ;
        var dep = double.Parse(Console.ReadLine());
        p.Dep(dep);
        Console.WriteLine(p);
    }
    else
    {
        Console.WriteLine("Tenha um bom dia meu consagrado!!");
    }



}


