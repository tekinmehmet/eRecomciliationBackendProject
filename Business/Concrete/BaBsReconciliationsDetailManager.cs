﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BaBsReconciliationsDetailManager : IBaBsReconciliationsDetailService
    {
        private readonly IBaBsReconciliationsDetailDal _baBsReconciliationsDetailDal;

        public BaBsReconciliationsDetailManager(IBaBsReconciliationsDetailDal baBsReconciliationsDetailDal)
        {
            _baBsReconciliationsDetailDal = baBsReconciliationsDetailDal;
        }
    }
}
