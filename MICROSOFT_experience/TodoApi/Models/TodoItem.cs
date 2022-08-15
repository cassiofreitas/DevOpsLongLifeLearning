namespace TodoApi.Models
{
    /* A model is a set of classes that represent the data that the app manages. */
    public class TodoItem
    {
        /* unique key to a relational database*/
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set;}
        public string? Secret { get; set;}
    }
    public class TodoItemDTO
    {
        public long Id {get; set;}
        public string? Name {get; set;}
        public bool IsComplete {get; set;}
    }
}