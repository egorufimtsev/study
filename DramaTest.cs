using NUnit.Framework;

namespace homework;

[TestFixture]
public class DramaTest
{
    private Drama _drama;

    [SetUp]
    public void Setup()
    {
        _drama = new Drama("Seagull", 180, "Anton Pavlovich Chekhov" );
        _drama.Type = PerformanceType.Usual;
        _drama.StartDateAndTime = new DateTime(2023,10,18,18,30,0);
        _drama.SurchargeOrDiscount = 0.5;
        _drama.Description = "A special play, a symbol of the renewal that the Moscow Art Theater has brought to the world stage";
    }

    [Test]
    public void ConstructorTest()
    {
        Assert.That(_drama.Duration, Is.EqualTo(180));
        Assert.That(_drama.Name,Is.EqualTo("Seagull"));
        Assert.That(_drama.AuthorPlay, Is.EqualTo("Anton Pavlovich Chekhov"));
        Assert.That(_drama.Type, Is.EqualTo(PerformanceType.Usual));
        Assert.That(_drama.StartDateAndTime, Is.EqualTo(new DateTime(2023,10,18,18,30,0)));
        Assert.That(_drama.SurchargeOrDiscount, Is.EqualTo(0.5));
        Assert.That(_drama.Description,Is.EqualTo("A special play, a symbol of the renewal that the Moscow Art Theater has brought to the world stage"));
    }

    [Test]
    public void GetInfoTest()
    {
        var expectedInfo = "Название: Seagull. ";
        expectedInfo += "Продолжительность: 180 мин. ";
        expectedInfo +=
            "Описание: A special play, a symbol of the renewal that the Moscow Art Theater has brought to the world stage. ";
        expectedInfo += "Дата и время начала: 18.10.2023 18:30:00. ";
        expectedInfo += "Время окончания: 21:30. ";
        expectedInfo += "Тип: Обычный. ";
        expectedInfo += "Надбавка/скидка: 0,5. ";
        expectedInfo += "Автор пьесы: Anton Pavlovich Chekhov";
        
        Assert.That(_drama.GetInfo(),Is.EqualTo(expectedInfo));

    }
}