class Skill : Goal
{
    public Enemy _enemy;
    static public List<Skill> _skills = new List<Skill>();
    List<Objective> _objectives = new List<Objective>();
    public int _lvl = 0;
    public Skill(string desc):base(desc){
        _skills.Add(this);
    }
    public override void Acheivment(){
        Console.WriteLine($"Enter the number of the objective you want to complete");
        try
            {
                _objectives[int.Parse(Console.ReadLine()) - 1].Acheivment();
                 Console.WriteLine($"Hooray! your power is increacing");
                _xp += 27;
                LevelUp();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine($"Not in list");
            }
    }
    protected override void LevelUp(){
        if(_xp > _lvl * 0.2 / Math.Log2(_lvl)){
            _lvl ++;
        }
        Console.WriteLine($"Level Up: {_title}");
        _enemy.LoseXp();
    }
    public override void Display(){
        Console.WriteLine($"{_title} XP:{_xp/(_lvl + 1)} Lvl:{_lvl} ");
        foreach(Objective obj in _objectives){
            Console.Write($"\t");
            obj.Display();
        }
        Console.WriteLine($"");
        _enemy.Display();
        Console.WriteLine($"");
    }
    public void Add_Objective(string objective){
        _objectives.Add(new Objective(objective));
    }
    public void Add_Objective(string objective, int num){
        _objectives.Add(new Objective(objective, num));
    }
    public void CreateEnemy(){
        new Enemy($"The enemy of your {_title}",this);
    }
    
}