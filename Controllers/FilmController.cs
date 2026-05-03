using Microsoft.AspNetCore.Mvc;
using TP_MODUL10_103022400112.Models;


namespace TP_MODUL10_103022400112.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmController : ControllerBase
    {
        private static List<Film> films = new List<Film>
        {
            new Film("Inception", "Christopher Nolan", "2010", "Sci-Fi", "9.0"),
            new Film("Interstellar", "Christopher Nolan", "2014", "Sci-Fi", "8.7"),
            new Film("Parasite", "Bong Joon-ho", "2019", "Thriller", "8.6")
        };

        [HttpGet]
        public ActionResult<List<Film>> GetAllFilm() 
        { 
            return Ok(films);
        }

        [HttpGet("{index}")]
        public ActionResult<Film> GetFilmByIndex(int index)
        {
            if (index < 0 || index >= films.Count)
            {
                return NotFound("Film tidak ditemukan");
            }
            return Ok(films[index]);
        }

        [HttpPost]
        public ActionResult<Film> AddFilm([FromBody]Film newFilm)
        {
            films.Add(newFilm);
            return CreatedAtAction(nameof(GetFilmByIndex), new { index = films.Count - 1 }, newFilm);
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteFilm(int index)
        {
            if (index < 0 || index >= films.Count)
            {
                return NotFound("Film tidak ditemukan");
            }
            films.RemoveAt(index);
            return Ok("Film berhasil dihapus");
        }

    }
}
