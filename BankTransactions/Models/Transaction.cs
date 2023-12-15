using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Name")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(12, ErrorMessage = "  12 characters only")]
        public string AccountName { get; set; }

        [DisplayName("Beneficary Name")]
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "This field is required")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is required")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("Swift Code")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only")]
        public string SWIFTCode { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }
    }
}