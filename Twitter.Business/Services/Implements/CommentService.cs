using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Business.Dtos.CommentsDto;
using Twitter.Business.Repositories.Interfaces;
using Twitter.Business.Services.Interfaces;

namespace Twitter.Business.Services.Implements
{
    public class CommentService : ICommentService
    {
        ICommentRepository _repo {  get; set; }
        IMapper _mapper { get; set; }
        public CommentService(ICommentRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IEnumerable<CommentListItemDto> GetAll()
        =>_mapper.Map<IEnumerable<CommentListItemDto>>(_repo.GetAll());


    }
}
