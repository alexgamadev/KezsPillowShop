using Microsoft.EntityFrameworkCore.Migrations;

namespace KezsPillowShop.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Small", "Small Pillows" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Medium", "Medium-sized Pillows" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Large", "Large Pillows" });

            migrationBuilder.InsertData(
                table: "Pillows",
                columns: new[] { "PillowId", "CategoryId", "ImageThumbnailURL", "ImageURL", "InStock", "IsPillowOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRXsK2fq0Tqa8fE5rD1AxovFIHY_HveG4PlGilg0H-GSWpv0BYN&usqp=CAU", "https://ae01.alicdn.com/kf/H1c61b06d8d0a4e6ab356c550559c47a4k/Ins-Fluffy-Pillow-Wool-Cushions-Fur-Cushion-Cover-Sofa-Long-Plush-Bed-Pillows-Christmas-Decorations-Christmas.jpg", true, true, "This pillow is fluffy", "Fluffy Pillow", 4.00m, "Fluffy" },
                    { 4, 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSMdOkIfISIK2jYNoWsJVpmk0raK-rKlcTTRAeQpAwl0wHky_Xq&usqp=CAU", "https://seoulify.net/wp-content/uploads/2017/11/40x30cm-Pusheen-Cat-Plush-Toys-Stuffed-Animal-Doll-Animal-Pillow-Toy-Pusheen-Cat-For-Kid-Kawaii-5.jpg", true, false, "This pillow is decorated with animals", "Animal Pillow", 4.00m, "Animalistic" },
                    { 3, 2, "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS47efweL_I18knIGa3nLg0KGTeGlp_x6jf4rOaRvWVvs2PlaEz&usqp=CAU", "https://i1.adis.ws/i/dm/30180876.jpg?$standardplayerdefault$&img404=noimagedefault", true, true, "This pillow is shaped like a heart", "Heart Pillow", 7.00m, "Hearty" },
                    { 2, 3, "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSWaBdPWH3paRAS4LQKhr36RjkeiRx3aYVTtgMhSgbzK5FPIieh&usqp=CAU", "https://www.livelaughlove.co.uk/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/l/l/lll_53_32.jpg", false, false, "This pillow is patchy", "Patchwork Pillow", 10.00m, "Patchy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pillows",
                keyColumn: "PillowId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pillows",
                keyColumn: "PillowId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pillows",
                keyColumn: "PillowId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pillows",
                keyColumn: "PillowId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
