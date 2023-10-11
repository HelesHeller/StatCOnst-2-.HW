using System;

class MusicalInstrument
{
    protected string name;
    protected string description;

    public MusicalInstrument(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Звук музичного інструменту");
    }

    public void Show()
    {
        Console.WriteLine($"Назва музичного інструменту: {name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Опис музичного інструменту: {description}");
    }

    public virtual void History()
    {
        Console.WriteLine($"Історія створення музичного інструменту {name}");
    }
}

class Violin : MusicalInstrument
{
    public Violin(string description) : base("Скрипка", description) { }
}

class Trombone : MusicalInstrument
{
    public Trombone(string description) : base("Тромбон", description) { }
}

class Ukulele : MusicalInstrument
{
    public Ukulele(string description) : base("Укулеле", description) { }
}

class Cello : MusicalInstrument
{
    public Cello(string description) : base("Віолончель", description) { }
}

abstract class Worker
{
    public abstract void Print();
}

class President : Worker
{
    public override void Print()
    {
        Console.WriteLine("Це президент.");
    }
}

class Security : Worker
{
    public override void Print()
    {
        Console.WriteLine("Це охоронець.");
    }
}

class Manager : Worker
{
    public override void Print()
    {
        Console.WriteLine("Це менеджер.");
    }
}

class Engineer : Worker
{
    public override void Print()
    {
        Console.WriteLine("Це інженер.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Violin violin = new Violin("Духовий струнний музичний інструмент");
        violin.Sound();
        violin.Show();
        violin.Desc();
        violin.History();

        President president = new President();
        president.Print();

        Engineer engineer = new Engineer();
        engineer.Print();
    }
}
