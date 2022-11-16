using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n1.SetPerson("Luis", 78);
            //Hijos de n1
            n2.SetPerson("Jorge", 60);
            n3.SetPerson("Carlos", 58);
            //Hijos de n2
            n4.SetPerson("José", 40);
            n5.SetPerson("Juan", 42);
            //Hijos de n3
            n6.SetPerson("Alberto", 41);
            n7.SetPerson("Pedro", 43);
            // visitar el árbol aquí
            Visitor visitor = new AgeVisitor();
            n1.Accept(visitor);
            Console.WriteLine(visitor.Content);
            visitor = new NameVisitor();
            n1.Accept(visitor);
            Console.WriteLine(visitor.Content);
        }
    }
}
