using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestN5.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "permission_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false, comment: "Unique ID for the requirement status")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "varchar(50)", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    last_modified_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permission_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    document_number = table.Column<string>(type: "varchar(20)", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    last_name = table.Column<string>(type: "varchar(50)", nullable: false),
                    email = table.Column<string>(type: "varchar(60)", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    last_modified_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "permission",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Unique identifier for the permission"),
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    permission_type_id = table.Column<int>(type: "int", nullable: false),
                    permission_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    last_modified_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permission", x => x.id);
                    table.ForeignKey(
                        name: "FK_permission_permission_type_permission_type_id",
                        column: x => x.permission_type_id,
                        principalTable: "permission_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_permission_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_permission_permission_type_id",
                table: "permission",
                column: "permission_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_permission_user_id",
                table: "permission",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_users_document_number",
                table: "users",
                column: "document_number",
                unique: true);

            // Insertar datos en permission_type
            migrationBuilder.Sql("INSERT INTO dbo.permission_type (description, created_date) VALUES ('DÍA DE CUMPLEAÑOS', GETDATE());");
            migrationBuilder.Sql("INSERT INTO dbo.permission_type (description, created_date) VALUES ('PERMISO POR ENFERMEDAD', GETDATE());");
            migrationBuilder.Sql("INSERT INTO dbo.permission_type (description, created_date) VALUES ('PERMISO POR VACACIONES', GETDATE());");
            migrationBuilder.Sql("INSERT INTO dbo.permission_type (description, created_date) VALUES ('PERMISO POR MATERNIDAD', GETDATE());");
            migrationBuilder.Sql("INSERT INTO dbo.permission_type (description, created_date) VALUES ('PERMISO POR ASUNTOS PERSONALES', GETDATE());");

            // Insertar datos en users
            migrationBuilder.Sql("INSERT INTO users (id, name, last_name, document_number, email, is_active, created_date) VALUES ('e2da7a26-60cc-42cc-94aa-5b56e4f54838','ANDRES','MEDINA','12345','amedina@yopmail.com',1,GETDATE());");
            migrationBuilder.Sql("INSERT INTO users (id, name, last_name, document_number, email, is_active, created_date) VALUES ('02b3ac4e-cb91-4f43-bd6c-474fc88e8095','HANER','PRUEBA','234545','haner@yopmail.com',1,GETDATE());");
            migrationBuilder.Sql("INSERT INTO users (id, name, last_name, document_number, email, is_active, created_date) VALUES ('1fd36d1a-cce6-444e-ae29-a94bf0ed6efb','THIAGO','PRUEBA','110504','tprueba@yopmail.com',1,GETDATE());");
            migrationBuilder.Sql("INSERT INTO users (id, name, last_name, document_number, email, is_active, created_date) VALUES ('f05b6a59-98e4-43ec-8caa-387e68c2b4b9','ANALIA','PRUEBA','9349586','aprueba@yopmail.com',1,GETDATE());");
            migrationBuilder.Sql("INSERT INTO users (id, name, last_name, document_number, email, is_active, created_date) VALUES ('afdf57e7-4a9a-42f1-9bb7-6952b1317cb2','CHRISTOPHER','PRUEBA','654321','cprueba@yopmail.com',1,GETDATE());");
            migrationBuilder.Sql("INSERT INTO users (id, name, last_name, document_number, email, is_active, created_date) VALUES ('91c3f6f1-3aca-4e4d-8a92-03fa47da3fb6','MAYRA','PRUEBA','537969','mprueba@yopmail.com',1,GETDATE());");

            // Insertar datos en permission
            migrationBuilder.Sql("INSERT INTO permission (id, user_id, permission_type_id, permission_date, created_date) VALUES ('80be0d36-bfc6-4ca8-8c1e-2a39231ead0c','e2da7a26-60cc-42cc-94aa-5b56e4f54838',2,'2025-04-25',GETDATE());");
            migrationBuilder.Sql("INSERT INTO permission (id, user_id, permission_type_id, permission_date, created_date) VALUES ('a83f9a9e-1848-4f16-8311-91d7bc69d623','02b3ac4e-cb91-4f43-bd6c-474fc88e8095',1,'2025-04-20',GETDATE());");
            migrationBuilder.Sql("INSERT INTO permission (id, user_id, permission_type_id, permission_date, created_date) VALUES ('fcf3a92f-76ef-4e2d-ab07-ed9912d8b4a2','1fd36d1a-cce6-444e-ae29-a94bf0ed6efb',3,'2025-04-19',GETDATE());");
            migrationBuilder.Sql("INSERT INTO permission (id, user_id, permission_type_id, permission_date, created_date) VALUES ('da2b9fe4-160e-4fbe-89b2-a7b69089067e','f05b6a59-98e4-43ec-8caa-387e68c2b4b9',4,'2025-04-30',GETDATE());");
            migrationBuilder.Sql("INSERT INTO permission (id, user_id, permission_type_id, permission_date, created_date) VALUES ('2cea1e4d-a3ec-41cb-a4a9-f6853f34ddbb','afdf57e7-4a9a-42f1-9bb7-6952b1317cb2',5,'2025-04-26',GETDATE());");
            migrationBuilder.Sql("INSERT INTO permission (id, user_id, permission_type_id, permission_date, created_date) VALUES ('d1a8ff20-ce7f-4e42-bd5e-c9198be56649','91c3f6f1-3aca-4e4d-8a92-03fa47da3fb6',1,'2025-04-23',GETDATE());");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "permission");

            migrationBuilder.DropTable(
                name: "permission_type");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
