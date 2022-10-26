using FizzBuzz.Data;
using FizzBuzz.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FizzBuzz.Migrations
{
    public partial class DataSeeder : Migration
    {
        

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            SeedNumberSQL(migrationBuilder);

        }

        private void SeedNumberSQL(MigrationBuilder migrationBuilder)
        {
         
            string a ;
            for (int i = 1; i <=100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    a = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    a = "Fizz";
                }
                else if (i % 5 == 0)
                {
                   a = "Buzz";
                }
                else
                {
                   a = i.ToString() ;
                }           
              
                string id = Guid.NewGuid().ToString();
                migrationBuilder.Sql(@$"INSERT INTO [dbo].[FizzNum] ([FZN] ) VALUES ( '{a}' );");
            }   
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
             
    }
    
}
