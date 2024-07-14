abstract
class Tax
{
    protected List<Form> _w2 = new List<Form>();
    protected List<Form> _capitol = new List<Form>();
    protected List<Form> _1099 = new List<Form>();
    protected List<float> _dividends = new List<float>();
    protected float other_income;
    public struct Form{
        public string type{get; set; }
        public float income{get; set;}
        public float loss{get; set; }
        public float cut{get; set; }
        public Form(){

        }
    }
    protected Tax(){

    }
    public abstract void Display();
}