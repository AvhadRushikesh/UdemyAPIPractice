namespace UdemyAPIPractice.Model.Country
{
    public class UpdateCountryDto : BaseCountryDto
    {
        // If we don't want Id To Specidy in Put Request Comment this line and comment  if (id != updateCountryDto.Id) this line in Controller's PUT Method
        public int Id { get; set; }
    }
}
