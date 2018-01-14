namespace Animals{
    public class Animal
    {
        private string _name;
        private string _species;

        public string Name {get {return _name;}}
        public string Species {get {return _species;}}

        public void SetName(string name){
            _name = name;
        }
        public void SetSpecies(string species){
            _species = species;
        }


    }
}