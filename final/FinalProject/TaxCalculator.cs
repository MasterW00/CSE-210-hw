class TaxCalculator:TaxForm
{
    float _dividensGross, _otherGross, _capitolGross, _w2Gross, _1099Gross, _1099Expence, _capitolLoss, _creditTotal = 0;
    float _grossIncome, _deductions, _1099Adjusted, _agi;
    float _taxGross, _taxAdjusted;
    (int, float) _bracket;
    public TaxCalculator(){
        Gross_Income();
        Taxes_1099();
        CompareDeductions();
        Total_Credit();
        Adjust_Tax();
    }
    float Collect_Tax_Break_Info(){
        float deductions = 0;
        Console.Clear();
        Console.WriteLine("REMINDER: FOCUS on bolded words, you can enter nothing for $0");
        Console.WriteLine($"THIS YEAR: ");
        UserIn.Prompt("How much have you paid in Student Loan INTREST", out float x);
        if (x > _student_intrest_deduct){
            x = _student_intrest_deduct;
        }
        deductions += x;
        UserIn.Prompt("How much have YOU contributed to your 401(k)", out x);
        if(x > _401k_added_retired + _401k_deduct && _age >= _retirement_age){
            x = _401k_added_retired + _401k_deduct;
        }
        else if (x > _401k_deduct){
            x = _401k_deduct;
        }
        deductions += x;
        UserIn.Prompt("How much did you put in IRA COMBINED", out x);
        if(x > _ira_retired && _age >= _retirement_age){
            x = _ira_retired;
        }
        if(x > _ira_deduct){
            x = _ira_deduct;
        }
        deductions += x;
        UserIn.Prompt("How much have you contributed to your Health Savings Account?", out x);
        deductions += x;
        deductions += _1099Tax / 2;
        return deductions;
    }
    float Adjust_Income(float income){
        return _grossIncome - _deductions - _capitolLoss;
    }
    void Taxes_1099(){
        Expences_1099();
        Adjust_1099();
        _1099Tax = _1099Adjusted * _1099_rate;
    }
    void Total_Loss(){
        foreach(Form form in _capitol){
            _capitolLoss += form.loss;
        }
    }
    void Gross_W2(){
        foreach(Form form in _w2){
            _w2Gross += form.income;
        }
    }
    void Gross_Capitol(){
        foreach(Form form in _capitol){
            _capitolGross += form.income;
        }
    }
    void Total_Dividend(){
        foreach(float form in _dividends){
            _dividensGross += form;
        }
    }
    void Gross_1099(){
         foreach(Form form in _1099){
            _1099Gross += form.income;
        }
    }
    void Gross_Other(){
        foreach(float form in _other_income){
            _otherGross += form;
        }
    }
    void Expences_1099(){
        foreach(Form form in _1099){
            foreach(float exp in form.cut){
                _1099Expence += exp;
            }
        }
    }
    void Adjust_1099(){
        _1099Adjusted = _1099Gross - _1099Expence;
    }
    (int, float) Get_TaxBracket(float income){
        foreach((int,float) bracket in brackets){
            if(_agi < bracket.Item1){
                return bracket;
            }
        }
        return brackets[brackets.Count - 1];
    }
    void CompareDeductions(){
        float deductions = Collect_Tax_Break_Info();
        int status = FilingStatus();
        float agi = Adjust_Income(_grossIncome);
        float standard_agi = _grossIncome - status;
        (int,float) standard_bracket = Get_TaxBracket(standard_agi), itemized_bracket = Get_TaxBracket(agi);
        float tax_standard = standard_agi * standard_bracket.Item2, tax_itemized = agi * itemized_bracket.Item2;
        if(tax_standard < tax_itemized){
            _agi = standard_agi;
            _deductions = status;
            _taxGross = tax_standard;
            _bracket = standard_bracket;
        }
        else{
            _agi = agi;
            _deductions = deductions;
            _taxGross = tax_itemized;
            _bracket = itemized_bracket;
        }
    }
    int FilingStatus(){
        if(married){
            if(joint){
                return _standard_mfj_ss;
            }
            if(head){
                return _standard_head;
            }
            else{
                return _standard_mfj_ss;
            }
        }
        else{
            return _standard_single;
        }
    }
    void Gross_Income(){
        Gross_Capitol();
        Total_Dividend();
        Gross_1099();
        Gross_W2();
        Gross_Other();
        _grossIncome = _1099Adjusted + _w2Gross + _otherGross + _capitolGross + _dividensGross;
    }
    void Total_Credit(){
        foreach(float duct in _credits){
            _creditTotal += duct;
        }
    }
    void Adjust_Tax(){
        _taxAdjusted = _taxGross - _creditTotal;
    }
    override public void Display(){
        Console.WriteLine($"Gross income: %{_grossIncome}\nDeductions: -${_deductions}\nAdjusted: ${_agi}\nBracket:{_bracket.Item2*100}%\nGross Tax: {_taxGross}\nAdjusted Tax:{_taxAdjusted}");
    }

}