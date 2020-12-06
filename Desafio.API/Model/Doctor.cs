using System;
using System.Collections.Generic;

namespace Desafio.API.Model
{
    public class Doctor
    {
        public Guid Id {get; set;}
        public string Name {get; set;}
        public string Crm{get;set;}
        public string CrmUf {get; set;}
        
        /*EF Relations*/
        public IEnumerable<Patient> Patients {get; set;}

        
    }
}