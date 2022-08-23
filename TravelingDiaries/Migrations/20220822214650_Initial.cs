using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelingDiaries.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "place",
                columns: table => new
                {
                    PlaceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackagePrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_place", x => x.PlaceID);
                });

            migrationBuilder.CreateTable(
                name: "shoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_shoppingCartItems_place_PlaceID",
                        column: x => x.PlaceID,
                        principalTable: "place",
                        principalColumn: "PlaceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "place",
                columns: new[] { "PlaceID", "Description", "Image", "Image1", "Image2", "Image3", "PackagePrice", "PlaceName", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "Jammu and Kashmir is a union territory of India.It is situated in the northernmost part of India.The main languages that are used by the people of Jammu and Kashmir are Urdu, Dogri,and Kashmiri.Vaishno Devi and Amarnath are the major Hindu pilgrim centres in Jammu and Kashmir.", "https://img.freepik.com/free-photo/sunrise-dal-lake-kashmir-india_1232-4765.jpg?w=740&t=st=1660742921~exp=1660743521~hmac=0923b8734ac5a6599c2586a098052333909e7042b57dfa255f6ad38608a23014", "https://static.toiimg.com/thumb/62507186.cms?resizemode=75&width=1200&height=900", "https://www.tourmyindia.com/blog//wp-content/uploads/2014/02/Top-Things-to-Do-in-Jammu-and-Kashmir.jpg", "https://assets.thehansindia.com/h-upload/2021/12/04/1125042-kashmir.webp", 50000, "Jammu and Kashmir", "Jammu and Kashmir is a region administered by India as a union territory and consists of the southern portion of the larger Kashmir region." },
                    { 2, "Delhi is officially the National Capital Territory. NewDelhi is the capital of India.Delhi has an important structure like Humayun’s tomb, Old fort, Siri fort,Jama Masjid,Lotus temple monuments.Delhi – it’s not just a city but an emotion.Delhi has been the centre of a succession of mighty empires and powerful kingdoms. Numerous ruins scattered throughout the territory offer a constant reminder of the area’s history.", "https://cdn.britannica.com/37/189837-050-F0AF383E/New-Delhi-India-War-Memorial-arch-Sir.jpg", "http://static2.tripoto.com/media/filter/tst/img/15546/TripDocument/4126922057_8e74c08828_o.jpg", "https://cdn.britannica.com/92/189792-050-1B98CC71/Bara-Gumbad-mosque-Lodi-Gardens-Delhi.jpg", "https://media.istockphoto.com/photos/humayun-tomb-new-delhi-india-picture-id505239248?k=20&m=505239248&s=612x612&w=0&h=-VDBIaBQquH4MEiLgeCwzhndOAGhIBjKseW_trSmWqo=", 40000, "Delhi", "Delhi is a part of the National Capital Region, which has 12.5 million residents. The governance of Delhi is like that of a state in India." },
                    { 3, "Jaipur, popularly known as the Pink City of India, is the largest city in the state of RajasthanJaipur is the capital of state Rajasthan The main attraction of Jaipur is its archetypal architecture. The city was planned as per the Indian Vastu Shastra, a science that promotes well being and prosperity. The directions of all the streets and markets in Jaipur are East to West and North to South.Jai Singh II made sure that the entire Jaipur city was planned as per the Hindu architectural theory. ", "https://static.independent.co.uk/s3fs-public/thumbnails/image/2018/08/14/09/jaipur-hawa.jpg?quality=75&width=982&height=726&auto=webp", "https://www.micato.com/wp-content/uploads/2018/09/jaipur-1110x700.jpg", "https://assets.traveltriangle.com/blog/wp-content/uploads/2016/09/jal-mahal-cover-439.jpg", "https://image.shutterstock.com/image-photo/ancient-temple-ruins-gadi-sagar-260nw-786126286.jpg", 25000, "Jaipur", " Across the entire Rajasthan, Jaipur is known to be the biggest city. It is also popularly called the Pink City." },
                    { 4, "Mumbai was previously known as Bombay and it is the capital of Maharashtra.Mumbai is one of India’s largest cities which is also the financial and entertainment capital of India.Marathi is the main language of the state and Kabadi is the state sport.Gateway of India is the symbol of Mumbai.It is the tourists’ centre.One of the most iconic hotels of India, the Taj Mahal Palace is located in Mumbai.It is famous for Chhatrapati Shivaji Terminus.The city is known for its popular nightlife.", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Marine_Lines_Mumbai_2021.jpg/800px-Marine_Lines_Mumbai_2021.jpg", "https://www.holidify.com/images/bgImages/MUMBAI.jpg", "https://images.unsplash.com/photo-1529253355930-ddbe423a2ac7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8bXVtYmFpfGVufDB8fDB8fA%3D%3D&w=1000&q=80", "https://assets.gqindia.com/photos/5f4df431de5e2aaea53dd83d/2:3/w_719,h_1079,c_limit/The-most-expensive-residential-spots-in-Mumbai-where-1-square-feet-costs-upwards-of-Rs-40,000.jpg", 30000, "Mumbai", "Mumbai (formerly called Bombay) is a densely populated city on India’s west coast." },
                    { 5, "Chennai,formerly Madras,city,capital of Tamil Nadu state,southern India,located on the Coromandel Coast of the Bay of Bengal.Known as the “Gateway to South India,”Chennai is located on the Coromandel Coast along the Bay of Bengal.It is included as one of the four metropolitan siblings of the country.It has a cultural and historical background that is both rich and vast.It thoroughly mixes up with the metropolis lifestyle perfectly.Besides,it is very famous for its South-Indian culture, museums from the British Era, monuments, temples, and so on.", "https://media.istockphoto.com/photos/detail-work-in-gopuram-hindu-temple-kapaleeshwarar-chennai-tamil-nadu-picture-id808900036?k=20&m=808900036&s=612x612&w=0&h=NLkFUtqGEnBgiSbtlhBF02CiZD9NZXbE0f3vccIwVnk=", "https://www.tralover.com/uploads/0000/1/2021/11/10/47193d1364680014c23ad25ff3b7e433.jpg", "https://upload.wikimedia.org/wikipedia/commons/3/32/Chennai_Central.jpg", "https://cdn.britannica.com/13/100813-050-708D93FE/Kapaleeswarar-temple-Hindu-Mylapore-Chennai-India-Tamil.jpg", 10000, "Chennai", " Chennai used to be known as Madras. It is considered as the capital of Tamil Nadu in the southern side of India." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_shoppingCartItems_PlaceID",
                table: "shoppingCartItems",
                column: "PlaceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shoppingCartItems");

            migrationBuilder.DropTable(
                name: "place");
        }
    }
}
