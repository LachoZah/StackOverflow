using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public int User_Id { get; set; }

        public string title { get; set; }
       
        public int vote { get; set; }

        public string body { get; set; }
    }
}