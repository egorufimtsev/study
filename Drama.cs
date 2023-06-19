namespace homework;

public class Drama : Performance
{
    public string AuthorPlay { get; set; }

    public Drama(string name, int duration, string authorPlay) : base(name, duration)
    {
        AuthorPlay = authorPlay;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $" Автор пьесы: {AuthorPlay}";
    }
}