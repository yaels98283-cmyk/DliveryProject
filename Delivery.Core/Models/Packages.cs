namespace Delivery.Core.Models
{
    public class Packages
    {
        public int Id { get; set; }
        public int DeliverID { get; set; }
        public int RecipientID { get; set; }
        public string Description { get; set; }
        public StausP Status { get; set; }

        public Delivers Deliver { get; set; }
        public Recipients recipient { get; set; }


        
    }
    public enum StausP
    {
         onHold,onWay,Got
    }
}

