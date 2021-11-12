﻿// <auto-generated />
using System;
using Connexio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Connexio.Migrations
{
    [DbContext(typeof(pokemongoolotContext))]
    [Migration("20211112183322_Noves Taules Per desencriptar")]
    partial class NovesTaulesPerdesencriptar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "en_US.UTF-8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Connexio.Equip", b =>
                {
                    b.Property<string>("NomEquip")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nom_equip");

                    b.Property<string>("ImgEquip")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("img_equip");

                    b.HasKey("NomEquip");

                    b.ToTable("Equips");
                });

            modelBuilder.Entity("Connexio.Habilitat", b =>
                {
                    b.Property<string>("NomHabilitat")
                        .HasColumnType("varchar(40)")
                        .HasColumnName("nom_habilitat");

                    b.Property<string>("DescripcioHabilitat")
                        .HasColumnType("varchar(150)")
                        .HasColumnName("descripcio_habilitat");

                    b.Property<int?>("Dmg")
                        .HasColumnType("integer")
                        .HasColumnName("dmg");

                    b.Property<string>("TipusHabilitat")
                        .HasColumnType("varchar(40)")
                        .HasColumnName("tipus_habilitat");

                    b.HasKey("NomHabilitat");

                    b.ToTable("Habilitats");
                });

            modelBuilder.Entity("Connexio.HabilitatsPokemon", b =>
                {
                    b.Property<int>("NumPokedex")
                        .HasColumnType("integer")
                        .HasColumnName("num_pokedex");

                    b.Property<string>("NomHabilitat")
                        .HasColumnType("varchar(40)")
                        .HasColumnName("nom_habilitat");

                    b.HasKey("NumPokedex", "NomHabilitat")
                        .HasName("Habilitats_pokemon_pkey");

                    b.HasIndex("NomHabilitat");

                    b.ToTable("HabilitatsPokemons");
                });

            modelBuilder.Entity("Connexio.InventariEquip", b =>
                {
                    b.Property<string>("NomEquip")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nom_equip");

                    b.Property<string>("NomObjecteEquip")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nom_objecte_equip");

                    b.Property<int?>("Quantitat")
                        .HasColumnType("integer")
                        .HasColumnName("quantitat");

                    b.HasKey("NomEquip", "NomObjecteEquip")
                        .HasName("Inventari_equip_pkey");

                    b.HasIndex("NomObjecteEquip");

                    b.ToTable("InventariEquips");
                });

            modelBuilder.Entity("Connexio.Objecte", b =>
                {
                    b.Property<string>("NomObjecte")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nom_objecte");

                    b.Property<string>("DescripcioObjecte")
                        .HasColumnType("varchar(300)")
                        .HasColumnName("descripcio_objecte");

                    b.Property<string>("ImgObjecte")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("img_objecte");

                    b.HasKey("NomObjecte");

                    b.ToTable("Objectes");
                });

            modelBuilder.Entity("Connexio.ObjecteEquip", b =>
                {
                    b.Property<string>("NomObjecteEquip")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nom_objecte_equip");

                    b.Property<string>("Desc")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("descripcio_objecte_equip");

                    b.Property<string>("Img")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("img");

                    b.Property<int?>("Valor")
                        .HasColumnType("integer")
                        .HasColumnName("valor");

                    b.HasKey("NomObjecteEquip");

                    b.ToTable("ObjecteEquips");
                });

            modelBuilder.Entity("Connexio.ObjecteUsuari", b =>
                {
                    b.Property<string>("NomUsuari")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("nom_usuari");

                    b.Property<string>("NomObjecte")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("nom_objecte");

                    b.Property<int?>("Quantitat")
                        .HasColumnType("integer")
                        .HasColumnName("quantitat");

                    b.HasKey("NomUsuari", "NomObjecte")
                        .HasName("Objecte_usuari_pkey");

                    b.HasIndex("NomObjecte");

                    b.ToTable("ObjecteUsuaris");
                });

            modelBuilder.Entity("Connexio.PokedexUsuari", b =>
                {
                    b.Property<int>("NumPokedex")
                        .HasColumnType("integer")
                        .HasColumnName("num_pokedex");

                    b.Property<string>("NomUsuari")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("nom_usuari");

                    b.Property<int?>("CopsAtrapat")
                        .HasColumnType("integer")
                        .HasColumnName("cops_atrapats");

                    b.Property<DateTime?>("DataVisualitzacio")
                        .HasColumnType("date")
                        .HasColumnName("data_visualitzacio");

                    b.Property<bool?>("HasSeenShiny")
                        .HasColumnType("boolean")
                        .HasColumnName("hasSeenShiny");

                    b.HasKey("NumPokedex", "NomUsuari")
                        .HasName("Pokedex_usuari_pkey");

                    b.HasIndex("NomUsuari");

                    b.ToTable("PokedexUsuaris");
                });

            modelBuilder.Entity("Connexio.Pokemon", b =>
                {
                    b.Property<int>("NumPokedex")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("num_pokedex")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DescripcioPokemon")
                        .HasColumnType("varchar(300)")
                        .HasColumnName("descripcio_pokemon");

                    b.Property<string>("ImgPokemon")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("img_pokemon");

                    b.Property<string>("NomFamilia")
                        .HasColumnType("varchar(40)")
                        .HasColumnName("nom_familia");

                    b.Property<string>("NomPokemon")
                        .HasColumnType("varchar(40)")
                        .HasColumnName("nom_pokemon");

                    b.Property<int?>("OrdreFamilia")
                        .HasColumnType("integer")
                        .HasColumnName("ordre_familia");

                    b.Property<int?>("PcMax")
                        .HasColumnType("integer")
                        .HasColumnName("pc_max");

                    b.Property<int?>("PcMin")
                        .HasColumnType("integer")
                        .HasColumnName("pc_min");

                    b.Property<string>("PsMax")
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ps_max");

                    b.Property<int?>("PsMin")
                        .HasColumnType("integer")
                        .HasColumnName("ps_min");

                    b.Property<string>("TipusPokemon")
                        .HasColumnType("varchar(40)")
                        .HasColumnName("tipus_pokemon");

                    b.HasKey("NumPokedex")
                        .HasName("Pokemon_pkey");

                    b.HasIndex("TipusPokemon");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("Connexio.Pokeparada", b =>
                {
                    b.Property<double>("Latitud")
                        .HasColumnType("double precision")
                        .HasColumnName("latitud");

                    b.Property<double>("Longitud")
                        .HasColumnType("double precision")
                        .HasColumnName("longitud");

                    b.Property<string>("DescripcioPokeparada")
                        .HasColumnType("varchar(300)")
                        .HasColumnName("descripcio_pokeparada");

                    b.Property<string>("ImgPokeparada")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("img_pokeparada");

                    b.Property<string>("NomPokeparada")
                        .HasColumnType("varchar(40)")
                        .HasColumnName("nom_pokeparada");

                    b.Property<string>("TipusPokeparada")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("tipus_pokeparada");

                    b.Property<string>("TipusPokeparadaNavigationNomTipus")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Latitud", "Longitud")
                        .HasName("Pokeparada_pkey");

                    b.HasIndex("TipusPokeparadaNavigationNomTipus");

                    b.ToTable("Pokeparada");
                });

            modelBuilder.Entity("Connexio.PokeparadaGym", b =>
                {
                    b.Property<double>("Latitud")
                        .HasColumnType("double precision")
                        .HasColumnName("latitud");

                    b.Property<double>("Longitud")
                        .HasColumnType("double precision")
                        .HasColumnName("longitud");

                    b.Property<string>("NomEquip")
                        .HasColumnType("varchar(40)")
                        .HasColumnName("nom_equip");

                    b.Property<int?>("NomUsuari1")
                        .HasColumnType("integer")
                        .HasColumnName("nom_usuari_1");

                    b.Property<int?>("NomUsuari2")
                        .HasColumnType("integer")
                        .HasColumnName("nom_usuari_2");

                    b.Property<int?>("NomUsuari3")
                        .HasColumnType("integer")
                        .HasColumnName("nom_usuari_3");

                    b.Property<int?>("NomUsuari4")
                        .HasColumnType("integer")
                        .HasColumnName("nom_usuari_4");

                    b.Property<int?>("NomUsuari5")
                        .HasColumnType("integer")
                        .HasColumnName("nom_usuari_5");

                    b.HasKey("Latitud", "Longitud")
                        .HasName("Pokeparada_gym_pkey");

                    b.HasIndex("NomUsuari1");

                    b.HasIndex("NomUsuari2");

                    b.HasIndex("NomUsuari3");

                    b.HasIndex("NomUsuari4");

                    b.HasIndex("NomUsuari5");

                    b.ToTable("PokeparadaGyms");
                });

            modelBuilder.Entity("Connexio.RegalContingut", b =>
                {
                    b.Property<string>("Emisor")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("emisor");

                    b.Property<string>("Receptor")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("receptor");

                    b.Property<string>("NomObjecte")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nom_objecte");

                    b.Property<int?>("Quantitat")
                        .HasColumnType("integer")
                        .HasColumnName("quantitat");

                    b.HasKey("Emisor", "Receptor", "NomObjecte")
                        .HasName("Regal_contingut_pkey");

                    b.HasIndex("NomObjecte");

                    b.HasIndex("Receptor");

                    b.ToTable("RegalContinguts");
                });

            modelBuilder.Entity("Connexio.Temp", b =>
                {
                    b.Property<string>("NomTemps")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nom_temps");

                    b.Property<string>("ImgTemps")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("img_temps");

                    b.HasKey("NomTemps");

                    b.ToTable("Temps");
                });

            modelBuilder.Entity("Connexio.Tipu", b =>
                {
                    b.Property<string>("NomTipus")
                        .HasColumnType("varchar(40)")
                        .HasColumnName("nom_tipus");

                    b.Property<string>("NomColorHexadecimal")
                        .HasColumnType("varchar(7)")
                        .HasColumnName("nom_color");

                    b.HasKey("NomTipus");

                    b.ToTable("Tipus");
                });

            modelBuilder.Entity("Connexio.TipusPokeparada", b =>
                {
                    b.Property<string>("NomTipus")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nom_pokeparada");

                    b.HasKey("NomTipus");

                    b.ToTable("TipusPokeparada");
                });

            modelBuilder.Entity("Connexio.TipusPotenciatClima", b =>
                {
                    b.Property<string>("NomTipus")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nom_tipus");

                    b.Property<string>("NomTemps")
                        .HasColumnType("varchar(40)")
                        .HasColumnName("emisor");

                    b.HasKey("NomTipus", "NomTemps")
                        .HasName("Tipus_potenciat_clima_pkey");

                    b.HasIndex("NomTemps");

                    b.ToTable("TipusPotenciatClimas");
                });

            modelBuilder.Entity("Connexio.Usuari", b =>
                {
                    b.Property<string>("NomUsuari")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("nom_usuari");

                    b.Property<DateTime?>("DataCreacio")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_creacio");

                    b.Property<double?>("Distancia")
                        .HasColumnType("double precision")
                        .HasColumnName("distancia");

                    b.Property<bool?>("IsOnline")
                        .HasColumnType("boolean")
                        .HasColumnName("is_online");

                    b.Property<double?>("Nivell")
                        .HasColumnType("double precision")
                        .HasColumnName("nivell");

                    b.Property<string>("NomEquip")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("nom_equip");

                    b.Property<int?>("PolvosEstelares")
                        .HasColumnType("integer")
                        .HasColumnName("polvos_estelares");

                    b.HasKey("NomUsuari")
                        .HasName("Usuari_pkey");

                    b.HasIndex("NomEquip");

                    b.ToTable("Usuaris");
                });

            modelBuilder.Entity("Connexio.UsuariAmic", b =>
                {
                    b.Property<string>("NomUsuariAmic")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("nom_usuari_amic");

                    b.Property<string>("NomUsuari")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("nom_usuari");

                    b.HasKey("NomUsuariAmic")
                        .HasName("Usuari_amics_pkey");

                    b.HasIndex("NomUsuari");

                    b.ToTable("UsuariAmics");
                });

            modelBuilder.Entity("Connexio.UsuariOpcion", b =>
                {
                    b.Property<string>("NomUsuari")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("nom_usuari");

                    b.Property<int?>("Musica")
                        .HasColumnType("integer")
                        .HasColumnName("musica");

                    b.Property<int?>("Soroll")
                        .HasColumnType("integer")
                        .HasColumnName("soroll");

                    b.Property<bool?>("Vibracio")
                        .HasColumnType("boolean")
                        .HasColumnName("vibracio");

                    b.HasKey("NomUsuari")
                        .HasName("Usuari_opcions_pkey");

                    b.ToTable("UsuariOpcions");
                });

            modelBuilder.Entity("Connexio.UsuariPokemon", b =>
                {
                    b.Property<int>("IdUsuariPokemon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id_usuari_pokemon")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DataCaptura")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_captura");

                    b.Property<string>("HabilitatPokemonCarregat")
                        .HasColumnType("varchar(40)")
                        .HasColumnName("habilitat_pokemon_carregat");

                    b.Property<string>("HabilitatPokemonSimple")
                        .HasColumnType("varchar(40)")
                        .HasColumnName("habilitat_pokemon_simple");

                    b.Property<bool?>("IsInGym")
                        .HasColumnType("boolean")
                        .HasColumnName("is_in_gym");

                    b.Property<string>("NomUsuari")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("nom_usuari");

                    b.Property<int>("NumPokedex")
                        .HasColumnType("integer")
                        .HasColumnName("num_pokedex");

                    b.Property<int?>("Pc")
                        .HasColumnType("integer")
                        .HasColumnName("pc");

                    b.Property<int?>("Ps")
                        .HasColumnType("integer")
                        .HasColumnName("ps");

                    b.HasKey("IdUsuariPokemon")
                        .HasName("Usuari_pokemon_pkey");

                    b.HasIndex("HabilitatPokemonCarregat");

                    b.HasIndex("HabilitatPokemonSimple");

                    b.HasIndex("NomUsuari");

                    b.HasIndex("NumPokedex");

                    b.ToTable("UsuariPokemons");
                });

            modelBuilder.Entity("Connexio.UsuariPokemonCaramel", b =>
                {
                    b.Property<string>("NomUsuari")
                        .HasColumnType("varchar(25)")
                        .HasColumnName("nom_usuari");

                    b.Property<int>("NumPokemon")
                        .HasColumnType("integer")
                        .HasColumnName("num_pokemon");

                    b.Property<int?>("Quantitat")
                        .HasColumnType("integer")
                        .HasColumnName("quantitat");

                    b.HasKey("NomUsuari", "NumPokemon")
                        .HasName("Usuari_pokemon_caramels_pkey");

                    b.HasIndex("NumPokemon");

                    b.ToTable("UsuariPokemonCaramels");
                });

            modelBuilder.Entity("Connexio.HabilitatsPokemon", b =>
                {
                    b.HasOne("Connexio.Habilitat", "NomHabilitatNavigation")
                        .WithMany("HabilitatsPokemons")
                        .HasForeignKey("NomHabilitat")
                        .HasConstraintName("fk_nom_habilitat_pokemon")
                        .IsRequired();

                    b.HasOne("Connexio.Pokemon", "NumPokedexNavigation")
                        .WithMany("HabilitatsPokemons")
                        .HasForeignKey("NumPokedex")
                        .HasConstraintName("fk_num_pokedex_habilitat")
                        .IsRequired();

                    b.Navigation("NomHabilitatNavigation");

                    b.Navigation("NumPokedexNavigation");
                });

            modelBuilder.Entity("Connexio.InventariEquip", b =>
                {
                    b.HasOne("Connexio.Equip", "NomEquipNavigation")
                        .WithMany("InventariEquips")
                        .HasForeignKey("NomEquip")
                        .HasConstraintName("Inventari_equip_nom_equip_fkey")
                        .IsRequired();

                    b.HasOne("Connexio.ObjecteEquip", "NomObjecteEquipNavigation")
                        .WithMany("InventariEquips")
                        .HasForeignKey("NomObjecteEquip")
                        .HasConstraintName("Inventari_equip_nom_objecte_equip_fkey")
                        .IsRequired();

                    b.Navigation("NomEquipNavigation");

                    b.Navigation("NomObjecteEquipNavigation");
                });

            modelBuilder.Entity("Connexio.ObjecteUsuari", b =>
                {
                    b.HasOne("Connexio.Objecte", "NomObjecteNavigation")
                        .WithMany("ObjecteUsuaris")
                        .HasForeignKey("NomObjecte")
                        .HasConstraintName("fk_nom_objecte_usuari")
                        .IsRequired();

                    b.HasOne("Connexio.Usuari", "NomUsuariNavigation")
                        .WithMany("ObjecteUsuaris")
                        .HasForeignKey("NomUsuari")
                        .HasConstraintName("fk_nom_usuari_objectes")
                        .IsRequired();

                    b.Navigation("NomObjecteNavigation");

                    b.Navigation("NomUsuariNavigation");
                });

            modelBuilder.Entity("Connexio.PokedexUsuari", b =>
                {
                    b.HasOne("Connexio.Usuari", "NomUsuariNavigation")
                        .WithMany("PokedexUsuaris")
                        .HasForeignKey("NomUsuari")
                        .HasConstraintName("Pokedex_usuari_nom_usuari_fkey")
                        .IsRequired();

                    b.HasOne("Connexio.Pokemon", "NumPokedexNavigation")
                        .WithMany("PokedexUsuaris")
                        .HasForeignKey("NumPokedex")
                        .HasConstraintName("Pokedex_usuari_num_pokedex_fkey")
                        .IsRequired();

                    b.Navigation("NomUsuariNavigation");

                    b.Navigation("NumPokedexNavigation");
                });

            modelBuilder.Entity("Connexio.Pokemon", b =>
                {
                    b.HasOne("Connexio.Tipu", "TipusPokemonNavigation")
                        .WithMany("Pokemons")
                        .HasForeignKey("TipusPokemon")
                        .HasConstraintName("fk_tipus_nom");

                    b.Navigation("TipusPokemonNavigation");
                });

            modelBuilder.Entity("Connexio.Pokeparada", b =>
                {
                    b.HasOne("Connexio.TipusPokeparada", "TipusPokeparadaNavigation")
                        .WithMany("Pokeparada")
                        .HasForeignKey("TipusPokeparadaNavigationNomTipus");

                    b.Navigation("TipusPokeparadaNavigation");
                });

            modelBuilder.Entity("Connexio.PokeparadaGym", b =>
                {
                    b.HasOne("Connexio.UsuariPokemon", "NomUsuari1Navigation")
                        .WithMany("PokeparadaGymNomUsuari1Navigations")
                        .HasForeignKey("NomUsuari1")
                        .HasConstraintName("fk_usuari_1");

                    b.HasOne("Connexio.UsuariPokemon", "NomUsuari2Navigation")
                        .WithMany("PokeparadaGymNomUsuari2Navigations")
                        .HasForeignKey("NomUsuari2")
                        .HasConstraintName("fk_usuari_2");

                    b.HasOne("Connexio.UsuariPokemon", "NomUsuari3Navigation")
                        .WithMany("PokeparadaGymNomUsuari3Navigations")
                        .HasForeignKey("NomUsuari3")
                        .HasConstraintName("fk_usuari_3");

                    b.HasOne("Connexio.UsuariPokemon", "NomUsuari4Navigation")
                        .WithMany("PokeparadaGymNomUsuari4Navigations")
                        .HasForeignKey("NomUsuari4")
                        .HasConstraintName("fk_usuari_4");

                    b.HasOne("Connexio.UsuariPokemon", "NomUsuari5Navigation")
                        .WithMany("PokeparadaGymNomUsuari5Navigations")
                        .HasForeignKey("NomUsuari5")
                        .HasConstraintName("fk_usuari_5");

                    b.Navigation("NomUsuari1Navigation");

                    b.Navigation("NomUsuari2Navigation");

                    b.Navigation("NomUsuari3Navigation");

                    b.Navigation("NomUsuari4Navigation");

                    b.Navigation("NomUsuari5Navigation");
                });

            modelBuilder.Entity("Connexio.RegalContingut", b =>
                {
                    b.HasOne("Connexio.Usuari", "EmisorNavigation")
                        .WithMany("RegalContingutEmisorNavigations")
                        .HasForeignKey("Emisor")
                        .HasConstraintName("Regal_contingut_emisor_fkey")
                        .IsRequired();

                    b.HasOne("Connexio.Objecte", "NomObjecteNavigation")
                        .WithMany("RegalContinguts")
                        .HasForeignKey("NomObjecte")
                        .HasConstraintName("Regal_contingut_nom_objecte_fkey")
                        .IsRequired();

                    b.HasOne("Connexio.Usuari", "ReceptorNavigation")
                        .WithMany("RegalContingutReceptorNavigations")
                        .HasForeignKey("Receptor")
                        .HasConstraintName("Regal_contingut_receptor_fkey")
                        .IsRequired();

                    b.Navigation("EmisorNavigation");

                    b.Navigation("NomObjecteNavigation");

                    b.Navigation("ReceptorNavigation");
                });

            modelBuilder.Entity("Connexio.TipusPotenciatClima", b =>
                {
                    b.HasOne("Connexio.Temp", "NomTempsNavigation")
                        .WithMany("TipusPotenciatClimas")
                        .HasForeignKey("NomTemps")
                        .HasConstraintName("Tipus_potenciat_clima_nom_temps_fkey")
                        .IsRequired();

                    b.HasOne("Connexio.Tipu", "NomTipusNavigation")
                        .WithMany("TipusPotenciatClimas")
                        .HasForeignKey("NomTipus")
                        .HasConstraintName("Tipus_potenciat_clima_nom_tipus_fkey")
                        .IsRequired();

                    b.Navigation("NomTempsNavigation");

                    b.Navigation("NomTipusNavigation");
                });

            modelBuilder.Entity("Connexio.Usuari", b =>
                {
                    b.HasOne("Connexio.Equip", "NomEquipNavigation")
                        .WithMany("Usuaris")
                        .HasForeignKey("NomEquip")
                        .HasConstraintName("fk_nom_equip");

                    b.Navigation("NomEquipNavigation");
                });

            modelBuilder.Entity("Connexio.UsuariAmic", b =>
                {
                    b.HasOne("Connexio.Usuari", "NomUsuariNavigation")
                        .WithMany("UsuariAmicNomUsuariNavigations")
                        .HasForeignKey("NomUsuari")
                        .HasConstraintName("fk_nom_usuari_amics");

                    b.HasOne("Connexio.Usuari", "NomUsuariAmicNavigation")
                        .WithOne("UsuariAmicNomUsuariAmicNavigation")
                        .HasForeignKey("Connexio.UsuariAmic", "NomUsuariAmic")
                        .HasConstraintName("fk_nom_amic_usuari_amics")
                        .IsRequired();

                    b.Navigation("NomUsuariAmicNavigation");

                    b.Navigation("NomUsuariNavigation");
                });

            modelBuilder.Entity("Connexio.UsuariOpcion", b =>
                {
                    b.HasOne("Connexio.Usuari", "NomUsuariNavigation")
                        .WithOne("UsuariOpcion")
                        .HasForeignKey("Connexio.UsuariOpcion", "NomUsuari")
                        .HasConstraintName("fk_nom_usuari_opcions")
                        .IsRequired();

                    b.Navigation("NomUsuariNavigation");
                });

            modelBuilder.Entity("Connexio.UsuariPokemon", b =>
                {
                    b.HasOne("Connexio.Habilitat", "HabilitatPokemonCarregatNavigation")
                        .WithMany("UsuariPokemonHabilitatPokemonCarregatNavigations")
                        .HasForeignKey("HabilitatPokemonCarregat")
                        .HasConstraintName("fk_habilitat_pokemon_carregat");

                    b.HasOne("Connexio.Habilitat", "HabilitatPokemonSimpleNavigation")
                        .WithMany("UsuariPokemonHabilitatPokemonSimpleNavigations")
                        .HasForeignKey("HabilitatPokemonSimple")
                        .HasConstraintName("fk_habilitat_pokemon_simple");

                    b.HasOne("Connexio.Usuari", "NomUsuariNavigation")
                        .WithMany("UsuariPokemons")
                        .HasForeignKey("NomUsuari")
                        .HasConstraintName("fk_nom_user_pokemon");

                    b.HasOne("Connexio.Pokemon", "NumPokedexNavigation")
                        .WithMany("UsuariPokemons")
                        .HasForeignKey("NumPokedex")
                        .HasConstraintName("fk_num_pokedex_user_pokemon")
                        .IsRequired();

                    b.Navigation("HabilitatPokemonCarregatNavigation");

                    b.Navigation("HabilitatPokemonSimpleNavigation");

                    b.Navigation("NomUsuariNavigation");

                    b.Navigation("NumPokedexNavigation");
                });

            modelBuilder.Entity("Connexio.UsuariPokemonCaramel", b =>
                {
                    b.HasOne("Connexio.Usuari", "NomUsuariNavigation")
                        .WithMany("UsuariPokemonCaramels")
                        .HasForeignKey("NomUsuari")
                        .HasConstraintName("fk_nom_usuari_caramels")
                        .IsRequired();

                    b.HasOne("Connexio.Pokemon", "NumPokemonNavigation")
                        .WithMany("UsuariPokemonCaramels")
                        .HasForeignKey("NumPokemon")
                        .HasConstraintName("fk_num_pokedex_caramel")
                        .IsRequired();

                    b.Navigation("NomUsuariNavigation");

                    b.Navigation("NumPokemonNavigation");
                });

            modelBuilder.Entity("Connexio.Equip", b =>
                {
                    b.Navigation("InventariEquips");

                    b.Navigation("Usuaris");
                });

            modelBuilder.Entity("Connexio.Habilitat", b =>
                {
                    b.Navigation("HabilitatsPokemons");

                    b.Navigation("UsuariPokemonHabilitatPokemonCarregatNavigations");

                    b.Navigation("UsuariPokemonHabilitatPokemonSimpleNavigations");
                });

            modelBuilder.Entity("Connexio.Objecte", b =>
                {
                    b.Navigation("ObjecteUsuaris");

                    b.Navigation("RegalContinguts");
                });

            modelBuilder.Entity("Connexio.ObjecteEquip", b =>
                {
                    b.Navigation("InventariEquips");
                });

            modelBuilder.Entity("Connexio.Pokemon", b =>
                {
                    b.Navigation("HabilitatsPokemons");

                    b.Navigation("PokedexUsuaris");

                    b.Navigation("UsuariPokemonCaramels");

                    b.Navigation("UsuariPokemons");
                });

            modelBuilder.Entity("Connexio.Temp", b =>
                {
                    b.Navigation("TipusPotenciatClimas");
                });

            modelBuilder.Entity("Connexio.Tipu", b =>
                {
                    b.Navigation("Pokemons");

                    b.Navigation("TipusPotenciatClimas");
                });

            modelBuilder.Entity("Connexio.TipusPokeparada", b =>
                {
                    b.Navigation("Pokeparada");
                });

            modelBuilder.Entity("Connexio.Usuari", b =>
                {
                    b.Navigation("ObjecteUsuaris");

                    b.Navigation("PokedexUsuaris");

                    b.Navigation("RegalContingutEmisorNavigations");

                    b.Navigation("RegalContingutReceptorNavigations");

                    b.Navigation("UsuariAmicNomUsuariAmicNavigation");

                    b.Navigation("UsuariAmicNomUsuariNavigations");

                    b.Navigation("UsuariOpcion");

                    b.Navigation("UsuariPokemonCaramels");

                    b.Navigation("UsuariPokemons");
                });

            modelBuilder.Entity("Connexio.UsuariPokemon", b =>
                {
                    b.Navigation("PokeparadaGymNomUsuari1Navigations");

                    b.Navigation("PokeparadaGymNomUsuari2Navigations");

                    b.Navigation("PokeparadaGymNomUsuari3Navigations");

                    b.Navigation("PokeparadaGymNomUsuari4Navigations");

                    b.Navigation("PokeparadaGymNomUsuari5Navigations");
                });
#pragma warning restore 612, 618
        }
    }
}
