using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.ComponentModel.DataAnnotations;

namespace CornKillers.Models
{
    public class ApplicationUser
    {
        //private ICollection<Serial> serials;

        public ApplicationUser()
        {

        }

        //public int ApplicationUserID { get; set; } 

        public Guid ApplicationUserID { get; set; } 

        public string Name { get; set; }

        //public virtual ICollection<Serial> Serials
        //{
        //    get { return this.serials; }
        //    set { this.serials = value; }
        //}
    }
}
