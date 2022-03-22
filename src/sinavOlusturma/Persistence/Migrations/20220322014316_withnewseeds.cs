using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class withnewseeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleText", "Title" },
                values: new object[] { 1, "metin1", "title1" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleText", "Title" },
                values: new object[] { 2, "metin2", "title1" });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "ArticleId", "CreationDate" },
                values: new object[] { 1, 1, new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "ArticleId", "CreationDate" },
                values: new object[] { 2, 2, new DateTime(2022, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswer", "ExamId", "OptionA", "OptionB", "OptionC", "OptionD", "QuestionText" },
                values: new object[] { 1, 1, 1, "a", "b", "c", "d", "soru text" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswer", "ExamId", "OptionA", "OptionB", "OptionC", "OptionD", "QuestionText" },
                values: new object[] { 2, 2, 1, "a", "b", "c", "d", "soru text" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswer", "ExamId", "OptionA", "OptionB", "OptionC", "OptionD", "QuestionText" },
                values: new object[] { 3, 3, 1, "a", "b", "c", "d", "soru text" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswer", "ExamId", "OptionA", "OptionB", "OptionC", "OptionD", "QuestionText" },
                values: new object[] { 4, 4, 1, "a", "b", "c", "d", "soru text" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswer", "ExamId", "OptionA", "OptionB", "OptionC", "OptionD", "QuestionText" },
                values: new object[] { 5, 1, 2, "a", "b", "c", "d", "soru text" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswer", "ExamId", "OptionA", "OptionB", "OptionC", "OptionD", "QuestionText" },
                values: new object[] { 6, 2, 2, "a", "b", "c", "d", "soru text" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswer", "ExamId", "OptionA", "OptionB", "OptionC", "OptionD", "QuestionText" },
                values: new object[] { 7, 3, 2, "a", "b", "c", "d", "soru text" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CorrectAnswer", "ExamId", "OptionA", "OptionB", "OptionC", "OptionD", "QuestionText" },
                values: new object[] { 8, 4, 2, "a", "b", "c", "d", "soru text" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
