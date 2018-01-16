namespace BagOLoot
{
    public class Present
    {
        public Present (Child child)
        {
            this.Child = child;
        }

        public Present (string name, Child child)
        {
            this.Name = name;
            this.Child = child;
        }

        public string Name {get; set;}
        public Child Child {get; set;}

        public bool Delivered {get; set;} = false;
    }
}