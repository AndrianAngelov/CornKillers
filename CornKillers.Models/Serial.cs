namespace CornKillers.Models
{
    using System.Collections.Generic;

    public class Serial
    {
        private ICollection<ApplicationUser> applicationUsers;

        public Serial()
        {
            this.applicationUsers = new HashSet<ApplicationUser>();
        }

        public int SerialID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUsers
        {
            get { return this.applicationUsers; }
            set { this.applicationUsers = value; }
        }
    }
}
