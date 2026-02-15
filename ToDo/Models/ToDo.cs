using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ToDoDemo.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "please enter a description .")]
        public string Discription { get; set; } = string.Empty;

        [Required(ErrorMessage = "please enter a due date .")]

        public DateTime? DueDate { get; set; }
        [Required(ErrorMessage = "please enter a category .")]

        public string CategoryId { get; set; } = string.Empty;

        [ValidateNever]

        public Category? Category { get; set; } = null;
        [Required(ErrorMessage = "please enter a status .")]

        public string StatusId { get; set; } = string.Empty;

        [ValidateNever]

        public Status? Status { get; set; } = null;

        public bool Overdue => StatusId == "open" && DueDate < DateTime.Today;






    }
}
