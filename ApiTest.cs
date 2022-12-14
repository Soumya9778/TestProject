using APITest_Dec2022.API_Mappings;
using APITest_Dec2022.API_Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APITest_Dec2022
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public void GetusersAPITest()
        {
            var getUser = new GetUserMethod();
            var response = getUser.GetUserList();
            Assert.AreEqual(2, response.Page);
            Assert.AreEqual("Michael", response.Data[0].first_name);
        }

        [TestMethod]
        public void NewuserCreate()
        {
            var createUser = new CreateUserMethod();
            var response = createUser.UserCreation();
            Assert.AreEqual("Raj", response.Name);
        }

    }
}
