namespace Library{
    public class AgeVisitor : Visitor {
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
            if( Content == null)
            {
                Content = "0";
            }
            if (person.Edad > int.Parse(Content))
            {
                Content = person.Edad.ToString();
            }
        }
    }
}