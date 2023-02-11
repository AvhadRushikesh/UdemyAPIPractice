using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyAPIPractice.Model.Country
{
    // api/countries OR For Get Method in Controllers
    public class GetCountryDto : BaseCountryDto
    {
        public int Id { get; set; }
       
    }
}
