using Microsoft.EntityFrameworkCore;

namespace EFTodo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        using (var context = new AppDbContext())
        {
            context.TodoItems.Add(new TodoItem()
            {
                Created = DateTime.UtcNow,
                Id = Guid.NewGuid(),
                Deleted = false,
                Description = "Test"
            });
            context.SaveChanges();

            foreach (var item in context.TodoItems)
            {
                Console.WriteLine(item.ToString());
            }    
        }

        Console.ReadLine();

    }
}