namespace ToDoListWebApp.Models
{
    public class ToDoListItem
    {

        public static int _idCounter = 0;

        public int ID { get; set; }
        public string Task { get; set; }
        public bool IsCompleted { get; set; }

        public ToDoListItem()
        {
            ID = ++_idCounter; // Automatically increment ID
            Task = "N/A";
            IsCompleted = false;
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



