using System.Xml.Linq;

namespace ToDoListWebApp.Models
{
    public class UserToDoList
    {
        static public List<ToDoListItem> UserList { get; set; } = new List<ToDoListItem>();

        static public int NextId => UserList.Count > 0 ? UserList.Max(t => t.ID) + 1 : 1;
        public UserToDoList()
        {

        }

        // Constructor 
        public UserToDoList (List<ToDoListItem> AUserToDoList)
        {

            UserList = AUserToDoList;
            
        }


        // Methods

        public void AddItem(ToDoListItem entry)
        {
            entry.ID = NextId;
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
