using Microsoft.AspNetCore.Html;
using System.Reflection;
using sasha_2.Models;

namespace sasha_2.Helpers
{
    public static class CinemaHelpers
    {
        public static HtmlString ExternalHelperMethod(List<Cinema> cinemas)
        {
            var html = "<table class='table'><thead><tr><th>ID</th><th>Название</th><th>Адрес</th><th>Телефон</th><th>Email</th><th>Количество залов</th><th>Год основания</th><th>Действия</th></tr></thead><tbody>";


            for (int i = 0; i < cinemas.Count; i++)
            {
                var studio = cinemas[i];
                html += $"<tr><td>{studio.Id}</td><td>{studio.Name}</td><td>{studio.Address}</td><td>{studio.Phone}</td><td>{studio.Email}</td><td>{studio.NumberOfHalls}</td><td>{studio.EstablishedYear}</td><td><a href='/Cinema/Details/{studio.Id}' class='btn btn-secondary'>Просмотр</a></td></tr>";
            }

            html += "</tbody></table>";
            return new HtmlString(html);
        }

        public static List<Cinema> GetMockCinemaList()
        {
            var cinema = new List<Cinema>
            {
                new Cinema
                {
                    Id = 1,
                    Name = "Киномакс",
                    Address = "пр. Нариманова, 111",
                    Phone = "+7 (8422) 123-456",
                    Email = "kinomax@uln.ru",
                    NumberOfHalls = 6,
                    EstablishedYear = 1999
                },
                new Cinema
                {
                    Id = 2,
                    Name = "Сатурн",
                    Address = "ул. Пушкинская, 20  ",
                    Phone = "+7 (8422) 789-012",
                    Email = "saturn@cinema.ru ",
                    NumberOfHalls = 4,
                    EstablishedYear = 2007
                },
                new Cinema
                {
                    Id = 3,
                    Name = "Синема Парк",
                    Address = "ул. Рябикова, 70",
                    Phone = "+7 (8422) 987-654",
                    Email = "cinepark@yandex.ru",
                    NumberOfHalls = 8,
                    EstablishedYear = 2005
                },
            };
            return cinema;
        }
    }
}
