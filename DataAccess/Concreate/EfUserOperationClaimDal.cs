using Core.DataAccess.EntityFramework;
using Core.Entities.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework.Contex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate
{
    public class EfUserOperationClaimDal:EfEntityRepositoryBase<UserOperationClaim,ContextDb>, IUserOperationClaimDal
    {
    }
}
