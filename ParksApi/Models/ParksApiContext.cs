using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
    public class ParksApiContext : DbContext
    {
        public ParksApiContext(DbContextOptions<ParksApiContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
              .HasData(
                  new Park { ParkId = 1, Name = "Acadia", Description = "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats.", State = "Maine", Area = "49,076.63 acres (198.6 km2)", Visitors = "2,669,034", YearEstablished = "1919" },
                  new Park { ParkId = 2, Name = "Badlands", Description = "The Badlands are a collection of buttes, pinnacles, spires, and mixed-grass prairies. The White River Badlands contain the largest assemblage of known late Eocene and Oligocene mammal fossils. The wildlife includes bison, bighorn sheep, black-footed ferrets, and prairie dogs.", State = "South Dakota", Area = "242,755.94 acres (982.4 km2)", Visitors = "916,932", YearEstablished = "1978" },
                  new Park { ParkId = 3, Name = "Crater Lake", Description = "Crater Lake lies in the caldera of an ancient volcano called Mount Mazama that collapsed 7,700 years ago. The lake is the deepest in the United States and is noted for its vivid blue color and water clarity. Wizard Island and the Phantom Ship are more recent volcanic formations within the caldera. As the lake has no inlets or outlets, it is replenished only by precipitation.", State = "Oregon", Area = "183,224.05 acres (741.5 km2)", Visitors = "670,500", YearEstablished = "1902" },
                  new Park { ParkId = 4, Name = "Dry Tortugas", Description = "The islands of the Dry Tortugas, at the westernmost end of the Florida Keys, are the site of Fort Jefferson, a Civil War-era fort that is the largest masonry structure in the Western Hemisphere. The park is home to undisturbed coral reefs and shipwrecks, and is only accessible by plane or boat.", State = "Florida", Area = "64,701.22 acres (261.8 km2)", Visitors = "48,543", YearEstablished = "1992" },
                  new Park { ParkId = 5, Name = "Yosemite", Description = "3	Yosemite features sheer granite cliffs, exceptionally tall waterfalls, and old-growth forests at a unique intersection of geology and hydrology. Half Dome and El Capitan rise from the park's centerpiece, the glacier-carved Yosemite Valley, and from its vertical walls drop Yosemite Falls, one of North America's tallest waterfalls at 2,425 feet (739 m) high. Three giant sequoia groves, along with a pristine wilderness in the heart of the Sierra Nevada, are home to a wide variety of rare plant and animal species", State = "California", Area = "761,747.50 acres (3,082.7 km2)", Visitors = "2,268,313", YearEstablished = "1890" },

              );
        }

        public DbSet<Park> Parks { get; set; }
    }
}