﻿namespace TeemosPieShopDotNet.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
