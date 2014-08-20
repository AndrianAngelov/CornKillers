namespace CornKillers.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Post
    {
        private ICollection<PostAnswer> answer;

        public Post()
        {
            this.answer = new HashSet<PostAnswer>();
        }

        public virtual ICollection<PostAnswer> Answers
        {
            get { return this.answer; }
            set { this.answer = value; }
        }

        //public PostType Type { get; set; }
    }
}
