using SocialMedia.Entities;
namespace SocialMedia.Repositories;

public interface IPostRepository
{
    public List<Post>? GetAllPost();
    public void SaveAllPosts(List<Post> posts);
}