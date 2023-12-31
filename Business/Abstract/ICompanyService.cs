﻿using Core.Utilities.Result.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        //CRUD

        IResult Add(Company company);
        IDataResult<List<Company>> GetList();

    }
}
