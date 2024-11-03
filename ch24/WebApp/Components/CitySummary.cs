// Listing 24.7 The contents of the CitySummary.cs file in the WebApp/Components folder

using Microsoft.AspNetCore.Mvc;

namespace WebApp.Components
{
    public class CitySummary : ViewComponent
    {
        private CitiesData data;

        public CitySummary(CitiesData cdata)
        {
            data = cdata;
        }

        public string Invoke()
        {
            return $"{data.Cities.Count()} cities, {data.Cities.Sum(c => c.Population):N0} people";
        }
    }
}
