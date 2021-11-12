using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Connexio
{
    public partial class pokemongoolotContext : DbContext
    {
        public pokemongoolotContext()
        {
        }

        public pokemongoolotContext(DbContextOptions<pokemongoolotContext> options)
            : base(options) 
        {
        }
        public virtual DbSet<Equip> Equips { get; set; }
        public virtual DbSet<Habilitat> Habilitats { get; set; }
        public virtual DbSet<HabilitatsPokemon> HabilitatsPokemons { get; set; }
        public virtual DbSet<Objecte> Objectes { get; set; }
        public virtual DbSet<ObjecteUsuari> ObjecteUsuaris { get; set; }
        public virtual DbSet<Pokemon> Pokemons { get; set; }
        public virtual DbSet<PokeparadaGym> PokeparadaGyms { get; set; }
        public virtual DbSet<Pokeparada> Pokeparada { get; set; }
        public virtual DbSet<Temp> Temps { get; set; }
        public virtual DbSet<Tipu> Tipus { get; set; }
        public virtual DbSet<TipusPokeparada> TipusPokeparada { get; set; }
        public virtual DbSet<Usuari> Usuaris { get; set; }
        public virtual DbSet<UsuariAmic> UsuariAmics { get; set; }
        public virtual DbSet<UsuariOpcion> UsuariOpcions { get; set; }
        public virtual DbSet<UsuariPokemon> UsuariPokemons { get; set; }
        public virtual DbSet<UsuariPokemonCaramel> UsuariPokemonCaramels { get; set; }
        public virtual DbSet<InventariEquip> InventariEquips { get; set; }
        public virtual DbSet<ObjecteEquip> ObjecteEquips { get; set; }
        public virtual DbSet<PokedexUsuari> PokedexUsuaris { get; set; }
        public virtual DbSet<RegalContingut> RegalContinguts { get; set; }
        public virtual DbSet<TipusPotenciatClima> TipusPotenciatClimas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(Decrypt.DecryptFile());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            // modelBuilder.Entity<Equip>(entity =>
            // {
            //     entity.HasKey(e => e.NomEquip)
            //         .HasName("Equip_pkey");
            // });

            // modelBuilder.Entity<Habilitat>(entity =>
            // {
            //     entity.HasKey(e => e.NomHabilitat)
            //         .HasName("Habilitats_pkey");
            // });

            // modelBuilder.Entity<Objecte>(entity =>
            // {
            //     entity.HasKey(e => e.NomObjecte)
            //         .HasName("Objecte_pkey");
            // });

            // modelBuilder.Entity<Temp>(entity =>
            // {
            //     entity.HasKey(e => e.NomTemps)
            //         .HasName("Temps_pkey");
            // });


            modelBuilder.Entity<HabilitatsPokemon>(entity =>
            {
                entity.HasKey(e => new { e.NumPokedex, e.NomHabilitat })
                    .HasName("Habilitats_pokemon_pkey");

                entity.HasOne(d => d.NomHabilitatNavigation)
                    .WithMany(p => p.HabilitatsPokemons)
                    .HasForeignKey(d => d.NomHabilitat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nom_habilitat_pokemon");

                entity.HasOne(d => d.NumPokedexNavigation)
                    .WithMany(p => p.HabilitatsPokemons)
                    .HasForeignKey(d => d.NumPokedex)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_num_pokedex_habilitat");
            });


            modelBuilder.Entity<ObjecteUsuari>(entity =>
            {
                entity.HasKey(e => new { e.NomUsuari, e.NomObjecte })
                    .HasName("Objecte_usuari_pkey");

                entity.HasOne(d => d.NomObjecteNavigation)
                    .WithMany(p => p.ObjecteUsuaris)
                    .HasForeignKey(d => d.NomObjecte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nom_objecte_usuari");

                entity.HasOne(d => d.NomUsuariNavigation)
                    .WithMany(p => p.ObjecteUsuaris)
                    .HasForeignKey(d => d.NomUsuari)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nom_usuari_objectes");
            });

            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.HasKey(e => e.NumPokedex)
                    .HasName("Pokemon_pkey");

                entity.HasOne(d => d.TipusPokemonNavigation)
                    .WithMany(p => p.Pokemons)
                    .HasForeignKey(d => d.TipusPokemon)
                    .HasConstraintName("fk_tipus_nom");
            });

            modelBuilder.Entity<PokeparadaGym>(entity =>
            {
                entity.HasKey(e => new { e.Latitud, e.Longitud })
                    .HasName("Pokeparada_gym_pkey");

                entity.HasOne(d => d.NomUsuari1Navigation)
                    .WithMany(p => p.PokeparadaGymNomUsuari1Navigations)
                    .HasForeignKey(d => d.NomUsuari1)
                    .HasConstraintName("fk_usuari_1");

                entity.HasOne(d => d.NomUsuari2Navigation)
                    .WithMany(p => p.PokeparadaGymNomUsuari2Navigations)
                    .HasForeignKey(d => d.NomUsuari2)
                    .HasConstraintName("fk_usuari_2");

                entity.HasOne(d => d.NomUsuari3Navigation)
                    .WithMany(p => p.PokeparadaGymNomUsuari3Navigations)
                    .HasForeignKey(d => d.NomUsuari3)
                    .HasConstraintName("fk_usuari_3");

                entity.HasOne(d => d.NomUsuari4Navigation)
                    .WithMany(p => p.PokeparadaGymNomUsuari4Navigations)
                    .HasForeignKey(d => d.NomUsuari4)
                    .HasConstraintName("fk_usuari_4");

                entity.HasOne(d => d.NomUsuari5Navigation)
                    .WithMany(p => p.PokeparadaGymNomUsuari5Navigations)
                    .HasForeignKey(d => d.NomUsuari5)
                    .HasConstraintName("fk_usuari_5");
            });

            modelBuilder.Entity<Pokeparada>(entity =>
            {
                entity.HasKey(e => new { e.Latitud, e.Longitud })
                    .HasName("Pokeparada_pkey");
            });



            // modelBuilder.Entity<Tipu>(entity =>
            // {
            //     entity.HasKey(e => e.NomTipus)
            //         .HasName("Tipus_pkey");
            // });

            // modelBuilder.Entity<TipusPokeparada>(entity =>
            // {
            //     entity.HasKey(e => e.NomTipus)
            //         .HasName("Tipus_pokeparada_pkey");
            // });

            modelBuilder.Entity<Usuari>(entity =>
            {
                entity.HasKey(e => e.NomUsuari)
                    .HasName("Usuari_pkey");

                entity.HasOne(d => d.NomEquipNavigation)
                    .WithMany(p => p.Usuaris)
                    .HasForeignKey(d => d.NomEquip)
                    .HasConstraintName("fk_nom_equip");
            });

            modelBuilder.Entity<UsuariAmic>(entity =>
            {
                entity.HasKey(e => e.NomUsuariAmic)
                    .HasName("Usuari_amics_pkey");

                entity.HasOne(d => d.NomUsuariNavigation)
                    .WithMany(p => p.UsuariAmicNomUsuariNavigations)
                    .HasForeignKey(d => d.NomUsuari)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nom_usuari_amics");

                entity.HasOne(d => d.NomUsuariAmicNavigation)
                    .WithOne(p => p.UsuariAmicNomUsuariAmicNavigation)
                    .HasForeignKey<UsuariAmic>(d => d.NomUsuariAmic)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nom_amic_usuari_amics");
            });

            modelBuilder.Entity<UsuariOpcion>(entity =>
            {
                entity.HasKey(e => e.NomUsuari)
                    .HasName("Usuari_opcions_pkey");

                entity.HasOne(d => d.NomUsuariNavigation)
                    .WithOne(p => p.UsuariOpcion)
                    .HasForeignKey<UsuariOpcion>(d => d.NomUsuari)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nom_usuari_opcions");
            });

            modelBuilder.Entity<UsuariPokemon>(entity =>
            {
                entity.HasKey(e => e.IdUsuariPokemon)
                    .HasName("Usuari_pokemon_pkey");

                entity.HasOne(d => d.HabilitatPokemonCarregatNavigation)
                    .WithMany(p => p.UsuariPokemonHabilitatPokemonCarregatNavigations)
                    .HasForeignKey(d => d.HabilitatPokemonCarregat)
                    .HasConstraintName("fk_habilitat_pokemon_carregat");

                entity.HasOne(d => d.HabilitatPokemonSimpleNavigation)
                    .WithMany(p => p.UsuariPokemonHabilitatPokemonSimpleNavigations)
                    .HasForeignKey(d => d.HabilitatPokemonSimple)
                    .HasConstraintName("fk_habilitat_pokemon_simple");

                entity.HasOne(d => d.NomUsuariNavigation)
                    .WithMany(p => p.UsuariPokemons)
                    .HasForeignKey(d => d.NomUsuari)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nom_user_pokemon");

                entity.HasOne(d => d.NumPokedexNavigation)
                    .WithMany(p => p.UsuariPokemons)
                    .HasForeignKey(d => d.NumPokedex)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_num_pokedex_user_pokemon");
            });

            modelBuilder.Entity<UsuariPokemonCaramel>(entity =>
            {
                entity.HasKey(e => new { e.NomUsuari, e.NumPokemon })
                    .HasName("Usuari_pokemon_caramels_pkey");

                entity.HasOne(d => d.NomUsuariNavigation)
                    .WithMany(p => p.UsuariPokemonCaramels)
                    .HasForeignKey(d => d.NomUsuari)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nom_usuari_caramels");

                entity.HasOne(d => d.NumPokemonNavigation)
                    .WithMany(p => p.UsuariPokemonCaramels)
                    .HasForeignKey(d => d.NumPokemon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_num_pokedex_caramel");
            });



            modelBuilder.Entity<InventariEquip>(entity =>
            {
                entity.HasKey(e => new { e.NomEquip, e.NomObjecteEquip })
                    .HasName("Inventari_equip_pkey");

                entity.HasOne(d => d.NomEquipNavigation)
                    .WithMany(p => p.InventariEquips)
                    .HasForeignKey(d => d.NomEquip)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Inventari_equip_nom_equip_fkey");

                entity.HasOne(d => d.NomObjecteEquipNavigation)
                    .WithMany(p => p.InventariEquips)
                    .HasForeignKey(d => d.NomObjecteEquip)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Inventari_equip_nom_objecte_equip_fkey");
            });

             modelBuilder.Entity<PokedexUsuari>(entity =>
            {
                entity.HasKey(e => new { e.NumPokedex, e.NomUsuari })
                    .HasName("Pokedex_usuari_pkey");

        
                entity.Property(e => e.DataVisualitzacio)
                    .HasColumnType("date");

                entity.HasOne(d => d.NomUsuariNavigation)
                    .WithMany(p => p.PokedexUsuaris)
                    .HasForeignKey(d => d.NomUsuari)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Pokedex_usuari_nom_usuari_fkey");

                entity.HasOne(d => d.NumPokedexNavigation)
                    .WithMany(p => p.PokedexUsuaris)
                    .HasForeignKey(d => d.NumPokedex)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Pokedex_usuari_num_pokedex_fkey");
            });


            modelBuilder.Entity<RegalContingut>(entity =>
            {
                entity.HasKey(e => new { e.Emisor, e.Receptor, e.NomObjecte })
                    .HasName("Regal_contingut_pkey");

                entity.HasOne(d => d.EmisorNavigation)
                    .WithMany(p => p.RegalContingutEmisorNavigations)
                    .HasForeignKey(d => d.Emisor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Regal_contingut_emisor_fkey");

                entity.HasOne(d => d.NomObjecteNavigation)
                    .WithMany(p => p.RegalContinguts)
                    .HasForeignKey(d => d.NomObjecte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Regal_contingut_nom_objecte_fkey");

                entity.HasOne(d => d.ReceptorNavigation)
                    .WithMany(p => p.RegalContingutReceptorNavigations)
                    .HasForeignKey(d => d.Receptor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Regal_contingut_receptor_fkey");
            });

             modelBuilder.Entity<TipusPotenciatClima>(entity =>
            {
                entity.HasKey(e => new { e.NomTipus, e.NomTemps })
                    .HasName("Tipus_potenciat_clima_pkey");

                entity.HasOne(d => d.NomTempsNavigation)
                    .WithMany(p => p.TipusPotenciatClimas)
                    .HasForeignKey(d => d.NomTemps)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Tipus_potenciat_clima_nom_temps_fkey");

                entity.HasOne(d => d.NomTipusNavigation)
                    .WithMany(p => p.TipusPotenciatClimas)
                    .HasForeignKey(d => d.NomTipus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Tipus_potenciat_clima_nom_tipus_fkey");
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
