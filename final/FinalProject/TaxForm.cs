//inheritance!! :o
class TaxForm:Tax
{

    public TaxForm(){
        Collect_all_Forms();
        Personal_Info();
    }
    Form NewForm(){
        Form form = new Form();
        return form;
    }
    void Personal_Info(){
        UserIn.Prompt("How old are you?", out _age, true);
        UserIn.Prompt("Are you married", out married);
        if(married){
            UserIn.Prompt("Are you filing jointly to your spouse?", out joint);
            UserIn.Prompt("Are you the head of the household?", out head);    
        }  
    }
    void Collect_W2(){
        UserIn.Prompt("How many W2 forms do you have", out int _ifw2, true);
        if(_ifw2 > 0){
            for(int x = 0; x < _ifw2; x++){
                Form w2 = NewForm();
                UserIn.Prompt($"enter is W2 {x + 1} gross income", out float put);
                w2.income = put;
                _w2.Add(w2);
            }
        }
    }
    void Collect_1099(){
        UserIn.Prompt("How many 1099 forms do you have", out int _if1099, true);
        if(_if1099 > 0){
            for(int x = 0; x < _if1099; x++){
                Form form = NewForm();
                UserIn.Prompt($"What is 1099 {x + 1} gross income", out float put);
                form.income = put;
                UserIn.Prompt($"What is 1099 {x + 1} loss", out put);
                form.loss = put;
                UserIn.Prompt($"Enter 1099 {x + 1} expences <enter nothing to continue>", out put);
                UserIn.PopulateList<float>("+", form.cut, UserIn.ParseFloat);
                _1099.Add(form);
            }
        }
    }
    void Collect_Capitol(){
        UserIn.Prompt("How many Capitols do you have", out int _ifcapitol, true);
        if(_ifcapitol > 0){
            for(int x = 0; x < _ifcapitol; x++){
                Form form = NewForm();
                UserIn.Prompt($"What is Capitol {x + 1} gain", out float put);
                form.income = put;
                UserIn.Prompt($"What is Capitol {x + 1} loss", out put);
                form.loss = put;
                _capitol.Add(form);
            }
        }
    }
    void Collect_Dividends(){
        UserIn.Prompt("How many dividends have you gotten (total yearly ammount per capitol)", out int _ifdividend, true);
        if(_ifdividend > 0){
            for(int x = 1; x <= _ifdividend; x++){
                UserIn.Prompt($"What is dividend {x} income", out float put);
                _dividends.Add(put);
            }
        }
    }
    void Collect_Other_Income(){
        UserIn.Prompt("How many other incomes have you gotten", out int _ifother, true);
        if(_ifother > 0){
            for(int x = 1; x <= _ifother; x++){
                UserIn.Prompt($"How much is {x} income", out float put);
                _other_income.Add(put);
            }
        }
    }
    void Collect_Credits(){
        UserIn.PopulateList<float>("+",_credits,UserIn.ParseFloat);
    }
    void Collect_all_Forms(){
        Collect_W2();
        Collect_1099();
        Collect_Capitol();
        Collect_Dividends();
        Collect_Other_Income();
        Collect_Capitol();
    }
    override public void Display(){
        Console.Clear();
        Console.WriteLine($"W2 Forms");
        foreach(Form x in _w2){
            Display_Form(x);
        }
        Console.WriteLine($"1099 Forms");
        foreach(Form x in _1099){
            Display_Form(x);
        }
        Console.WriteLine($"Capitol Gains");
        foreach(Form x in _capitol){
            Display_Form(x);
        }
        Console.Write($"Dividens: ");
        foreach(float x in _dividends){
            Console.Write($"{x}, ");
        }
        Console.WriteLine();
        foreach(float x in _other_income){
            Console.Write($"{x}, ");
        }
        Console.WriteLine($"");
    }
}
