using System.ComponentModel.DataAnnotations;

namespace L01P02_2019AP650_2019SM601.Models
{
    public class pedidos
    {
        [Key]


        [Display(Name = "ID")]

        public int pedidoId { get; set; }

        [Display(Name = "motorista ID")]

        public int motoristaId { get; set; }

        [Display(Name = "cliente ID")]

        public int clienteId { get; set; }

        [Display(Name = "Plato ID")]

        public int platoId { get; set; }


        [Display(Name = "cantidad")]

        public int cantidad { get; set; }

        [Display(Name = "Precio")]

        public decimal precio { get; set; }


    }
}

