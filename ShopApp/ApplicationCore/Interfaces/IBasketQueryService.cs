﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IBasketQueryService
    {
        Task<int> CountTotalBasketItems(string username);
    }
}
