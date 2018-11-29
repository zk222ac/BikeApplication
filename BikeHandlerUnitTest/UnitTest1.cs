using BikeLibrary.handler;
using BikeLibrary.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BikeHandlerUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private BikesHandler handler;

        [TestInitialize]
        public void BeforeEachTest()
        {
            handler = BikesHandler.Instance;
            //handler.KoebteCykler.Clear();
        }


        [TestMethod]
        public void TestMethod1()
        {
            // arange
            int cntExpected = 5;

            // act
            int cnt = handler.GetAll().Count;

            // assert
            Assert.AreEqual(cntExpected, cnt);

        }

        [TestMethod]
        public void TestMethodId1()
        {
            // arange
            int sizeExpected = 12;
            int priceExpected = 3100;
            int id = 3;



            // act
            Bike bike = handler.GetFromId(id);

            // assert
            Assert.AreEqual(sizeExpected, bike.Size);
            Assert.AreEqual(priceExpected, bike.Price);

        }

        [TestMethod]
        public void TestMethodId2()
        {
            // arange
            int id = 32; // findes ikke

            // act
            Bike bike = handler.GetFromId(id);

            // assert
            Assert.IsNull(bike);

        }


        [TestMethod]
        public void TestMethodType1()
        {
            // arange
            int cntExpected = 3;
            string cType = "men";

            // act
            int cnt = handler.GetByType(cType).Count;

            // assert
            Assert.AreEqual(cntExpected, cnt);

        }

        [TestMethod]
        public void TestMethodType2()
        {
            // arange
            int cntExpected = 1;
            string cType = "kids";

            // act
            int cnt = handler.GetByType(cType).Count;

            // assert
            Assert.AreEqual(cntExpected, cnt);

        }

        [TestMethod]
        public void TestMethodType3()
        {
            // arange
            int cntExpected = 1;
            string cType = "lady";

            // act
            int cnt = handler.GetByType(cType).Count;

            // assert
            Assert.AreEqual(cntExpected, cnt);

        }


        [TestMethod]
        public void TestMethodType4()
        {
            // arange
            int cntExpected = 0;
            string cType = "notExists";

            // act
            int cnt = handler.GetByType(cType).Count;

            // assert
            Assert.AreEqual(cntExpected, cnt);

        }
    }
}
