using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTansactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "This Field Is Required.")]
        [MaxLength(12, ErrorMessage ="Maximum 12 number only")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Benificiary Name")]
        [Required(ErrorMessage = "This Field Is Required.")]
        public string BenificiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This Field Is Required.")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This Field Is Required.")]
        [MaxLength(11, ErrorMessage = "Maximum 11 number only")]
        public string SWIFTCode { get; set;}

        [Required(ErrorMessage = "This Field Is Required.")]
        public string Amount { get; set;}

        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
        public DateTime Date { get; set;}
    }
}
