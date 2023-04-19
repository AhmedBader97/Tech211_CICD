using FourPillarsApp;
using System.Diagnostics.Metrics;

namespace FourPillarsTests;
public class AirPlaneTest
{

    [Test]

    public void ReturnAirPlaneObjectIfCreatedSuccessfully()
    {
        var a = new Airplane();
        Assert.Pass();
    }


    [Test]

    public void ReturnAmountOfTimesMovedCorrectly()
    {
        var a = new Airplane();
        var actualResult = a.Move(3);
        var expectedResult = 3 ;

        Assert.That(actualResult, Is.EqualTo(expectedResult.ToString()));
    }


    [TestCase(300)]
    [TestCase(500)]
    public void ReturnValueOfAltitudeCorrectly(int meters)
    {
        var a = new Airplane(0,meters);
        var actualResult = a.Altitude;
        var expectedResult = meters;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [TestCase(3,500)]
    public void ReturnValueOfAmountOfTimesMovedAndAltitudeCorrectly(int times, int altitude)
    {
        var a = new Airplane();

        var actualResult = a.Ascend(times,altitude);
        var expectedResult = "Moving along 3 times at an altitude of 500 meters.";

        Assert.That(actualResult, Is.EqualTo(expectedResult));

    }

    //[Test]
    //public void ReturnsCorrectToStringObject()
    //{
    //    var a = new Airplane();

    //    var actualResult = a.GetType();
    //    var expectedResult = "ClassesApp.Airplane";

    //    Assert.That(actualResult, Is.EqualTo(expectedResult));
    //}


    [TestCase(200)]
    public void ReturnsCorrectCapacity(int capacity)
    {
        var a = new Airplane(capacity,10);

        var actualResult = a.Capacity;
        var expectedResult = capacity;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void ReturnsCorrectSpeed()
    {
        var a = new Airplane(0,0,100,0,0);

        var actualResult = a.Speed;
        var expectedResult = 100;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [TestCase(100)]
    
    public void ReturnsCorrectPosition(int position)
    {
        var a = new Airplane();

        var actualResult = a.Position;
        var expectedResult = position;

        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }













}
