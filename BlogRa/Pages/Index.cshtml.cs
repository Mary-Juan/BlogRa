using BlogRa.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogRa.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BlogContext _db;
        public List<ArticleDto> Articles { get; set; }

        public IndexModel(ILogger<IndexModel> logger, BlogContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            Articles = _db.Articles.Select(a => new ArticleDto()
            {
                Id = a.Id,
                Title = a.Title,
                Picture = a.Picture,
                PictureAlt = a.PictureAlt,
                PictureTitle = a.PictureTitle,
                ShortDescription = a.ShortDescription
            }).OrderByDescending(a => a.Id).ToList();
        }
    }
}
