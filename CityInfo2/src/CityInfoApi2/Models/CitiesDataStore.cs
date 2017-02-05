using System.Collections.Generic;


namespace CityInfoApi2.Models
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            //init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id=1,
                    Name="New York City",
                    Description="The one with the big park"
                },
                new CityDto()
                {
                    Id=2,
                    Name="Antwerp",
                    Description="The one with the Cathedral that never really got finished"
                },
                new CityDto()
                {
                    Id=3,
                    Name="Paris",
                    Description="The one with the big tower"
                }
            };
        }
    }
}
