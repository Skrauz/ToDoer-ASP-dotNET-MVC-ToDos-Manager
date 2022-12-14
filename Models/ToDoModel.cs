using System.ComponentModel.DataAnnotations;

namespace ToDoer.Models;
public class ToDo
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Task Name")]
    [Required]
    public string TodoName { get; set; } = "";

    public bool Complete { get; set; } = false;

    public DateTime? CreationDate {get; set;} = DateTime.Now;

    //if the deadline is given, add a time left table section
    public DateTime? Deadline {get; set;}

    //tags separated by coma
    public string? Tags {get; set;} = "";
}