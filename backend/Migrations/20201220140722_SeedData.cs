using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "Phone", "StartDate" },
                values: new object[,]
                {
                    { 1, "Customer Address 1", "John 1", "Doe 1", "543211", new DateTimeOffset(new DateTime(2020, 11, 30, 9, 7, 22, 364, DateTimeKind.Unspecified).AddTicks(8546), new TimeSpan(0, -5, 0, 0, 0)) },
                    { 2, "Customer Address 2", "John 2", "Doe 2", "543212", new DateTimeOffset(new DateTime(2020, 11, 10, 9, 7, 22, 364, DateTimeKind.Unspecified).AddTicks(8912), new TimeSpan(0, -5, 0, 0, 0)) },
                    { 3, "Customer Address 3", "John 3", "Doe 3", "543213", new DateTimeOffset(new DateTime(2020, 10, 21, 9, 7, 22, 364, DateTimeKind.Unspecified).AddTicks(8934), new TimeSpan(0, -5, 0, 0, 0)) },
                    { 4, "Customer Address 4", "John 4", "Doe 4", "543214", new DateTimeOffset(new DateTime(2020, 10, 1, 9, 7, 22, 364, DateTimeKind.Unspecified).AddTicks(8941), new TimeSpan(0, -5, 0, 0, 0)) },
                    { 5, "Customer Address 5", "John 5", "Doe 5", "543215", new DateTimeOffset(new DateTime(2020, 9, 11, 9, 7, 22, 364, DateTimeKind.Unspecified).AddTicks(8948), new TimeSpan(0, -5, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CommissionPercentage", "Manufacturer", "Name", "PurchasePrice", "QuantityOnHand", "SalePrice", "Style" },
                values: new object[,]
                {
                    { 10, 20.00m, "Manufacturer 10", "Bike 10", 1000.00m, 10, 1200.00m, "Style 10" },
                    { 9, 18.00m, "Manufacturer 9", "Bike 9", 900.00m, 10, 1080.00m, "Style 9" },
                    { 8, 16.00m, "Manufacturer 8", "Bike 8", 800.00m, 10, 960.00m, "Style 8" },
                    { 7, 14.00m, "Manufacturer 7", "Bike 7", 700.00m, 10, 840.00m, "Style 7" },
                    { 6, 12.00m, "Manufacturer 6", "Bike 6", 600.00m, 10, 720.00m, "Style 6" },
                    { 5, 10.00m, "Manufacturer 5", "Bike 5", 500.00m, 10, 600.00m, "Style 5" },
                    { 4, 8.00m, "Manufacturer 4", "Bike 4", 400.00m, 10, 480.00m, "Style 4" },
                    { 3, 6.00m, "Manufacturer 3", "Bike 3", 300.00m, 10, 360.00m, "Style 3" },
                    { 2, 4.00m, "Manufacturer 2", "Bike 2", 200.00m, 10, 240.00m, "Style 2" },
                    { 1, 2.00m, "Manufacturer 1", "Bike 1", 100.00m, 10, 120.00m, "Style 1" }
                });

            migrationBuilder.InsertData(
                table: "Salespeople",
                columns: new[] { "SalespersonId", "Address", "FirstName", "LastName", "Manager", "Phone", "StartDate", "TerminationDate" },
                values: new object[,]
                {
                    { 1, "Salesperson Address 1", "Mike 1", "Salesperson 1", "Manager", "123451", new DateTimeOffset(new DateTime(2020, 11, 5, 9, 7, 22, 361, DateTimeKind.Unspecified).AddTicks(7395), new TimeSpan(0, -5, 0, 0, 0)), null },
                    { 2, "Salesperson Address 2", "Mike 2", "Salesperson 2", "Manager", "123452", new DateTimeOffset(new DateTime(2020, 9, 21, 9, 7, 22, 364, DateTimeKind.Unspecified).AddTicks(736), new TimeSpan(0, -5, 0, 0, 0)), null },
                    { 3, "Salesperson Address 3", "Mike 3", "Salesperson 3", "Manager", "123453", new DateTimeOffset(new DateTime(2020, 8, 7, 9, 7, 22, 364, DateTimeKind.Unspecified).AddTicks(814), new TimeSpan(0, -5, 0, 0, 0)), null },
                    { 4, "Salesperson Address 4", "Mike 4", "Salesperson 4", "Manager", "123454", new DateTimeOffset(new DateTime(2020, 6, 23, 9, 7, 22, 364, DateTimeKind.Unspecified).AddTicks(826), new TimeSpan(0, -5, 0, 0, 0)), null },
                    { 5, "Salesperson Address 5", "Mike 5", "Salesperson 5", "Manager", "123455", new DateTimeOffset(new DateTime(2020, 5, 9, 9, 7, 22, 364, DateTimeKind.Unspecified).AddTicks(835), new TimeSpan(0, -5, 0, 0, 0)), null }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "DiscountId", "BeginDate", "DiscountPercentage", "EndDate", "ProductId" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2020, 12, 10, 9, 7, 22, 365, DateTimeKind.Unspecified).AddTicks(3351), new TimeSpan(0, -5, 0, 0, 0)), 15.00m, null, 1 },
                    { 2, new DateTimeOffset(new DateTime(2020, 12, 10, 9, 7, 22, 365, DateTimeKind.Unspecified).AddTicks(3925), new TimeSpan(0, -5, 0, 0, 0)), 15.00m, null, 2 },
                    { 3, new DateTimeOffset(new DateTime(2020, 12, 10, 9, 7, 22, 365, DateTimeKind.Unspecified).AddTicks(3942), new TimeSpan(0, -5, 0, 0, 0)), 15.00m, null, 3 },
                    { 4, new DateTimeOffset(new DateTime(2020, 12, 10, 9, 7, 22, 365, DateTimeKind.Unspecified).AddTicks(3947), new TimeSpan(0, -5, 0, 0, 0)), 15.00m, null, 4 },
                    { 5, new DateTimeOffset(new DateTime(2020, 12, 10, 9, 7, 22, 365, DateTimeKind.Unspecified).AddTicks(3951), new TimeSpan(0, -5, 0, 0, 0)), 15.00m, null, 5 },
                    { 6, new DateTimeOffset(new DateTime(2020, 12, 10, 9, 7, 22, 365, DateTimeKind.Unspecified).AddTicks(3957), new TimeSpan(0, -5, 0, 0, 0)), 15.00m, null, 6 },
                    { 7, new DateTimeOffset(new DateTime(2020, 12, 10, 9, 7, 22, 365, DateTimeKind.Unspecified).AddTicks(3961), new TimeSpan(0, -5, 0, 0, 0)), 15.00m, null, 7 },
                    { 8, new DateTimeOffset(new DateTime(2020, 12, 10, 9, 7, 22, 365, DateTimeKind.Unspecified).AddTicks(3965), new TimeSpan(0, -5, 0, 0, 0)), 15.00m, null, 8 },
                    { 9, new DateTimeOffset(new DateTime(2020, 12, 10, 9, 7, 22, 365, DateTimeKind.Unspecified).AddTicks(3969), new TimeSpan(0, -5, 0, 0, 0)), 15.00m, null, 9 },
                    { 10, new DateTimeOffset(new DateTime(2020, 12, 10, 9, 7, 22, 365, DateTimeKind.Unspecified).AddTicks(3973), new TimeSpan(0, -5, 0, 0, 0)), 15.00m, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[,]
                {
                    { 1, 1, 3, new DateTimeOffset(new DateTime(2020, 12, 10, 9, 7, 22, 365, DateTimeKind.Unspecified).AddTicks(9841), new TimeSpan(0, -5, 0, 0, 0)), 1 },
                    { 2, 2, 4, new DateTimeOffset(new DateTime(2020, 12, 15, 9, 7, 22, 366, DateTimeKind.Unspecified).AddTicks(387), new TimeSpan(0, -5, 0, 0, 0)), 2 },
                    { 3, 3, 5, new DateTimeOffset(new DateTime(2020, 12, 5, 9, 7, 22, 366, DateTimeKind.Unspecified).AddTicks(406), new TimeSpan(0, -5, 0, 0, 0)), 2 },
                    { 4, 4, 6, new DateTimeOffset(new DateTime(2020, 12, 12, 9, 7, 22, 366, DateTimeKind.Unspecified).AddTicks(413), new TimeSpan(0, -5, 0, 0, 0)), 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "DiscountId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Salespeople",
                keyColumn: "SalespersonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Salespeople",
                keyColumn: "SalespersonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Salespeople",
                keyColumn: "SalespersonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Salespeople",
                keyColumn: "SalespersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Salespeople",
                keyColumn: "SalespersonId",
                keyValue: 2);
        }
    }
}
