using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
    public class ParksLookupContext : DbContext
    {
        public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
              .HasData(
                  new Park { ParkId = 1, Name = "Crater Lake", Location = "OR", Type = "National Park", Description = "Crater Lake inspires awe. Native Americans witnessed its formation 7,700 years ago, when a violent eruption triggered the collapse of a tall peak. Scientists marvel at its purity: fed by rain and snow, its the deepest lake in the USA and one of the most pristine on earth. Artists, photographers, and sightseers gaze in wonder at its blue water and stunning setting atop the Cascade Mountain Range." },
                  new Park { ParkId = 2, Name = "Point Reyes", Location = "CA", Type = "National Park", Description = "From its thunderous ocean breakers crashing against rocky headlands and expansive sand beaches to its open grasslands, brushy hillsides, and forested ridges, Point Reyes offers visitors over 1500 species of plants and animals to discover. Home to several cultures over thousands of years, the Seashore preserves a tapestry of stories and interactions of people. Point Reyes awaits your exploration." },
                  new Park { ParkId = 3, Name = "Zion", Location = "UT", Type = "National Park", Description = "Follow the paths where native people and pioneers walked. Gaze up at massive sandstone cliffs of cream, pink, and red that soar into a brilliant blue sky. Experience wilderness in a narrow slot canyon. Zion’s unique array of plants and animals will enchant you as you absorb the rich history of the past and enjoy the excitement of present day adventures." },
                  new Park { ParkId = 4, Name = "Palouse Falls", Location = "WA", Type = "State Park", Description = "In the southeast corner of Washington, Palouse Falls State Park is named after its iconic main attraction, the 198-foot Palouse Falls waterfall. While this scenic waterfall, often described as the best in the state, is the main attraction in the park, many visitors travel here for the chance to surround themselves with nature." },
                  new Park { ParkId = 5, Name = "City of Rocks", Location = "NM", Type = "State Park", Description = "Formed of volcanic ash 30 million years ago and sculpted by wind and water into rows of monolithic blocks, City of Rocks State Park takes its name from these incredible rock formations. Cactus gardens and hiking trails add to this unique destination." },
                  new Park { ParkId = 6, Name = "Tonto Natural Bridge", Location = "AZ", Type = "State Park", Description = "Tonto Natural Bridge State Park is located in central Arizona near Payson. It is believed to be the largest natural travertine bridge in the world. The bridge stands 183 feet high over a 400-foot long tunnel that measures 150 feet at its widest point." }
              );
        }

        public DbSet<Park> Parks { get; set; }
    }
}