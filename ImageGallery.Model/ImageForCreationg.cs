using System.ComponentModel.DataAnnotations;

namespace ImageGallery.Model
{
    public class ImageForCreationg
    {
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        public byte[] Bytes { get; set; }

    }
}
