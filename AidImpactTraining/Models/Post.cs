using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AidImpactTraining.Models
{
    public class Post
    {
        // Code allowing to define what Entity Framework needs
        public long Id { get; set; }

        private string _key;

        public string Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value; }
        }

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
