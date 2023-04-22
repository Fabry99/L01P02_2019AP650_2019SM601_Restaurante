using System.ComponentModel.DataAnnotations;

namespace L01P02_2019AP650_2019SM601.Models
{
    public class motoristas
    {
        [Key]
        [Display(Name = "ID")]

        public int motoristaId { get; set; }

        [Display(Name = "Nombre de motoriste")]

        public string? nombreMotorista { get; set; }

    }
}

