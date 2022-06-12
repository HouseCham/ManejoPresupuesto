using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 50, ErrorMessage = "El nombre de la categoria no debe exceder los 50 caracteres")]
        public string Nombre { get; set; }

        [Display(Name = "Tipo de Operacion")]
        public TipoOperacion TipoOperacionId { get; set; }

        public int UsuarioId { get; set; }
    }
}
