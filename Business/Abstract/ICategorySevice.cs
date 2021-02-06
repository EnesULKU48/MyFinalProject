﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategorySevice
    {
        List<Category> GetAll();

        Category GetById(int categoryId);

    }
}
