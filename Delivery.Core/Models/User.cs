using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public eRole Role { get; set; }

        
    }
    public enum eRole
    {
        deliver, recipient
    }
}
