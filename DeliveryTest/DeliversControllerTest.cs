//using DeliveryProject.Controllers;
//using DeliveryProject.Models;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DeliveryTest
//{
//    public class DeliversControllerTest
//    {
//        private FakeContext fakeContext = new FakeContext();

//        [Fact]
//        public void Get_ReturnList()
//        {

//            var controller = new DeliversController(fakeContext);
//            var result = controller.Get();
//            Assert.IsType<List<Delivers>>(result);
//        }

//        [Fact]
//        public void Get_ReturnDeliver()
//        {
//            var id = 2;
//            var controller = new DeliversController(fakeContext);
//            Assert.IsType<OkObjectResult>(controller.Get(id));
//        }

//        [Fact]
//        public void Post_add_deliver()
//        {
//            var controller = new DeliversController(fakeContext);
//            Delivers newd = new Delivers { Id = 3, Name = "chani", Address = "nicest street",Email="fjlks@gmail.com", PhoneNumber = "0213212321" };
//            var result = controller.Post(newd);
//            Assert.IsType<OkObjectResult>(result);
//        }
//        [Fact]
//        public void Put_updateDeliver()
//        {
//            Delivers newD = new Delivers { Id = 2, Name = "chni", Address = "nist street", Email = "fs@gmail.com", PhoneNumber = "0245412321" };
//            var controller = new DeliversController(fakeContext);
//            var result = controller.Put(1, newD);
//            Assert.IsType<OkObjectResult>(result);
//        }
//        [Fact]
//        public void Delete_deleteDeliver()
//        {
//            var controller = new DeliversController(fakeContext);
//            var id = 1;
//            var result = controller.Delete(id);
//            Assert.IsType<NoContentResult>(result);
//        }
//    }
//}
