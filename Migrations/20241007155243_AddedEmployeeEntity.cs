using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSharpTest.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmployeeEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "guest_birthdate",
                table: "Guests",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    employee_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    employee_first_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    employee_last_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    employee_email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    employee_identification_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    employee_password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.employee_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "employee_id", "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[,]
                {
                    { 1, "Helmer_Sipes@yahoo.com", "Jalyn", "8473815565", "Marks", "nxlw2r9eghn38vpmdoio" },
                    { 2, "Maida.Kuvalis@yahoo.com", "Lola", "3855530997", "Kassulke", "6lwlgybhxvsdx5lzzq7e" },
                    { 3, "Onie.Gleichner96@hotmail.com", "Winston", "3340156174", "Weimann", "2hwpc8qmp2n9sy9sybmg" },
                    { 4, "Melyssa_Kunde@yahoo.com", "Karen", "4088175050", "Beatty", "934mbil7cb7q1ohqarmb" },
                    { 5, "Eva_Denesik@hotmail.com", "Sanford", "5295870035", "Bosco", "8xjdcr8sli658w0o4bwr" },
                    { 6, "Nels.Block@gmail.com", "Raphael", "8875582078", "D'Amore", "tbg2iip2rwujrh2hxeb2" },
                    { 7, "Leonard.Ondricka@yahoo.com", "Helene", "2156439559", "Runolfsdottir", "58ap8gi4tcl1wr0itxrf" },
                    { 8, "Berta_Heidenreich@yahoo.com", "Annetta", "2566440240", "Lindgren", "10ivbj4366p5eo9xa1tp" },
                    { 9, "Eveline.Schmitt@hotmail.com", "Leopoldo", "3158496727", "Schuppe", "ziund7y3gfbhfwyddzvp" },
                    { 10, "Werner_Jenkins@hotmail.com", "Danyka", "5000442792", "Cremin", "o0z5pqtzdrlx4bd12y9g" },
                    { 11, "Billy76@yahoo.com", "Federico", "5024113767", "Schimmel", "1184771m2fnxt7ousfok" },
                    { 12, "Aurelie_Pollich32@yahoo.com", "Benedict", "2824137193", "Swaniawski", "g97uipzslcf1hfilfciu" },
                    { 13, "Fleta_Ondricka91@hotmail.com", "Roosevelt", "6840202890", "Effertz", "myk5qvna8ndcb09ng65t" },
                    { 14, "Iliana45@gmail.com", "Pat", "8594318971", "Deckow", "ad9r76s69cyp01f0ga7p" },
                    { 15, "Omari29@yahoo.com", "Dora", "1189990479", "Von", "td8ogck9b5muiof5qe9q" },
                    { 16, "Salvador36@hotmail.com", "Beaulah", "5636582382", "Stracke", "137h2rl3k7ylpgatja43" },
                    { 17, "Dalton.Kuhic23@hotmail.com", "Ricky", "5295014968", "Oberbrunner", "8ilcvb0698ey7tissi9j" },
                    { 18, "Rossie.OReilly@yahoo.com", "Sean", "7676579695", "Barton", "fi32uc7d2km2z9p23yul" },
                    { 19, "Jeffery18@hotmail.com", "Erling", "4774638475", "Cassin", "sy7ba1hw2kgh50icr32w" },
                    { 20, "Khalid.Schinner74@hotmail.com", "Johan", "2419829091", "Zboncak", "8qj9u5ixw1oz7rtp4f3j" },
                    { 21, "Berneice.Runolfsdottir8@yahoo.com", "Dora", "1523113037", "Vandervort", "jfwyt5waiarser41p295" },
                    { 22, "Meaghan_Kub62@yahoo.com", "Evalyn", "6456561210", "Daugherty", "vx88bgc0w453vll08jmo" },
                    { 23, "Ida_Klocko26@gmail.com", "Treva", "5966274732", "Bradtke", "zg9mn23pbltqxalg8lz5" },
                    { 24, "Maia.Flatley14@hotmail.com", "Earl", "8112015777", "Kulas", "g9s8k7c5czw707zkxpmt" },
                    { 25, "Verda.Hagenes94@gmail.com", "Marge", "9355389786", "Lueilwitz", "vmrrqphf1e60fd2m66xm" },
                    { 26, "Jairo_Schoen@hotmail.com", "Shane", "5511068830", "Shanahan", "s2fpg85qi40pomnq44yf" },
                    { 27, "Lottie_Bednar39@hotmail.com", "Brandi", "5112827346", "Kulas", "emliv5i2ietlyh3bkyo6" },
                    { 28, "Emiliano.Runolfsson@hotmail.com", "Dixie", "4931166183", "Lockman", "l3ghlbebbzi7gsw7i9br" },
                    { 29, "Johann_Schoen81@gmail.com", "Kenya", "5461797080", "Hessel", "bhwtsapkhyl2c9dxdepi" },
                    { 30, "Hershel_Ward@yahoo.com", "Thalia", "3729917835", "Hartmann", "qnzz5o9vw0k7gs1f8p9t" },
                    { 31, "Americo2@yahoo.com", "Clyde", "7491545632", "Beahan", "6y13999e5kqgid8rz340" },
                    { 32, "Jonathan14@hotmail.com", "Kiara", "2025613916", "Corwin", "zloohtfh5spa80j1tfkc" },
                    { 33, "Annie28@yahoo.com", "Katarina", "5181328576", "Batz", "w2qz5u70gmpmdd8f513s" },
                    { 34, "Rashad.Waters@hotmail.com", "Alexie", "7519703491", "Heaney", "4df390uon5sdk0eld10t" },
                    { 35, "Stevie.McDermott@hotmail.com", "Ruth", "6742673896", "Funk", "hp2ntzcaly1c3lh39ypy" },
                    { 36, "Roslyn.Hartmann38@gmail.com", "Anahi", "1318951737", "Grimes", "l52uiw8gxzmgxjo71xh8" },
                    { 37, "Oscar78@hotmail.com", "Sarai", "6789823198", "Quitzon", "bhh4n9362e9sa31x14hj" },
                    { 38, "Reanna_Medhurst34@hotmail.com", "Kay", "4809408287", "Conroy", "fl6o1rlf25b8c7rwk0cx" },
                    { 39, "Jayda88@hotmail.com", "Norwood", "7124210873", "Hegmann", "55o1gv305bxqgh88y5oq" },
                    { 40, "Verner.Renner@yahoo.com", "Cora", "3918191557", "Nitzsche", "unu9rsd2e1m0uixjn18c" },
                    { 41, "Daphnee38@hotmail.com", "Unique", "7635373955", "Bechtelar", "zftsnjxddh82jsl37ke4" },
                    { 42, "Billie69@yahoo.com", "Christian", "6040403634", "Champlin", "c844uzolr4lm9gan77y0" },
                    { 43, "Jeremy22@yahoo.com", "Kendrick", "1088626830", "Gibson", "z48uj3bi9ceegl85nhkn" },
                    { 44, "Diana56@yahoo.com", "Chadrick", "8687674707", "Hamill", "zu6mknh9qbvhvu4rbmkz" },
                    { 45, "Moses_Stoltenberg53@hotmail.com", "Chanelle", "8681821277", "Jacobson", "gwht24mxz99asxx4hefg" },
                    { 46, "Hortense.Mills@yahoo.com", "Valentine", "7663332918", "Funk", "w9urt78nc3woy0jis0pj" },
                    { 47, "Kip56@yahoo.com", "Wilhelmine", "7058384411", "Hahn", "9ec4nmjkpdgwrhbjsuh4" },
                    { 48, "Chyna22@gmail.com", "Reta", "6505930248", "Rohan", "ctbqnwtc2xqwzy6auk13" },
                    { 49, "Luz_Gleichner89@yahoo.com", "Prudence", "6224485444", "Ruecker", "rqu7je7a48g8ugg8jn7l" },
                    { 50, "Minnie.Gusikowski@hotmail.com", "Franco", "3572946667", "Gerlach", "pdwhyp1jm6k7txrgelv4" },
                    { 51, "Floyd_Crist42@hotmail.com", "Emiliano", "2716545389", "Schaden", "8joaub8qk0sjdyukn0r2" },
                    { 52, "Edna88@hotmail.com", "Shayna", "6752546499", "Will", "l1bj4abck1i887xlmkcd" },
                    { 53, "Reece87@yahoo.com", "Gilda", "3624100037", "Olson", "r6wvtz0sxegw6c66j2sb" },
                    { 54, "Braxton.Jones16@hotmail.com", "Amya", "6692542702", "Howe", "54ucp8xxc71uc1u6re05" },
                    { 55, "Daryl8@hotmail.com", "Eulah", "7323823332", "Reichert", "oenz94bkk867da3yc9gh" },
                    { 56, "Brooke76@gmail.com", "Jennings", "3652339709", "Labadie", "qw86fkai6cjh3nleocjd" },
                    { 57, "Aubree48@yahoo.com", "Ashlynn", "5512718069", "Cassin", "burmtqljvhkdxhjib0to" },
                    { 58, "Furman_Grant@yahoo.com", "Jettie", "1793734150", "Wilkinson", "o6qr3ddrhwewsr83v0xy" },
                    { 59, "Eula.Nicolas93@hotmail.com", "Reginald", "3952330534", "Friesen", "7bmdsx66eqz35v2fb1b3" },
                    { 60, "Magali.Kilback4@gmail.com", "Estelle", "7424164635", "Farrell", "bq1kls38rcgfvkk58s8n" },
                    { 61, "Johanna_Carter88@hotmail.com", "Constance", "3938603423", "Runolfsdottir", "bmegjxbd37t2t1sw1t1m" },
                    { 62, "Tiara13@gmail.com", "Kirk", "5076205581", "Sauer", "ehjuxan6ji7ctgd3kurm" },
                    { 63, "Lilla.Franecki@hotmail.com", "Rogelio", "9594551562", "Brakus", "gr9pggk8tl74efa4gdy1" },
                    { 64, "Vladimir.Nienow@gmail.com", "Cedrick", "2043305415", "Ferry", "f80zobbc1dls6c5ogswa" },
                    { 65, "Einar81@hotmail.com", "Alvah", "7859522086", "Padberg", "38hi197qb8hltnoi67q2" },
                    { 66, "Rod_Kerluke@gmail.com", "Dereck", "4555822938", "Christiansen", "7vkbrvhtt071oz5j4onf" },
                    { 67, "Enola_Fay18@hotmail.com", "Claire", "9522556148", "Hirthe", "81iutlh3nli79mq3cctt" },
                    { 68, "Mateo.Volkman@yahoo.com", "Katelyn", "4235196831", "Kohler", "ixv87ug9wv2ny3mf774n" },
                    { 69, "Rebecca.Schmeler6@yahoo.com", "Clement", "8563667729", "Kuphal", "jsm599aon34qmo00zxau" },
                    { 70, "Trisha35@hotmail.com", "Antoinette", "7329056856", "Kuhlman", "ljbqni1c5n0ymks1p0fe" },
                    { 71, "Remington_Jacobson86@hotmail.com", "Kristy", "9195233782", "Nicolas", "100q1l3i91yx7kfbzf0n" },
                    { 72, "Angeline.Veum@hotmail.com", "Euna", "4365043978", "Runolfsdottir", "l7n9rsadtk9kj6szx1cy" },
                    { 73, "Gabriella4@yahoo.com", "Ruthe", "5859517170", "Reynolds", "2dn9fofeu4xou41ey950" },
                    { 74, "Guy.Legros90@yahoo.com", "Jermaine", "5066152425", "Gerlach", "t0y2s81te0aauk0a4nu9" },
                    { 75, "Douglas.Medhurst57@hotmail.com", "May", "6789987556", "Feeney", "0s1xr4ttcgmt8evvdzm6" },
                    { 76, "Tania_Rice94@gmail.com", "Melba", "8449041320", "Feeney", "c0yi3e672cfs15572oqo" },
                    { 77, "Delores.Harvey@yahoo.com", "Nels", "1536521957", "Lang", "l3n1kc19cctpevibrmf6" },
                    { 78, "Tyrese.Schumm@gmail.com", "Omari", "9194364947", "MacGyver", "p1i4o1mtt0j34u1adks8" },
                    { 79, "Glenda.Raynor@yahoo.com", "Emilia", "7309717451", "Turcotte", "fc6tewxpq6cn94yrdg7t" },
                    { 80, "Lula_Turcotte91@yahoo.com", "Delbert", "7887297575", "Wisoky", "tq6gxo1p3njgytc1c7su" },
                    { 81, "Mabelle63@yahoo.com", "Jamie", "9501470056", "Wolf", "rho6fykok87tbio1ecgz" },
                    { 82, "Elna.Von54@gmail.com", "Junius", "8998974056", "Wolff", "tpite5cd1thcus47wohe" },
                    { 83, "Christy.McCullough@gmail.com", "Jewel", "4772941848", "Nienow", "w1ovk455aaamkhu5rtyr" },
                    { 84, "Tania_Beatty@gmail.com", "Anabelle", "3509805865", "Murray", "dkm9g9c1nozlwysesjt6" },
                    { 85, "Sally.Jones14@hotmail.com", "Zachary", "1007618832", "Hamill", "xz724rioarv1cuzmxt0j" },
                    { 86, "Durward.Carroll56@hotmail.com", "Alejandrin", "4586878383", "Jones", "zga24e1ehl0wsgaldakz" },
                    { 87, "Anna_Veum44@hotmail.com", "Lucile", "5802303136", "Powlowski", "vezzsmgd9g3nake0exw6" },
                    { 88, "Jesse_Ryan6@yahoo.com", "Madyson", "5305828432", "Braun", "m0ixmlp6r8hy6sqju7cj" },
                    { 89, "Rhett.Stark@gmail.com", "Brett", "3876511156", "Zulauf", "hhfrpt7fovuousi3l3em" },
                    { 90, "Barry.Pollich@yahoo.com", "Makenna", "3285743633", "Lakin", "t3di7aiw9j1fxzf4smct" },
                    { 91, "Carmelo_Pouros@hotmail.com", "Sanford", "4904424621", "Blanda", "jwq6yka4c9ky8wu8mhtm" },
                    { 92, "Idell6@yahoo.com", "Edgar", "4964533146", "Hackett", "huurk9jvz9l3bzg2tky1" },
                    { 93, "Donavon_Blanda14@hotmail.com", "Ferne", "9104143384", "Pacocha", "0go0p4csvtc6cmw3zpik" },
                    { 94, "Cecilia69@hotmail.com", "Lela", "9889681426", "Mosciski", "tdgtxynwoxijko7ts5q3" },
                    { 95, "Ike28@gmail.com", "Zoila", "8388139067", "Cassin", "6jkkq846pq3oj87htebi" },
                    { 96, "Precious.Runte22@yahoo.com", "Gracie", "3422719274", "Dach", "34wdumqmjo4c4pi3mpcr" },
                    { 97, "Gunnar34@hotmail.com", "Jaiden", "9718772554", "Jerde", "to3taiax4grp6qkqhs77" },
                    { 98, "Linwood_Price@gmail.com", "Lilian", "6246074010", "Bosco", "srmxylhlv0pqkbm1728p" },
                    { 99, "Ashlee_Spencer99@gmail.com", "Gunner", "2859059204", "Welch", "wpqkryp7bgoysz45h00u" },
                    { 100, "Nelda_Grady13@gmail.com", "Danyka", "7982472826", "Davis", "qvwjald0yv9gyryea3tv" }
                });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 1,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1998, 10, 29), "Gardner51@hotmail.com", "Neil", "7842223146", "Hegmann", "2367902786" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 2,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 3, 15), "Ova_Emard@gmail.com", "Hudson", "8400452795", "Jerde", "9223474753" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 3,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2020, 1, 12), "Austyn62@yahoo.com", "Macey", "6954740530", "Olson", "6972817576" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 4,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2015, 6, 5), "Reese.Bruen12@yahoo.com", "Pink", "7604710372", "Glover", "5047032555" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 5,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2020, 6, 2), "Dewayne.Waters@yahoo.com", "Jovany", "7767043200", "Zboncak", "9108506764" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 6,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2003, 4, 24), "Donavon.Kiehn77@yahoo.com", "Tyrese", "2949082175", "Altenwerth", "8232262955" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 7,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 4, 26), "Georgianna.Altenwerth@yahoo.com", "Clara", "2767412919", "Erdman", "3601415321" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 8,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2002, 5, 19), "Trey.Roob@hotmail.com", "Kirstin", "5041410367", "Ankunding", "7759370293" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 9,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2003, 1, 30), "Selena.OReilly@gmail.com", "Delaney", "5704296885", "Pfeffer", "5199774654" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 10,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2020, 11, 21), "Anderson_Hoppe26@yahoo.com", "Laverna", "8540561938", "Steuber", "9112589279" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 11,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 4, 20), "Vidal.Lind@gmail.com", "Kiarra", "1888692647", "Beier", "2714601551" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 12,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2009, 11, 23), "Bianka_Schimmel@yahoo.com", "Lora", "2205610146", "Towne", "3886575007" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 13,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1995, 11, 13), "Kali12@yahoo.com", "Leann", "1178572105", "Hane", "1253062399" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 14,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2003, 6, 10), "Mozell.Renner28@gmail.com", "Johann", "3440544481", "Rowe", "5934974534" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 15,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2006, 1, 7), "Tianna.Mante96@yahoo.com", "Devan", "8634188986", "Steuber", "3232091425" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 16,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2006, 1, 20), "Lesley2@yahoo.com", "Brandon", "5212538314", "Mayert", "5101652259" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 17,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1996, 3, 12), "Valentine21@hotmail.com", "Rosella", "1074277389", "Lowe", "6505350851" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 18,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2008, 11, 4), "Donald.Hegmann37@gmail.com", "Bernadine", "6467259346", "Koepp", "2036921594" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 19,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 3, 10), "Alexis48@gmail.com", "Margaret", "9966495123", "Metz", "3117692357" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 20,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2004, 3, 23), "Wilber.Fahey50@hotmail.com", "Mohamed", "6576371495", "Kautzer", "9324440126" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 21,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2008, 3, 15), "Nya.Toy46@hotmail.com", "Etha", "1024115347", "Corkery", "1700329480" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 22,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2023, 3, 15), "Ambrose_Stoltenberg88@hotmail.com", "Fabiola", "3772298766", "Beahan", "1451164324" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 23,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1997, 7, 25), "Elody.Nader@gmail.com", "Joesph", "3914719259", "Hoppe", "9102065034" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 24,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2020, 9, 8), "Dalton_Kuphal@hotmail.com", "Waylon", "7074152356", "Stiedemann", "4438806256" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 25,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2012, 3, 5), "Ericka40@gmail.com", "Therese", "6606454816", "Hickle", "3055074814" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 26,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2011, 2, 13), "Cristina.Murray80@gmail.com", "Elza", "7009414294", "Dare", "8207690830" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 27,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2001, 4, 21), "Hannah_Jaskolski88@gmail.com", "Brenda", "8490567432", "Johnston", "2060001141" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 28,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2019, 8, 12), "Maureen.Muller3@gmail.com", "Molly", "4504395398", "Oberbrunner", "4821635507" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 29,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1997, 9, 14), "Griffin_Hintz@gmail.com", "Candida", "4440076563", "Kozey", "1204975439" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 30,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2020, 10, 8), "Syble.Little@yahoo.com", "Jacques", "1047310134", "Abbott", "9108986735" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 31,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2021, 5, 31), "Dixie.Marvin@gmail.com", "Bo", "8128578109", "Stokes", "3631918364" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 32,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2000, 3, 9), "Jaylon_Effertz91@gmail.com", "Laverne", "1111384628", "Romaguera", "2608511699" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 33,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2020, 10, 23), "Destini8@hotmail.com", "Vicente", "3512874957", "Leannon", "5001512696" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 34,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 6, 19), "Dianna.Lind2@yahoo.com", "Aniyah", "9858809440", "Hirthe", "9211015302" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 35,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2007, 12, 31), "Mohammad30@gmail.com", "Dylan", "3095019666", "Hilll", "3298916459" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 36,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2012, 5, 2), "Breana.Swift@gmail.com", "Karlee", "2381203588", "Price", "1931296260" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 37,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 12, 25), "Hardy_Dickens70@hotmail.com", "Dante", "8369624201", "Kohler", "6409257086" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 38,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2004, 7, 27), "Idell7@gmail.com", "Lenna", "2675685910", "Raynor", "3880460127" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 39,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2006, 12, 4), "Cortez_Pouros60@gmail.com", "Alta", "9605931232", "Ziemann", "2193754782" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 40,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1998, 1, 11), "Camilla72@gmail.com", "Selmer", "9742581253", "Schneider", "6672306015" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 41,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 10, 27), "Vivienne_Glover65@gmail.com", "Hilda", "9207780407", "Trantow", "5366185935" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 42,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2009, 11, 20), "Nadia_Casper91@yahoo.com", "Demetris", "3915932070", "Stracke", "1371779015" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 43,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2000, 3, 31), "Vilma.Walter@yahoo.com", "Sigurd", "8855885932", "Turner", "8277100465" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 44,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1999, 12, 10), "Luigi.Jacobson@hotmail.com", "Garrick", "3604089263", "Zboncak", "4602994940" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 45,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2018, 1, 22), "Dana84@gmail.com", "Seth", "5196488426", "Rice", "4508192800" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 46,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2000, 12, 11), "Celia88@hotmail.com", "Lilla", "4144530545", "Wolff", "1132193007" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 47,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1995, 3, 9), "Missouri_Fadel@yahoo.com", "Lamar", "1397404638", "Hammes", "3637615121" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 48,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2008, 6, 15), "Damian36@gmail.com", "Addison", "4469417656", "Fisher", "6155011562" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 49,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2007, 3, 5), "Mekhi.OReilly52@gmail.com", "Opal", "2675030628", "Rohan", "1910742698" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 50,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2011, 3, 25), "Abe98@yahoo.com", "Britney", "8625568858", "Gerlach", "6104115329" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 51,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2014, 10, 9), "Bethany72@yahoo.com", "Jana", "3254914138", "Boyle", "4160865520" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 52,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2022, 1, 8), "Zola.Runolfsdottir@gmail.com", "Serena", "7162712996", "White", "6061585531" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 53,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1994, 11, 14), "Janae.Witting@hotmail.com", "Ayla", "3215702403", "Balistreri", "7134198974" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 54,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2021, 10, 2), "Kira46@gmail.com", "Trisha", "5814332068", "Cummerata", "3397322621" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 55,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2024, 4, 10), "Mariano.Kuvalis33@gmail.com", "Carmela", "7649307276", "Balistreri", "1826219861" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 56,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2014, 10, 8), "Oren.Becker3@hotmail.com", "Kamille", "8202559978", "Cremin", "1159054354" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 57,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1996, 3, 11), "Green77@yahoo.com", "Dimitri", "2733485729", "Maggio", "3490585328" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 58,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2019, 5, 12), "Dawn_Legros29@yahoo.com", "Patience", "3319522968", "Rau", "6187600212" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 59,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2012, 9, 9), "Narciso49@yahoo.com", "Connie", "9226229132", "Morissette", "2816859031" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 60,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2001, 4, 12), "Darrin.Lind@gmail.com", "Rodolfo", "6973343772", "Gibson", "7237474439" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 61,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2009, 6, 26), "Gaetano46@gmail.com", "Kiel", "4010395120", "Goldner", "8988710002" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 62,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2011, 7, 24), "Rosetta_Gulgowski74@gmail.com", "Ralph", "2104092073", "Rosenbaum", "3048722503" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 63,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1998, 5, 7), "Kianna25@hotmail.com", "Braden", "3270976919", "Kunze", "8051210493" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 64,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 7, 3), "Victoria_Hessel@hotmail.com", "Emerson", "3303049003", "Bergnaum", "9072539254" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 65,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2023, 11, 12), "Anthony.Wilkinson@hotmail.com", "Jesse", "1329605708", "Bosco", "6841410843" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 66,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1999, 7, 8), "Dorcas78@gmail.com", "Jordy", "7136187531", "Hermann", "4940415646" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 67,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2007, 8, 12), "Gilbert_Schinner69@gmail.com", "Burley", "7982101794", "Tromp", "3344942433" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 68,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2009, 7, 16), "Marty.Kling@hotmail.com", "Aimee", "9815126581", "Koepp", "8235148085" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 69,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2007, 10, 31), "Alexandria_Block38@hotmail.com", "Edmund", "7655668408", "Leffler", "3636397949" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 70,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1996, 10, 25), "Hugh37@yahoo.com", "Norene", "4922806211", "Effertz", "6578572554" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 71,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2018, 9, 29), "Coleman27@yahoo.com", "Olaf", "9224030609", "Kuhn", "5651005328" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 72,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2021, 11, 28), "Alena_Dach@yahoo.com", "Augusta", "8164631541", "Stokes", "2042286295" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 73,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2020, 6, 20), "Eryn.Hills29@hotmail.com", "Elta", "9797017226", "Kassulke", "1304319361" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 74,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 8, 9), "Wilson.Mohr25@hotmail.com", "Bradley", "6845683012", "Bednar", "7241653663" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 75,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2008, 8, 21), "Karelle5@yahoo.com", "Humberto", "6723647421", "Lind", "2537663862" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 76,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1996, 5, 30), "Conor.Beahan62@gmail.com", "Monte", "4716429965", "Turner", "4584411015" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 77,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2007, 7, 4), "Bella_Davis64@gmail.com", "Dillon", "6652566268", "Mohr", "6966251849" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 78,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2007, 8, 4), "Shaun_Ziemann@gmail.com", "Hunter", "5644499244", "Metz", "8780477603" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 79,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2024, 1, 5), "Marquise.Zulauf@gmail.com", "Cristian", "6658779848", "Mitchell", "2465458157" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 80,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2015, 12, 29), "Dalton.Cronin40@yahoo.com", "Price", "7106612286", "Gerlach", "9584663727" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 81,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2019, 2, 25), "Jayda44@gmail.com", "Jamar", "4040620597", "Lynch", "5275767984" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 82,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2022, 2, 25), "Bradford_Schmeler4@gmail.com", "Leann", "5710466081", "Tillman", "8641408210" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 83,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2011, 2, 11), "Forrest86@hotmail.com", "Trace", "4961531642", "Luettgen", "1024089625" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 84,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2000, 9, 13), "Oliver66@hotmail.com", "Mikayla", "8707654251", "Kautzer", "8348720190" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 85,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1995, 11, 14), "Matt.Stroman5@yahoo.com", "Grayson", "2202964664", "Kerluke", "9452077252" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 86,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2021, 5, 15), "Brannon_Bruen49@gmail.com", "Mariela", "2625905509", "Kemmer", "5097324940" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 87,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1995, 7, 2), "Eliseo_Ritchie60@hotmail.com", "Terrance", "1274316369", "Oberbrunner", "1633973332" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 88,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2003, 8, 31), "Julius26@hotmail.com", "Delpha", "1452610752", "Abshire", "2539975235" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 89,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2006, 9, 17), "Solon_Langworth@gmail.com", "Jarret", "8883562293", "Roob", "3047677358" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 90,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2006, 7, 3), "Anabel_Harvey52@hotmail.com", "Delmer", "4968421224", "Keebler", "9401423563" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 91,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2009, 5, 17), "Mattie.Johnston21@yahoo.com", "Jaleel", "3352597303", "Maggio", "1587951590" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 92,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2015, 2, 9), "Emelia.Dibbert61@hotmail.com", "Araceli", "4462302452", "Lehner", "8350001437" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 93,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2007, 12, 22), "Rogelio_Schamberger@hotmail.com", "Malvina", "6451166711", "Lakin", "8806782202" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 94,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2005, 1, 14), "Delta39@yahoo.com", "Benedict", "5692462147", "Johnson", "6784558004" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 95,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2018, 4, 6), "Blair.Lynch76@hotmail.com", "Roma", "5710414291", "Rutherford", "8244564608" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 96,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1997, 1, 14), "Keith25@gmail.com", "Ransom", "8542556717", "Frami", "9256067060" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 97,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2016, 11, 22), "Gabriel.Jones96@yahoo.com", "German", "1798640726", "Senger", "4595161494" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 98,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2001, 1, 8), "Kenya25@hotmail.com", "Cleveland", "2336636905", "Becker", "7643404526" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 99,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2001, 3, 9), "Willa33@gmail.com", "Pablo", "9614621661", "Barrows", "4036653534" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 100,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2011, 9, 11), "Antone_Swift@yahoo.com", "Nora", "1245097383", "Mann", "2783316626" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 1,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { false, 31, "11" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 2,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 148, "48", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 3,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { false, 238, "51" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 4,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 128, "86", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 5,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 211, "97", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 6,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 186, "23" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 7,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 84, "38", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 8,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 117, "58", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 9,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { true, 62, "65" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 10,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 38, "48", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 11,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 183, "48", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 12,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 118, "63", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 13,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 211, "10", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 14,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { true, 61, "65" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 15,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 114, "91", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 16,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 214, "35", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 17,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 245, "91" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 18,
                columns: new[] { "room_max_occupancy_people", "room_price_per_night", "room_type_id" },
                values: new object[] { 207, 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 19,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 225, "9", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 20,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 44, "44", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 21,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 253, "37", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 22,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 219, "66", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 23,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 137, "37", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 24,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 118, "84", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 25,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 253, "76", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 26,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 79, "99" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 27,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 88, "93", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 28,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { true, 170, "54" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 29,
                columns: new[] { "room_availability", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, "20", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 30,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 95, "90", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 31,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 12, "66" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 32,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 168, "74", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 33,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 168, "68", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 34,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 28, "51", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 35,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 195, "57", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 36,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 205, "85" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 37,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 7, "29", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 38,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 104, "21" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 39,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 232, "78", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 40,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 3, "25", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 41,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 130, "42", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 42,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 119, "10", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 43,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 220, "70" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 44,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 39, "15", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 45,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 31, "82", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 46,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { false, 76, "93" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 47,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 27, "2", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 48,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 99, "8", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 49,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 243, "72", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 50,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 188, "70", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 51,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 190, "25" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 52,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 209, "1", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 53,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 112, "44", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 54,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 90, "57", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 55,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 118, "86", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 56,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 145, "43" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 57,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 32, "49", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 58,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 216, "93", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 59,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 0, "90", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 60,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 232, "93", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 61,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 202, "55", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 62,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 11, "37", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 63,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 28, "63" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 64,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 22, "39", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 65,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 187, "94", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 66,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { false, 197, "61" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 67,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 178, "64", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 68,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 221, "43", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 69,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 85, "81" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 70,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 21, "96", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 71,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 47, "9", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 72,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 62, "77", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 73,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 73, "6", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 74,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 32, "3", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 75,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 85, "6", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 76,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 219, "99" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 77,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 216, "16", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 78,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 37, "38", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 79,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { false, 252, "36" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 80,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 102, "27", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 81,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 195, "22" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 82,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 88, "18", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 83,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 7, "48", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 84,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 187, "100", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 85,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 231, "40", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 86,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 65, "65", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 87,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 60, "77", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 88,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 252, "9", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 89,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 254, "19" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 90,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 244, "63", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 91,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 21, "98" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 92,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 197, "86", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 93,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 248, "94", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 94,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 151, "56", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 95,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 2, "2" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 96,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 2, "24", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 97,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 127, "7", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 98,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { true, 85, "88" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 99,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 153, "56", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 100,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 201, "61", 80.0, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "guest_birthdate",
                table: "Guests",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 1,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2022, 6, 10), "Natasha.Heller@hotmail.com", "Sasha", "9886792480", "Dickinson", "2484762545" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 2,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2016, 1, 5), "Coty.Hahn98@yahoo.com", "Elody", "9963703119", "Kutch", "6528289449" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 3,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 11, 13), "Rickey.Schimmel91@gmail.com", "Skylar", "6826338740", "Smith", "4004423123" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 4,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1995, 10, 15), "Roslyn.Weimann22@gmail.com", "Kaleb", "7138018402", "Satterfield", "9769942468" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 5,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 5, 23), "Tanner.Kris@yahoo.com", "Jamarcus", "5777516868", "Doyle", "5186212234" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 6,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 10, 30), "Anne.Cummerata17@gmail.com", "Savion", "3891558710", "Fritsch", "3427681243" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 7,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2013, 9, 7), "Timmy.Reilly@hotmail.com", "Estell", "4844624982", "Klocko", "1495944025" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 8,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2008, 6, 7), "Princess.Barton@gmail.com", "Leanne", "8706775740", "Douglas", "2165841246" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 9,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2023, 12, 21), "Sophia_Sporer@gmail.com", "Mariah", "7594014750", "Lynch", "4033062872" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 10,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 6, 16), "Leif_Kerluke99@hotmail.com", "Chaya", "8684543060", "Borer", "3754958379" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 11,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2004, 8, 6), "Aryanna_Kiehn@gmail.com", "Muriel", "7827113990", "Connelly", "1380480019" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 12,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1995, 9, 13), "Sammy.Abshire@gmail.com", "Tad", "4388710218", "Lockman", "6145656851" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 13,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1995, 10, 11), "Ressie_Moore25@yahoo.com", "Ronaldo", "3163558966", "Kemmer", "2563416817" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 14,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 8, 8), "Ronny_Upton62@gmail.com", "Macie", "8981289482", "Douglas", "4114717539" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 15,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2016, 11, 22), "Faye.Legros79@gmail.com", "Julius", "7180084656", "Mitchell", "8757141655" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 16,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2020, 7, 3), "Margarita39@gmail.com", "Dino", "1457778082", "Grimes", "1474800200" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 17,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 12, 4), "Frankie.Barrows@gmail.com", "Caleigh", "9777923458", "Johns", "6827602889" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 18,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2011, 1, 1), "Simeon_Trantow@hotmail.com", "Dean", "3127649883", "Funk", "7240065680" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 19,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 6, 27), "Haylie_Greenfelder@hotmail.com", "Fabiola", "2616491007", "Flatley", "7470881755" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 20,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 7, 9), "Aliyah.Schiller@yahoo.com", "Marc", "1981956192", "Schinner", "9557395578" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 21,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2013, 8, 5), "Durward_Greenfelder50@hotmail.com", "Geovanni", "3574581133", "DuBuque", "4099885120" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 22,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2016, 10, 25), "Betty.Pfannerstill@yahoo.com", "Guido", "4232499679", "Ruecker", "1012409732" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 23,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2005, 7, 22), "Edison_Schmeler@hotmail.com", "Geraldine", "3572707050", "Hauck", "9092530691" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 24,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2021, 9, 6), "Shanon60@hotmail.com", "Quinn", "5743343262", "Von", "6637328004" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 25,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2006, 4, 21), "Onie_Carter@gmail.com", "Pablo", "8162114314", "Lind", "6759892571" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 26,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 3, 22), "River.Hammes96@hotmail.com", "Jude", "8635083384", "Hickle", "8141363074" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 27,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2011, 3, 25), "Kenya7@yahoo.com", "Jennie", "2386405993", "Stroman", "6438703935" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 28,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2019, 1, 7), "Shanna.Hackett68@hotmail.com", "Lauren", "4883438036", "Gislason", "6104634480" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 29,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2002, 1, 18), "Milan2@yahoo.com", "Gaston", "5373210384", "Dickens", "7797802836" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 30,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2005, 3, 6), "Deion.Berge92@yahoo.com", "Darion", "6637233503", "Feeney", "2749638301" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 31,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2000, 9, 23), "Josue2@gmail.com", "Mustafa", "6536068612", "McKenzie", "7941236558" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 32,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2018, 10, 29), "Maximilian60@hotmail.com", "Keshaun", "7885118563", "McGlynn", "7425796707" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 33,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2018, 1, 10), "Destiny.Boehm39@hotmail.com", "Tom", "7328135185", "Buckridge", "2433805278" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 34,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2020, 8, 1), "Valentina46@yahoo.com", "Louisa", "4467522998", "Batz", "3884127528" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 35,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 4, 20), "Crystal_Leannon@gmail.com", "Colleen", "5402567079", "Auer", "2597196221" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 36,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2012, 11, 26), "Sylvan22@gmail.com", "Ed", "6454410194", "Dicki", "4929594802" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 37,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2002, 9, 11), "Terrance_Kris@hotmail.com", "Emiliano", "5939523552", "Langosh", "8274482408" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 38,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2021, 10, 22), "Gay.Erdman91@hotmail.com", "Uriah", "6782127859", "Gottlieb", "6533202070" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 39,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2000, 5, 24), "Vivienne68@gmail.com", "Houston", "2890195708", "Lubowitz", "8863455836" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 40,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 2, 25), "Bailee_Lebsack@gmail.com", "Chet", "3208436837", "Treutel", "9835333817" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 41,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2015, 11, 29), "Nikki31@yahoo.com", "Dina", "2814692367", "Bauch", "9898439740" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 42,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1997, 2, 27), "Lindsey89@hotmail.com", "Daphney", "3932973651", "Schneider", "7054607465" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 43,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 8, 20), "Liza.Langworth90@hotmail.com", "Sabrina", "2139744424", "Rohan", "3907445223" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 44,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 12, 13), "Krystel77@hotmail.com", "Araceli", "6920190587", "Powlowski", "2959705789" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 45,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2011, 8, 12), "Demetrius.Hermann@yahoo.com", "Lamar", "2155673289", "Ward", "1112196079" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 46,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2015, 5, 15), "Nelle79@hotmail.com", "Jazmyne", "8876013231", "Mann", "3930165233" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 47,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2005, 5, 2), "Percival_Beer@hotmail.com", "Shawna", "9876613818", "Mills", "7681914532" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 48,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2005, 2, 13), "Sasha93@yahoo.com", "Kenton", "4720285537", "Wunsch", "4656966195" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 49,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2008, 7, 15), "Ervin45@hotmail.com", "Agustina", "6052648727", "Kemmer", "1419939469" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 50,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1996, 5, 17), "Javon3@hotmail.com", "Nelle", "7145222184", "Dickens", "6808350313" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 51,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1994, 11, 17), "Graciela5@yahoo.com", "Chauncey", "2006997125", "Nicolas", "5857827971" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 52,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2003, 6, 14), "Maximus92@gmail.com", "Freda", "3842601552", "Morissette", "8613061063" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 53,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2001, 7, 21), "Martin.Von84@yahoo.com", "Parker", "7012759950", "Harber", "6420772947" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 54,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2002, 11, 25), "Nicolas78@hotmail.com", "Rosendo", "7439331064", "Wiza", "6621265495" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 55,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2008, 5, 8), "Cecil_Stanton@gmail.com", "Hiram", "5408247266", "Kutch", "3860132138" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 56,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1997, 12, 23), "Sylvester_Murphy@gmail.com", "Major", "3068005428", "Fisher", "9284975993" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 57,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2023, 1, 8), "Sophie.Satterfield36@hotmail.com", "Alanis", "5806225526", "West", "8709956630" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 58,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1995, 6, 6), "Gardner95@gmail.com", "Marcellus", "7666101622", "Conroy", "1586388092" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 59,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2004, 5, 25), "Verna.Boyer@hotmail.com", "Eldridge", "7851231738", "Greenfelder", "8081306455" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 60,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2003, 11, 28), "Oma86@yahoo.com", "Joan", "4650256663", "Wilderman", "7400087453" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 61,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2002, 8, 3), "Kailyn_Denesik26@hotmail.com", "Shaina", "7934948731", "Robel", "3786255193" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 62,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2002, 3, 5), "Edgardo_Blanda@hotmail.com", "Ubaldo", "5930113970", "Corwin", "5018332496" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 63,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2012, 9, 24), "Roger_Wolf72@gmail.com", "Colton", "6055570380", "Kuhn", "7054346015" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 64,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 9, 9), "Scot.Huels@hotmail.com", "Eldora", "3759635354", "Carroll", "7068376086" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 65,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2005, 11, 13), "Magali_Kunde96@yahoo.com", "Hershel", "8306812081", "Bartoletti", "3714410535" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 66,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2024, 6, 25), "Tyra.Kuhn@yahoo.com", "Virginie", "3459258152", "Hackett", "8476020384" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 67,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1995, 5, 21), "Oran73@gmail.com", "Maxime", "8075178759", "Marks", "7414705616" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 68,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1996, 6, 6), "Olaf56@yahoo.com", "Kelly", "3122969422", "Quitzon", "1030412933" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 69,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2005, 2, 2), "Jonas.Heaney@gmail.com", "Khalil", "9456901944", "Rowe", "7082759429" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 70,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2002, 11, 7), "Nelle.Muller@hotmail.com", "Idell", "3499416143", "Barrows", "2829303712" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 71,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2002, 8, 6), "Rod.Homenick@gmail.com", "Dante", "3017597000", "Harris", "8500954659" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 72,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2018, 3, 12), "Mozell_Steuber@yahoo.com", "Kacie", "5343282235", "Stamm", "1942849086" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 73,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2024, 5, 15), "Julianne_Ratke@gmail.com", "Hannah", "5387900799", "Willms", "8740443226" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 74,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2007, 1, 29), "Makenna_Prohaska22@yahoo.com", "Crawford", "5276062452", "Crooks", "2898281569" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 75,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2022, 5, 5), "Rashad_Schroeder61@yahoo.com", "Arnaldo", "6227999085", "Marvin", "3104173311" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 76,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2016, 2, 11), "Leonor.Hackett89@yahoo.com", "Scotty", "7871774512", "Upton", "9104701389" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 77,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2020, 3, 25), "Ettie.Halvorson@hotmail.com", "Gail", "6931154109", "Casper", "6445124000" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 78,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2021, 11, 25), "Zane8@gmail.com", "Ezra", "7316047814", "Brakus", "8945935603" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 79,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2006, 12, 1), "Nora.Goldner@yahoo.com", "Dedrick", "3853141044", "Hane", "4608014333" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 80,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1996, 6, 15), "Raymond_Wisoky13@gmail.com", "Madilyn", "2346664211", "Baumbach", "8699526166" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 81,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 12, 6), "Marion.Zboncak98@gmail.com", "Britney", "2524060286", "Homenick", "1212804189" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 82,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2022, 11, 2), "Alysa_Ebert@hotmail.com", "Gayle", "5920200364", "Hegmann", "5842122255" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 83,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2018, 5, 7), "Liana_Hermiston74@gmail.com", "Jayson", "9841471850", "Ryan", "6029885790" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 84,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2019, 7, 6), "Cale72@yahoo.com", "Antonietta", "5227374197", "Cummings", "2880714304" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 85,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2021, 2, 3), "Nichole.Johnston@gmail.com", "Jayce", "7821227857", "Jerde", "7636126569" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 86,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2009, 10, 30), "Ralph_Bednar88@hotmail.com", "Cornell", "4495914120", "Erdman", "8361235188" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 87,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2006, 9, 26), "Dion.Auer@yahoo.com", "Alexzander", "6165746059", "Bartell", "9371513400" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 88,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2011, 9, 27), "Avery46@yahoo.com", "Lorenz", "9821994423", "Armstrong", "1429796443" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 89,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2016, 3, 24), "Annette.Runte@gmail.com", "Stan", "3344877272", "Kohler", "5195034873" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 90,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1995, 1, 17), "Marilyne29@gmail.com", "Elise", "7583194533", "Champlin", "8184108100" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 91,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2015, 8, 23), "Chanelle37@yahoo.com", "Jennings", "7856869217", "Kovacek", "9907223273" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 92,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1998, 5, 13), "Harry_Torphy@hotmail.com", "Thora", "5508450791", "Kuhlman", "7337409817" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 93,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2005, 11, 30), "Allie.King0@yahoo.com", "Norval", "2769212804", "Kihn", "9449545489" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 94,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2011, 11, 13), "Blake_Ankunding23@gmail.com", "Sid", "4416103223", "Carter", "9705170626" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 95,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2005, 8, 14), "Kian.Weber71@yahoo.com", "Reyes", "5227729998", "Lehner", "1513865335" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 96,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2016, 1, 31), "Vicenta.Schaden@yahoo.com", "Morris", "2358347408", "Corkery", "2674568372" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 97,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1996, 1, 5), "Montana.Sauer90@yahoo.com", "Kelvin", "8485502451", "Von", "6721389730" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 98,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2019, 1, 11), "Seth.Volkman@gmail.com", "Gregoria", "3875135937", "Sporer", "5026738793" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 99,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2006, 4, 14), "Barton90@hotmail.com", "Virgie", "5746250449", "Becker", "1480694924" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 100,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2004, 3, 28), "Ulises_Mann28@yahoo.com", "Adelia", "4356958539", "Bernhard", "2474094435" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 1,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { true, 74, "97" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 2,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 57, "29", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 3,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { true, 175, "97" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 4,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 187, "43", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 5,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 149, "94", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 6,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 10, "6" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 7,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 172, "53", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 8,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 62, "89", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 9,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { false, 213, "72" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 10,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 25, "94", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 11,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 22, "26", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 12,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 246, "57", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 13,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 168, "62", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 14,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { false, 255, "70" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 15,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 207, "76", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 16,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 229, "65", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 17,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 203, "63" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 18,
                columns: new[] { "room_max_occupancy_people", "room_price_per_night", "room_type_id" },
                values: new object[] { 94, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 19,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 170, "2", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 20,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 27, "26", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 21,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 216, "26", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 22,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 89, "77", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 23,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 129, "74", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 24,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 70, "37", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 25,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 74, "72", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 26,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 158, "12" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 27,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 49, "31", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 28,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { false, 215, "44" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 29,
                columns: new[] { "room_availability", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, "51", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 30,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 84, "3", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 31,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 150, "69" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 32,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 117, "44", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 33,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 133, "89", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 34,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 179, "73", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 35,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 243, "12", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 36,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 168, "31" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 37,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 130, "25", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 38,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 1, "100" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 39,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 233, "68", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 40,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 168, "3", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 41,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 233, "70", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 42,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 109, "21", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 43,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 212, "17" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 44,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 79, "58", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 45,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 86, "51", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 46,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { true, 28, "46" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 47,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 191, "7", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 48,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 28, "59", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 49,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 51, "6", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 50,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 238, "32", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 51,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 75, "17" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 52,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 195, "68", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 53,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 81, "46", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 54,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 193, "7", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 55,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 218, "85", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 56,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 169, "68" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 57,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 201, "78", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 58,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 211, "50", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 59,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 109, "1", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 60,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 20, "34", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 61,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 86, "8", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 62,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 113, "50", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 63,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 225, "28" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 64,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 88, "7", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 65,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 154, "10", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 66,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { true, 73, "14" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 67,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 184, "54", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 68,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 134, "40", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 69,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 209, "32" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 70,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 254, "50", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 71,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 220, "11", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 72,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 182, "14", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 73,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 95, "29", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 74,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 78, "78", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 75,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 2, "29", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 76,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 161, "30" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 77,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 44, "97", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 78,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 109, "76", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 79,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { true, 208, "51" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 80,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 117, "81", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 81,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 127, "11" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 82,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 20, "71", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 83,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 176, "99", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 84,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 163, "62", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 85,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 237, "71", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 86,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 128, "6", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 87,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 109, "3", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 88,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 253, "20", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 89,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 108, "81" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 90,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 213, "35", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 91,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 58, "87" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 92,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 232, "24", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 93,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 28, "45", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 94,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 196, "64", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 95,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 107, "60" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 96,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 192, "67", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 97,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 20, "35", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 98,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { false, 59, "10" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 99,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 27, "34", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 100,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 191, "51", 50.0, 1 });
        }
    }
}
