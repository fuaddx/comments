using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Business.Dtos.CommentsDto;
using Twitter.Core.Entities;

namespace Twitter.Business.Profiles
{
    public class CommentMappingProfile:Profile
    {
        public CommentMappingProfile()
        {
            CreateMap<Comment, CommentListItemDto>().ReverseMap();
        }
    }
}
