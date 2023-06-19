namespace homework;

public class Opera : Performance
{
    public string Composer { get; set; }
    public string AuthorLibretto { get; set; }

    public Opera(string name, int duration, string composer) : base(name, duration)
    {
        Composer = composer;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $" Композитор: {Composer}. Автор либретто: {AuthorLibretto}.";
    }
}