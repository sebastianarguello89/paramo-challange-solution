using Microsoft.EntityFrameworkCore.Migrations;

namespace Sat.Recruitment.DataAccess.Migrations
{
    public partial class populateusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			var sp = @"EXEC(N'
               INSERT INTO [dbo].[Users]
					(
						Name,
						Email,
						Address,
						Phone,
						Money,
						Discriminator
					)
			   VALUES
					(
						''Juan'',
						''Juan@marmol.com'',
						''Peru 2464'',
						''+5491154762312'',
						1234,
						''NormalUser''
					),
					(
						''Franco'',
						''Franco.Perez@gmail.com'',
						''Alvear y Colombres'',
						''+534645213542'',
						112234,
						''PremiumUser''
					),
					(
						''Agustina'',
						''Agustina@gmail.com'',
						''Garay y Otra Calle'',
						''+534645213542'',
						112234,
						''SuperUser''
					);                
			')";

			migrationBuilder.Sql(sp);
		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
