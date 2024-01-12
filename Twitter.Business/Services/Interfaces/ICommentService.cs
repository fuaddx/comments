using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Business.Dtos.CommentsDto;

namespace Twitter.Business.Services.Interfaces
{
    public interface ICommentService
    {
        IEnumerable<CommentListItemDto> GetAll();
        /*Task Delete();
        Task SoftDelete(int id);
        Task ReverseSoftDelet(int id);*/
    }
}
