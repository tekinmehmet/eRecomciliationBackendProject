﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class AccountReconciliationsDetail : IEntity
    {
        public int Id { get; set; }
        public int CurrencyId { get; set; }
        public int AccountReconciliationId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal CurrencyDebit { get; set; }
        public decimal CurrencyCredit { get; set; }
    }
}
