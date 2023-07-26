using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        //Dependency Injection

        private readonly ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public IResult Add(Company company)
        {
            _companyDal.Add(company);
            return new SuccessResult(Messages.AddedCompany);
        }

        //public List<Company> GetList()
        //{
        //    return _companyDal.GetAll();
        //}

        IDataResult<List<Company>> ICompanyService.GetList()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(), "Sorgulama İşlemi Başarılıdır.");
        }
    }
}
