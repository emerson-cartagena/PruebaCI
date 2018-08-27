using System.ComponentModel.DataAnnotations;


namespace PruebaCI.Models
{
    public class PersonaMetadata
    {
        [Display(Name = "ID")]
        public int Id;

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string Nombre;

        [Display(Name = "Dirección")]
        public string Direccion;

        [Display(Name = "Telefono")]
        public string Telefono;

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "Debe ingresar edad")]
        public int Edad;

        [Display(Name = "Correo electronico")]
        [Required(ErrorMessage = "Debe ingresar correo electronico")]
        public string Correo { get; set; }

    }
}