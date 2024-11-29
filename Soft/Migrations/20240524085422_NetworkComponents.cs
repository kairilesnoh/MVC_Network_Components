using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nc.Soft.Migrations; 
/// <inheritdoc />
public partial class NetworkComponents : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.EnsureSchema(
            name: "ConnectionComponent");

        migrationBuilder.EnsureSchema(
            name: "NetworkServer");

        migrationBuilder.EnsureSchema(
            name: "NetworkComponentType");

        migrationBuilder.EnsureSchema(
            name: "Facility");

        migrationBuilder.EnsureSchema(
            name: "Location");

        migrationBuilder.EnsureSchema(
            name: "SupportStructure");

        migrationBuilder.CreateTable(
            name: "AspNetRoles",
            columns: table => new
            {
                Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetRoles", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUsers",
            columns: table => new
            {
                Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                AccessFailedCount = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUsers", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "CableWirings",
            schema: "ConnectionComponent",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Length = table.Column<double>(type: "float", nullable: false),
                ConnectorType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                SerialNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                FacilityId = table.Column<int>(type: "int", nullable: false),
                NetworkServerTypeId = table.Column<int>(type: "int", nullable: false),
                PathwayId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_CableWirings", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "CommunicationAppearances",
            schema: "NetworkServer",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                SerialNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                FacilityId = table.Column<int>(type: "int", nullable: false),
                NetworkServerTypeId = table.Column<int>(type: "int", nullable: false),
                GeographicPointId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_CommunicationAppearances", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "ConnectionComponentTypes",
            schema: "NetworkComponentType",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Speed = table.Column<double>(type: "float", nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ConnectionComponentTypes", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "DeviceTypes",
            schema: "NetworkComponentType",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                HardwareVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_DeviceTypes", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "FacilityEntities",
            schema: "Facility",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                FacilityTypeId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_FacilityEntities", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "FacilityTypes",
            schema: "Facility",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_FacilityTypes", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "FiberWirings",
            schema: "ConnectionComponent",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Length = table.Column<double>(type: "float", nullable: false),
                ConnectorType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                SerialNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                FacilityId = table.Column<int>(type: "int", nullable: false),
                NetworkServerTypeId = table.Column<int>(type: "int", nullable: false),
                PathwayId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_FiberWirings", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "GeographicBoundaries",
            schema: "Location",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_GeographicBoundaries", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "GeographicPoints",
            schema: "Location",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_GeographicPoints", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "MicrowaveComponents",
            schema: "ConnectionComponent",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Frequency = table.Column<double>(type: "float", nullable: false),
                PowerOutput = table.Column<double>(type: "float", nullable: false),
                SerialNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                FacilityId = table.Column<int>(type: "int", nullable: false),
                NetworkServerTypeId = table.Column<int>(type: "int", nullable: false),
                PathwayId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_MicrowaveComponents", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "NetworkServerTypes",
            schema: "NetworkComponentType",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Memory = table.Column<int>(type: "int", nullable: false),
                Hostname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_NetworkServerTypes", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Pathways",
            schema: "Location",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                TotalDistance = table.Column<double>(type: "float", nullable: false),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Pathways", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Routers",
            schema: "NetworkServer",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                SerialNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                FacilityId = table.Column<int>(type: "int", nullable: false),
                NetworkServerTypeId = table.Column<int>(type: "int", nullable: false),
                GeographicPointId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Routers", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "SupportStructures",
            schema: "SupportStructure",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                InstallationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                IsMaintenanceValid = table.Column<bool>(type: "bit", nullable: true),
                GeographicPointId = table.Column<int>(type: "int", nullable: false),
                SerialNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                FacilityId = table.Column<int>(type: "int", nullable: false),
                NetworkServerTypeId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_SupportStructures", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "SupportStructureTypes",
            schema: "NetworkComponentType",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_SupportStructureTypes", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Switches",
            schema: "NetworkServer",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                NumberOfPorts = table.Column<int>(type: "int", nullable: false),
                SerialNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                FacilityId = table.Column<int>(type: "int", nullable: false),
                NetworkServerTypeId = table.Column<int>(type: "int", nullable: false),
                GeographicPointId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Switches", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "AspNetRoleClaims",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                table.ForeignKey(
                    name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                    column: x => x.RoleId,
                    principalTable: "AspNetRoles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserClaims",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                table.ForeignKey(
                    name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserLogins",
            columns: table => new
            {
                LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                table.ForeignKey(
                    name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserRoles",
            columns: table => new
            {
                UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                table.ForeignKey(
                    name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                    column: x => x.RoleId,
                    principalTable: "AspNetRoles",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserTokens",
            columns: table => new
            {
                UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                table.ForeignKey(
                    name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                    column: x => x.UserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_AspNetRoleClaims_RoleId",
            table: "AspNetRoleClaims",
            column: "RoleId");

        migrationBuilder.CreateIndex(
            name: "RoleNameIndex",
            table: "AspNetRoles",
            column: "NormalizedName",
            unique: true,
            filter: "[NormalizedName] IS NOT NULL");

        migrationBuilder.CreateIndex(
            name: "IX_AspNetUserClaims_UserId",
            table: "AspNetUserClaims",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_AspNetUserLogins_UserId",
            table: "AspNetUserLogins",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_AspNetUserRoles_RoleId",
            table: "AspNetUserRoles",
            column: "RoleId");

        migrationBuilder.CreateIndex(
            name: "EmailIndex",
            table: "AspNetUsers",
            column: "NormalizedEmail");

        migrationBuilder.CreateIndex(
            name: "UserNameIndex",
            table: "AspNetUsers",
            column: "NormalizedUserName",
            unique: true,
            filter: "[NormalizedUserName] IS NOT NULL");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "AspNetRoleClaims");

        migrationBuilder.DropTable(
            name: "AspNetUserClaims");

        migrationBuilder.DropTable(
            name: "AspNetUserLogins");

        migrationBuilder.DropTable(
            name: "AspNetUserRoles");

        migrationBuilder.DropTable(
            name: "AspNetUserTokens");

        migrationBuilder.DropTable(
            name: "CableWirings",
            schema: "ConnectionComponent");

        migrationBuilder.DropTable(
            name: "CommunicationAppearances",
            schema: "NetworkServer");

        migrationBuilder.DropTable(
            name: "ConnectionComponentTypes",
            schema: "NetworkComponentType");

        migrationBuilder.DropTable(
            name: "DeviceTypes",
            schema: "NetworkComponentType");

        migrationBuilder.DropTable(
            name: "FacilityEntities",
            schema: "Facility");

        migrationBuilder.DropTable(
            name: "FacilityTypes",
            schema: "Facility");

        migrationBuilder.DropTable(
            name: "FiberWirings",
            schema: "ConnectionComponent");

        migrationBuilder.DropTable(
            name: "GeographicBoundaries",
            schema: "Location");

        migrationBuilder.DropTable(
            name: "GeographicPoints",
            schema: "Location");

        migrationBuilder.DropTable(
            name: "MicrowaveComponents",
            schema: "ConnectionComponent");

        migrationBuilder.DropTable(
            name: "NetworkServerTypes",
            schema: "NetworkComponentType");

        migrationBuilder.DropTable(
            name: "Pathways",
            schema: "Location");

        migrationBuilder.DropTable(
            name: "Routers",
            schema: "NetworkServer");

        migrationBuilder.DropTable(
            name: "SupportStructures",
            schema: "SupportStructure");

        migrationBuilder.DropTable(
            name: "SupportStructureTypes",
            schema: "NetworkComponentType");

        migrationBuilder.DropTable(
            name: "Switches",
            schema: "NetworkServer");

        migrationBuilder.DropTable(
            name: "AspNetRoles");

        migrationBuilder.DropTable(
            name: "AspNetUsers");
    }
}
