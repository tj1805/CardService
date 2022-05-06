using System;
using System.Collections.Generic;
using System.Text;

namespace CardServide.Data.Entities
{
    public class Card
    {
        public Guid Id { get; set; }
        public Guid ApplicationUserId { get; set; }    
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiryDate { get; set; }
        public string CardCvv { get; set; }
        public int CardPin { get; set; }
        public string CardType { get; set; }
        public bool IsBlocked { get; set; }
        public bool CardStatus { get; set; }    





    }
}
