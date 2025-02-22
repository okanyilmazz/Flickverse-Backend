using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Categories",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Categories", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Countries",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Countries", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ExclusiveLounges",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ExclusiveLounges", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Languages",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Languages", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Casts",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Biography = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Casts", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Casts_Countries_CountryId",
            //            column: x => x.CountryId,
            //            principalTable: "Countries",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Cities",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Cities", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Cities_Countries_CountryId",
            //            column: x => x.CountryId,
            //            principalTable: "Countries",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Directors",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Biography = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Directors", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Directors_Countries_CountryId",
            //            column: x => x.CountryId,
            //            principalTable: "Countries",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Movies",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        IMDbRating = table.Column<double>(type: "float", nullable: false),
            //        ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ProductionYear = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Movies", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Movies_Countries_CountryId",
            //            column: x => x.CountryId,
            //            principalTable: "Countries",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Movies_Languages_LanguageId",
            //            column: x => x.LanguageId,
            //            principalTable: "Languages",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CastImages",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CastId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CastImages", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_CastImages_Casts_CastId",
            //            column: x => x.CastId,
            //            principalTable: "Casts",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Districts",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Districts", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Districts_Cities_CityId",
            //            column: x => x.CityId,
            //            principalTable: "Cities",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DirectorImages",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        DirectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DirectorImages", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_DirectorImages_Directors_DirectorId",
            //            column: x => x.DirectorId,
            //            principalTable: "Directors",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MovieCasts",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CastId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MovieCasts", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_MovieCasts_Casts_CastId",
            //            column: x => x.CastId,
            //            principalTable: "Casts",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_MovieCasts_Movies_MovieId",
            //            column: x => x.MovieId,
            //            principalTable: "Movies",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MovieCategories",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MovieCategories", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_MovieCategories_Categories_CategoryId",
            //            column: x => x.CategoryId,
            //            principalTable: "Categories",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_MovieCategories_Movies_MovieId",
            //            column: x => x.MovieId,
            //            principalTable: "Movies",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MovieDirectors",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        DirectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MovieDirectors", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_MovieDirectors_Directors_DirectorId",
            //            column: x => x.DirectorId,
            //            principalTable: "Directors",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_MovieDirectors_Movies_MovieId",
            //            column: x => x.MovieId,
            //            principalTable: "Movies",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MovieExclusiveLounges",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ExclusiveLoungeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MovieExclusiveLounges", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_MovieExclusiveLounges_ExclusiveLounges_ExclusiveLoungeId",
            //            column: x => x.ExclusiveLoungeId,
            //            principalTable: "ExclusiveLounges",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_MovieExclusiveLounges_Movies_MovieId",
            //            column: x => x.MovieId,
            //            principalTable: "Movies",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MovieImages",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MovieImages", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_MovieImages_Movies_MovieId",
            //            column: x => x.MovieId,
            //            principalTable: "Movies",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Addresses",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        AddressDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Addresses", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Addresses_Cities_CityId",
            //            column: x => x.CityId,
            //            principalTable: "Cities",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Addresses_Countries_CountryId",
            //            column: x => x.CountryId,
            //            principalTable: "Countries",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Addresses_Districts_DistrictId",
            //            column: x => x.DistrictId,
            //            principalTable: "Districts",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CinemaHalls",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CinemaHalls", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_CinemaHalls_Addresses_AddressId",
            //            column: x => x.AddressId,
            //            principalTable: "Addresses",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CinemaHallExclusiveLounges",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CinemaHallId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ExclusiveLoungeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CinemaHallExclusiveLounges", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_CinemaHallExclusiveLounges_CinemaHalls_CinemaHallId",
            //            column: x => x.CinemaHallId,
            //            principalTable: "CinemaHalls",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_CinemaHallExclusiveLounges_ExclusiveLounges_ExclusiveLoungeId",
            //            column: x => x.ExclusiveLoungeId,
            //            principalTable: "ExclusiveLounges",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CinemaHallMovies",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CinemaHallId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CinemaHallMovies", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_CinemaHallMovies_CinemaHalls_CinemaHallId",
            //            column: x => x.CinemaHallId,
            //            principalTable: "CinemaHalls",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_CinemaHallMovies_Movies_MovieId",
            //            column: x => x.MovieId,
            //            principalTable: "Movies",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Addresses_CityId",
            //    table: "Addresses",
            //    column: "CityId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Addresses_CountryId",
            //    table: "Addresses",
            //    column: "CountryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Addresses_DistrictId",
            //    table: "Addresses",
            //    column: "DistrictId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "Addresses",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_CastImages_CastId",
            //    table: "CastImages",
            //    column: "CastId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "CastImages",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Casts_CountryId",
            //    table: "Casts",
            //    column: "CountryId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "Casts",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "Categories",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_CinemaHallExclusiveLounges_CinemaHallId",
            //    table: "CinemaHallExclusiveLounges",
            //    column: "CinemaHallId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CinemaHallExclusiveLounges_ExclusiveLoungeId",
            //    table: "CinemaHallExclusiveLounges",
            //    column: "ExclusiveLoungeId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "CinemaHallExclusiveLounges",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_CinemaHallMovies_CinemaHallId",
            //    table: "CinemaHallMovies",
            //    column: "CinemaHallId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CinemaHallMovies_MovieId",
            //    table: "CinemaHallMovies",
            //    column: "MovieId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "CinemaHallMovies",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_CinemaHalls_AddressId",
            //    table: "CinemaHalls",
            //    column: "AddressId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "CinemaHalls",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cities_CountryId",
            //    table: "Cities",
            //    column: "CountryId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "Cities",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "Countries",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_DirectorImages_DirectorId",
            //    table: "DirectorImages",
            //    column: "DirectorId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "DirectorImages",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Directors_CountryId",
            //    table: "Directors",
            //    column: "CountryId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "Directors",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Districts_CityId",
            //    table: "Districts",
            //    column: "CityId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "Districts",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "ExclusiveLounges",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "Languages",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_MovieCasts_CastId",
            //    table: "MovieCasts",
            //    column: "CastId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MovieCasts_MovieId",
            //    table: "MovieCasts",
            //    column: "MovieId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "MovieCasts",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_MovieCategories_CategoryId",
            //    table: "MovieCategories",
            //    column: "CategoryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MovieCategories_MovieId",
            //    table: "MovieCategories",
            //    column: "MovieId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "MovieCategories",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_MovieDirectors_DirectorId",
            //    table: "MovieDirectors",
            //    column: "DirectorId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MovieDirectors_MovieId",
            //    table: "MovieDirectors",
            //    column: "MovieId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "MovieDirectors",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_MovieExclusiveLounges_ExclusiveLoungeId",
            //    table: "MovieExclusiveLounges",
            //    column: "ExclusiveLoungeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MovieExclusiveLounges_MovieId",
            //    table: "MovieExclusiveLounges",
            //    column: "MovieId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "MovieExclusiveLounges",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_MovieImages_MovieId",
            //    table: "MovieImages",
            //    column: "MovieId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "MovieImages",
            //    column: "Id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Movies_CountryId",
            //    table: "Movies",
            //    column: "CountryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Movies_LanguageId",
            //    table: "Movies",
            //    column: "LanguageId");

            //migrationBuilder.CreateIndex(
            //    name: "UK_Id",
            //    table: "Movies",
            //    column: "Id",
            //    unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CastImages");

            migrationBuilder.DropTable(
                name: "CinemaHallExclusiveLounges");

            migrationBuilder.DropTable(
                name: "CinemaHallMovies");

            migrationBuilder.DropTable(
                name: "DirectorImages");

            migrationBuilder.DropTable(
                name: "MovieCasts");

            migrationBuilder.DropTable(
                name: "MovieCategories");

            migrationBuilder.DropTable(
                name: "MovieDirectors");

            migrationBuilder.DropTable(
                name: "MovieExclusiveLounges");

            migrationBuilder.DropTable(
                name: "MovieImages");

            migrationBuilder.DropTable(
                name: "CinemaHalls");

            migrationBuilder.DropTable(
                name: "Casts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "ExclusiveLounges");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
