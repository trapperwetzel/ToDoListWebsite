using System.Xml.Linq;

namespace ToDoListWebApp.Models
{
    public class UserToDoList
    {
        static public List<ToDoListItem> UserList { get; set; } = new List<ToDoListItem>();


        public UserToDoList()
        {

        }

        // Constructor 
        public UserToDoList (List<ToDoListItem> AUserToDoList)
        {
            UserList = AUserToDoList;
            
        }


        // Methods

        internal void AddItem(ToDoListItem entry)
        {
            UserList.Add(entry);
        }





        

        internal void RemoveFromList(int number)
        {
            for (int i = 0; i < UserList.Count; i++)
            {
                if (i == number - 1)
                {
                    UserList.Remove(UserList[i]);
                    break;
                }
            }
        }
    }
}
