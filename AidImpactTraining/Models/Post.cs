using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AidImpactTraining.Models
{
    public class Post
    {
        [Display(Name = "Titre de l'article")]
        [Required]
        [StringLength(100, MinimumLength = 5,
            ErrorMessage = "Le titre de l'article doit contenir entre 5 et 100 caractères")]
        public string Title { get; set; }

        public DateTime Posted { get; set; }

        public string Author { get; set; }

        [Display(Name = "Contenu de l'article")]
        [Required]
        [MinLength(100, ErrorMessage = "Le contenu de l'article doit faire au moins 100 caractères")]
        public string Body { get; set; }
    }
}
