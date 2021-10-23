using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JokesCatalog.Models
{
    public class Joke
    {
        public Joke()
        {
        }

        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        [Display(Name ="Date Created")]
        public DateTime DateCreated { get; set; }
    }
}
