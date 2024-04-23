using BellaVitaPizzeria.Core.Contracts;
using BellaVitaPizzeria.Core.Models.Cart;
using BellaVitaPizzeria.Infrastructure.Common;
using BellaVitaPizzeria.Infrastructure.Constants;
using BellaVitaPizzeria.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BellaVitaPizzeria.Core.Services
{
    public class CartService : ICartService
    {
        private readonly IRepository repository;

        public CartService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddToCartAsync(PurchaseModel model)
        {
            var cart = repository.AllReadonly<Cart>()
                .FirstOrDefault(x => x.UserId == model.UserId && x.Purchase.Title == model.Title && x.Purchase.Size == model.Size);

            if (cart != null)
            {
                var purchase = await repository.GetByIdAsync<Purchase>(cart.PurchaseId);
                purchase.Quantity++;
            }
            else
            {
                var purchase = new Purchase()
                {
                    Title = model.Title,
                    Size = model.Size,
                    Quantity = 1,
                    Image = Convert.FromBase64String(model.Image),
                    UnitPrice = model.UnitPrice,
                };
                await repository.AddAsync<Purchase>(purchase);
                await repository.AddAsync<Cart>(new Cart() { UserId = model.UserId, Purchase = purchase });
            }

            await repository.SaveChangesAsync();
        }
        public async Task<IEnumerable<PurchaseModel>> GetPurchasesAsync(string userId)
        {
            return await repository.AllReadonly<Cart>()
                .Where(x => x.UserId == userId)
                .Select(x => new PurchaseModel(
                    x.Purchase.Id,
                    x.Purchase.Title,
                    x.Purchase.Size,
                    Convert.ToBase64String(x.Purchase.Image),
                    x.Purchase.Quantity,
                    x.Purchase.UnitPrice,
                    x.UserId))
                .ToListAsync();
        }

        public async Task ChangeQuantityAsync(int id, string operation)
        {
            var purchase = await repository.GetByIdAsync<Purchase>(id);

            if (purchase != null) 
            {
                if (purchase.Quantity > 1 && operation == "-")
                {
                    purchase.Quantity--;

                    await repository.SaveChangesAsync();
                }
                else if (operation == "+") 
                {
                    purchase.Quantity++;

                    await repository.SaveChangesAsync();
                }                
            }
        }

        public async Task DeletePurchaseAsync(int id, string userId)
        {
            var purchase = await repository.GetByIdAsync<Purchase>(id);

            if (purchase != null) 
            {
                var cart = await repository.AllReadonly<Cart>().FirstOrDefaultAsync(x => x.PurchaseId == id && x.UserId == userId);

                if(cart != null)
                {
                    repository.Delete(cart);

                    await repository.DeleteAsync<Purchase>(id);

                    await repository.SaveChangesAsync();
                }
            }
        }

        public async Task AddOrderAsync(OrderFormModel model)
        {
            var purchases = await repository.AllReadonly<Cart>()
                .Where(x => x.UserId == model.UserId).ToListAsync();

            if (purchases.Any()) 
            {
                var purchasesIds = purchases.Select(x => x.PurchaseId).ToArray();

                var order = new Order()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    Town = model.Town,
                    Street = model.Street,
                    Comment = model.Comment,
                    UserId = model.UserId,
                };

                order.AddPurchases(purchasesIds);

                foreach (var item in purchases) 
                {
                    var purchase = await repository.GetByIdAsync<Purchase>(item.PurchaseId);

                    if(purchase != null)
                        order.TotalSum += purchase.Sum;
                }

                try
                {
                    await repository.AddAsync<Order>(order);

                    for (int i = 0; i < purchases.Count(); i++)
                    {
                        repository.Delete<Cart>(purchases[i]);
                    }

                    await repository.SaveChangesAsync();
                }
                catch (Exception)
                {
                    throw new ApplicationException(ErrorMessagesConstants.OperationFailedErrorMessage);
                }
            }            
        }

        public async Task DeleteOrderAsync(int id)
        {
            var order = await repository.GetByIdAsync<Order>(id);

            if (order != null) 
            {
                foreach (var purchaseId in order.PurchasesIds) 
                {
                    await repository.DeleteAsync<Purchase>(purchaseId);
                }

                await repository.DeleteAsync<Order>(id);

                await repository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<OrderFormModel>> GetOrdersAsync()
        {
            return await repository.AllReadonly<Order>()
                .Where(x=>x.IsCompleted==false)
                .Select(x => new OrderFormModel()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    PhoneNumber = x.PhoneNumber,
                    Town = x.Town,
                    Street = x.Street,
                    Comment = x.Comment,
                    PurchasesIds = x.PurchasesIds,
                    UserId = x.UserId,
                    TotalSum = x.TotalSum
                }).ToListAsync();
        }

        public async Task CompleteOrderAsync(int id)
        {
            var order = await repository.GetByIdAsync<Order>(id);

            if (order != null) 
            {
                order.IsCompleted = true;

                await repository.SaveChangesAsync();
            }
        }
    }
}
