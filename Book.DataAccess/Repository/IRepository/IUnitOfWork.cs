﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Book.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        ISpCall SpCall { get; }
        void Save();
    }
}
