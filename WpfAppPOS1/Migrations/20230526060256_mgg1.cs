﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfAppPOS1.Migrations
{
    /// <inheritdoc />
    public partial class mgg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 76, 229, 211, 54, 184, 78, 168, 35, 38, 94, 173, 189, 0, 156, 161, 131, 222, 210, 116, 109, 50, 228, 173, 109, 95, 191, 41, 163, 221, 173, 207, 179, 212, 31, 12, 58, 21, 1, 173, 55, 173, 41, 21, 138, 229, 121, 85, 23, 64, 211, 119, 110, 32, 66, 99, 92, 21, 158, 176, 83, 17, 30, 204, 166 }, new byte[] { 226, 22, 225, 138, 152, 162, 184, 43, 37, 209, 130, 212, 53, 99, 142, 196, 165, 232, 239, 150, 255, 49, 146, 44, 18, 86, 66, 252, 153, 73, 102, 235, 124, 6, 227, 71, 77, 113, 7, 73, 224, 172, 13, 111, 64, 173, 110, 0, 76, 177, 219, 116, 215, 160, 2, 216, 12, 71, 163, 203, 139, 203, 175, 158, 225, 17, 132, 245, 107, 169, 182, 203, 184, 0, 188, 162, 233, 134, 138, 90, 90, 164, 174, 231, 37, 67, 61, 211, 98, 20, 185, 111, 178, 148, 86, 34, 245, 190, 173, 127, 121, 173, 63, 97, 24, 0, 76, 86, 65, 190, 103, 187, 18, 139, 8, 103, 85, 4, 213, 27, 6, 71, 167, 124, 98, 165, 249, 68 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 52, 19, 154, 19, 120, 34, 228, 126, 5, 44, 43, 178, 245, 59, 125, 146, 26, 49, 30, 43, 192, 90, 142, 113, 171, 137, 149, 55, 103, 67, 35, 123, 33, 227, 230, 97, 237, 204, 184, 14, 86, 26, 13, 156, 214, 151, 162, 44, 220, 161, 94, 226, 182, 129, 240, 208, 234, 115, 226, 119, 254, 172, 19, 126 }, new byte[] { 89, 156, 134, 239, 66, 230, 24, 88, 90, 118, 118, 238, 187, 151, 191, 128, 211, 85, 252, 149, 1, 136, 53, 59, 164, 207, 205, 248, 230, 105, 22, 14, 133, 78, 16, 63, 13, 82, 57, 167, 18, 70, 152, 170, 180, 68, 121, 20, 25, 222, 242, 114, 78, 242, 54, 129, 236, 219, 39, 184, 217, 247, 112, 132, 198, 81, 168, 150, 158, 244, 37, 215, 80, 18, 129, 24, 234, 22, 207, 6, 68, 68, 116, 172, 40, 205, 204, 164, 159, 190, 129, 158, 135, 102, 67, 11, 125, 84, 169, 143, 133, 95, 228, 196, 246, 70, 48, 166, 216, 175, 197, 138, 207, 55, 192, 224, 103, 236, 74, 187, 26, 22, 230, 55, 85, 68, 135, 220 } });
        }
    }
}
