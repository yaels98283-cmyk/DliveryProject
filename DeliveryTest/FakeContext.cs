//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DeliveryProject;
//using Delivery.Core.Models; 

//namespace DeliveryTest
//{
//    internal class FakeContext: IDataContext
//    {
//        public List<Delivers> delivers { get; set; }
//        public List<Packages> packages { get; set; }
//        public List<Recipients> recipients { get; set; }
//        public FakeContext()
//        {
//            delivers = new List<Delivers> { new Delivers { Id = 2, Address = "hashmer 3", Email = "o@gmail.com", Name = "rubi", PhoneNumber = "08765553234" },
//                                                                       new Delivers{ Id = 4, Address = "yeuusa", Email = "d@gmail.com", Name = "si", PhoneNumber = "08767657234"} };
//            packages = new List<Packages> { new Packages { Code = 1, DeliverID = 4, Description = "toys", RecipientID = 3, Status = StausP.onHold } };

//            recipients = new List<Recipients> { new Recipients { Id=3,Name="nusi",Address="yus 2",Email="skf@gmail.com",PhoneNumber="0987656787"},
//                                                                       new Recipients{ Id =5, Address = "yeuausa", Email = "do@gmail.com", Name = "sisisi", PhoneNumber = "08767657234"} };
//        }   
//    }
//}
