//using DeliveryProject.Controllers;
//using Delivery.Core.Models;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DeliveryTest
//{
//    public class RecipientsControllerTest
//    {
//        private FakeContext fakeContext=new FakeContext();
//        [Fact]
//        public void Get_ReturnList()
//        {

//            var controller = new RecipientsController(fakeContext);
//            var result = controller.Get();
//            Assert.IsType<List<Recipients>>(result);
//        }
//        [Fact]
//        public void Get_ReturnRecipient()
//        {
//            var id = 1;
//            var controller = new RecipientsController(fakeContext);
//            Assert.IsType<OkObjectResult>(controller.Get(id));
//        }

//        [Fact]
//        public void Post_add_recipient()
//        {
//            var controller = new RecipientsController(fakeContext);
//            Recipients newR = new Recipients { Id = 3, Name = "chani", Address = "nicest street", Email = "fjlks@gmail.com", PhoneNumber = "0213212321" };
//            var result = controller.Post(newR);
//            Assert.IsType<OkObjectResult>(result);
//        }
//        [Fact]
//        public void Put_updateRecipient()
//        {
//            Recipients newR = new Recipients { Id = 2, Name = "chni", Address = "nist street", Email = "fs@gmail.com", PhoneNumber = "0245412321" };
//            var controller = new RecipientsController(fakeContext);
//            var result = controller.Put(1, newR);
//            Assert.IsType<OkObjectResult>(result);
//        }
//        [Fact]
//        public void Delete_deleteRecipient()
//        {
//            var controller = new RecipientsController(fakeContext);
//            var id = 1;
//            var result = controller.Delete(id);
//            Assert.IsType<NoContentResult>(result);
//        }
//    }
//}
