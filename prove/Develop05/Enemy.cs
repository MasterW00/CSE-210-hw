class Enemy:Skill
{
    string _name;
    public Enemy( string desc, Skill skill):base(desc){
        ChooseName();
        skill._enemy = this;
        _skills.Remove(this);

    }
    public override void Acheivment(){
        Console.WriteLine($"<{_name}> Im getting Stonger!");
        _xp += 23;
        LevelUp();
    }
    protected override void LevelUp(){
        if(_xp > _lvl * 0.2 / Math.Log2(_lvl)){
            _lvl ++;
        }
        Console.WriteLine($"Level Up: {_name}");
    }
    private void ChooseName(){
        Random rng = new Random();
        int a = rng.Next(0,6);
        List<string> names = new List<string>(){"Vader", "Maurcell", "Greg", "Vlad", "Domoinic", "Unhapinator", "Killjoy"};
        _name = names[a];
    }
    public void LoseXp(){
        _xp =- 51;
    }
    public override void Display(){
        Console.WriteLine($"Enemy: {_name} LVL:{_lvl}");
    }
}