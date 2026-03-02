using SocialMedia.Entities;

namespace SocialMedia.Dtos;

public class CommentCreateDto
{
    public string Content { get; set; }
    public Guid PostId { get; set; }
    public Guid? ReplyId { get; set; }

    internal Comment ToEntity()
    {
        throw new NotImplementedException();
    }
}
