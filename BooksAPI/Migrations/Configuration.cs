namespace BooksAPI.Migrations
{
    using BooksAPI.Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<BooksAPI.Models.BooksAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BooksAPIContext context)
        {
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
            context.Authors.AddOrUpdate(new Author[] {
                new Author() { AuthorId = 1, Name = "Ahmad"},
                new Author() { AuthorId = 2, Name = "Rehman"},
                new Author() { AuthorId = 3, Name = "Mansoor"},
                new Author() { AuthorId = 4, Name = "Akram"},
                new Author() { AuthorId = 5, Name = "Shafkat"}

            });

            context.Books.AddOrUpdate(new Book[] {
                new Book() { BookId = 1,  Title= "Midnight Rain", Genre = "Fantasy",
                PublishDate = new DateTime(2000, 12, 16), AuthorId = 1, Description =
                "A former architect battles an evil sorceress.", Price = 14.95M },

                new Book() { BookId = 2, Title = "Maeve Ascendant", Genre = "Fantasy",
                    PublishDate = new DateTime(2000, 11, 17), AuthorId = 2, Description =
                    "After the collapse of a nanotechnology society, the young" +
                    "survivors lay the foundation for a new society.", Price = 12.95M },

                new Book() { BookId = 3, Title = "The Sundered Grail", Genre = "Fantasy",
                    PublishDate = new DateTime(2001, 09, 10), AuthorId = 2, Description =
                    "The two daughters of Maeve battle for control of England.", Price = 12.95M },

                new Book() { BookId = 4, Title = "Lover Birds", Genre = "Romance",
                    PublishDate = new DateTime(2000, 09, 02), AuthorId = 3, Description =
                    "When Carla meets Paul at an ornithology conference, tempers fly.", Price = 7.99M },

                new Book() { BookId = 5, Title = "Splish Splash", Genre = "Romance",
                    PublishDate = new DateTime(2000, 11, 02), AuthorId = 4, Description =
                    "A deep sea diver finds true love 20,000 leagues beneath the sea.", Price = 6.99M},
            });
        }
    }
}
