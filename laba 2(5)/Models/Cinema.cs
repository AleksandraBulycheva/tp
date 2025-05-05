using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace sasha_2.Models
{
    public class Cinema
    {
        public int Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Адрес")]
        public string Address { get; set; }

        [DisplayName("Телефон")]
        public string Phone { get; set; }

        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Количество залов")]
        public int NumberOfHalls { get; set; }

        [DisplayName("Год основания")]
        public int EstablishedYear { get; set; }
    }
}
