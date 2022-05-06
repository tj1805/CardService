using CardServide.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CardServide.Data.Services
{
    public interface ICardRepositiory
    {

        Task<IEnumerable<Card>> GetCardsAsync(Guid applicationUserId);

        Task<Card> GetCardAsync(Guid id); 
        

        
        // activate card by Id 

        // deactivate card by id 

        //pin reset on card encryp on Db


    }
}
