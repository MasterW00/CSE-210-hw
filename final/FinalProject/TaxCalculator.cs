class TaxCalculator:Tax
{
    float _grossDividens, _grossOther, _grossCapitol, _grossW2, _expence1099, _capitolLoss;
    TaxCalculator(){
        Calc_all_Income();
        Calc_Loss();
    }
    void Calc_Loss(){

    }
    void Calc_W2_Gross(){

    }
    void Calc_Capitol_gross(){

    }
    void Calc_Dividend(){

    }
    void Calc_Gross_1099(){

    }
    void Calc_Gross_Other(){

    }
    void Calc_all_Income(){
        Calc_Capitol_gross();
        Calc_Dividend();
        Calc_Gross_1099();
        Calc_W2_Gross();
        Calc_Gross_Other();
    }
    override public void Display(){
        
    }

}