using FourPillarsApp;
namespace FourPillarsTests;


public class PersonTest
{


   
    [TestCase(-1)]
    [TestCase(-50)]
    [TestCase(-100)]
    public void GivenAgeIsBelowZero_ReturnsDefaultAge(int NegativeAge)
    {
        Person p = new Person();
        int expectedResult = 18; //default age
        var Actualresult = p.Age;
        Assert.That(expectedResult, Is.EqualTo(Actualresult));


    }


    [Test]

    public void GivenAgeInConstructor_ReturnsCorrectAge()
    {
        
        Person p = new Person(23);
        
        int actualAge = p.Age;

        int expectedAge = 23;

        Assert.That(expectedAge, Is.EqualTo(actualAge));

    }

    [Test]
    public void ReturnsFullName()
    {
        Person p = new Person("Ahmed","Bader");

        string actualName = p.GetFullName();

        string expectedName = "Ahmed Bader";

        Assert.That(expectedName, Is.EqualTo(actualName));
    }


    [Test]

    public void ReturnsFullNameWithTitle()
    {
        Person p = new Person("Ahmed", "Bader");

        string actualName = p.GetFullName("Mr");
        string expectedName = "Mr Ahmed Bader";

        Assert.That(expectedName, Is.EqualTo(actualName));
    }
}