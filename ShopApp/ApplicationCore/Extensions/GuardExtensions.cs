using ApplicationCore.Entities.BasketAggregate;
using ApplicationCore.Exceptions;
using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Extensions
{
    public static class GuardExtensions
    {

        public static void EmptyBasketOnCheckOut(this IGuardClause guardClause, IReadOnlyCollection<BasketItem> basketItems)
        {
            if (!basketItems.Any())
                throw new EmptyBasketOnCheckoutException();

        }
    }
}
