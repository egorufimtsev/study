using System.ComponentModel.DataAnnotations;
using homework;
using NUnit.Framework;


[TestFixture]
public class PerformanceTest
{
    private static Performance performance;

    [SetUp]
    public void Setup()
    {
        performance = new Performance("Swan Lake", 160);
        
        performance.Description = "Swan Lake is the most popular and frequently performed ballet in the world";
        performance.StartDateAndTime = new DateTime(2023,10,18,18,30,0);
        performance.Type = PerformanceType.Usual;
        performance.SurchargeOrDiscount = 0.5;
    }

    [Test]
    public void ConstructorTest()
    {
        Assert.That(performance.Name, Is.EqualTo("Swan Lake"));
        Assert.That(performance.Duration, Is.EqualTo(160));
        Assert.That(performance.Type, Is.EqualTo(PerformanceType.Usual));
        Assert.That(performance.Description, Is.EqualTo("Swan Lake is the most popular and frequently performed ballet in the world"));
        Assert.That(performance.StartDateAndTime, Is.EqualTo(new DateTime(2023,10,18,18,30,0)));
        Assert.That(performance.SurchargeOrDiscount, Is.EqualTo(0.5));
    }

    [Test]
    public void CorrectEndTimeTest()
    {
        Assert.That(performance.EndTime, Is.EqualTo("21:10"));
    }

    [Test]
    public void GetInfoTest()
    {
        var expectedInfo = "Название: Swan Lake. ";
        expectedInfo += "Продолжительность: 160 мин. ";
        expectedInfo += "Описание: Swan Lake is the most popular and frequently performed ballet in the world. ";
        expectedInfo += "Дата и время начала: 18.10.2023 18:30:00. ";
        expectedInfo += "Время окончания: 21:10. ";
        expectedInfo += "Тип: Обычный. ";
        expectedInfo += "Надбавка/скидка: 0,5.";

        Assert.That(performance.GetInfo(),Is.EqualTo(expectedInfo));
    }

    [Test]
    public void CompareToTest()
    {
        var one = new Performance("one", 10) { StartDateAndTime = new DateTime(2023, 10, 18, 18, 30, 0) };
        var two = new Performance("two", 10) { StartDateAndTime = new DateTime(2023, 10, 18, 18, 30, 0) };
        var three = new Performance("three", 10) { StartDateAndTime = new DateTime(2022, 10, 18, 18, 30, 0) };
        var four = new Performance("hour", 10) { StartDateAndTime = new DateTime(2024, 10, 18, 18, 30, 0) };

        Assert.That(one.CompareTo(two), Is.EqualTo(0));
        Assert.That(one.CompareTo(three), Is.GreaterThan(0));
        Assert.That(one.CompareTo(four),  Is.LessThan(0));

    }
}