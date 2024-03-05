using System.Collections;
using System.Text.RegularExpressions;

namespace TestRegualrExpression
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Regex r = new Regex(@"^[a-zA-z0-9]{4,20}@\w+\.+com$");
            string pat = "nandinink1947@gmail.com";

            
            bool Actual = RegularExpression.Program.Valid(r,pat);
            Assert.IsTrue(Actual);



        }
    }
}