using NUnit.Framework;

namespace homework;

[TestFixture]
public class RepertoireTest
{
    private Repertoire _repertoire;
    private List<Performance> _listPerformances;

    [SetUp]
    public void Setup()
    {
        var one = new Performance("one",120){StartDateAndTime = new DateTime(2023, 7, 18, 18, 30, 0) };
        var two = new Performance("two",120){StartDateAndTime = new DateTime(2023, 7, 18, 18, 30, 0) };;

        var three = new Performance("three",120){StartDateAndTime = new DateTime(2023, 7, 18, 18, 30, 0) };;

        var four = new Performance("four",120){StartDateAndTime = new DateTime(2023, 7, 18, 18, 30, 0) };;
        var five = new Performance("five",120){StartDateAndTime = new DateTime(2023, 7, 18, 18, 30, 0) };;

        _listPerformances = new List<Performance>() { one, two, three, four, five };

        _repertoire = new Repertoire(MonthName.July, 2023, _listPerformances);
    }

    [Test]
    public void ConstructorTest()
    {
        Assert.That(_repertoire.Month, Is.EqualTo(MonthName.July));
        Assert.That(_repertoire.Year,Is.EqualTo(2023));
    }
    
    [Test]
    public void CountTest()
    {
        Assert.That(_repertoire.Count, Is.EqualTo(5));
    }
    
    [Test]
    public void IEnumerableTest()
    {
        var i = 0;

        foreach(var member in _repertoire)
            Assert.That(member, Is.SameAs(_listPerformances[i++]));
    }
}