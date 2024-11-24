namespace ToDoListWebApp.Models
{
    public class ToDoListItem
    {

        public int ID { get; set; }
        public string Task { get; set; }

        public bool IsCompleted { get; set; }

        public ToDoListItem():this(-1,"N/A",false)
        {

        }

        public ToDoListItem(string aTask):this(1,aTask,false)
        {
            this.Task = aTask;
        }
        public ToDoListItem(int aID, string aTask, bool aComplete)
        {

            this.ID = aID;
            this.Task = aTask;
            this.IsCompleted = aComplete;

        }




    }
}



