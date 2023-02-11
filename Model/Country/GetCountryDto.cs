using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyAPIPractice.Model.Country
{
    // api/countries OR For Get Method in Controllers
    public class GetCountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
