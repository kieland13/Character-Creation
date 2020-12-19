using Microsoft.EntityFrameworkCore.Migrations;

namespace DAndDWebsite.Migrations.MvcStatistic
{
    public partial class StatisticInitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statistic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatId = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    Initiative = table.Column<int>(type: "int", nullable: false),
                    Proficiency = table.Column<int>(type: "int", nullable: false),
                    HealthPoints = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Acrobatics = table.Column<int>(type: "int", nullable: false),
                    AnimalHandling = table.Column<int>(type: "int", nullable: false),
                    Arcana = table.Column<int>(type: "int", nullable: false),
                    Athletics = table.Column<int>(type: "int", nullable: false),
                    Deception = table.Column<int>(type: "int", nullable: false),
                    History = table.Column<int>(type: "int", nullable: false),
                    Insight = table.Column<int>(type: "int", nullable: false),
                    Intimidation = table.Column<int>(type: "int", nullable: false),
                    Investigation = table.Column<int>(type: "int", nullable: false),
                    Medicine = table.Column<int>(type: "int", nullable: false),
                    Nature = table.Column<int>(type: "int", nullable: false),
                    Perception = table.Column<int>(type: "int", nullable: false),
                    Performance = table.Column<int>(type: "int", nullable: false),
                    Persuassion = table.Column<int>(type: "int", nullable: false),
                    Religion = table.Column<int>(type: "int", nullable: false),
                    SleightOfHand = table.Column<int>(type: "int", nullable: false),
                    Stealth = table.Column<int>(type: "int", nullable: false),
                    Survival = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistic", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statistic");
        }
    }
}
