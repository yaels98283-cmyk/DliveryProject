//using DeliveryProject.Controllers;
//using Delivery.Core.Models;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Text;
//using System.Threading.Tasks;

//namespace DeliveryTest
//{
//    public class PackagesControllerTest
//    {
//        private FakeContext fakeContext=new FakeContext();
//        [Fact]
//        public void Get_ReturnList()
//        {

//            var controller = new PackagesController(fakeContext);
//            var result = controller.Get();
//            Assert.IsType<List<Packages>>(result);
//        }
//        [Fact]
//        public void Get_ReturnPackage()
//        {
//        var code = 1;
//        var controller = new PackagesController(fakeContext);
//        Assert.IsType<OkObjectResult>(controller.Get(code));
//        }

//        [Fact]
//        public void Post_add_package()
//        {
//            var controller=new PackagesController(fakeContext);
//            Packages newp=new Packages { Code=2,DeliverID=1,Description="nice package", RecipientID=1,Status=StausP.onHold };
//            var result= controller.Post(newp);
//            Assert.IsType<OkObjectResult>(result);
//        }
//        [Fact]
//        public void Put_updatePackage()
//        {
//            Packages newp = new Packages { Code = 2, DeliverID = 1, Description = "update p", RecipientID = 1, Status = StausP.onHold };
//            var controller = new PackagesController(fakeContext);
//            var result = controller.Put(1, newp);
//            Assert.IsType<OkObjectResult>(result);
//        }
//        [Fact]
//        public void Delete_deletePackage()
//        {
//            var controller= new PackagesController(fakeContext);
//            var code = 1;
//            var result=controller.Delete(code);
//            Assert.IsType<NoContentResult>(result);
//        }


//    }
//}
