﻿using ForumApp.Models;

namespace ForumApp.Contracts
{
    public interface IPostService
    {
        //We will use this for showing all posts
        Task<IEnumerable<PostViewModel>> GetAllAsync();
        Task AddAsync(PostViewModel model);
    }
}
