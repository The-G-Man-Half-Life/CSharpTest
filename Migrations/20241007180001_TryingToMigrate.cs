using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSharpTest.Migrations
{
    /// <inheritdoc />
    public partial class TryingToMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 100);

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    booking_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    booking_start_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    booking_end_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    booking_total_cost = table.Column<double>(type: "double", nullable: false),
                    Booking_room_id = table.Column<int>(type: "int", nullable: false),
                    Booking_guest_id = table.Column<int>(type: "int", nullable: false),
                    Booking_employee_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.booking_id);
                    table.ForeignKey(
                        name: "FK_Bookings_Employee_Booking_employee_id",
                        column: x => x.Booking_employee_id,
                        principalTable: "Employee",
                        principalColumn: "employee_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Guests_Booking_guest_id",
                        column: x => x.Booking_guest_id,
                        principalTable: "Guests",
                        principalColumn: "guest_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Rooms_Booking_room_id",
                        column: x => x.Booking_room_id,
                        principalTable: "Rooms",
                        principalColumn: "room_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 1,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Ova.Weimann21@hotmail.com", "Jonatan", "9084304801", "Thompson", "uevd9o5jlbzujhsaczg9" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 2,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Erik_Goyette@gmail.com", "Marlin", "6069704429", "Morissette", "3xowtqc0nk40u7gx54ol" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 3,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Margret.Maggio72@gmail.com", "Erling", "1420858544", "Leannon", "zahj2r7dp4dyij8parre" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 4,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Dereck_Hand@yahoo.com", "Adrian", "5877068981", "Mante", "cfnsyh3ptkuw93qfp2km" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 5,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Merlin.Rosenbaum4@gmail.com", "Branson", "4498874026", "Swaniawski", "455da53whkvv1g4adbiz" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 6,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Abe_Brekke10@gmail.com", "Lee", "7794888488", "Emard", "xs8gvy5h6ld3hy9iyo7i" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 7,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Karolann.Beer16@gmail.com", "Vern", "4934334711", "Moore", "fh7rd44xue3q65ycdijz" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 8,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Hans_Macejkovic@gmail.com", "Edgardo", "3513748720", "Hackett", "j2k77jycd77mtr2vb3sz" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 9,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Janick_Klein@gmail.com", "Delilah", "5647904800", "DuBuque", "yu892p7zs5aypd7unyoi" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 10,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Monserrate58@gmail.com", "Brianne", "5381831226", "Legros", "aosyld84st9kroewxvyh" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 11,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Ewell_Heaney65@gmail.com", "Jordane", "2587400739", "Trantow", "1wotsiepvmsbbcalkk9y" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 12,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Wilfredo53@hotmail.com", "Erik", "4023891463", "Goodwin", "tby0rcs0x9v0ptdaftii" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 13,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Hermann.Nikolaus@hotmail.com", "Milton", "4475732503", "Moore", "0yq700e8whma43lociub" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 14,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Estefania_Kuphal29@hotmail.com", "Edgardo", "2694227586", "Braun", "w71z79movbxpvkk7c7aq" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 15,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Kyleigh81@gmail.com", "Dorthy", "6153459421", "Mosciski", "gz4hxdxif2h7i3f1vc0a" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 16,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Jovany89@gmail.com", "Rosalia", "5283971607", "Pagac", "l1h2j9vhjewsxfwyl3ku" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 17,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Delaney96@yahoo.com", "Pat", "7722987582", "Thiel", "kgd4egmsp9w5ppj7211l" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 18,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Adriana_Smitham16@gmail.com", "Eulah", "5433852647", "Strosin", "0ys8wv4t3h9igh7vpr64" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 19,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Brenden88@yahoo.com", "Daphnee", "8112715903", "Sporer", "wl7p9n3rmne3trfg4s6k" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 20,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Leann_Feest@yahoo.com", "Mabel", "9154868056", "Kuvalis", "z5wng8cropp2e2uwlmuo" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 21,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Easton.Crist84@yahoo.com", "Blaze", "1689662354", "Daugherty", "pajnfyygewtvwz99qyxn" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 22,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Eve_Collier5@gmail.com", "Anita", "6108641505", "Rowe", "z6l1wytapyb9s48jfn3n" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 23,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Dixie12@hotmail.com", "Jettie", "8592116602", "Yundt", "kkfvuszpnlddmmz3cf96" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 24,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Teagan_Kiehn@yahoo.com", "Skye", "7099915567", "Quitzon", "5w1loq5yyxhirets1c2k" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 25,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Brandi_Nader@hotmail.com", "Hannah", "6407680827", "Grady", "p4o8smoon3abedrzhhs9" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 26,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Roman_Dickinson96@yahoo.com", "Rodrigo", "5216040274", "Zemlak", "ps3prmlj9bbbpdgnn3kx" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 27,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Daisy_Stehr91@gmail.com", "Trinity", "8724840139", "Pfeffer", "tngxoh3mcmhzr1xqrqd8" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 28,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Ole48@gmail.com", "Ransom", "1828242171", "Rodriguez", "lmv4usfq7g8exi6j8zai" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 29,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Lester.Ratke@gmail.com", "Zora", "4131018494", "Olson", "3bkuple486a9jqa6zuoj" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 30,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Tony95@hotmail.com", "Juliana", "2754540088", "Leannon", "neppcf5ucke7lfg014v5" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 31,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Trever_Hessel37@hotmail.com", "Claud", "4855803566", "Hackett", "mfbu4x1gchb25aqgv737" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 32,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Jennifer_Parker48@hotmail.com", "Janick", "4053218040", "Lubowitz", "endj4h2u461nlhdp3m0z" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 33,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Gregorio3@hotmail.com", "Doyle", "9464676328", "Greenfelder", "maubgxrjrpgywpy1nbyl" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 34,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Arjun_Ullrich64@gmail.com", "Dashawn", "7175360058", "McLaughlin", "kvmynvfc5o3kswpo9t96" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 35,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Christophe15@yahoo.com", "Katheryn", "4946346112", "Adams", "ofgqd293to7gh6bw5wnf" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 36,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Maida.Mueller72@yahoo.com", "Terry", "6671891674", "Sporer", "1apankoamhc2mvxujxvv" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 37,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Tony_Jones55@gmail.com", "Luz", "7165478323", "Kulas", "k83ue4zfws599kbzuacx" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 38,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Granville_Harber30@gmail.com", "Sigurd", "5812568591", "Schultz", "mrx9vpz8sdd3c0rjzzml" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 39,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Margarita.Brown@yahoo.com", "Woodrow", "6664833758", "Tremblay", "eovdatbzl2elfsafwj5z" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 40,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Angelo_Little@gmail.com", "Jovanny", "9803296786", "Renner", "gzx2r2pqd5y5s5221xa8" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 41,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Helmer.VonRueden@yahoo.com", "Reilly", "3523196455", "Schimmel", "es8bgiyjrinw2bl7mf1z" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 42,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Carmine_Little68@hotmail.com", "Roel", "6704279344", "Reichert", "nobk6jnu0g2q3yeby5mb" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 43,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Hertha.Hodkiewicz@hotmail.com", "Moshe", "7155198854", "Koch", "7glxox55q8euutwuysz0" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 44,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Rosie_Schmidt56@gmail.com", "Angelina", "4765169808", "Runolfsson", "75i6xaf7regpqezxevgy" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 45,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Jayda72@yahoo.com", "Selena", "6498673277", "Casper", "lwv8x7znt2kc1b9l7d36" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 46,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Wilhelmine47@hotmail.com", "Jennie", "3849235362", "Hirthe", "j7qden43x56sd7q1c056" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 47,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Charlotte_Bins87@yahoo.com", "Ayden", "8028938436", "White", "l82tzmern11xnjyg6cdt" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 48,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Zena50@gmail.com", "Dawn", "6039601497", "Weissnat", "vh6wwlsb8w4tt8gvz18c" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 49,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Chaim.Trantow@gmail.com", "Paul", "3775850690", "DuBuque", "kdjpbp2i9edmf3f69iux" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 50,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Alivia46@yahoo.com", "Evelyn", "8877705372", "Brakus", "8f9bj3xu04xrfmljm97l" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 51,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Lurline.Ledner46@gmail.com", "Kayley", "3517867806", "Breitenberg", "n0u7436aco7c412y4bnn" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 52,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Rashad73@hotmail.com", "Schuyler", "1400781225", "Legros", "xkxpqomyrkg5myihxmn4" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 53,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Nicolas.Satterfield@yahoo.com", "Abigayle", "1510659297", "Koch", "zthrhivbetnji9crmczw" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 54,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Mozelle60@yahoo.com", "Zula", "7173330851", "McLaughlin", "fi2bkqxek0xs6lzd8bqk" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 55,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Kiera_Botsford46@yahoo.com", "German", "9687929169", "Bechtelar", "y9aeoajuwdbme9bwdf4w" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 56,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Edwardo.Bogan67@hotmail.com", "Jace", "7173320229", "Haley", "4hjduh3mhyqz9acwsjyj" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 57,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Alessandra9@yahoo.com", "Alphonso", "5554851701", "Nolan", "scj7fta9guiag4oegsuw" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 58,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Catalina_Zboncak39@hotmail.com", "Bella", "8785386488", "Bauch", "9unjp8shy9cqwz0z0qm6" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 59,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Santa_Ebert@yahoo.com", "Justen", "7266278406", "Sawayn", "7ljk2bbpyotsflk2hd6n" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 60,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Ariane38@gmail.com", "Melyna", "2316556552", "Fritsch", "xuje6di5r2mdqzc9odds" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 61,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Abraham.Boyer26@hotmail.com", "Bettie", "1962743910", "Wuckert", "fz3mtzkq6fhnyb9d54q6" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 62,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Lavern76@hotmail.com", "Jo", "1114957750", "Prosacco", "ln64ilnhgkrnu2ubvnma" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 63,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Janae.Schuppe@gmail.com", "Rylan", "5864631419", "Boehm", "xqyimy1xh37vje9xxkil" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 64,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Leopold_Pfannerstill@yahoo.com", "Enid", "4103815451", "Stoltenberg", "250zkfw045o89qk1xnr3" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 65,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Elliot_Lockman88@hotmail.com", "Blanca", "3294113749", "Gerhold", "qe5qsr27u18z1wtxenzv" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 66,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Elliot_Mitchell63@hotmail.com", "Kareem", "8989002571", "Walker", "rvs1x7g7bx7s4g0v2tmb" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 67,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Beverly.Champlin@yahoo.com", "Larue", "6542766521", "Pouros", "5kg7j7bnm0wgjm94w2qn" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 68,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Nella79@gmail.com", "Kris", "5981997080", "Kassulke", "tfw6iq4xycnhwjd15vqx" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 69,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Deondre15@gmail.com", "Rachel", "4716662044", "Kemmer", "ar3hfc9k0kzjoq0mkly5" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 70,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Joana.Franecki15@yahoo.com", "Samson", "3240443593", "Botsford", "ld5pv0dlr3ty4y5u74g1" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 71,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "General.Schowalter84@hotmail.com", "Pierce", "3543018932", "Champlin", "upp515pzb9xwbgntxiko" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 72,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Lavonne.Hamill@hotmail.com", "Melyssa", "3826608474", "Stanton", "w5y169r89218y5t1x710" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 73,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Barton_Upton@yahoo.com", "Whitney", "3838254482", "Leffler", "98ztmro5ssr6oivxctm5" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 74,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Hanna.Gerhold@yahoo.com", "Hester", "8687989937", "Rutherford", "sinfpy8wc4r0xzp4fiqq" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 75,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Vito63@gmail.com", "Trent", "6420926645", "Kris", "7b8zlc3czwqprxkqndso" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 76,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Stefanie51@yahoo.com", "Kiley", "7692121866", "Lang", "ctz3a91eao92oosqpwna" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 77,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Aisha_Bogisich@hotmail.com", "Cathrine", "5655773640", "Tillman", "yki9zge0x13j1hoq9lzy" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 78,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Neoma38@yahoo.com", "Catalina", "8840896920", "Breitenberg", "6000v7b3nozgutfogu2y" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 79,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Pinkie.Hauck61@gmail.com", "Nolan", "2748017188", "Gutkowski", "9wzivopk0i9yxgax8doi" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 80,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Stephen.Kassulke75@hotmail.com", "Vivien", "4435830897", "Okuneva", "q7xmqfe9vrh0ozs6o1jx" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 81,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Fausto_Spencer97@gmail.com", "Delia", "9474860369", "Gislason", "flw684q1ud7zow6tkuu8" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 82,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Newton_Wisoky@yahoo.com", "Mortimer", "6209808952", "Greenfelder", "rpsbjxqo5v4c95ij7xvp" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 83,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Jaren.Bartoletti36@hotmail.com", "Derrick", "5477361422", "Boyle", "eoii7bw7wm5z2ksp8emh" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 84,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Carlo4@gmail.com", "Gaston", "7190560170", "Rosenbaum", "ci50v002ytgfpdk5akk5" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 85,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Mozell.Abbott12@hotmail.com", "Susie", "7779444288", "Hauck", "wmisqw7ecaqwd04spm6f" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 86,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Garret_Metz@hotmail.com", "Sibyl", "5113219325", "Keebler", "o529ix1giingu055gtki" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 87,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Ted_Jenkins@gmail.com", "Jade", "8020954872", "Witting", "9g5ryxwdt6vbd4k1lnk9" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 88,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "King_Wiza99@gmail.com", "Sophie", "6756974712", "Gulgowski", "o949ffb797lhwg7x53b2" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 89,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Gerry99@hotmail.com", "Nellie", "2254370748", "Gaylord", "im51st471ri6ltw1fy1o" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 90,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Karley.Kovacek@hotmail.com", "Sandy", "7341465560", "Kuphal", "zlx6494yk2hcopbxw5ak" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 91,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Otilia22@hotmail.com", "Berenice", "2070262631", "Frami", "wki83bynfodnoe726s98" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 92,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Taylor_Waelchi85@gmail.com", "Bennett", "4506990147", "West", "m8gwe7nbstjzuwlbjlec" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 93,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Queen68@hotmail.com", "Christophe", "7197436923", "Graham", "pab0rf8n3igii73ka4um" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 94,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Everardo88@gmail.com", "Adolph", "5988408024", "Kuvalis", "ziuo59vtcnem14gw7sn1" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 95,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Sylvan.Tremblay37@gmail.com", "Bobby", "7032934024", "Kautzer", "7it3xfoz5xqbzdsnqocu" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 96,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Zola.Abbott@yahoo.com", "Bette", "2929563615", "Stehr", "sxn9xe1s83l6tyf464xh" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 97,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Candido40@hotmail.com", "Pasquale", "5923896442", "Blanda", "604sjivhm3p7siudjcpi" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 98,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Prudence.Lueilwitz@yahoo.com", "Natasha", "1832670446", "Gulgowski", "ks8c3xaya6bwl239fcty" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 99,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Preston40@yahoo.com", "Adelbert", "8326823712", "Ortiz", "5df9os42pmufhr4ua1o8" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 100,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Erich.Bednar@hotmail.com", "Gennaro", "9614855914", "Funk", "j9ef73e0n1atu1zklnd0" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 1,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2011, 8, 24), "Consuelo.Roberts16@yahoo.com", "Trace", "2348004911", "Sporer", "6554856040" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 2,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2018, 12, 31), "Lora_Leannon@gmail.com", "Edd", "3652431004", "Aufderhar", "7302753245" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 3,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2019, 10, 12), "Gwendolyn30@gmail.com", "Linnie", "1557754518", "Lindgren", "7359684037" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 4,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2024, 5, 9), "Benjamin.Ankunding@hotmail.com", "Violette", "6220855535", "Stark", "6849944464" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 5,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2021, 12, 15), "Dane_Grimes63@yahoo.com", "Ardith", "1672709927", "Daugherty", "4850981699" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 6,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2023, 12, 27), "Oleta.Leffler15@yahoo.com", "Chaya", "7323685366", "Reilly", "8013896025" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 7,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1995, 2, 12), "Marcus.Wintheiser13@yahoo.com", "Pascale", "8104787884", "Schaden", "4794292404" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 8,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2001, 10, 11), "Katheryn52@gmail.com", "Lorna", "5829273739", "Hills", "3289799865" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 9,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 5, 5), "Ole_Reilly47@yahoo.com", "Shawna", "2357154732", "Rohan", "6086703098" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 10,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1997, 2, 27), "Shawna97@gmail.com", "Maeve", "7731598412", "Green", "3764711350" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 11,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2000, 6, 30), "Carlo_Mueller@gmail.com", "Hildegard", "8725778572", "Daniel", "2750386392" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 12,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 12, 23), "Aurelio.Zboncak71@hotmail.com", "Estel", "2941022478", "Schoen", "2268512970" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 13,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2001, 5, 30), "Alexzander51@gmail.com", "Emiliano", "2646863136", "Wilkinson", "4951617022" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 14,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2022, 3, 26), "Lewis_McLaughlin53@yahoo.com", "Izabella", "3499142164", "Weber", "2643060422" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 15,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1995, 9, 5), "Stefan90@yahoo.com", "Arely", "2104162223", "Kohler", "2145154404" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 16,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2012, 5, 15), "Diamond.Runolfsson@hotmail.com", "Mike", "9797403885", "Littel", "9460247117" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 17,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2003, 6, 2), "Roxanne_Mann24@gmail.com", "Sadie", "7575067537", "Nikolaus", "5340290355" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 18,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2013, 4, 5), "Morris.Kris@hotmail.com", "Misael", "1302241412", "Trantow", "2556023049" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 19,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2005, 3, 14), "Caleigh35@gmail.com", "Delores", "2846562288", "Dickinson", "3229281012" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 20,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2002, 3, 21), "Althea.Douglas@gmail.com", "Amy", "4900248378", "Marks", "6709596228" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 21,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1998, 9, 15), "Alisa_Donnelly88@yahoo.com", "Juanita", "6600321042", "Gulgowski", "8556047074" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 22,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2015, 9, 11), "Reinhold.Mitchell@hotmail.com", "Berniece", "5866438106", "Quitzon", "3037424368" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 23,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2001, 7, 7), "Darwin23@yahoo.com", "Chloe", "4407433151", "Gerlach", "7813547841" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 24,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1997, 12, 8), "Isadore11@hotmail.com", "Winona", "1987184688", "Abernathy", "5564238509" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 25,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2024, 5, 30), "Bobbie.Quitzon@hotmail.com", "Esteban", "3854005531", "Harris", "6813965728" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 26,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 7, 26), "Nicholas_Rodriguez@gmail.com", "Alexys", "3143407809", "West", "1517151238" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 27,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2016, 2, 28), "Cassandra_Schowalter@gmail.com", "Guiseppe", "8024851367", "Pfeffer", "1119785804" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 28,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1999, 10, 3), "Jakayla53@hotmail.com", "Noelia", "1965762633", "Corkery", "7225562351" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 29,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2014, 12, 30), "Layne.Torp@hotmail.com", "Katlynn", "8023272599", "Legros", "2475562328" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 30,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 4, 15), "Juanita_Bosco@gmail.com", "Elise", "6795469287", "Skiles", "2546360529" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 31,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2016, 8, 1), "Cordelia40@gmail.com", "Jamarcus", "1302737715", "Jacobson", "5922567087" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 32,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2022, 8, 22), "Ashton_Klein52@gmail.com", "Icie", "6190891120", "Steuber", "4591308973" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 33,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2013, 2, 26), "Wilfredo_Stokes93@gmail.com", "Willow", "6674584401", "Schuster", "7986843987" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 34,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2022, 7, 27), "Yadira36@hotmail.com", "Krystel", "2395695643", "O'Reilly", "9600627070" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 35,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 3, 6), "Camryn3@yahoo.com", "Victor", "1945916769", "Runolfsson", "5113627228" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 36,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2001, 6, 21), "Thelma.Stoltenberg23@gmail.com", "Nakia", "2896236639", "Wolff", "1907346407" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 37,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2006, 5, 23), "Berniece.Buckridge47@gmail.com", "Kayleigh", "9499300156", "Rath", "9343489200" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 38,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2003, 7, 15), "Norma_Beahan66@hotmail.com", "Gregg", "4878199170", "Bailey", "8373259934" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 39,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2013, 10, 24), "Rosemarie51@gmail.com", "Desmond", "3141930781", "Mills", "5058160823" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 40,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2005, 6, 18), "Henry.Monahan@hotmail.com", "Hilma", "5352265764", "Murphy", "1922880188" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 41,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2021, 11, 21), "Ariane.Boyle89@yahoo.com", "Karianne", "4024040747", "Nolan", "5797402787" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 42,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2013, 2, 13), "Alda.Romaguera@yahoo.com", "Asa", "5223728161", "Sporer", "1967678329" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 43,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2002, 10, 15), "Sandra_Gulgowski@gmail.com", "Ethel", "1808292548", "Mosciski", "7210064055" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 44,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2011, 1, 27), "Mario.Lindgren@yahoo.com", "Alanis", "1724191146", "Frami", "2648897108" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 45,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2001, 2, 8), "Guadalupe_Erdman@gmail.com", "Priscilla", "6781564861", "Kling", "3789603661" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 46,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2021, 1, 31), "Jennie.Purdy@yahoo.com", "Jed", "7006345509", "O'Keefe", "2736924579" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 47,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1995, 1, 2), "Providenci.Stracke@yahoo.com", "Sid", "2484903042", "Turner", "5579413649" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 48,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2023, 9, 28), "Rupert.Hyatt54@hotmail.com", "Cecelia", "7595975850", "Kulas", "9684673148" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 49,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2008, 5, 11), "Toby_Schamberger@yahoo.com", "Jose", "1445270453", "Reynolds", "5522709215" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 50,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2023, 7, 22), "Ottis67@gmail.com", "Stefan", "9632394685", "Koelpin", "4888763813" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 51,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2005, 2, 23), "Eldridge99@yahoo.com", "Carolina", "8456612799", "Crooks", "7208518851" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 52,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2022, 12, 23), "Einar_Block@gmail.com", "Esmeralda", "2132644118", "Ruecker", "2957994384" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 53,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2012, 1, 26), "Marcel.Weber@hotmail.com", "Luisa", "2182928855", "Vandervort", "9539903252" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 54,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1999, 5, 29), "Helena46@yahoo.com", "Roscoe", "5572268697", "Johnston", "7839441167" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 55,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2023, 3, 9), "Rudolph28@yahoo.com", "Wilford", "2968065284", "King", "3847156900" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 56,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2021, 3, 26), "Burdette_Okuneva@hotmail.com", "Verda", "6772548382", "Cassin", "8529387687" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 57,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2016, 11, 7), "Casper68@hotmail.com", "Geoffrey", "1284793926", "Heidenreich", "2741626963" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 58,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2018, 1, 12), "Erwin_Welch24@yahoo.com", "Morgan", "9804824714", "Emard", "3755013999" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 59,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1996, 12, 13), "Electa22@yahoo.com", "Hettie", "6669213355", "Marquardt", "7987904905" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 60,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 9, 15), "Bruce.Douglas@hotmail.com", "River", "9213935489", "Reichel", "8441644360" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 61,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1999, 1, 17), "Obie56@yahoo.com", "Edwina", "9099334392", "Rowe", "1880109060" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 62,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2022, 7, 26), "Adrian6@yahoo.com", "Cleo", "8260315987", "Parker", "8474990149" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 63,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1996, 9, 1), "Cecelia_Lehner@yahoo.com", "Alvina", "6972896250", "Stanton", "1987571587" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 64,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1995, 7, 29), "Darlene.Ortiz@gmail.com", "Fanny", "1835774257", "Conn", "4927208362" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 65,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1996, 2, 8), "Stevie88@hotmail.com", "Vincenza", "2453875024", "Bode", "7559403795" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 66,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2015, 8, 17), "Kelli.Legros@gmail.com", "Corene", "6826249917", "McCullough", "9978294024" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 67,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 9, 3), "Blaze_Bergstrom@gmail.com", "Will", "1122083286", "Senger", "5488956399" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 68,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2005, 10, 2), "Lorena.Koepp@hotmail.com", "Winifred", "8583090582", "McCullough", "7149922257" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 69,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2004, 7, 15), "Bennett64@yahoo.com", "Kendall", "4419214538", "Friesen", "7772898582" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 70,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2007, 7, 13), "Juston_Wiza@gmail.com", "Ignacio", "9991742115", "Schowalter", "7079129005" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 71,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2021, 6, 15), "Johnny_Corkery69@gmail.com", "Chet", "3887122224", "Weimann", "2594471732" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 72,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2003, 4, 27), "Constantin31@hotmail.com", "Josiah", "5274162658", "Bins", "5990678288" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 73,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2023, 11, 14), "Afton.Konopelski@gmail.com", "Matteo", "8919313527", "Christiansen", "6635481152" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 74,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2002, 4, 22), "Buford_Ebert@gmail.com", "Shad", "8240104711", "Gutkowski", "1720241149" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 75,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2000, 7, 22), "Bud_Rohan60@gmail.com", "Mabelle", "6142547019", "Schmitt", "1272916888" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 76,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2015, 1, 8), "Jed10@hotmail.com", "Thea", "1942456856", "Collins", "4511024040" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 77,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2021, 4, 10), "Dannie_Schneider@yahoo.com", "Muriel", "3186227724", "Jacobson", "6744933096" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 78,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2012, 4, 6), "Percival.Auer14@hotmail.com", "Emerson", "7693251506", "O'Connell", "3418599521" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 79,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2017, 10, 26), "Rafaela_Terry37@gmail.com", "Alaina", "6953231257", "Sauer", "9683566899" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 80,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1998, 2, 26), "Griffin_Lebsack3@yahoo.com", "Cecil", "8481926722", "Kassulke", "3970233666" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 81,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2023, 6, 25), "Leopoldo_Ratke@gmail.com", "Alena", "3944156838", "Konopelski", "6755253365" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 82,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2006, 8, 8), "Reilly_Hickle21@yahoo.com", "Reymundo", "7002884714", "Huels", "4429821827" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 83,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2016, 8, 4), "Ardella1@yahoo.com", "Hazel", "1608528633", "Koch", "2314070124" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 84,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2013, 1, 15), "Erica_Trantow95@hotmail.com", "Elmira", "9681610287", "Watsica", "3057642447" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 85,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1996, 8, 6), "Kari.Crona@gmail.com", "Jeramy", "6091716526", "Kirlin", "8059595614" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 86,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2014, 7, 16), "Celia.Crist@yahoo.com", "Brent", "8871833026", "Ankunding", "6765445038" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 87,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2011, 7, 20), "Mario73@yahoo.com", "Adolf", "9343832193", "Hirthe", "2361901974" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 88,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2009, 2, 2), "Jonatan_Herzog89@yahoo.com", "Oral", "5241634352", "Senger", "3781403794" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 89,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2016, 1, 11), "Hilbert_Mante83@yahoo.com", "Martine", "3446980654", "Abbott", "2229051791" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 90,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2009, 7, 25), "Melyna.Will@yahoo.com", "Ewald", "4164531556", "Russel", "4383797601" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 91,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2003, 2, 28), "Rosa.Hyatt31@gmail.com", "Cole", "5134786887", "Fadel", "7452745021" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 92,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1994, 10, 27), "Emmie_Langworth@gmail.com", "Lynn", "8966555504", "Ernser", "1985631125" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 93,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2012, 11, 8), "Weston73@gmail.com", "Yoshiko", "9080967820", "Haley", "9700842855" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 94,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2023, 8, 29), "Duane66@hotmail.com", "Darby", "5753151088", "Corwin", "9055329187" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 95,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(1998, 9, 17), "Lilly94@hotmail.com", "Johnson", "9991440311", "Streich", "5952222395" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 96,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2022, 2, 5), "Fabian66@yahoo.com", "Orie", "1428204172", "Hills", "2066517320" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 97,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2011, 8, 11), "Asha.Hudson@hotmail.com", "Aron", "1328598060", "Abshire", "3439560348" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 98,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2007, 3, 25), "Ottis48@hotmail.com", "Brad", "2548042667", "Volkman", "9313675567" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 99,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2006, 9, 25), "August33@hotmail.com", "Cydney", "8387611038", "Bergnaum", "9514444775" });

            migrationBuilder.UpdateData(
                table: "Guests",
                keyColumn: "guest_id",
                keyValue: 100,
                columns: new[] { "guest_birthdate", "guest_email", "guest_first_name", "guest_identification_number", "guest_last_name", "guest_phone_number" },
                values: new object[] { new DateOnly(2010, 1, 13), "Willa_Beier@hotmail.com", "Vernie", "6888686341", "Adams", "6216524439" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 1,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 112, "2", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 2,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 171, "3", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 3,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 91, "4", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 4,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 245, "5", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 5,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 22, "6", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 6,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 56, "7", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 7,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 120, "8", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 8,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 203, "9", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 9,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 247, "10", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 10,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 132, "11", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 11,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 135, "12", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 12,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 55, "13", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 13,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 106, "14" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 14,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { false, 177, "15" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 15,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 107, "16", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 16,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 60, "17", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 17,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 235, "18", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 18,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 158, "19", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 19,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 153, "20", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 20,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 21, "21" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 21,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 60, "22" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 22,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 34, "23" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 23,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { true, 23, "24" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 24,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 244, "25", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 25,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 143, "26", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 26,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 42, "27", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 27,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 230, "28", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 28,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 171, "29", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 29,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 46, "30", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 30,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 189, "31", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 31,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 199, "32" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 32,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 163, "33", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 33,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 99, "34" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 34,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 212, "35", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 35,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { true, 242, "36" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 36,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 155, "37", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 37,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { true, 78, "38" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 38,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 216, "39", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 39,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 86, "40", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 40,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 99, "41", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 41,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 44, 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 42,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 49, "43" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 43,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 129, "44", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 44,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 68, "45", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 45,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 87, "46", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 46,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 29, "47", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 47,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 245, "48", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 48,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { true, 41, "49" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 49,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 207, "50", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 50,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 56, "51", 200.0, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Booking_employee_id",
                table: "Bookings",
                column: "Booking_employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Booking_guest_id",
                table: "Bookings",
                column: "Booking_guest_id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Booking_room_id",
                table: "Bookings",
                column: "Booking_room_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 1,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Helmer_Sipes@yahoo.com", "Jalyn", "8473815565", "Marks", "nxlw2r9eghn38vpmdoio" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 2,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Maida.Kuvalis@yahoo.com", "Lola", "3855530997", "Kassulke", "6lwlgybhxvsdx5lzzq7e" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 3,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Onie.Gleichner96@hotmail.com", "Winston", "3340156174", "Weimann", "2hwpc8qmp2n9sy9sybmg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 4,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Melyssa_Kunde@yahoo.com", "Karen", "4088175050", "Beatty", "934mbil7cb7q1ohqarmb" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 5,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Eva_Denesik@hotmail.com", "Sanford", "5295870035", "Bosco", "8xjdcr8sli658w0o4bwr" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 6,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Nels.Block@gmail.com", "Raphael", "8875582078", "D'Amore", "tbg2iip2rwujrh2hxeb2" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 7,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Leonard.Ondricka@yahoo.com", "Helene", "2156439559", "Runolfsdottir", "58ap8gi4tcl1wr0itxrf" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 8,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Berta_Heidenreich@yahoo.com", "Annetta", "2566440240", "Lindgren", "10ivbj4366p5eo9xa1tp" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 9,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Eveline.Schmitt@hotmail.com", "Leopoldo", "3158496727", "Schuppe", "ziund7y3gfbhfwyddzvp" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 10,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Werner_Jenkins@hotmail.com", "Danyka", "5000442792", "Cremin", "o0z5pqtzdrlx4bd12y9g" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 11,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Billy76@yahoo.com", "Federico", "5024113767", "Schimmel", "1184771m2fnxt7ousfok" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 12,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Aurelie_Pollich32@yahoo.com", "Benedict", "2824137193", "Swaniawski", "g97uipzslcf1hfilfciu" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 13,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Fleta_Ondricka91@hotmail.com", "Roosevelt", "6840202890", "Effertz", "myk5qvna8ndcb09ng65t" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 14,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Iliana45@gmail.com", "Pat", "8594318971", "Deckow", "ad9r76s69cyp01f0ga7p" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 15,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Omari29@yahoo.com", "Dora", "1189990479", "Von", "td8ogck9b5muiof5qe9q" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 16,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Salvador36@hotmail.com", "Beaulah", "5636582382", "Stracke", "137h2rl3k7ylpgatja43" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 17,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Dalton.Kuhic23@hotmail.com", "Ricky", "5295014968", "Oberbrunner", "8ilcvb0698ey7tissi9j" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 18,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Rossie.OReilly@yahoo.com", "Sean", "7676579695", "Barton", "fi32uc7d2km2z9p23yul" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 19,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Jeffery18@hotmail.com", "Erling", "4774638475", "Cassin", "sy7ba1hw2kgh50icr32w" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 20,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Khalid.Schinner74@hotmail.com", "Johan", "2419829091", "Zboncak", "8qj9u5ixw1oz7rtp4f3j" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 21,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Berneice.Runolfsdottir8@yahoo.com", "Dora", "1523113037", "Vandervort", "jfwyt5waiarser41p295" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 22,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Meaghan_Kub62@yahoo.com", "Evalyn", "6456561210", "Daugherty", "vx88bgc0w453vll08jmo" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 23,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Ida_Klocko26@gmail.com", "Treva", "5966274732", "Bradtke", "zg9mn23pbltqxalg8lz5" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 24,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Maia.Flatley14@hotmail.com", "Earl", "8112015777", "Kulas", "g9s8k7c5czw707zkxpmt" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 25,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Verda.Hagenes94@gmail.com", "Marge", "9355389786", "Lueilwitz", "vmrrqphf1e60fd2m66xm" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 26,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Jairo_Schoen@hotmail.com", "Shane", "5511068830", "Shanahan", "s2fpg85qi40pomnq44yf" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 27,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Lottie_Bednar39@hotmail.com", "Brandi", "5112827346", "Kulas", "emliv5i2ietlyh3bkyo6" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 28,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Emiliano.Runolfsson@hotmail.com", "Dixie", "4931166183", "Lockman", "l3ghlbebbzi7gsw7i9br" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 29,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Johann_Schoen81@gmail.com", "Kenya", "5461797080", "Hessel", "bhwtsapkhyl2c9dxdepi" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 30,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Hershel_Ward@yahoo.com", "Thalia", "3729917835", "Hartmann", "qnzz5o9vw0k7gs1f8p9t" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 31,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Americo2@yahoo.com", "Clyde", "7491545632", "Beahan", "6y13999e5kqgid8rz340" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 32,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Jonathan14@hotmail.com", "Kiara", "2025613916", "Corwin", "zloohtfh5spa80j1tfkc" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 33,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Annie28@yahoo.com", "Katarina", "5181328576", "Batz", "w2qz5u70gmpmdd8f513s" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 34,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Rashad.Waters@hotmail.com", "Alexie", "7519703491", "Heaney", "4df390uon5sdk0eld10t" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 35,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Stevie.McDermott@hotmail.com", "Ruth", "6742673896", "Funk", "hp2ntzcaly1c3lh39ypy" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 36,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Roslyn.Hartmann38@gmail.com", "Anahi", "1318951737", "Grimes", "l52uiw8gxzmgxjo71xh8" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 37,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Oscar78@hotmail.com", "Sarai", "6789823198", "Quitzon", "bhh4n9362e9sa31x14hj" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 38,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Reanna_Medhurst34@hotmail.com", "Kay", "4809408287", "Conroy", "fl6o1rlf25b8c7rwk0cx" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 39,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Jayda88@hotmail.com", "Norwood", "7124210873", "Hegmann", "55o1gv305bxqgh88y5oq" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 40,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Verner.Renner@yahoo.com", "Cora", "3918191557", "Nitzsche", "unu9rsd2e1m0uixjn18c" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 41,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Daphnee38@hotmail.com", "Unique", "7635373955", "Bechtelar", "zftsnjxddh82jsl37ke4" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 42,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Billie69@yahoo.com", "Christian", "6040403634", "Champlin", "c844uzolr4lm9gan77y0" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 43,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Jeremy22@yahoo.com", "Kendrick", "1088626830", "Gibson", "z48uj3bi9ceegl85nhkn" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 44,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Diana56@yahoo.com", "Chadrick", "8687674707", "Hamill", "zu6mknh9qbvhvu4rbmkz" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 45,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Moses_Stoltenberg53@hotmail.com", "Chanelle", "8681821277", "Jacobson", "gwht24mxz99asxx4hefg" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 46,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Hortense.Mills@yahoo.com", "Valentine", "7663332918", "Funk", "w9urt78nc3woy0jis0pj" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 47,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Kip56@yahoo.com", "Wilhelmine", "7058384411", "Hahn", "9ec4nmjkpdgwrhbjsuh4" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 48,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Chyna22@gmail.com", "Reta", "6505930248", "Rohan", "ctbqnwtc2xqwzy6auk13" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 49,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Luz_Gleichner89@yahoo.com", "Prudence", "6224485444", "Ruecker", "rqu7je7a48g8ugg8jn7l" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 50,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Minnie.Gusikowski@hotmail.com", "Franco", "3572946667", "Gerlach", "pdwhyp1jm6k7txrgelv4" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 51,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Floyd_Crist42@hotmail.com", "Emiliano", "2716545389", "Schaden", "8joaub8qk0sjdyukn0r2" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 52,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Edna88@hotmail.com", "Shayna", "6752546499", "Will", "l1bj4abck1i887xlmkcd" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 53,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Reece87@yahoo.com", "Gilda", "3624100037", "Olson", "r6wvtz0sxegw6c66j2sb" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 54,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Braxton.Jones16@hotmail.com", "Amya", "6692542702", "Howe", "54ucp8xxc71uc1u6re05" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 55,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Daryl8@hotmail.com", "Eulah", "7323823332", "Reichert", "oenz94bkk867da3yc9gh" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 56,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Brooke76@gmail.com", "Jennings", "3652339709", "Labadie", "qw86fkai6cjh3nleocjd" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 57,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Aubree48@yahoo.com", "Ashlynn", "5512718069", "Cassin", "burmtqljvhkdxhjib0to" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 58,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Furman_Grant@yahoo.com", "Jettie", "1793734150", "Wilkinson", "o6qr3ddrhwewsr83v0xy" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 59,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Eula.Nicolas93@hotmail.com", "Reginald", "3952330534", "Friesen", "7bmdsx66eqz35v2fb1b3" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 60,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Magali.Kilback4@gmail.com", "Estelle", "7424164635", "Farrell", "bq1kls38rcgfvkk58s8n" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 61,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Johanna_Carter88@hotmail.com", "Constance", "3938603423", "Runolfsdottir", "bmegjxbd37t2t1sw1t1m" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 62,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Tiara13@gmail.com", "Kirk", "5076205581", "Sauer", "ehjuxan6ji7ctgd3kurm" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 63,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Lilla.Franecki@hotmail.com", "Rogelio", "9594551562", "Brakus", "gr9pggk8tl74efa4gdy1" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 64,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Vladimir.Nienow@gmail.com", "Cedrick", "2043305415", "Ferry", "f80zobbc1dls6c5ogswa" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 65,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Einar81@hotmail.com", "Alvah", "7859522086", "Padberg", "38hi197qb8hltnoi67q2" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 66,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Rod_Kerluke@gmail.com", "Dereck", "4555822938", "Christiansen", "7vkbrvhtt071oz5j4onf" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 67,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Enola_Fay18@hotmail.com", "Claire", "9522556148", "Hirthe", "81iutlh3nli79mq3cctt" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 68,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Mateo.Volkman@yahoo.com", "Katelyn", "4235196831", "Kohler", "ixv87ug9wv2ny3mf774n" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 69,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Rebecca.Schmeler6@yahoo.com", "Clement", "8563667729", "Kuphal", "jsm599aon34qmo00zxau" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 70,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Trisha35@hotmail.com", "Antoinette", "7329056856", "Kuhlman", "ljbqni1c5n0ymks1p0fe" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 71,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Remington_Jacobson86@hotmail.com", "Kristy", "9195233782", "Nicolas", "100q1l3i91yx7kfbzf0n" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 72,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Angeline.Veum@hotmail.com", "Euna", "4365043978", "Runolfsdottir", "l7n9rsadtk9kj6szx1cy" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 73,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Gabriella4@yahoo.com", "Ruthe", "5859517170", "Reynolds", "2dn9fofeu4xou41ey950" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 74,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Guy.Legros90@yahoo.com", "Jermaine", "5066152425", "Gerlach", "t0y2s81te0aauk0a4nu9" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 75,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Douglas.Medhurst57@hotmail.com", "May", "6789987556", "Feeney", "0s1xr4ttcgmt8evvdzm6" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 76,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Tania_Rice94@gmail.com", "Melba", "8449041320", "Feeney", "c0yi3e672cfs15572oqo" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 77,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Delores.Harvey@yahoo.com", "Nels", "1536521957", "Lang", "l3n1kc19cctpevibrmf6" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 78,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Tyrese.Schumm@gmail.com", "Omari", "9194364947", "MacGyver", "p1i4o1mtt0j34u1adks8" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 79,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Glenda.Raynor@yahoo.com", "Emilia", "7309717451", "Turcotte", "fc6tewxpq6cn94yrdg7t" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 80,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Lula_Turcotte91@yahoo.com", "Delbert", "7887297575", "Wisoky", "tq6gxo1p3njgytc1c7su" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 81,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Mabelle63@yahoo.com", "Jamie", "9501470056", "Wolf", "rho6fykok87tbio1ecgz" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 82,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Elna.Von54@gmail.com", "Junius", "8998974056", "Wolff", "tpite5cd1thcus47wohe" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 83,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Christy.McCullough@gmail.com", "Jewel", "4772941848", "Nienow", "w1ovk455aaamkhu5rtyr" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 84,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Tania_Beatty@gmail.com", "Anabelle", "3509805865", "Murray", "dkm9g9c1nozlwysesjt6" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 85,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Sally.Jones14@hotmail.com", "Zachary", "1007618832", "Hamill", "xz724rioarv1cuzmxt0j" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 86,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Durward.Carroll56@hotmail.com", "Alejandrin", "4586878383", "Jones", "zga24e1ehl0wsgaldakz" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 87,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Anna_Veum44@hotmail.com", "Lucile", "5802303136", "Powlowski", "vezzsmgd9g3nake0exw6" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 88,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Jesse_Ryan6@yahoo.com", "Madyson", "5305828432", "Braun", "m0ixmlp6r8hy6sqju7cj" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 89,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Rhett.Stark@gmail.com", "Brett", "3876511156", "Zulauf", "hhfrpt7fovuousi3l3em" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 90,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Barry.Pollich@yahoo.com", "Makenna", "3285743633", "Lakin", "t3di7aiw9j1fxzf4smct" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 91,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Carmelo_Pouros@hotmail.com", "Sanford", "4904424621", "Blanda", "jwq6yka4c9ky8wu8mhtm" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 92,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Idell6@yahoo.com", "Edgar", "4964533146", "Hackett", "huurk9jvz9l3bzg2tky1" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 93,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Donavon_Blanda14@hotmail.com", "Ferne", "9104143384", "Pacocha", "0go0p4csvtc6cmw3zpik" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 94,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Cecilia69@hotmail.com", "Lela", "9889681426", "Mosciski", "tdgtxynwoxijko7ts5q3" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 95,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Ike28@gmail.com", "Zoila", "8388139067", "Cassin", "6jkkq846pq3oj87htebi" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 96,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Precious.Runte22@yahoo.com", "Gracie", "3422719274", "Dach", "34wdumqmjo4c4pi3mpcr" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 97,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Gunnar34@hotmail.com", "Jaiden", "9718772554", "Jerde", "to3taiax4grp6qkqhs77" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 98,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Linwood_Price@gmail.com", "Lilian", "6246074010", "Bosco", "srmxylhlv0pqkbm1728p" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 99,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Ashlee_Spencer99@gmail.com", "Gunner", "2859059204", "Welch", "wpqkryp7bgoysz45h00u" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "employee_id",
                keyValue: 100,
                columns: new[] { "employee_email", "employee_first_name", "employee_identification_number", "employee_last_name", "employee_password" },
                values: new object[] { "Nelda_Grady13@gmail.com", "Danyka", "7982472826", "Davis", "qvwjald0yv9gyryea3tv" });

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
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 31, "11", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 2,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 148, "48", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 3,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 238, "51", 200.0, 4 });

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
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 211, "97", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 6,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 186, "23", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 7,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 84, "38", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 8,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 117, "58", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 9,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 62, "65", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 10,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 38, "48", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 11,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 183, "48", 80.0, 2 });

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
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 211, "10" });

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
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 245, "91", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 18,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 207, "59", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 19,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 225, "9", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 20,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 44, "44" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 21,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 253, "37" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 22,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 219, "66" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 23,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { false, 137, "37" });

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
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 79, "99", 50.0, 1 });

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
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 170, "54", 50.0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 29,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 64, "20", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 30,
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 95, "90", 80.0, 2 });

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
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 168, "68" });

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
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { false, 195, "57" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 36,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 205, "85", 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 37,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { false, 7, "29" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 38,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 104, "21", 80.0, 2 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 39,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 232, "78", 200.0, 4 });

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
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 130, 150.0, 3 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 42,
                columns: new[] { "room_max_occupancy_people", "room_number" },
                values: new object[] { 119, "10" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 43,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 220, "70", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 44,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 39, "15", 200.0, 4 });

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
                columns: new[] { "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { 76, "93", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 47,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { true, 27, "2", 200.0, 4 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "room_id",
                keyValue: 48,
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number" },
                values: new object[] { false, 99, "8" });

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
                columns: new[] { "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[] { false, 188, "70", 50.0, 1 });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "room_id", "room_availability", "room_max_occupancy_people", "room_number", "room_price_per_night", "room_type_id" },
                values: new object[,]
                {
                    { 51, true, 190, "25", 50.0, 1 },
                    { 52, true, 209, "1", 200.0, 4 },
                    { 53, false, 112, "44", 150.0, 3 },
                    { 54, true, 90, "57", 80.0, 2 },
                    { 55, true, 118, "86", 80.0, 2 },
                    { 56, true, 145, "43", 200.0, 4 },
                    { 57, false, 32, "49", 50.0, 1 },
                    { 58, false, 216, "93", 150.0, 3 },
                    { 59, false, 0, "90", 50.0, 1 },
                    { 60, false, 232, "93", 150.0, 3 },
                    { 61, true, 202, "55", 200.0, 4 },
                    { 62, true, 11, "37", 80.0, 2 },
                    { 63, false, 28, "63", 50.0, 1 },
                    { 64, false, 22, "39", 200.0, 4 },
                    { 65, true, 187, "94", 150.0, 3 },
                    { 66, false, 197, "61", 50.0, 1 },
                    { 67, true, 178, "64", 50.0, 1 },
                    { 68, false, 221, "43", 200.0, 4 },
                    { 69, true, 85, "81", 50.0, 1 },
                    { 70, false, 21, "96", 150.0, 3 },
                    { 71, false, 47, "9", 50.0, 1 },
                    { 72, true, 62, "77", 50.0, 1 },
                    { 73, true, 73, "6", 50.0, 1 },
                    { 74, false, 32, "3", 150.0, 3 },
                    { 75, true, 85, "6", 80.0, 2 },
                    { 76, true, 219, "99", 50.0, 1 },
                    { 77, true, 216, "16", 150.0, 3 },
                    { 78, true, 37, "38", 200.0, 4 },
                    { 79, false, 252, "36", 150.0, 3 },
                    { 80, false, 102, "27", 200.0, 4 },
                    { 81, false, 195, "22", 200.0, 4 },
                    { 82, true, 88, "18", 200.0, 4 },
                    { 83, true, 7, "48", 150.0, 3 },
                    { 84, false, 187, "100", 200.0, 4 },
                    { 85, true, 231, "40", 200.0, 4 },
                    { 86, false, 65, "65", 150.0, 3 },
                    { 87, true, 60, "77", 200.0, 4 },
                    { 88, false, 252, "9", 150.0, 3 },
                    { 89, false, 254, "19", 80.0, 2 },
                    { 90, true, 244, "63", 150.0, 3 },
                    { 91, false, 21, "98", 150.0, 3 },
                    { 92, false, 197, "86", 200.0, 4 },
                    { 93, true, 248, "94", 150.0, 3 },
                    { 94, true, 151, "56", 50.0, 1 },
                    { 95, false, 2, "2", 50.0, 1 },
                    { 96, true, 2, "24", 80.0, 2 },
                    { 97, false, 127, "7", 150.0, 3 },
                    { 98, true, 85, "88", 80.0, 2 },
                    { 99, false, 153, "56", 150.0, 3 },
                    { 100, true, 201, "61", 80.0, 2 }
                });
        }
    }
}
