using System;
using System.Collections.Generic;
using KuseaBlog.Core.Objects;

namespace KuseaBlog.Core
{
    public interface IBlogRepository
    {
        IList<Post> Posts(int pageNo, int pageSize);
        int TotalPosts(bool checkIsPublished = true);

        // Category
        IList<Post> PostsForCategory(string categorySlug, int pageNo, int pageSize);
        int TotalPostsForCategory(string categorySlug); 
        Category Category(string categorySlug);

        // Tag
        IList<Post> PostsForTag(string tagSlug, int pageNo, int pageSize);
        int TotalPostsForTag(string tagSlug);
        Tag Tag(string tagSlug);

        // Search
        IList<Post> PostsForSearch(string search, int pageNo, int pageSize);
        int TotalPostsForSearch(string search);

        Post Post(int year, int month, string titleSlug);
        Post Post(int id);

        // Widgets
        IList<Category> Categories();
        IList<Tag> Tags();

        // Admin 
        IList<Post> Posts(int pageNo, int pageSize, string sortColumn,
                            bool sortByAscending);
        int AddPost(Post post);

        void EditPost(Post post);

        void DeletePost(int id);

        Category Category(int id);

        int AddCategory(Category category);

        void EditCategory(Category category);

        void DeleteCategory(int id);

        int AddTag(Tag tag);

        void DeleteTag(int id);

        void EditTag(Tag tag);

        Tag Tag(int id);
    }
}
