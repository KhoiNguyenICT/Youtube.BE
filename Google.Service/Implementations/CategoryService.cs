﻿using Google.Model;
using Google.Model.Entities;
using Google.Service.Dtos.Category;
using Google.Service.Interfaces;

namespace Google.Service.Implementations
{
    public class CategoryService : BaseService<Category, CategoryDto>, ICategoryService
    {
        public CategoryService(AppDbContext context) : base(context)
        {
        }
    }
}