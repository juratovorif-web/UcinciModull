using SocialMedia.Entities;

namespace SocialMedia.Repositories;

public interface ICommentRepository
{
    public List<Comment>? GetAllComments();
    public void SaveAllComments(List<Comment> comments);
}