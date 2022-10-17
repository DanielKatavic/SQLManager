namespace SQLManager.Models
{
    internal class Database
    {
        public string? Name { get; set; }

        public override string ToString() => Name ?? string.Empty;
    }
}
