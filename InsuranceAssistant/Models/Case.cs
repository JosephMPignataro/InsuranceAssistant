using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceAssistant.Models
{
    public class Case
    {
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string Status { get; set; }
        public string ProvidingCompany { get; set; }
        public string CaseManager { get; set; }
        public string ClientAge { get; set; }
        public string FaceAmmount  { get; set; }
        public string State { get; set; }
        public string Agent { get; set; }
        public string CompletionDate { get; set; }
        public string ProductType { get; set; }
        public string Notes { get; set; }
        public Case()
    {

    }
    }
}
