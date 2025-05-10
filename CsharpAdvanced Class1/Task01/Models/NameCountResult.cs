namespace Task01.Models
{
   public class NameCountResult
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public NameCountResult (string name, int count) //Constructor [REMEMBER THAT!!!]
        {
            Name = name;
            Count = count;
        }
    }
}
