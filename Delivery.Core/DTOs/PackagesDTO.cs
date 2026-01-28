using Delivery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.DTOs
{
    public class PackagesDTO
    {
        public int Id { get; set; }
        public int DeliverID { get; set; }
        public int RecipientID { get; set; }
        public string Description { get; set; }
        public StausP Status { get; set; }
    }
}
