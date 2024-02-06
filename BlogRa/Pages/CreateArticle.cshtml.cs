using BlogRa.Dtos;
using BlogRa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogRa.Pages
{
    public class CreateArticleModel : PageModel
    {
        private readonly BlogContext _db;
        public CreateArticleModel(BlogContext db)
        {
            _db = db;
        }

        public CreateArticleDto Article { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        [TempData]
        public string SuccessMessage { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost(CreateArticleDto article)
        {
            if (!ModelState.IsValid)
            {
                ErrorMessage = "لطفا مقادیر خواسته شده را وارد نمایید.";
                return Page();
            }
            else
            {

                var newArticle = new Article(article.Title, article.Picture, article.PictureAlt, article.PictureTitle, article.ShortDescription, article.Body);
                _db.Articles.Add(newArticle);
                _db.SaveChanges();
                SuccessMessage = "مقاله با موفقیت اضافه شد.";
                return RedirectToPage("/Index");
            }
        }

    }
}
