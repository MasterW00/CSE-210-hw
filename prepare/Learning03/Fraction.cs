class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction(int _top = 1, int _bottom = 1){
        this._top = _top;
        this._bottom = _bottom;
    }
    public Fraction(int _top){
        this._top = _top;
        this._bottom = 1;
    }
    public int top(){
        return _top;
    }
    public int bottom(){
        return _bottom;
    }
    public void setTop(int top){
        _top = top;
    }
    public void setBottom(int bottom){
        _bottom = bottom;
    }

    
    public override string ToString(){
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }

    public string GetFractionString(){
        return this.ToString();
    }
}