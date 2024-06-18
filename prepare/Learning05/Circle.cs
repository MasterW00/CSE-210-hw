class Circle : Shape
{
    int _radius;
    public Circle(int radius, string color) : base(color){
        _radius = radius;
    }
    public override double GetArea(){
        return Math.PI * Math.Pow(_radius, 2);
    }
}