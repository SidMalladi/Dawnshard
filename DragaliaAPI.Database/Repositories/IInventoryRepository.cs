﻿using DragaliaAPI.Database.Entities;
using DragaliaAPI.Shared.Definitions.Enums;

namespace DragaliaAPI.Database.Repositories;

public interface IInventoryRepository
{
    IQueryable<DbPlayerMaterial> Materials { get; }

    IQueryable<DbPlayerDragonGift> DragonGifts { get; }

    DbPlayerMaterial AddMaterial(Materials type);

    Task<DbPlayerMaterial?> GetMaterial(Materials materialId);

    Task UpdateQuantity(IEnumerable<Materials> list, int quantity);
    Task UpdateQuantity(Materials item, int quantity);
    Task UpdateQuantity(IEnumerable<KeyValuePair<Materials, int>> quantityMap);

    Task<bool> CheckQuantity(IEnumerable<KeyValuePair<Materials, int>> quantityMap);
    Task<bool> CheckQuantity(Materials materialId, int quantity);

    DbPlayerDragonGift AddDragonGift(DragonGifts giftId, int quantity);

    Task<DbPlayerDragonGift?> GetDragonGift(DragonGifts materialId);

    Task RefreshPurchasableDragonGiftCounts();
}
