﻿namespace Boilerplate.Web.Mvc.Twitter
{
    /// <summary>
    /// An image used in a Twitter card. The Image must be less than 1MB in size.
    /// </summary>
    public class TwitterImage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterImage"/> class.
        /// </summary>
        /// <param name="imageUrl">The image URL. The Image must be less than 1MB in size.</param>
        public TwitterImage(string imageUrl)
        {
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwitterImage"/> class.
        /// </summary>
        /// <param name="imageUrl">The image URL. The Image must be less than 1MB in size.</param>
        /// <param name="width">The width of the image in pixels to help Twitter accurately preserve the aspect ratio
        /// of the image when resizing. This property is optional.</param>
        /// <param name="height">The height of the image in pixels to help Twitter accurately preserve the aspect ratio
        /// of the image when resizing. This property is optional.</param>
        public TwitterImage(string imageUrl, int? width, int? height)
            : this(imageUrl)
        {
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Gets or sets the height of the image in pixels to help Twitter accurately preserve the aspect ratio of
        /// the image when resizing. This property is optional.
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Gets the image URL. The Image must be less than 1MB in size.
        /// </summary>
        public string ImageUrl { get; }

        /// <summary>
        /// Gets or sets the width of the image in pixels to help Twitter accurately preserve the aspect ratio of
        /// the image when resizing. This property is optional.
        /// </summary>
        public int? Width { get; set; }
    }
}
