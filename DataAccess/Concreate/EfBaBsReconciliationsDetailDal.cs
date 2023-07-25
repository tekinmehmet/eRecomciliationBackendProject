using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework.Contex;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate
{
    public class EfBaBsReconciliationsDetailDal:EfEntityRepositoryBase<BaBsReconciliationsDetail,ContextDb>, IBaBsReconciliationsDetailDal
    {
    }
}
