//inheritance!! :o
class TaxForm:Tax
{

    public TaxForm(){
        Collect_all_Forms();
    }
    Form NewForm(){
        Form form = new Form();
        return form;
    }
    void Collect_W2(){

        UserIn.Prompt("How many W2 forms do you have", out int _ifw2);
        if(_ifw2 > 0){
            for(int x = 0; x < _ifw2; x++){
                Form w2 = NewForm();
                UserIn.Prompt($"What is W2 {x + 1} gross income", out float put);
                w2.income = put;
                UserIn.Prompt($"What is W2 {x + 1} cuts", out put);
                w2.cut = put;
                _w2.Add(w2);
            }
        }
    }
    void Collect_1099(){
        UserIn.Prompt("How many 1099 forms do you have", out int _if1099);
        if(_if1099 > 0){
            for(int x = 0; x < _if1099; x++){
                Form form = NewForm();
                UserIn.Prompt($"What is 1099 {x + 1} gross income", out float put);
                form.income = put;
                UserIn.Prompt($"What is 1099 {x + 1} loss", out put);
                form.loss = put;
                UserIn.Prompt($"What is 1099 {x + 1} expence", out put);
                form.cut = put;
                _1099.Add(form);
            }
        }
    }
    void Collect_Capitol(){
        UserIn.Prompt("How many Capitols do you have", out int _ifcapitol);
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
        UserIn.Prompt("How many dividends have you gotten (total yearly ammount per capitol)", out int _ifdividend);
        if(_ifdividend > 0){
            for(int x = 1; x <= _ifdividend; x++){
                UserIn.Prompt($"What is dividend {x} income", out float put);
                _dividends.Add(put);
            }
        }
    }
    void Collect_Other(){
        UserIn.Prompt("How Much other income have you recived", out other_income);
    }
    void Collect_all_Forms(){
        Collect_W2();
        Collect_1099();
        Collect_Capitol();
        Collect_Dividends();
        Collect_Other();
    }
    override public void Display(){
        foreach(Form x in _w2){
            Console.WriteLine($"{x}");
        }
        foreach(Form x in _1099){
            Console.WriteLine($"{x}");
        }
        foreach(Form x in _capitol){
            Console.WriteLine($"{x}");
        }
        Console.WriteLine($"Dividens");
        foreach(float x in _dividends){
            Console.Write($"{x}, ");
        }
        Console.WriteLine();
        Console.WriteLine($"{other_income}");
    }
}