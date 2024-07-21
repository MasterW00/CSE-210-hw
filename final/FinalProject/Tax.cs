abstract
class Tax
{
    protected List<Form> _capitol = new List<Form>(), _1099 = new List<Form>(), _w2 = new List<Form>();
    protected List<float> _dividends = new List<float>(), _other_income = new List<float>(), _credits = new List<float>();
    protected float _1099Tax;
    protected int _age;
    protected bool married, joint, head;
    //Following ammounts change year to year 
    //mfj = married file joint, ss = next surviving spouse, mfs = married file seperate, head = head of household
    protected int _standard_single = 14600, _standard_mfj_ss = 29200, _standard_head = 21900;
    protected int _retirement_age = 50, _401k_deduct = 24000, _401k_added_retired = 7500;
    protected int _student_intrest_deduct = 2500;
    protected int _ira_deduct = 7000, _ira_retired = 8000;
    protected int _standard_1099_single = 12950, _standard_1099_mfj = 25900;
    protected float _1099_rate = 0.153f;
    protected List<(int,float)> brackets = new List<(int,float)>(){(11000, .1f), (44725, .12f), (95375, .22f), (182100, .24f), (231251, .32f), (578125, .35f), (0, .37f)};
    public struct Form{
        public string type{get; set; }
        public float income{get; set;}
        public float loss{get; set; }
        public List<float> cut = new List<float>();
        public Form(){

        }
    }
    protected Tax(){

    }
    public abstract void Display();
    protected void Display_Form(Form form){
        Console.WriteLine($"----------------\n${form.income}\n$-{form.loss}\n$-{form.cut}\n");
    }
}