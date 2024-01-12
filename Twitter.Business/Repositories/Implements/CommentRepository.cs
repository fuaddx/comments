﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Business.Repositories.Interfaces;
using Twitter.Core.Entities;
using Twitter.Dal.Contexts;

namespace Twitter.Business.Repositories.Implements
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(TwitterContext db) : base(db)
        {
        }
    }
}
