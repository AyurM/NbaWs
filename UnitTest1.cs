using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckLongVin()
        {
            //� ������ ������ �����������, ��� �������� ������� ������
            //����� ���������� ��� ������������ VIN
            string testVin = "QWE356ABNMU7908ASDJUIQ";
            Assert.AreEqual(false, MyLibrary.VinCheck.CheckVIN(testVin));
        }

        [TestMethod]
        public void CheckShortVin() {
            //� ������ ������ �����������, ��� �������� �������� ������
            //����� ���������� ��� ������������ VIN
            string testVin = "QWE356ABN";
            Assert.AreEqual(false, MyLibrary.VinCheck.CheckVIN(testVin));
        }

        [TestMethod]
        public void CheckVinWithWrongSerialNumber() {
            //���� � ������ ��������� 6 �������� �� �������� �������, �� 
            //������ ����� ���������� ��� ������������ VIN
            string testVin = "QWE356ABNYU138E95";
            Assert.AreEqual(false, MyLibrary.VinCheck.CheckVIN(testVin));
        }

        [TestMethod]
        public void CheckCorrectVIN() {
            //���� ������ �������� ���������� VIN, �� ����� 
            //������ ������� true
            string testVin = "4JGBF71E47A278782";
            Assert.AreEqual(true, MyLibrary.VinCheck.CheckVIN(testVin));
        }
    }
}
