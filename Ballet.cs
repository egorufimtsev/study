namespace homework;

public class Ballet : Performance
{
    public string Composer { get; set; }
    public string Choreographer { get; set; }

    public Ballet(string name, int duration, string composer) : base(name, duration)
    {
        Composer = composer;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $" Композитор: {Composer}. Хореограф: {Choreographer}.";
    }
}