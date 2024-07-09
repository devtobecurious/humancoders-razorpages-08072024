using Microsoft.Extensions.Configuration;
using SdA.AFrodoJourney.Core.Interfaces.Businesses;
using SdA.AFrodoJourney.Core.Models;

namespace SdA.AFrodoJourney.Core.Services.Businesses
{
    public class SqlServerPeopleBusiness(IConfiguration configuration) : IGetAllPeopleBusiness
    {
        public List<Person> GetAll()
        {
            string cs = configuration.GetConnectionString("MaClef");
            // Appel de la base + requete d'appel de la procédure stockée
            return new();
        }
    }
}
