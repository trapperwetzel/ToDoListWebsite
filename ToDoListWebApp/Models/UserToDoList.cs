using System.Xml.Linq;

namespace ToDoListWebApp.Models
{
    public class UserToDoList
    {
        private readonly ToDoListContext _context;

        //constructor
        public UserToDoList(ToDoListContext context)
        {
            _context = context;

        }

        public List<ToDoListItem> GetAllItems()
        {
            return _context.ToDoListItems.ToList();
        }


        // Methods

        public void AddItem(ToDoListItem entry)
        {
            _context.ToDoListItems.Add(entry);
            _context.SaveChanges(); // Commits changes to the database
        }



        public void RemoveFromList(int id)
        {
            var itemToRemove = _context.ToDoListItems.FirstOrDefault(item => item.ID == id);
            if (itemToRemove != null)
            {
                _context.ToDoListItems.Remove(itemToRemove);
                _context.SaveChanges(); // Commits changes to the database
            }
        }

        public void MarkAsCompleted(int id)
        {
            var item = _context.ToDoListItems.FirstOrDefault(t => t.ID == id);
            if (item != null)
            {
                item.IsCompleted = true;
                _context.SaveChanges();
            }
        }



    }
}
