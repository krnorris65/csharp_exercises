namespace Animals{
    public class Dog: Animal
    {
        private double _speed {get; set;} = 1.5;

        public double Speed {get {return _speed;}}

        public void Walk(double hour, double miles){
            _speed = miles/hour;
        }

    }
}