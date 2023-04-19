using FourPillarsApp;

namespace FourPillarsTests;

public class VehicleTest
{

    [Test]

    public void CreatesAVechileSuccesfully()
    {
        Vehicle v = new Vehicle();

        Assert.Pass();
    }


    [Test]
    public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
    {
        Vehicle v = new Vehicle();
        var result = v.Move(2);
        Assert.AreEqual(20, v.Position);
        Assert.AreEqual("Moving along 2 times", result);
    }

    [Test]
    public void WhenADefaultVehicleMovesThreeTimesItsPositionIs30()
    {
        Vehicle v = new Vehicle();
        var result = v.Move(3);
        Assert.AreEqual(30, v.Position);
        Assert.AreEqual("Moving along 3 times", result);
    }

    [Test]
    public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
    {
        Vehicle v = new Vehicle(5, 40);
        var result = v.Move();
        Assert.AreEqual(40, v.Position);
        Assert.AreEqual("Moving along", result);

      

    }

    [TestCase(10)]
    [TestCase(50)]
    [TestCase(-20)]

    public void ReturnsCorrectSpeed(int speed)
    {
        Vehicle v = new Vehicle(10, speed);
        int actualSpeed = v.Speed;
        int expectedSpeed = speed;

        Assert.That(expectedSpeed, Is.EqualTo(actualSpeed));
    }

   
    [TestCase(-50)]

    public void ReturnsCorrectNumberOfPassengers(int amountOfPassengers)
    {
        Vehicle v = new Vehicle();
       

        Assert.That(amountOfPassengers, Is.EqualTo(v.NumPassengers));
    }

    [TestCase(-50)]
    [TestCase(-20)]
    [TestCase(-10)]
    [TestCase(-25)]
    public void ReturnsZeroPassengersWhenAmounOfPassengersIsNegative(int amountOfPassengers)
    {
        Vehicle v = new Vehicle();
        v.NumPassengers = amountOfPassengers;
        int expectedResult = 0;

        Assert.That(expectedResult, Is.EqualTo(v.NumPassengers));
    }
}