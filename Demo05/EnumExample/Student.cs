namespace Demo05.EnumExample
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public Gender Gender { get; set; }
        public Grade Grade { get; set; }
    }
}
