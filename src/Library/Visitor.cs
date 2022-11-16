using System.Text;
using System.Collections.Generic;
namespace Library{
    public abstract class Visitor
    {
        public string Content {get;set;}
        public abstract void Visit(Node node);
        public abstract void Visit(Person person);
    }

}