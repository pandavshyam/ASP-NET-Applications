using Day1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDay1
{
    [TestFixture]
    public class UnitTesting
    {

        [SetUp]
        public void setUp()
        {
            // Setup initilization goes here
            // For e.g. creation of object
            // Setup will be called at the start of each test

        }

        [TearDown]
        public void CleanUp()
        {
            // After calling each test method this method will be called

        }

        [OneTimeSetUp]
        public void OneTime()
        {
            // Called only for one time
        }

        [OneTimeTearDown]
        public void CleanOneTime()
        {
            // Called one time at the end of all test methods
        }



        public object GetData(int id)
        {
            if (id == 100)
            {
                return "Some Data";
            }

            else if (id == 200)
            {
                throw new Exception();
            }

            else
                return new Customer(10, "abc", "xyz", CustomerType.Basic);
        }

        [Test]
        public void TestException()
        {
            //var i = GetData(200);
            Assert.Throws<Exception>(() => GetData(200));
        }

        [Test]
        public void GetData_int_string()
        {
            var i = GetData(100);
            Assert.IsInstanceOf<string>(i);
        }

        [Test]
        public void GetData_int_int()
        {
            var i = GetData(200);
            Assert.IsInstanceOf<int>(i);
        }

        [Test]
        public void GetData_int_Customer()
        {
            var i = GetData(10);
            Assert.IsInstanceOf<Customer>(i);
        }

        [Test]
        public void IsApplicableToDiscount_BasicCustomer_False()
        {
            //Arrange : DO the arrangement for calling unit under Test
            Customer cust = new Customer(10, "Sachin", "T", CustomerType.Basic);

            CustomerOrderService service = new CustomerOrderService();
            //Act

            //Call method under Test

            var Result = service.IsApplicableToDiscount(cust);

            //Assert: Check Actual output with excpected output

            //Assert.IsFalse(Result);

            Assert.AreEqual(false, Result);
        }

        [Test]
        public void GetDiscount_CustomBasic_RetTenPerDiscount()
        {
            //Arrange
            Customer cust = new Customer(10, "Mukta", "P", CustomerType.SpecialCustomer);
            Order order = new Order(10, 10, 10, 1000);
            CustomerOrderService service = new CustomerOrderService();
            //Act
            var result = service.GetDiscount(cust, order);
            //Assert
            Assert.AreEqual(500, result);
        }

        [Test]
        public void TestPassword_LessThan5Words_False()
        {
            UserViewModel uvm = new UserViewModel();
            bool result = uvm.TestPassword("Password@123");

            Assert.AreEqual(result, true);
        }

        [TestCase("abcdefg", false)]
        [TestCase("12345", false)]
        [TestCase("abcd890", false)]
        [TestCase("abcd1236@#", true)]
        public void TestPassword(string pwd, bool ExpResult)
        {
            UserViewModel vm = new UserViewModel();
            var Result = vm.TestPassword(pwd);

            Assert.AreEqual(ExpResult, Result);
        }

        public static IEnumerable<TestCaseData> init()
        {
            yield return new TestCaseData("acbcd", false).SetName("Only Chars").SetCategory("Cat1");
            yield return new TestCaseData("1234", false).SetName("Only Digits").SetCategory("Cat1");
            yield return new TestCaseData("abc123%$", true).SetName("Correct Input").SetCategory("Cat1");
        }

        [Test, TestCaseSource("init")]
        public void MultipleTest(string pwd, bool ExpResult)
        {
            UserViewModel vm = new UserViewModel();
            var Result = vm.TestPassword(pwd);

            Assert.AreEqual(ExpResult, Result);
        }

        [Test, Category("Range")]
        public void Test4([Range(0,10,1)] int value)
        {

        }

        [Test, Category("Random")]
        public void Test5([Random(0,10,5)] byte x)
        {

        }

        //public void Test4([Values(0, 1, 2, 3, 4, 5, 6)] int value)
        //{
        //
        //}


    }
}
