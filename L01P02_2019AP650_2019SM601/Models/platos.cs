using System.ComponentModel.DataAnnotations;

namespace L01P02_2019AP650_2019SM601.Models
{
    public class platos
    {
        [Key]

        [Display(Name = "ID")]

        public int platoId { get; set; }

        [Display(Name = "Nombre de plato")]

        public string? nombrePlato{ get; set; }

        [Display(Name = "Precio")]

        public decimal precio { get; set; }
    }
}

