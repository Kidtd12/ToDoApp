namespace ToDoDemo.Models
{
    public class Filters
    {
        public string? CategoryId { get; set; }
        public string? StatusId { get; set; }
        public string? Due { get; set; }

        public Filters(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                CategoryId = null;
                StatusId = null;
                Due = null;
            }
            else
            {
                var parts = id.Split('-');

                CategoryId = parts[0] == "all" ? null : parts[0];
                StatusId = parts[1] == "all" ? null : parts[1];
                Due = parts[2] == "all" ? null : parts[2];
            }
        }

        public bool HasCategory => !string.IsNullOrEmpty(CategoryId);
        public bool HasStatus => !string.IsNullOrEmpty(StatusId);
        public bool HasDue => !string.IsNullOrEmpty(Due);
    }
}
