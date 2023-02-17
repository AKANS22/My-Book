using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using My_Book.Data.Model;
using System;
using System.Globalization;
using System.Linq;

namespace My_Book.Data
{
    public class BookDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {

            using(IServiceScope serviceScope= applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<BookContext>();

                if (!context.books.Any())
                {

                    context.books.AddRange(new Book()
                    {
                        Title = "Be Successfull",
                        Author = "Akans Udoka",
                        Genre = "Financial",
                        CoverUrl = "www.Akans.Com.Successful",
                        Rate = 4,
                        IsRead = true,
                        DateAdded = DateTime.Now.AddDays(-10),
                        DateRead = DateTime.Now


                    },
                    new Book()
                    {
                        Title = "The Beautiful Me",
                        Author = "Akans Isioma",
                        Genre = "Financial",
                        CoverUrl = "www.IsiomaAkans.Com.Successful",
                        Rate = 5,
                        IsRead = true,
                        DateAdded = DateTime.Now.AddDays(-5),
                        DateRead = DateTime.Now

                    });

                    context.SaveChanges();
                }
            }

        }
    }
}
