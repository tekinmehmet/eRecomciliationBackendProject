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
    public class EfUserDal : EfEntityRepositoryBase<User, ContextDb>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user, int companyId)
        {
            using (var context = new ContextDb())
            {
                var result = from OperationClaim in context.OperationClaims
                             join UserOperationClaim in context.UserOperationClaims
                             on OperationClaim.Id equals UserOperationClaim.OperationClaimId
                             where UserOperationClaim.CompanyId == companyId && UserOperationClaim.UserId == user.Id
                             select new OperationClaim
                             {
                                 Id = OperationClaim.Id,
                                 Name = OperationClaim.Name
                             };

                return result.ToList();
            }
        }
    }
}
