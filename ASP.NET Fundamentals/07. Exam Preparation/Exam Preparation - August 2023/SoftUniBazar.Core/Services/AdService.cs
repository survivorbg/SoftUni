﻿using Microsoft.EntityFrameworkCore;
using SoftUniBazar.Core.Contracts;
using SoftUniBazar.Core.Models;
using SoftUniBazar.Data;
using SoftUniBazar.Infrastructure.Data.Models;
using static SoftUniBazar.Infrastructure.Constants.AdDataConstants;

namespace SoftUniBazar.Core.Services;

public class AdService : IAdService
{
    private readonly BazarDbContext context;

    public AdService(BazarDbContext context)
    {
        this.context = context;
    }


    public async Task<IEnumerable<AllAdModel>> GetAllAdAsync()
    {
        return await context.Ads
            .Select(ad => new AllAdModel
            {
                Id = ad.Id,
                Owner = ad.Owner.UserName,
                OwnerId = ad.Owner.Id,
                CreatedOn = ad.CreatedOn.ToString(AdDateFormat),
                Category = ad.Category.Name,
                Description = ad.Description,
                Price = ad.Price.ToString("F2"),
                Name = ad.Name,
                ImageUrl = ad.ImageUrl
            })
            .ToListAsync();
    }
    public async Task<AllAdModel?> GetAdByIdAsync(int id)
    {
        return await context.Ads
            .Where(ad => ad.Id == id)
            .Select(ad => new AllAdModel
            {
                Id = ad.Id,
                Owner = ad.Owner.UserName,
                OwnerId = ad.Owner.Id,
                CreatedOn = ad.CreatedOn.ToString(AdDateFormat),
                Category = ad.Category.Name,
                Description = ad.Description,
                Price = ad.Price.ToString("F2"),
                Name = ad.Name,
                ImageUrl = ad.ImageUrl
            }).FirstOrDefaultAsync();


    }

    public async Task<bool> CheckIfAlreadyAddedAsync(int adId, string userId)
    {
        return await context.AdsBuyers.AnyAsync(ab => ab.BuyerId == userId && ab.AdId == adId);
    }

    public async Task AddToCardAsync(string userId, int adId)
    {
        AdBuyer ab = new AdBuyer()
        {
            AdId = adId,
            BuyerId = userId
        };
        await context.AdsBuyers.AddAsync(ab);
        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<AllAdModel>> GetAllAdInCartAsync(string userId)
    {
        var model = await context.AdsBuyers
            .Where(ab=>ab.BuyerId==userId)
            .Select(ab=> new AllAdModel
            {
                Id = ab.Ad.Id,
                Owner = ab.Ad.Owner.UserName,
                OwnerId = ab.Ad.Owner.Id,
                CreatedOn = ab.Ad.CreatedOn.ToString(AdDateFormat),
                Category = ab.Ad.Category.Name,
                Description = ab.Ad.Description,
                Name = ab.Ad.Name,
                Price = ab.Ad.Price.ToString("F2"),
                ImageUrl = ab.Ad.ImageUrl
            }).ToListAsync();
        return model;
    }

    public async Task RemoveFromCartAsync(string userId, int adId)
    {
        var ab = new AdBuyer()
        {
            AdId = adId,
            BuyerId = userId
        };

        context.AdsBuyers.Remove(ab);
        await context.SaveChangesAsync();
    }

    public async Task AddAdAsync(string userId, AddAdModel model)
    {
        if(model != null)
        {
            var ad = new Ad()
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                OwnerId = userId,
                CreatedOn = DateTime.UtcNow,
                ImageUrl = model.ImageUrl,
                CategoryId = model.CategoryId
            };

            await context.Ads.AddAsync(ad);
            await context.SaveChangesAsync();
        }
    }

    public async Task<EditAdModel?> GetModelForEditByIdAsync(int id)
    {
        return await context.Ads
            .Where(ad => ad.Id == id)
            .Select(ad => new EditAdModel
            {
                Id = ad.Id,
                Description = ad.Description,
                Price = ad.Price,
                Name = ad.Name,
                ImageUrl = ad.ImageUrl,
                CategoryId = ad.CategoryId,
                OwnerId = ad.Owner.Id
            }).FirstOrDefaultAsync();
    }

    public async Task EditAdAsync(EditAdModel model)
    {
        var adToEdit = await context.Ads
            .Where(a => a.Id == model.Id)
            .FirstOrDefaultAsync();

        if(adToEdit != null)
        {
            adToEdit.Name = model.Name;
            adToEdit.Description = model.Description;
            adToEdit.Price = model.Price;
            adToEdit.ImageUrl = model.ImageUrl;
            adToEdit.CategoryId = model.CategoryId;

            await context.SaveChangesAsync();
        }
    }
}
