using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptimizationEngine;

namespace OptimizationEngineTest
{
    ///
    [TestClass]
    public class DALTest
    {
        [TestMethod]
        public void DALConstructor()
        {
            bool ret = false;
            
            DAL dal = new DAL();
            if (File.Exists("OptimizationEngine.db"))
            {
                ret &= true;
            }
            
            Assert.IsTrue(ret);
        }
    }
}
