using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AccountReconciliationsDetailManager>().As<IAccountReconciliationsDetailService>();
            builder.RegisterType<EfAccountReconciliationsDetailDal>().As<IAccountReconciliationsDetailDal>();

            builder.RegisterType<AccountReconciliationManager>().As<IAccountReconciliationService>();
            builder.RegisterType<EfAccountReconciliationDal>().As<IAccountReconciliationDal>();

            builder.RegisterType<BaBsReconciliationsDetailManager>().As<IBaBsReconciliationsDetailService>();
            builder.RegisterType<EfBaBsReconciliationsDetailDal>().As<IBaBsReconciliationsDetailDal>();

            builder.RegisterType<BaBsReconciliationManager>().As<IBaBsReconciliationService>();
            builder.RegisterType<EfIBaBsReconciliationDal>().As<IBaBsReconciliationDal>();


            builder.RegisterType<CompanyManager>().As<ICompanyService>();
            builder.RegisterType<EfCompanyDal>().As<ICompanyDal>();

            builder.RegisterType<CurrencyAccountManager>().As<ICurrencyAccountService>();
            builder.RegisterType<EfCurrencyAccountDal>().As<ICurrencyAccountDal>();

            builder.RegisterType<CompanyManager>().As<ICurrencyService>();
            builder.RegisterType<EfCurrencyDal>().As<ICurrencyDal>();

            builder.RegisterType<MailParameterManager>().As<IMailParameterService>();
            builder.RegisterType<EfMailParameterDal>().As<IMailParameterDal>();
        }
    }
}
