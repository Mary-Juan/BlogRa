using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogRa.Dtos
{
    public class CreateArticleDto
    {
        [DisplayName("عنوان مقاله")]
        [Required(ErrorMessage ="{0} اجباریست.")]
        public string Title { get; set; }

        [DisplayName("عکس")]
        [Required(ErrorMessage = "{0} اجباریست.")]
        public string Picture { get; set; }

        [DisplayName("alt عکس")]
        public string PictureAlt { get; set; }

        [DisplayName("عنوان عکس")]
        public string PictureTitle { get; set; }

        [DisplayName("توضیحات کوتاه")]
        public string ShortDescription { get; set; }

        [DisplayName("بدنه مقاله")]
        [Required(ErrorMessage = "{0} اجباریست.")]
        public string Body { get; set; }
    }
}
