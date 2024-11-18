using EqualityApp;

namespace PersonTestApp
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void AddTest()
        {
            //Arrange
            PersonManager manager = new PersonManager();
            Person expected = new Person(1, "anil", 1000);

            //act
            Person actual = manager.GetData();           

            //asert
            Assert.AreEqual(expected, actual);
            //expected.Equals(actual)
        }
    }
}