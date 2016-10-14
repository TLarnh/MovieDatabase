using LexiconMovieDB.DAL;

namespace LexiconMovieDB.Migrations {
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LexiconMovieDB.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<LexiconMovieDB.DAL.MovieDbContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LexiconMovieDB.DAL.MovieDbContext context) {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Movies.AddOrUpdate(

                m => m.Title,
                            new Movie {
                                Title = "Return of the killing tomatoes",
                                Genre = Genre.Horror,
                                AgeLimit = 15,
                                Length = 90,
                                MetaScore = 7
                            },

            new Movie {
                Title = "Pogrammers Academy",
                Genre = Genre.Comedy,
                AgeLimit = 15,
                Length = 110,
                MetaScore = 67
            },

                        new Movie {
                            Title = "Finalizer 7",
                            Genre = Genre.Action,
                            AgeLimit = 15,
                            Length = 95,
                            MetaScore = 57
                        },

                                                new Movie {
                                                    Title = "The Lord of the Earrings",
                                                    Genre = Genre.Action,
                                                    AgeLimit = 11,
                                                    Length = 205,
                                                    MetaScore = 91
                                                });



        }
    }
}
