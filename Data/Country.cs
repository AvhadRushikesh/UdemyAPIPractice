namespace UdemyAPIPractice.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        // Every Hotel will have one Country but One Country can have multiple Hotel so to Represent that
        public virtual IList<Hotel> Hotels { get; set; }
    }
}