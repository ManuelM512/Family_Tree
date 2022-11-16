namespace Library{
    public class NameVisitor : Visitor {
        public override void Visit(Node node)
        {
            node.person.Accept(this);
            foreach (Node nod in node.Children)
            {
                nod.Accept(this);
            }
        }

        public override void Visit(Person person)
        {
            if(Content == null)
            {
                Content = "";
            }
            if (person.Nombre.Length > Content.Length)
            {
                Content = person.Nombre;
            }
        }
    }
}