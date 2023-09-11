using System.ComponentModel.DataAnnotations;

namespace BiebCWebsite.Models
{
    public class ItemModel
    {
        [Key]
        public int Id { get; set; }

        // hoe vaak is die verlengt? ... dat doe je door  +1 en als hij het niet kan een message error mee geven naar user.
        // 
        // uitleen datum
        // terug breng datum ... is niet meer uitgleend...user+item ver reken
        // datum uitlenen vegelijken datum vandaag... x dagen op basis van abonomnet user
    }
}
