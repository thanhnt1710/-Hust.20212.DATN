﻿using Hust.Datn.Service.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.Datn.Service.Interfaces.Repos
{
    public interface ICategoryRepo: IBaseRepo<Category>
    {
        public Task<object> GetAllCategory();
    }
}
