using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Connexio.Migrations
{
    public partial class NovesTaules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equips",
                columns: table => new
                {
                    nom_equip = table.Column<string>(type: "varchar(30)", nullable: false),
                    img_equip = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equips", x => x.nom_equip);
                });

            migrationBuilder.CreateTable(
                name: "Habilitats",
                columns: table => new
                {
                    nom_habilitat = table.Column<string>(type: "varchar(40)", nullable: false),
                    tipus_habilitat = table.Column<string>(type: "varchar(40)", nullable: true),
                    dmg = table.Column<int>(type: "integer", nullable: true),
                    descripcio_habilitat = table.Column<string>(type: "varchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilitats", x => x.nom_habilitat);
                });

            migrationBuilder.CreateTable(
                name: "ObjecteEquips",
                columns: table => new
                {
                    nom_objecte_equip = table.Column<string>(type: "varchar(30)", nullable: false),
                    descripcio_objecte_equip = table.Column<string>(type: "varchar(200)", nullable: true),
                    img = table.Column<string>(type: "varchar(100)", nullable: true),
                    valor = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjecteEquips", x => x.nom_objecte_equip);
                });

            migrationBuilder.CreateTable(
                name: "Objectes",
                columns: table => new
                {
                    nom_objecte = table.Column<string>(type: "varchar(30)", nullable: false),
                    descripcio_objecte = table.Column<string>(type: "varchar(300)", nullable: true),
                    img_objecte = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objectes", x => x.nom_objecte);
                });

            migrationBuilder.CreateTable(
                name: "Temps",
                columns: table => new
                {
                    nom_temps = table.Column<string>(type: "varchar(30)", nullable: false),
                    img_temps = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temps", x => x.nom_temps);
                });

            migrationBuilder.CreateTable(
                name: "Tipus",
                columns: table => new
                {
                    nom_tipus = table.Column<string>(type: "varchar(40)", nullable: false),
                    nom_color = table.Column<string>(type: "varchar(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipus", x => x.nom_tipus);
                });

            migrationBuilder.CreateTable(
                name: "TipusPokeparada",
                columns: table => new
                {
                    nom_pokeparada = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipusPokeparada", x => x.nom_pokeparada);
                });

            migrationBuilder.CreateTable(
                name: "Usuaris",
                columns: table => new
                {
                    nom_usuari = table.Column<string>(type: "varchar(25)", nullable: false),
                    nivell = table.Column<double>(type: "double precision", nullable: true),
                    data_creacio = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    distancia = table.Column<double>(type: "double precision", nullable: true),
                    polvos_estelares = table.Column<int>(type: "integer", nullable: true),
                    is_online = table.Column<bool>(type: "boolean", nullable: true),
                    nom_equip = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Usuari_pkey", x => x.nom_usuari);
                    table.ForeignKey(
                        name: "fk_nom_equip",
                        column: x => x.nom_equip,
                        principalTable: "Equips",
                        principalColumn: "nom_equip",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventariEquips",
                columns: table => new
                {
                    nom_equip = table.Column<string>(type: "varchar(30)", nullable: false),
                    nom_objecte_equip = table.Column<string>(type: "varchar(30)", nullable: false),
                    quantitat = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Inventari_equip_pkey", x => new { x.nom_equip, x.nom_objecte_equip });
                    table.ForeignKey(
                        name: "Inventari_equip_nom_equip_fkey",
                        column: x => x.nom_equip,
                        principalTable: "Equips",
                        principalColumn: "nom_equip",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Inventari_equip_nom_objecte_equip_fkey",
                        column: x => x.nom_objecte_equip,
                        principalTable: "ObjecteEquips",
                        principalColumn: "nom_objecte_equip",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    num_pokedex = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nom_pokemon = table.Column<string>(type: "varchar(40)", nullable: true),
                    descripcio_pokemon = table.Column<string>(type: "varchar(300)", nullable: true),
                    img_pokemon = table.Column<string>(type: "varchar(100)", nullable: true),
                    tipus_pokemon = table.Column<string>(type: "varchar(40)", nullable: true),
                    ps_min = table.Column<int>(type: "integer", nullable: true),
                    ps_max = table.Column<string>(type: "varchar(40)", nullable: true),
                    pc_min = table.Column<int>(type: "integer", nullable: true),
                    pc_max = table.Column<int>(type: "integer", nullable: true),
                    nom_familia = table.Column<string>(type: "varchar(40)", nullable: true),
                    ordre_familia = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pokemon_pkey", x => x.num_pokedex);
                    table.ForeignKey(
                        name: "fk_tipus_nom",
                        column: x => x.tipus_pokemon,
                        principalTable: "Tipus",
                        principalColumn: "nom_tipus",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipusPotenciatClimas",
                columns: table => new
                {
                    nom_tipus = table.Column<string>(type: "varchar(30)", nullable: false),
                    emisor = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Tipus_potenciat_clima_pkey", x => new { x.nom_tipus, x.emisor });
                    table.ForeignKey(
                        name: "Tipus_potenciat_clima_nom_temps_fkey",
                        column: x => x.emisor,
                        principalTable: "Temps",
                        principalColumn: "nom_temps",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Tipus_potenciat_clima_nom_tipus_fkey",
                        column: x => x.nom_tipus,
                        principalTable: "Tipus",
                        principalColumn: "nom_tipus",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pokeparada",
                columns: table => new
                {
                    latitud = table.Column<double>(type: "double precision", nullable: false),
                    longitud = table.Column<double>(type: "double precision", nullable: false),
                    nom_pokeparada = table.Column<string>(type: "varchar(40)", nullable: true),
                    descripcio_pokeparada = table.Column<string>(type: "varchar(300)", nullable: true),
                    img_pokeparada = table.Column<string>(type: "varchar(100)", nullable: true),
                    tipus_pokeparada = table.Column<string>(type: "varchar(50)", nullable: true),
                    TipusPokeparadaNavigationNomTipus = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pokeparada_pkey", x => new { x.latitud, x.longitud });
                    table.ForeignKey(
                        name: "FK_Pokeparada_TipusPokeparada_TipusPokeparadaNavigationNomTipus",
                        column: x => x.TipusPokeparadaNavigationNomTipus,
                        principalTable: "TipusPokeparada",
                        principalColumn: "nom_pokeparada",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ObjecteUsuaris",
                columns: table => new
                {
                    nom_usuari = table.Column<string>(type: "varchar(25)", nullable: false),
                    nom_objecte = table.Column<string>(type: "varchar(25)", nullable: false),
                    quantitat = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Objecte_usuari_pkey", x => new { x.nom_usuari, x.nom_objecte });
                    table.ForeignKey(
                        name: "fk_nom_objecte_usuari",
                        column: x => x.nom_objecte,
                        principalTable: "Objectes",
                        principalColumn: "nom_objecte",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nom_usuari_objectes",
                        column: x => x.nom_usuari,
                        principalTable: "Usuaris",
                        principalColumn: "nom_usuari",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegalContinguts",
                columns: table => new
                {
                    emisor = table.Column<string>(type: "varchar(25)", nullable: false),
                    receptor = table.Column<string>(type: "varchar(25)", nullable: false),
                    nom_objecte = table.Column<string>(type: "varchar(30)", nullable: false),
                    quantitat = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Regal_contingut_pkey", x => new { x.emisor, x.receptor, x.nom_objecte });
                    table.ForeignKey(
                        name: "Regal_contingut_emisor_fkey",
                        column: x => x.emisor,
                        principalTable: "Usuaris",
                        principalColumn: "nom_usuari",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Regal_contingut_nom_objecte_fkey",
                        column: x => x.nom_objecte,
                        principalTable: "Objectes",
                        principalColumn: "nom_objecte",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Regal_contingut_receptor_fkey",
                        column: x => x.receptor,
                        principalTable: "Usuaris",
                        principalColumn: "nom_usuari",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsuariAmics",
                columns: table => new
                {
                    nom_usuari_amic = table.Column<string>(type: "varchar(25)", nullable: false),
                    nom_usuari = table.Column<string>(type: "varchar(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Usuari_amics_pkey", x => x.nom_usuari_amic);
                    table.ForeignKey(
                        name: "fk_nom_amic_usuari_amics",
                        column: x => x.nom_usuari_amic,
                        principalTable: "Usuaris",
                        principalColumn: "nom_usuari",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nom_usuari_amics",
                        column: x => x.nom_usuari,
                        principalTable: "Usuaris",
                        principalColumn: "nom_usuari",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsuariOpcions",
                columns: table => new
                {
                    nom_usuari = table.Column<string>(type: "varchar(25)", nullable: false),
                    musica = table.Column<int>(type: "integer", nullable: true),
                    soroll = table.Column<int>(type: "integer", nullable: true),
                    vibracio = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Usuari_opcions_pkey", x => x.nom_usuari);
                    table.ForeignKey(
                        name: "fk_nom_usuari_opcions",
                        column: x => x.nom_usuari,
                        principalTable: "Usuaris",
                        principalColumn: "nom_usuari",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HabilitatsPokemons",
                columns: table => new
                {
                    num_pokedex = table.Column<int>(type: "integer", nullable: false),
                    nom_habilitat = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Habilitats_pokemon_pkey", x => new { x.num_pokedex, x.nom_habilitat });
                    table.ForeignKey(
                        name: "fk_nom_habilitat_pokemon",
                        column: x => x.nom_habilitat,
                        principalTable: "Habilitats",
                        principalColumn: "nom_habilitat",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_num_pokedex_habilitat",
                        column: x => x.num_pokedex,
                        principalTable: "Pokemons",
                        principalColumn: "num_pokedex",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokedexUsuaris",
                columns: table => new
                {
                    num_pokedex = table.Column<int>(type: "integer", nullable: false),
                    nom_usuari = table.Column<string>(type: "varchar(25)", nullable: false),
                    data_visualitzacio = table.Column<DateTime>(type: "date", nullable: true),
                    cops_atrapats = table.Column<int>(type: "integer", nullable: true),
                    hasSeenShiny = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pokedex_usuari_pkey", x => new { x.num_pokedex, x.nom_usuari });
                    table.ForeignKey(
                        name: "Pokedex_usuari_nom_usuari_fkey",
                        column: x => x.nom_usuari,
                        principalTable: "Usuaris",
                        principalColumn: "nom_usuari",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Pokedex_usuari_num_pokedex_fkey",
                        column: x => x.num_pokedex,
                        principalTable: "Pokemons",
                        principalColumn: "num_pokedex",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsuariPokemonCaramels",
                columns: table => new
                {
                    nom_usuari = table.Column<string>(type: "varchar(25)", nullable: false),
                    num_pokemon = table.Column<int>(type: "integer", nullable: false),
                    quantitat = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Usuari_pokemon_caramels_pkey", x => new { x.nom_usuari, x.num_pokemon });
                    table.ForeignKey(
                        name: "fk_nom_usuari_caramels",
                        column: x => x.nom_usuari,
                        principalTable: "Usuaris",
                        principalColumn: "nom_usuari",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_num_pokedex_caramel",
                        column: x => x.num_pokemon,
                        principalTable: "Pokemons",
                        principalColumn: "num_pokedex",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsuariPokemons",
                columns: table => new
                {
                    id_usuari_pokemon = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nom_usuari = table.Column<string>(type: "varchar(25)", nullable: true),
                    data_captura = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    num_pokedex = table.Column<int>(type: "integer", nullable: false),
                    pc = table.Column<int>(type: "integer", nullable: true),
                    ps = table.Column<int>(type: "integer", nullable: true),
                    habilitat_pokemon_simple = table.Column<string>(type: "varchar(40)", nullable: true),
                    habilitat_pokemon_carregat = table.Column<string>(type: "varchar(40)", nullable: true),
                    is_in_gym = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Usuari_pokemon_pkey", x => x.id_usuari_pokemon);
                    table.ForeignKey(
                        name: "fk_habilitat_pokemon_carregat",
                        column: x => x.habilitat_pokemon_carregat,
                        principalTable: "Habilitats",
                        principalColumn: "nom_habilitat",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_habilitat_pokemon_simple",
                        column: x => x.habilitat_pokemon_simple,
                        principalTable: "Habilitats",
                        principalColumn: "nom_habilitat",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_nom_user_pokemon",
                        column: x => x.nom_usuari,
                        principalTable: "Usuaris",
                        principalColumn: "nom_usuari",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_num_pokedex_user_pokemon",
                        column: x => x.num_pokedex,
                        principalTable: "Pokemons",
                        principalColumn: "num_pokedex",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokeparadaGyms",
                columns: table => new
                {
                    latitud = table.Column<double>(type: "double precision", nullable: false),
                    longitud = table.Column<double>(type: "double precision", nullable: false),
                    nom_equip = table.Column<string>(type: "varchar(40)", nullable: true),
                    nom_usuari_1 = table.Column<int>(type: "integer", nullable: true),
                    nom_usuari_2 = table.Column<int>(type: "integer", nullable: true),
                    nom_usuari_3 = table.Column<int>(type: "integer", nullable: true),
                    nom_usuari_4 = table.Column<int>(type: "integer", nullable: true),
                    nom_usuari_5 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pokeparada_gym_pkey", x => new { x.latitud, x.longitud });
                    table.ForeignKey(
                        name: "fk_usuari_1",
                        column: x => x.nom_usuari_1,
                        principalTable: "UsuariPokemons",
                        principalColumn: "id_usuari_pokemon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_usuari_2",
                        column: x => x.nom_usuari_2,
                        principalTable: "UsuariPokemons",
                        principalColumn: "id_usuari_pokemon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_usuari_3",
                        column: x => x.nom_usuari_3,
                        principalTable: "UsuariPokemons",
                        principalColumn: "id_usuari_pokemon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_usuari_4",
                        column: x => x.nom_usuari_4,
                        principalTable: "UsuariPokemons",
                        principalColumn: "id_usuari_pokemon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_usuari_5",
                        column: x => x.nom_usuari_5,
                        principalTable: "UsuariPokemons",
                        principalColumn: "id_usuari_pokemon",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HabilitatsPokemons_nom_habilitat",
                table: "HabilitatsPokemons",
                column: "nom_habilitat");

            migrationBuilder.CreateIndex(
                name: "IX_InventariEquips_nom_objecte_equip",
                table: "InventariEquips",
                column: "nom_objecte_equip");

            migrationBuilder.CreateIndex(
                name: "IX_ObjecteUsuaris_nom_objecte",
                table: "ObjecteUsuaris",
                column: "nom_objecte");

            migrationBuilder.CreateIndex(
                name: "IX_PokedexUsuaris_nom_usuari",
                table: "PokedexUsuaris",
                column: "nom_usuari");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_tipus_pokemon",
                table: "Pokemons",
                column: "tipus_pokemon");

            migrationBuilder.CreateIndex(
                name: "IX_Pokeparada_TipusPokeparadaNavigationNomTipus",
                table: "Pokeparada",
                column: "TipusPokeparadaNavigationNomTipus");

            migrationBuilder.CreateIndex(
                name: "IX_PokeparadaGyms_nom_usuari_1",
                table: "PokeparadaGyms",
                column: "nom_usuari_1");

            migrationBuilder.CreateIndex(
                name: "IX_PokeparadaGyms_nom_usuari_2",
                table: "PokeparadaGyms",
                column: "nom_usuari_2");

            migrationBuilder.CreateIndex(
                name: "IX_PokeparadaGyms_nom_usuari_3",
                table: "PokeparadaGyms",
                column: "nom_usuari_3");

            migrationBuilder.CreateIndex(
                name: "IX_PokeparadaGyms_nom_usuari_4",
                table: "PokeparadaGyms",
                column: "nom_usuari_4");

            migrationBuilder.CreateIndex(
                name: "IX_PokeparadaGyms_nom_usuari_5",
                table: "PokeparadaGyms",
                column: "nom_usuari_5");

            migrationBuilder.CreateIndex(
                name: "IX_RegalContinguts_nom_objecte",
                table: "RegalContinguts",
                column: "nom_objecte");

            migrationBuilder.CreateIndex(
                name: "IX_RegalContinguts_receptor",
                table: "RegalContinguts",
                column: "receptor");

            migrationBuilder.CreateIndex(
                name: "IX_TipusPotenciatClimas_emisor",
                table: "TipusPotenciatClimas",
                column: "emisor");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariAmics_nom_usuari",
                table: "UsuariAmics",
                column: "nom_usuari");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariPokemonCaramels_num_pokemon",
                table: "UsuariPokemonCaramels",
                column: "num_pokemon");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariPokemons_habilitat_pokemon_carregat",
                table: "UsuariPokemons",
                column: "habilitat_pokemon_carregat");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariPokemons_habilitat_pokemon_simple",
                table: "UsuariPokemons",
                column: "habilitat_pokemon_simple");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariPokemons_nom_usuari",
                table: "UsuariPokemons",
                column: "nom_usuari");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariPokemons_num_pokedex",
                table: "UsuariPokemons",
                column: "num_pokedex");

            migrationBuilder.CreateIndex(
                name: "IX_Usuaris_nom_equip",
                table: "Usuaris",
                column: "nom_equip");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HabilitatsPokemons");

            migrationBuilder.DropTable(
                name: "InventariEquips");

            migrationBuilder.DropTable(
                name: "ObjecteUsuaris");

            migrationBuilder.DropTable(
                name: "PokedexUsuaris");

            migrationBuilder.DropTable(
                name: "Pokeparada");

            migrationBuilder.DropTable(
                name: "PokeparadaGyms");

            migrationBuilder.DropTable(
                name: "RegalContinguts");

            migrationBuilder.DropTable(
                name: "TipusPotenciatClimas");

            migrationBuilder.DropTable(
                name: "UsuariAmics");

            migrationBuilder.DropTable(
                name: "UsuariOpcions");

            migrationBuilder.DropTable(
                name: "UsuariPokemonCaramels");

            migrationBuilder.DropTable(
                name: "ObjecteEquips");

            migrationBuilder.DropTable(
                name: "TipusPokeparada");

            migrationBuilder.DropTable(
                name: "UsuariPokemons");

            migrationBuilder.DropTable(
                name: "Objectes");

            migrationBuilder.DropTable(
                name: "Temps");

            migrationBuilder.DropTable(
                name: "Habilitats");

            migrationBuilder.DropTable(
                name: "Usuaris");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Equips");

            migrationBuilder.DropTable(
                name: "Tipus");
        }
    }
}
