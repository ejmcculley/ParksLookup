using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Location", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Crater Lake inspires awe. Native Americans witnessed its formation 7,700 years ago, when a violent eruption triggered the collapse of a tall peak. Scientists marvel at its purity: fed by rain and snow, its the deepest lake in the USA and one of the most pristine on earth. Artists, photographers, and sightseers gaze in wonder at its blue water and stunning setting atop the Cascade Mountain Range.", "Crater Lake, OR", "Crater Lake", "National Park" },
                    { 2, "From its thunderous ocean breakers crashing against rocky headlands and expansive sand beaches to its open grasslands, brushy hillsides, and forested ridges, Point Reyes offers visitors over 1500 species of plants and animals to discover. Home to several cultures over thousands of years, the Seashore preserves a tapestry of stories and interactions of people. Point Reyes awaits your exploration.", "Point Reyes, CA", "Point Reyes", "National Park" },
                    { 3, "Follow the paths where native people and pioneers walked. Gaze up at massive sandstone cliffs of cream, pink, and red that soar into a brilliant blue sky. Experience wilderness in a narrow slot canyon. Zion’s unique array of plants and animals will enchant you as you absorb the rich history of the past and enjoy the excitement of present day adventures.", "Springdale, UT", "Zion", "National Park" },
                    { 4, "In the southeast corner of Washington, Palouse Falls State Park is named after its iconic main attraction, the 198-foot Palouse Falls waterfall. While this scenic waterfall, often described as the best in the state, is the main attraction in the park, many visitors travel here for the chance to surround themselves with nature.", "LaCrosse, WA", "Palouse Falls", "State Park" },
                    { 5, "Formed of volcanic ash 30 million years ago and sculpted by wind and water into rows of monolithic blocks, City of Rocks State Park takes its name from these incredible rock formations. Cactus gardens and hiking trails add to this unique destination.", "Faywood, NM", "City of Rocks", "State Park" },
                    { 6, "Tonto Natural Bridge State Park is located in central Arizona near Payson. It is believed to be the largest natural travertine bridge in the world. The bridge stands 183 feet high over a 400-foot long tunnel that measures 150 feet at its widest point.", "Pine, AZ", "Tonto Natural Bridge", "State Park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);
        }
    }
}
