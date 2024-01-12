using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Business.Dtos.CommentsDto
{
    public class CommentListItemDto
    {
        public int Id { get; set; }
        public int Content { get; set; }
        public DateTime CreatedTime { get; set; }
        public AppUserDtos.AppUserPostItemDto AppUser { get; set; }
        public  int ParentCommentId { get; set; }
    }
}
