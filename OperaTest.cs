using NUnit.Framework;

namespace homework;

[TestFixture]
public class OperaTest
{
    private Opera _opera;

    [SetUp]
    public void Setup()
    {
        _opera = new Opera("Traviata", 150, "Giuseppe Verdi");
        _opera.AuthorLibretto = "Francesco Maria Piave";
        _opera.Type = PerformanceType.Usual;
        _opera.StartDateAndTime = new DateTime(2023,10,18,18,30,0);
        _opera.SurchargeOrDiscount = 0.5;
        _opera.Description = "The most popular opera in the world";
    }

    [Test]
    public void ConstructorTest()
    {
        Assert.That(_opera.Name,Is.EqualTo("Traviata"));
        Assert.That(_opera.Type, Is.EqualTo(PerformanceType.Usual));
        Assert.That(_opera.Duration, Is.EqualTo(150));
        Assert.That(_opera.Composer, Is.EqualTo("Giuseppe Verdi"));
        Assert.That(_opera.StartDateAndTime, Is.EqualTo(new DateTime(2023,10,18,18,30,0)));
        Assert.That(_opera.SurchargeOrDiscount, Is.EqualTo(0.5));
        Assert.That(_opera.Description,Is.EqualTo("The most popular opera in the world"));
        Assert.That(_opera.AuthorLibretto, Is.EqualTo("Francesco Maria Piave"));
    }

    [Test]
    public void GetInfoTest()
    {
        var expectedInfo = "Название: Traviata. ";
        expectedInfo += "Продолжительность: 150 мин. ";
        expectedInfo +=
            "Описание: The most popular opera in the world. ";
        expectedInfo += "Дата и время начала: 18.10.2023 18:30:00. ";
        expectedInfo += "Время окончания: 21:00. ";
        expectedInfo += "Тип: Обычный. ";
        expectedInfo += "Надбавка/скидка: 0,5. ";
        expectedInfo += "Композитор: Giuseppe Verdi. Автор либретто: Francesco Maria Piave.";
        
        Assert.That(_opera.GetInfo(),Is.EqualTo(expectedInfo));
    }
}