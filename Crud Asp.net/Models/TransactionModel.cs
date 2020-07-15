using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Asp.net.Models
{
   
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }

        
        
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "This Field is required.")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only")]
        [Column(TypeName = "nvarchar(12)")]
        public string AccountNumber { get; set; }

        
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This Field is required.")]
        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }

        
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This Field is required.")]
        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }

        
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This Field is required.")]
        [MaxLength(11)]
        [Column(TypeName = "nvarchar(11)")]
        public string SWIFTCode { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "This Field is required.")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
    }

}
