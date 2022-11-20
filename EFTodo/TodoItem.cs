using System;
namespace EFTodo
{
	public class TodoItem
	{
		public Guid Id { get; set; }
		public DateTime Created { get; set; }
		public string Description { get; set; }
		public bool Deleted { get; set; }

        public override string ToString()
        {
			return $"{Id} {Created} {Description} {Deleted}";
        }
    }
}

