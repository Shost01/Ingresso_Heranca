using System;
using System.Drawing;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Ingresso
{
    public double Preco { get; set; }

    public Ingresso(double preco)
    {
        Preco = preco;

    }

    public virtual void ExibirPreco()
    {
        Console.WriteLine("Ingresso normal: " + Preco);
    }


}

public class VIP : Ingresso
{
    public double PrecoAdicional { get; set; }

    public VIP(double preco, double precoAdicional) : base(preco)
    {
        PrecoAdicional = precoAdicional;
    }

    public override void ExibirPreco()
    {
        double precoVIP = Preco + PrecoAdicional;
        Console.WriteLine("Ingresso VIP: " + precoVIP);
    }

}

public class Normal : Ingresso
{
    public Normal(double preco) : base(preco)
    {

    }

    public override void ExibirPreco()
    {
        Console.WriteLine("Preços do ingresso:");
        base.ExibirPreco();
    }
}

public class Principal
{
    public static void Main(string[] args)
    {
        Ingresso ingressoNormal = new Normal(50.0);
        ingressoNormal.ExibirPreco();

        Ingresso ingressoVIP = new VIP(50.0, 20.0);
        ingressoVIP.ExibirPreco();

    }

}
