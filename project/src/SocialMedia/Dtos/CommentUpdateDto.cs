namespace SocialMedia.Dtos;

public class CommentUpdateDto
{
    public string Content { get; set; }
    public Guid PostId { get; set; }
    public Guid? ReplyId { get; set; } 
}
