using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mvc5WebApp.Controllers;
using Mvc5WebApp.Models;

namespace Mvc5WebApp.Tests.Controllers
{
    [TestClass]
    public class ProductsControllerTest
    {
        //測試Action回傳結果不是Null值
        [TestMethod]
        public void ProductsList_ReturnResult_IsNotNull()
        {
            //Arrange(初始化、配置、設定)
            ProductsController controller = new ProductsController();

            //Act(動作執行)
            ViewResult result = controller.ProductsList() as ViewResult;

            //Assert(斷言,評估執行結果是否符合預期)
            Assert.IsNotNull(result);
        }

        //測試傳入不同id值尋找產品，依不同id值回傳的結果型別是否符合預期
        [TestMethod]
        public void FindProductById_DifferentIdValue_IsExpectedType()
        {
            // Arrange
            ProductsController controller = new ProductsController();

            // Act
            //Find Product by ID
            var result1 = controller.FindProductById(null) as HttpNotFoundResult;
            var result2 = controller.FindProductById(0) as HttpNotFoundResult;
            var result3 = controller.FindProductById(3) as ViewResult;
            var result4 = controller.FindProductById(2) as RedirectToRouteResult;

            //Assert
            //判斷傳入不同參數時, 其回傳型別是否符合預期
            Assert.IsInstanceOfType(result1, typeof(HttpNotFoundResult));
            Assert.IsInstanceOfType(result2, typeof(HttpNotFoundResult));
            Assert.IsInstanceOfType(result3, typeof(ViewResult));
            Assert.IsInstanceOfType(result4, typeof(RedirectToRouteResult));
        }

        //測試執行轉向時，目標控制器與動作方法名稱是否符合預期
        [TestMethod]
        public void FindProductById_Redirect_ControllerActionIsExpected()
        {
            // Arrange
            ProductsController controller = new ProductsController();

            // Act
            //Find Product by ID
            var result = controller.FindProductById(2) as RedirectToRouteResult;

            //Assert
            Assert.AreEqual("Products", result.RouteValues["controller"]);
            Assert.AreEqual("ProductsList", result.RouteValues["action"]);
        }

        //測試Product產品數量是否符合預期
        [TestMethod]
        public void ProductsList_CountModel_ProductNumbersIsExpected()
        {
            //Arrange
            ProductsController controller = new ProductsController();

            //Act
            var result = controller.ProductsList() as ViewResult;
            int count = (result.Model as List<Product>).Count();
            //int numbers = ((List<Product>)result.Model).Count;

            //Assert
            Assert.AreEqual(3, count);
        }
    }
}
