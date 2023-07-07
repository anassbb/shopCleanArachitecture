using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities.BuyerAggregate
{
    internal class Buyer :BaseEntity
    {
        public string IdentityGuid  { get;  private set; }

        private List<PaymentMethod> paymentMethods = new List<PaymentMethod>();

        private Buyer() { }

        public  Buyer(string identity) : this()
        {
            Guard.Against.NullOrEmpty(identity, nameof(identity));
            IdentityGuid = identity;
        }


    }
}
