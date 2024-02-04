using Laba9;
using NuGet.Frameworks;
using System.Runtime.ExceptionServices;
namespace TestMark
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_1()
        {
            //Arrange
            Mark expected1 = new Mark();                     
            //Act
            Mark actual1 = new Mark();                       
            //Assert
            Assert.AreEqual(expected1.NameLimit, actual1.NameLimit);
            Assert.AreEqual(expected1.MarkLimit, actual1.MarkLimit);                        
        }
        [TestMethod]
        public void TestMethod1_2()
        {
            Mark expected2 = new Mark("Программирование", 10);
            Mark actual2 = new Mark("Программирование", 10);
            Assert.AreEqual(expected2.NameLimit, actual2.NameLimit);
            Assert.AreEqual(expected2.MarkLimit, actual2.MarkLimit);
        }
        [TestMethod]
        public void TestMethod1_3()
        {
            Mark expected2 = new Mark("Программирование", 10);
            Mark actual2 = new Mark("Программирование", 10);
            Mark expected3 = new Mark(expected2);
            Mark actual3 = new Mark(actual2);
            Assert.AreEqual(expected3.NameLimit, actual3.NameLimit);
            Assert.AreEqual(expected3.MarkLimit, actual3.MarkLimit);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            Mark expected1 = new Mark("Проектный семинар", 0);
            //Act
            Mark actual1 = new Mark("Проектный семинар", 21);
            //Assert
            Assert.AreEqual(expected1.NameLimit, actual1.NameLimit);
            Assert.AreEqual(expected1.MarkLimit, actual1.MarkLimit);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string expected1 = "Неудовлетворительно";                                  
            //Act
            Mark mark1 = new Mark("ТОИ", 3);
            string actual1 = mark1.Transfer();
            string actual_1 = Mark.Transf(mark1);            
            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected1, actual_1);
  
        }
        [TestMethod]
        public void TestMethod4()
        {
            string expected2 = "Удовлетворительно";
            Mark mark2 = new Mark("Fizra", 5);
            string actual2 = mark2.Transfer();
            string actual_2 = Mark.Transf(mark2);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected2, actual_2);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string expected3 = "Хорошо";
            Mark mark3 = new Mark("Матанализ", 7);
            string actual3 = mark3.Transfer();
            string actual_3 = Mark.Transf(mark3);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected3, actual_3);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string expected4 = "Отлично";
            Mark mark4 = new Mark("Дискра", 9);
            string actual4 = mark4.Transfer();
            string actual_4 = Mark.Transf(mark4);
            Assert.AreEqual(expected4, actual4);
            Assert.AreEqual(expected4, actual_4);
        }
        [TestMethod]
        public void TestMethod7()
        {
            string expected = "ПРОГРАММИРОВАНИЕ";
            Mark m1 = new Mark("Программирование", 6);
            string actual = !m1;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            uint expected = 0;
            Mark m1 = new Mark("ТОИ", 10);
            uint actual = -m1;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            int expected = 5;
            Mark m1 = new Mark("Fizra", 5);
            int actual = (int)m1;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            bool expected = true;
            Mark m1 = new Mark("Прога", 6);
            bool actual = m1;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod11()
        {
            string excepted = "Новое название";
            Mark m1 = new Mark("Прога", 8);
            string newName = "Новое название";
            string actual = m1 / newName;
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestMethod12()
        {
            bool excepted = true;
            Mark m1 = new Mark("Прога", 8);
            Mark m2 = new Mark("Дискра", 6);
            bool actual = m1 >= m2;
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestMethod13()
        {
            bool excepted = false;
            Mark m1 = new Mark("Прога", 8);
            Mark m2 = new Mark("Дискра", 6);
            bool actual = m1 <= m2;
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestMethod14()
        {
            double excepted = 5;
            double n = 2;
            Mark m1 = new Mark("Прога", 3);
            double actual = n + m1;
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestMethod15()
        {
            MarkArray excepted = new MarkArray();
            MarkArray actual = new MarkArray();
            Assert.AreEqual(excepted.Length, actual.Length);
            for (int i = 0; i < excepted.Length; i++)
            {
                Assert.AreEqual(excepted[i].NameLimit, actual[i].NameLimit);
                Assert.AreEqual(excepted[i].MarkLimit, actual[i].MarkLimit);
            }
        }
        [TestMethod]
        public void TestMethod16()
        {
            MarkArray excepted = new MarkArray(2);
            MarkArray actual = new MarkArray(2);
            Assert.AreEqual(excepted.Length, actual.Length);
            for (int i = 0; i < excepted.Length; i++)
            {
                Assert.AreEqual(excepted[i].NameLimit, actual[i].NameLimit);
            }

        }
        [TestMethod]
        public void TestMethod17()
        {
            string[] names = { "ТОИ", "Матанализ", "Правовая грамотность" };
            uint[] marks = { 5, 10, 8 };
            MarkArray expected = new MarkArray(3, names, marks);
            MarkArray actual = new MarkArray(3, names, marks);
            Assert.AreEqual(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i].NameLimit, actual[i].NameLimit);
                Assert.AreEqual(expected[i].MarkLimit, actual[i].MarkLimit);
            }           
        }
        [TestMethod]
        public void TestMethod18()
        {
            MarkArray excepted1 = new MarkArray(2);
            MarkArray actual1 = new MarkArray(2);
            MarkArray excepted2 = new MarkArray(excepted1);
            MarkArray actual2 = new MarkArray(actual1);
            Assert.AreEqual(excepted2.Length, actual2.Length);
            for (int i = 0;i < excepted1.Length;i++)
            {
                Assert.AreEqual(excepted2[i].NameLimit, actual2[i].NameLimit);
            }
        }
        [TestMethod]
        public void TestMethod19()
        {
            Mark expected_m = new Mark("Прога", 6);
            MarkArray expected = new MarkArray(2);
            expected[1] = expected_m;
            Mark actual_m = new Mark("Прога", 6);
            MarkArray actual = new MarkArray(2);
            actual[1] = actual_m;
            Assert.AreEqual(expected[1].NameLimit, actual[1].NameLimit);
            Assert.AreEqual(expected[1].MarkLimit, actual[1].MarkLimit);

        }
        //[TestMethod]
        //public void TestMethod20()
        //{
        //    string[] names = { "ТОИ", "Матанализ", "Правовая грамотность" };
        //    uint[] marks = { 5, 10, 8 };
        //    MarkArray expected = new MarkArray(3, names, marks);
        //    MarkArray actual = new MarkArray(3, names, marks);
        //    Assert.AreEqual(expected.PrintArray(), actual.PrintArray());
        //}
    }
}