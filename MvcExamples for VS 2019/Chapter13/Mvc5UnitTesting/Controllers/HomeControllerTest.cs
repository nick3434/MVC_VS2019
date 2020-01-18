using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mvc5Existing.Controllers;
using System.Web.Mvc;

namespace Mvc5UnitTesting.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_ReturnResult_IsNotNull()
        {
            //Arrange(初始化、配置、設定)
            HomeController controller = new HomeController();

            //Act(動作執行)
            ViewResult result = controller.Index() as ViewResult;

            //Assert(斷言,評估執行結果是否符合預期)
            Assert.IsNotNull(result);
        }
    }
}
