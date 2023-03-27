using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //CategoryId
        [Range(1, int.MaxValue, ErrorMessage ="Please Choose the Category.")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Range(10, int.MaxValue, ErrorMessage = "Amount should greater than 10 Dollars")]
        public int Amount { get; set; }

        public int Balance { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Note { get; set; }   

        public DateTime Date { get; set; } = DateTime.Now;

        [NotMapped]
        public string? CategoryTitleWithIcon
        {
            get
            {
                return Category == null ? "": Category.Icon + " " + Category.Title;
            }
        }

        [NotMapped]
        public string? TypeOfMoney
        {
            get
            {
                return ((Category == null || Category.Type == "Expenses") ? "- " : "+") + Amount.ToString("C0");
            }
        }

    }
}
