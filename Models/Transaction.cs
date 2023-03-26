using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JupiterX.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; } 

        [Required]
        [Column(TypeName="nvarchar(10)")]
        public string AccountName { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string BeneficiaryName { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(50)")]
        public string BankName { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(10)")]
        public string SWIFTCode { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        public int Amount { get; set; } = 0;

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
