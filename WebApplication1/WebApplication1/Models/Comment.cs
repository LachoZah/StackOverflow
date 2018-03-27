using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int User_Id { get; set; }

        public string body { get; set; }

        public Question Question { get; set; }
    }
}