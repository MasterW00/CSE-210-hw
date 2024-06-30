abstract
class Goal
{   
    protected string _title;
    protected int _xp = 0;
    public Goal(string desc){
        _title = desc;
    }
    public abstract void Acheivment();
    protected abstract void LevelUp();
    public abstract void Display();
}