using Delivery.Core.Models;

namespace DeliveryProject.Models
{
    public class PackagesPostModel
    {
        public int DeliverID { get; set; }
        public int RecipientID { get; set; }
        public string Description { get; set; }
        public StausP Status { get; set; }

        public Delivers Deliver { get; set; }
        public Recipients Recipient { get; set; }

    }
}
