using System.ComponentModel.DataAnnotations;
namespace ToDoListWebApp.Models
{
    public class ToDoListItem
    {


        [Key]
        public int ID { get; set; }

        [Required]
        public string Task { get; set; }
        public bool IsCompleted { get; set; }

        public ToDoListItem()
        {
            
        }

        public ToDoListItem(string task) : this()
        {
            Task = task;
        }

        public ToDoListItem(int id, string task, bool isCompleted)
        {
            ID = id;
            Task = task;
            IsCompleted = isCompleted;
        }




    }
}



