using CardServide.Data.Context;
using CardServide.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardServide.Data.Services
{
    public class CardRepositiory : ICardRepositiory
    {
        private readonly CardDbContext context;

        public CardRepositiory(CardDbContext context)
        {
            this.context = context;
        }
        public async  Task<Card> GetCardAsync(Guid id)
        {
            return await context.Cards.FirstOrDefaultAsync(b => b.Id== id);
        }

        public async Task<IEnumerable<Card>> GetCardsAsync(Guid applicationUserId)
        {
            return await context.Cards.Where(b=> b.ApplicationUserId = applicationUserId).ToListAsync();    
        }


    }
}
