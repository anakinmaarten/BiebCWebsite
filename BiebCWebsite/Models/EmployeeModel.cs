using System.ComponentModel.DataAnnotations;

namespace BiebCWebsite.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }


        public List<ItemModel>? Items { get; set; }
        public List<MovieModel>? Movies { get; set; }
        public List<CDModel>? CDs { get; set; }
        public List<BookModel>? Books { get; set; }

        public List<GuestModel>? Guests { get; set;}

    }
}
