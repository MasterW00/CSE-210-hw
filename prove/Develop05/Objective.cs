class Objective:Goal
{
    int _goal = 1;
    bool completed = false;
    public Objective(string desc, int goal):base(desc){
        _goal = goal;
    }
    public Objective(string desc):base(desc){
    }
    public override void Acheivment(){
        _xp ++;
        if(_xp >= _goal){
            LevelUp();
        }
    }
    protected override void LevelUp(){
        completed = true;
    }
    public override void Display(){
        for(int x = 0; x < _xp; x++){
            Console.Write($"0");
        }
        for(int x = 0; x < _goal - _xp; x++){
            Console.Write($"O");
        }
        Console.WriteLine($" {_title}");
    }

}