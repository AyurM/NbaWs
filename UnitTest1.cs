using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckLongVin()
        {
            //¬ данном методе провер€етс€, что заведомо длинна€ строка
            //будет распознана как неправильный VIN
            string testVin = "QWE356ABNMU7908ASDJUIQ";
            Assert.AreEqual(false, MyLibrary.VinCheck.CheckVIN(testVin));
        }

        [TestMethod]
        public void CheckShortVin() {
            //¬ данном методе провер€етс€, что заведомо коротка€ строка
            //будет распознана как неправильный VIN
            string testVin = "QWE356ABN";
            Assert.AreEqual(false, MyLibrary.VinCheck.CheckVIN(testVin));
        }

        [TestMethod]
        public void CheckVinWithWrongSerialNumber() {
            //≈сли в строке последние 6 символов не €вл€ютс€ цифрами, то 
            //строка будет распознана как неправильный VIN
            string testVin = "QWE356ABNYU138E95";
            Assert.AreEqual(false, MyLibrary.VinCheck.CheckVIN(testVin));
        }

        [TestMethod]
        public void CheckCorrectVIN() {
            //≈сли строка €вл€етс€ правильным VIN, то метод 
            //должен вернуть true
            string testVin = "4JGBF71E47A278782";
            Assert.AreEqual(true, MyLibrary.VinCheck.CheckVIN(testVin));
        }
    }
}
