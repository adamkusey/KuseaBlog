using KuseaBlog.Core;
using KuseaBlog.Core.Objects;
using System.Collections.Generic;

namespace KuseaBlog.Models
{
    public class WidgetViewModel
    {
        public IList<Category> Categories { get; private set; }
        public IList<Tag> Tags { get; private set; }
        public IList<Post> LatestPosts { get; private set; }

        public WidgetViewModel(IBlogRepository blogRepository)
        {
            Categories = blogRepository.Categories();
            Tags = blogRepository.Tags();
            LatestPosts = blogRepository.Posts(0, 10);
        }
    }
}