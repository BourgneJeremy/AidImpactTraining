using System.ComponentModel.DataAnnotations;

namespace AidImpactTraining.Models.Account
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress, MaxLength(500)]
        [Display(Name = "Adresse e-mail")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Mot de passe")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Les mots de passes doivent être les mêmes")]
        [Display(Name = "Confirmer le mot de passe")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Se rappeler de moi")]
        public bool RememberMe { get; set; }
    }

}