namespace TodoApp
{
    public class TodoItem
    {
        public TodoItem (string text)
        {
            text = text;
        }

        public string Text {  get; set; }
        public bool Completed { get; set; }

    }
}
