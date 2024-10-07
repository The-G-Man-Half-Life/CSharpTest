using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSharpTest.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    guest_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    guest_first_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guest_last_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guest_email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guest_identification_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guest_phone_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guest_birthdate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.guest_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    room_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    room_type_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    room_type_description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.room_type_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    room_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    room_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    room_price_per_night = table.Column<double>(type: "double", nullable: false),
                    room_availability = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    room_max_occupancy_people = table.Column<int>(type: "int", nullable: false),
                    room_type_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.room_id);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "RoomTypes",
                        principalColumn: "room_type_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "guest_id", "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[,]
                {
                    { 1, new DateOnly(2022, 6, 10), "Natasha.Heller@hotmail.com", "Sasha", "9886792480", "Dickinson", "2484762545" },
                    { 2, new DateOnly(2016, 1, 5), "Coty.Hahn98@yahoo.com", "Elody", "9963703119", "Kutch", "6528289449" },
                    { 3, new DateOnly(2017, 11, 13), "Rickey.Schimmel91@gmail.com", "Skylar", "6826338740", "Smith", "4004423123" },
                    { 4, new DateOnly(1995, 10, 15), "Roslyn.Weimann22@gmail.com", "Kaleb", "7138018402", "Satterfield", "9769942468" },
                    { 5, new DateOnly(2010, 5, 23), "Tanner.Kris@yahoo.com", "Jamarcus", "5777516868", "Doyle", "5186212234" },
                    { 6, new DateOnly(2010, 10, 30), "Anne.Cummerata17@gmail.com", "Savion", "3891558710", "Fritsch", "3427681243" },
                    { 7, new DateOnly(2013, 9, 7), "Timmy.Reilly@hotmail.com", "Estell", "4844624982", "Klocko", "1495944025" },
                    { 8, new DateOnly(2008, 6, 7), "Princess.Barton@gmail.com", "Leanne", "8706775740", "Douglas", "2165841246" },
                    { 9, new DateOnly(2023, 12, 21), "Sophia_Sporer@gmail.com", "Mariah", "7594014750", "Lynch", "4033062872" },
                    { 10, new DateOnly(2017, 6, 16), "Leif_Kerluke99@hotmail.com", "Chaya", "8684543060", "Borer", "3754958379" },
                    { 11, new DateOnly(2004, 8, 6), "Aryanna_Kiehn@gmail.com", "Muriel", "7827113990", "Connelly", "1380480019" },
                    { 12, new DateOnly(1995, 9, 13), "Sammy.Abshire@gmail.com", "Tad", "4388710218", "Lockman", "6145656851" },
                    { 13, new DateOnly(1995, 10, 11), "Ressie_Moore25@yahoo.com", "Ronaldo", "3163558966", "Kemmer", "2563416817" },
                    { 14, new DateOnly(2017, 8, 8), "Ronny_Upton62@gmail.com", "Macie", "8981289482", "Douglas", "4114717539" },
                    { 15, new DateOnly(2016, 11, 22), "Faye.Legros79@gmail.com", "Julius", "7180084656", "Mitchell", "8757141655" },
                    { 16, new DateOnly(2020, 7, 3), "Margarita39@gmail.com", "Dino", "1457778082", "Grimes", "1474800200" },
                    { 17, new DateOnly(2010, 12, 4), "Frankie.Barrows@gmail.com", "Caleigh", "9777923458", "Johns", "6827602889" },
                    { 18, new DateOnly(2011, 1, 1), "Simeon_Trantow@hotmail.com", "Dean", "3127649883", "Funk", "7240065680" },
                    { 19, new DateOnly(2017, 6, 27), "Haylie_Greenfelder@hotmail.com", "Fabiola", "2616491007", "Flatley", "7470881755" },
                    { 20, new DateOnly(2010, 7, 9), "Aliyah.Schiller@yahoo.com", "Marc", "1981956192", "Schinner", "9557395578" },
                    { 21, new DateOnly(2013, 8, 5), "Durward_Greenfelder50@hotmail.com", "Geovanni", "3574581133", "DuBuque", "4099885120" },
                    { 22, new DateOnly(2016, 10, 25), "Betty.Pfannerstill@yahoo.com", "Guido", "4232499679", "Ruecker", "1012409732" },
                    { 23, new DateOnly(2005, 7, 22), "Edison_Schmeler@hotmail.com", "Geraldine", "3572707050", "Hauck", "9092530691" },
                    { 24, new DateOnly(2021, 9, 6), "Shanon60@hotmail.com", "Quinn", "5743343262", "Von", "6637328004" },
                    { 25, new DateOnly(2006, 4, 21), "Onie_Carter@gmail.com", "Pablo", "8162114314", "Lind", "6759892571" },
                    { 26, new DateOnly(2017, 3, 22), "River.Hammes96@hotmail.com", "Jude", "8635083384", "Hickle", "8141363074" },
                    { 27, new DateOnly(2011, 3, 25), "Kenya7@yahoo.com", "Jennie", "2386405993", "Stroman", "6438703935" },
                    { 28, new DateOnly(2019, 1, 7), "Shanna.Hackett68@hotmail.com", "Lauren", "4883438036", "Gislason", "6104634480" },
                    { 29, new DateOnly(2002, 1, 18), "Milan2@yahoo.com", "Gaston", "5373210384", "Dickens", "7797802836" },
                    { 30, new DateOnly(2005, 3, 6), "Deion.Berge92@yahoo.com", "Darion", "6637233503", "Feeney", "2749638301" },
                    { 31, new DateOnly(2000, 9, 23), "Josue2@gmail.com", "Mustafa", "6536068612", "McKenzie", "7941236558" },
                    { 32, new DateOnly(2018, 10, 29), "Maximilian60@hotmail.com", "Keshaun", "7885118563", "McGlynn", "7425796707" },
                    { 33, new DateOnly(2018, 1, 10), "Destiny.Boehm39@hotmail.com", "Tom", "7328135185", "Buckridge", "2433805278" },
                    { 34, new DateOnly(2020, 8, 1), "Valentina46@yahoo.com", "Louisa", "4467522998", "Batz", "3884127528" },
                    { 35, new DateOnly(2010, 4, 20), "Crystal_Leannon@gmail.com", "Colleen", "5402567079", "Auer", "2597196221" },
                    { 36, new DateOnly(2012, 11, 26), "Sylvan22@gmail.com", "Ed", "6454410194", "Dicki", "4929594802" },
                    { 37, new DateOnly(2002, 9, 11), "Terrance_Kris@hotmail.com", "Emiliano", "5939523552", "Langosh", "8274482408" },
                    { 38, new DateOnly(2021, 10, 22), "Gay.Erdman91@hotmail.com", "Uriah", "6782127859", "Gottlieb", "6533202070" },
                    { 39, new DateOnly(2000, 5, 24), "Vivienne68@gmail.com", "Houston", "2890195708", "Lubowitz", "8863455836" },
                    { 40, new DateOnly(2017, 2, 25), "Bailee_Lebsack@gmail.com", "Chet", "3208436837", "Treutel", "9835333817" },
                    { 41, new DateOnly(2015, 11, 29), "Nikki31@yahoo.com", "Dina", "2814692367", "Bauch", "9898439740" },
                    { 42, new DateOnly(1997, 2, 27), "Lindsey89@hotmail.com", "Daphney", "3932973651", "Schneider", "7054607465" },
                    { 43, new DateOnly(2010, 8, 20), "Liza.Langworth90@hotmail.com", "Sabrina", "2139744424", "Rohan", "3907445223" },
                    { 44, new DateOnly(2010, 12, 13), "Krystel77@hotmail.com", "Araceli", "6920190587", "Powlowski", "2959705789" },
                    { 45, new DateOnly(2011, 8, 12), "Demetrius.Hermann@yahoo.com", "Lamar", "2155673289", "Ward", "1112196079" },
                    { 46, new DateOnly(2015, 5, 15), "Nelle79@hotmail.com", "Jazmyne", "8876013231", "Mann", "3930165233" },
                    { 47, new DateOnly(2005, 5, 2), "Percival_Beer@hotmail.com", "Shawna", "9876613818", "Mills", "7681914532" },
                    { 48, new DateOnly(2005, 2, 13), "Sasha93@yahoo.com", "Kenton", "4720285537", "Wunsch", "4656966195" },
                    { 49, new DateOnly(2008, 7, 15), "Ervin45@hotmail.com", "Agustina", "6052648727", "Kemmer", "1419939469" },
                    { 50, new DateOnly(1996, 5, 17), "Javon3@hotmail.com", "Nelle", "7145222184", "Dickens", "6808350313" },
                    { 51, new DateOnly(1994, 11, 17), "Graciela5@yahoo.com", "Chauncey", "2006997125", "Nicolas", "5857827971" },
                    { 52, new DateOnly(2003, 6, 14), "Maximus92@gmail.com", "Freda", "3842601552", "Morissette", "8613061063" },
                    { 53, new DateOnly(2001, 7, 21), "Martin.Von84@yahoo.com", "Parker", "7012759950", "Harber", "6420772947" },
                    { 54, new DateOnly(2002, 11, 25), "Nicolas78@hotmail.com", "Rosendo", "7439331064", "Wiza", "6621265495" },
                    { 55, new DateOnly(2008, 5, 8), "Cecil_Stanton@gmail.com", "Hiram", "5408247266", "Kutch", "3860132138" },
                    { 56, new DateOnly(1997, 12, 23), "Sylvester_Murphy@gmail.com", "Major", "3068005428", "Fisher", "9284975993" },
                    { 57, new DateOnly(2023, 1, 8), "Sophie.Satterfield36@hotmail.com", "Alanis", "5806225526", "West", "8709956630" },
                    { 58, new DateOnly(1995, 6, 6), "Gardner95@gmail.com", "Marcellus", "7666101622", "Conroy", "1586388092" },
                    { 59, new DateOnly(2004, 5, 25), "Verna.Boyer@hotmail.com", "Eldridge", "7851231738", "Greenfelder", "8081306455" },
                    { 60, new DateOnly(2003, 11, 28), "Oma86@yahoo.com", "Joan", "4650256663", "Wilderman", "7400087453" },
                    { 61, new DateOnly(2002, 8, 3), "Kailyn_Denesik26@hotmail.com", "Shaina", "7934948731", "Robel", "3786255193" },
                    { 62, new DateOnly(2002, 3, 5), "Edgardo_Blanda@hotmail.com", "Ubaldo", "5930113970", "Corwin", "5018332496" },
                    { 63, new DateOnly(2012, 9, 24), "Roger_Wolf72@gmail.com", "Colton", "6055570380", "Kuhn", "7054346015" },
                    { 64, new DateOnly(2017, 9, 9), "Scot.Huels@hotmail.com", "Eldora", "3759635354", "Carroll", "7068376086" },
                    { 65, new DateOnly(2005, 11, 13), "Magali_Kunde96@yahoo.com", "Hershel", "8306812081", "Bartoletti", "3714410535" },
                    { 66, new DateOnly(2024, 6, 25), "Tyra.Kuhn@yahoo.com", "Virginie", "3459258152", "Hackett", "8476020384" },
                    { 67, new DateOnly(1995, 5, 21), "Oran73@gmail.com", "Maxime", "8075178759", "Marks", "7414705616" },
                    { 68, new DateOnly(1996, 6, 6), "Olaf56@yahoo.com", "Kelly", "3122969422", "Quitzon", "1030412933" },
                    { 69, new DateOnly(2005, 2, 2), "Jonas.Heaney@gmail.com", "Khalil", "9456901944", "Rowe", "7082759429" },
                    { 70, new DateOnly(2002, 11, 7), "Nelle.Muller@hotmail.com", "Idell", "3499416143", "Barrows", "2829303712" },
                    { 71, new DateOnly(2002, 8, 6), "Rod.Homenick@gmail.com", "Dante", "3017597000", "Harris", "8500954659" },
                    { 72, new DateOnly(2018, 3, 12), "Mozell_Steuber@yahoo.com", "Kacie", "5343282235", "Stamm", "1942849086" },
                    { 73, new DateOnly(2024, 5, 15), "Julianne_Ratke@gmail.com", "Hannah", "5387900799", "Willms", "8740443226" },
                    { 74, new DateOnly(2007, 1, 29), "Makenna_Prohaska22@yahoo.com", "Crawford", "5276062452", "Crooks", "2898281569" },
                    { 75, new DateOnly(2022, 5, 5), "Rashad_Schroeder61@yahoo.com", "Arnaldo", "6227999085", "Marvin", "3104173311" },
                    { 76, new DateOnly(2016, 2, 11), "Leonor.Hackett89@yahoo.com", "Scotty", "7871774512", "Upton", "9104701389" },
                    { 77, new DateOnly(2020, 3, 25), "Ettie.Halvorson@hotmail.com", "Gail", "6931154109", "Casper", "6445124000" },
                    { 78, new DateOnly(2021, 11, 25), "Zane8@gmail.com", "Ezra", "7316047814", "Brakus", "8945935603" },
                    { 79, new DateOnly(2006, 12, 1), "Nora.Goldner@yahoo.com", "Dedrick", "3853141044", "Hane", "4608014333" },
                    { 80, new DateOnly(1996, 6, 15), "Raymond_Wisoky13@gmail.com", "Madilyn", "2346664211", "Baumbach", "8699526166" },
                    { 81, new DateOnly(2010, 12, 6), "Marion.Zboncak98@gmail.com", "Britney", "2524060286", "Homenick", "1212804189" },
                    { 82, new DateOnly(2022, 11, 2), "Alysa_Ebert@hotmail.com", "Gayle", "5920200364", "Hegmann", "5842122255" },
                    { 83, new DateOnly(2018, 5, 7), "Liana_Hermiston74@gmail.com", "Jayson", "9841471850", "Ryan", "6029885790" },
                    { 84, new DateOnly(2019, 7, 6), "Cale72@yahoo.com", "Antonietta", "5227374197", "Cummings", "2880714304" },
                    { 85, new DateOnly(2021, 2, 3), "Nichole.Johnston@gmail.com", "Jayce", "7821227857", "Jerde", "7636126569" },
                    { 86, new DateOnly(2009, 10, 30), "Ralph_Bednar88@hotmail.com", "Cornell", "4495914120", "Erdman", "8361235188" },
                    { 87, new DateOnly(2006, 9, 26), "Dion.Auer@yahoo.com", "Alexzander", "6165746059", "Bartell", "9371513400" },
                    { 88, new DateOnly(2011, 9, 27), "Avery46@yahoo.com", "Lorenz", "9821994423", "Armstrong", "1429796443" },
                    { 89, new DateOnly(2016, 3, 24), "Annette.Runte@gmail.com", "Stan", "3344877272", "Kohler", "5195034873" },
                    { 90, new DateOnly(1995, 1, 17), "Marilyne29@gmail.com", "Elise", "7583194533", "Champlin", "8184108100" },
                    { 91, new DateOnly(2015, 8, 23), "Chanelle37@yahoo.com", "Jennings", "7856869217", "Kovacek", "9907223273" },
                    { 92, new DateOnly(1998, 5, 13), "Harry_Torphy@hotmail.com", "Thora", "5508450791", "Kuhlman", "7337409817" },
                    { 93, new DateOnly(2005, 11, 30), "Allie.King0@yahoo.com", "Norval", "2769212804", "Kihn", "9449545489" },
                    { 94, new DateOnly(2011, 11, 13), "Blake_Ankunding23@gmail.com", "Sid", "4416103223", "Carter", "9705170626" },
                    { 95, new DateOnly(2005, 8, 14), "Kian.Weber71@yahoo.com", "Reyes", "5227729998", "Lehner", "1513865335" },
                    { 96, new DateOnly(2016, 1, 31), "Vicenta.Schaden@yahoo.com", "Morris", "2358347408", "Corkery", "2674568372" },
                    { 97, new DateOnly(1996, 1, 5), "Montana.Sauer90@yahoo.com", "Kelvin", "8485502451", "Von", "6721389730" },
                    { 98, new DateOnly(2019, 1, 11), "Seth.Volkman@gmail.com", "Gregoria", "3875135937", "Sporer", "5026738793" },
                    { 99, new DateOnly(2006, 4, 14), "Barton90@hotmail.com", "Virgie", "5746250449", "Becker", "1480694924" },
                    { 100, new DateOnly(2004, 3, 28), "Ulises_Mann28@yahoo.com", "Adelia", "4356958539", "Bernhard", "2474094435" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "room_type_id", "room_type_description", "room_type_name" },
                values: new object[,]
                {
                    { 1, "Una acogedora habitación básica con una cama individual, ideal para viajeros solos.", "Habitación Simple" },
                    { 2, "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos.", "Habitación Doble" },
                    { 3, "Espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad.", "Suite" },
                    { 4, "Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda.", "Habitación Familiar" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "room_id", "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[,]
                {
                    { 1, true, 74, "97", 200.0, 4 },
                    { 2, false, 57, "29", 80.0, 2 },
                    { 3, true, 175, "97", 200.0, 4 },
                    { 4, false, 187, "43", 80.0, 2 },
                    { 5, true, 149, "94", 80.0, 2 },
                    { 6, true, 10, "6", 150.0, 3 },
                    { 7, true, 172, "53", 200.0, 4 },
                    { 8, false, 62, "89", 50.0, 1 },
                    { 9, false, 213, "72", 150.0, 3 },
                    { 10, true, 25, "94", 200.0, 4 },
                    { 11, false, 22, "26", 200.0, 4 },
                    { 12, false, 246, "57", 50.0, 1 },
                    { 13, true, 168, "62", 50.0, 1 },
                    { 14, false, 255, "70", 80.0, 2 },
                    { 15, false, 207, "76", 50.0, 1 },
                    { 16, true, 229, "65", 50.0, 1 },
                    { 17, true, 203, "63", 150.0, 3 },
                    { 18, false, 94, "59", 50.0, 1 },
                    { 19, false, 170, "2", 200.0, 4 },
                    { 20, true, 27, "26", 200.0, 4 },
                    { 21, false, 216, "26", 150.0, 3 },
                    { 22, false, 89, "77", 150.0, 3 },
                    { 23, false, 129, "74", 50.0, 1 },
                    { 24, true, 70, "37", 150.0, 3 },
                    { 25, true, 74, "72", 200.0, 4 },
                    { 26, true, 158, "12", 50.0, 1 },
                    { 27, true, 49, "31", 50.0, 1 },
                    { 28, false, 215, "44", 50.0, 1 },
                    { 29, true, 64, "51", 50.0, 1 },
                    { 30, true, 84, "3", 150.0, 3 },
                    { 31, false, 150, "69", 50.0, 1 },
                    { 32, true, 117, "44", 80.0, 2 },
                    { 33, false, 133, "89", 150.0, 3 },
                    { 34, true, 179, "73", 50.0, 1 },
                    { 35, false, 243, "12", 80.0, 2 },
                    { 36, true, 168, "31", 150.0, 3 },
                    { 37, false, 130, "25", 150.0, 3 },
                    { 38, true, 1, "100", 80.0, 2 },
                    { 39, true, 233, "68", 150.0, 3 },
                    { 40, false, 168, "3", 200.0, 4 },
                    { 41, false, 233, "70", 200.0, 4 },
                    { 42, false, 109, "21", 50.0, 1 },
                    { 43, false, 212, "17", 200.0, 4 },
                    { 44, true, 79, "58", 80.0, 2 },
                    { 45, true, 86, "51", 80.0, 2 },
                    { 46, true, 28, "46", 200.0, 4 },
                    { 47, true, 191, "7", 150.0, 3 },
                    { 48, false, 28, "59", 80.0, 2 },
                    { 49, false, 51, "6", 150.0, 3 },
                    { 50, false, 238, "32", 150.0, 3 },
                    { 51, true, 75, "17", 50.0, 1 },
                    { 52, true, 195, "68", 80.0, 2 },
                    { 53, true, 81, "46", 200.0, 4 },
                    { 54, false, 193, "7", 150.0, 3 },
                    { 55, false, 218, "85", 200.0, 4 },
                    { 56, true, 169, "68", 200.0, 4 },
                    { 57, true, 201, "78", 150.0, 3 },
                    { 58, false, 211, "50", 200.0, 4 },
                    { 59, true, 109, "1", 150.0, 3 },
                    { 60, true, 20, "34", 50.0, 1 },
                    { 61, false, 86, "8", 50.0, 1 },
                    { 62, true, 113, "50", 150.0, 3 },
                    { 63, false, 225, "28", 50.0, 1 },
                    { 64, true, 88, "7", 80.0, 2 },
                    { 65, true, 154, "10", 80.0, 2 },
                    { 66, true, 73, "14", 50.0, 1 },
                    { 67, false, 184, "54", 80.0, 2 },
                    { 68, false, 134, "40", 50.0, 1 },
                    { 69, true, 209, "32", 50.0, 1 },
                    { 70, false, 254, "50", 50.0, 1 },
                    { 71, true, 220, "11", 150.0, 3 },
                    { 72, true, 182, "14", 200.0, 4 },
                    { 73, false, 95, "29", 80.0, 2 },
                    { 74, false, 78, "78", 50.0, 1 },
                    { 75, false, 2, "29", 200.0, 4 },
                    { 76, true, 161, "30", 50.0, 1 },
                    { 77, false, 44, "97", 50.0, 1 },
                    { 78, true, 109, "76", 50.0, 1 },
                    { 79, true, 208, "51", 150.0, 3 },
                    { 80, true, 117, "81", 150.0, 3 },
                    { 81, false, 127, "11", 200.0, 4 },
                    { 82, true, 20, "71", 80.0, 2 },
                    { 83, true, 176, "99", 80.0, 2 },
                    { 84, true, 163, "62", 150.0, 3 },
                    { 85, true, 237, "71", 80.0, 2 },
                    { 86, false, 128, "6", 80.0, 2 },
                    { 87, false, 109, "3", 50.0, 1 },
                    { 88, false, 253, "20", 50.0, 1 },
                    { 89, false, 108, "81", 80.0, 2 },
                    { 90, false, 213, "35", 200.0, 4 },
                    { 91, false, 58, "87", 150.0, 3 },
                    { 92, false, 232, "24", 80.0, 2 },
                    { 93, false, 28, "45", 80.0, 2 },
                    { 94, true, 196, "64", 80.0, 2 },
                    { 95, false, 107, "60", 50.0, 1 },
                    { 96, true, 192, "67", 150.0, 3 },
                    { 97, false, 20, "35", 200.0, 4 },
                    { 98, false, 59, "10", 80.0, 2 },
                    { 99, true, 27, "34", 80.0, 2 },
                    { 100, true, 191, "51", 50.0, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_room_type_id",
                table: "Rooms",
                column: "room_type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
