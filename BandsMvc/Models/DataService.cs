using BandsMvc.Models;

namespace Acme.Models
{
    public class DataService // Service
    {
        // Fejk-DB
        List<Band> bands = new List<Band>
        {
            new Band { Id = 1, Name = "Sebbes Angels", Description = "Rock Band"},
            new Band { Id = 20, Name = "Jazzy Ralle", Description = "Jazz Band"},
            new Band { Id = 35, Name = "Simon och Co", Description = "Orkester"},
        };

        public Band[] GetAllBands()
        {
            return bands.ToArray();
        }

    }
}
