class Square : Shape
{
    int _side;
    public Square(int side, string color) : base(color){
        _side = side;
    }
    public override double GetArea(){
        return Math.Pow(_side, 2);
    }
}