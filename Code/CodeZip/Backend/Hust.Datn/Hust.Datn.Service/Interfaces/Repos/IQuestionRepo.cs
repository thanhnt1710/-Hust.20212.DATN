﻿using Hust.Datn.Service.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hust.Datn.Service.Interfaces.Repos
{
    public interface IQuestionRepo : IBaseRepo<Question>
    {
        Task<int> GetMaxID(string sql);
        Task<List<ResultTest>> ScroingTest(string sql, object param);
    }
}
