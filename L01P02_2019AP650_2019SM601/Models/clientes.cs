using System.ComponentModel.DataAnnotations;

namespace L01P02_2019AP650_2019SM601.Models
{
    public class clientes
    {
        [Key]

        [Display(Name = "ID")]

        public int clienteId { get; set; }

        [Display(Name = "Nombre de cliente")]

        public string? nombreCliente { get; set; }

        [Display(Name = "Dirección")]

        public int direccion { get; set; }
    }
}

