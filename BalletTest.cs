using NUnit.Framework;

namespace homework;

[TestFixture]
public class BalletTest
{
    private Ballet _ballet;

    [SetUp]
    public void Setup()
    {
        _ballet = new Ballet("Nutcracker", 120, "Pyotr Ilyich Tchaikovsky");
        _ballet.Choreographer = "By Marius Petipa";
        _ballet.Type = PerformanceType.Usual;
        _ballet.Description = "The plot is based on E. T. A. Hoffman's fairy tale The Nutcracker and the Mouse King";
        _ballet.StartDateAndTime = new DateTime(2023,10,18,18,30,0);
        _ballet.SurchargeOrDiscount = 0.5;
    }

    [Test]
    public void ConstructorTest()
    {
        Assert.That(_ballet.Name,Is.EqualTo("Nutcracker"));
        Assert.That(_ballet.Choreographer, Is.EqualTo("By Marius Petipa"));
        Assert.That(_ballet.Type, Is.EqualTo(PerformanceType.Usual));
        Assert.That(_ballet.Duration, Is.EqualTo(120));
        Assert.That(_ballet.Composer, Is.EqualTo("Pyotr Ilyich Tchaikovsky"));
        Assert.That(_ballet.StartDateAndTime, Is.EqualTo(new DateTime(2023,10,18,18,30,0)));
        Assert.That(_ballet.SurchargeOrDiscount, Is.EqualTo(0.5));
        Assert.That(_ballet.Description,Is.EqualTo("The plot is based on E. T. A. Hoffman's fairy tale The Nutcracker and the Mouse King"));

    }

    [Test]
    public void GetInfoTest()
    {
        var expectedInfo = "Название: Nutcracker. ";
        expectedInfo += "Продолжительность: 120 мин. ";
        expectedInfo +=
            "Описание: The plot is based on E. T. A. Hoffman's fairy tale The Nutcracker and the Mouse King. ";
        expectedInfo += "Дата и время начала: 18.10.2023 18:30:00. ";
        expectedInfo += "Время окончания: 20:30. ";
        expectedInfo += "Тип: Обычный. ";
        expectedInfo += "Надбавка/скидка: 0,5. ";
        expectedInfo += "Композитор: Pyotr Ilyich Tchaikovsky. Хореограф: By Marius Petipa.";
        
        Assert.That(_ballet.GetInfo(),Is.EqualTo(expectedInfo));
    }
}