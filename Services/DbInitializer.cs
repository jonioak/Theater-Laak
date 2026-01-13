using Backend;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Services
{
    public static class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();

            // Look for any voorstellingen.
            if (context.Voorstellingen.Any())
            {
                return;   // DB has been seeded
            }

            var voorstellingen = new Voorstelling[]
            {
                new Voorstelling
                {
                    Titel = "De Lion King",
                    Beschrijving = "Het verhaal van Simba.",
                    Genre = "Musical",
                    Leeftijd = 6,
                    Afbeelding = "https://images.unsplash.com/photo-1507676184212-d03816a98fbb?auto=format&fit=crop&w=800&q=80",
                    Banner = "https://images.unsplash.com/photo-1507676184212-d03816a98fbb?auto=format&fit=crop&w=1920&q=80",
                    BegunstigerOnly = false,
                    ZaalId = 1,
                    PrijzenPerRang = new List<RangPrijs>
                    {
                        new RangPrijs { Rang = 1, Prijs = 50.00 },
                        new RangPrijs { Rang = 2, Prijs = 40.00 },
                        new RangPrijs { Rang = 3, Prijs = 30.00 }
                    }
                },
                new Voorstelling
                {
                    Titel = "Hamlet",
                    Beschrijving = "To be or not to be.",
                    Genre = "Toneel",
                    Leeftijd = 12,
                    Afbeelding = "https://images.unsplash.com/photo-1505664194779-8beaceb93744?auto=format&fit=crop&w=800&q=80",
                    Banner = "https://images.unsplash.com/photo-1505664194779-8beaceb93744?auto=format&fit=crop&w=1920&q=80",
                    BegunstigerOnly = false,
                    ZaalId = 2,
                    PrijzenPerRang = new List<RangPrijs>
                    {
                        new RangPrijs { Rang = 1, Prijs = 45.00 },
                        new RangPrijs { Rang = 2, Prijs = 35.00 }
                    }
                },
                 new Voorstelling
                {
                    Titel = "Cabaret Night",
                    Beschrijving = "Een avond vol lach en muziek.",
                    Genre = "Cabaret",
                    Leeftijd = 16,
                    Afbeelding = "https://images.unsplash.com/photo-1516280440614-6697288d5d38?auto=format&fit=crop&w=800&q=80",
                    Banner = "https://images.unsplash.com/photo-1516280440614-6697288d5d38?auto=format&fit=crop&w=1920&q=80",
                    BegunstigerOnly = false,
                    ZaalId = 3,
                    PrijzenPerRang = new List<RangPrijs>
                    {
                        new RangPrijs { Rang = 1, Prijs = 25.00 }
                    }
                },
                 new Voorstelling
                {
                    Titel = "Het Zwanenmeer",
                    Beschrijving = "Klassiek ballet.",
                    Genre = "Dans",
                    Leeftijd = 0,
                    Afbeelding = "https://images.unsplash.com/photo-1521320226546-87b106956014?auto=format&fit=crop&w=800&q=80",
                    Banner = "https://images.unsplash.com/photo-1521320226546-87b106956014?auto=format&fit=crop&w=1920&q=80",
                    BegunstigerOnly = true,
                    ZaalId = 1,
                    PrijzenPerRang = new List<RangPrijs>
                    {
                        new RangPrijs { Rang = 1, Prijs = 60.00 },
                        new RangPrijs { Rang = 2, Prijs = 50.00 },
                        new RangPrijs { Rang = 3, Prijs = 40.00 }
                    }
                }
            };

            context.Voorstellingen.AddRange(voorstellingen);
            context.SaveChanges();
        }
    }
}
