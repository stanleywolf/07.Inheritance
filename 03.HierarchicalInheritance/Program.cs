using System;


class Program
{
    static void Main(string[] args)
    {
        var cat = new Cat();
        var dog = new Dog();

        dog.Eat();
        dog.Bark();

        cat.Eat();
        cat.Meow();
    }

}