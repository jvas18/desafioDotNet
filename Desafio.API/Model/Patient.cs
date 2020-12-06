

using System;

namespace Desafio.API.Model
{
    public class Patient
    {
        
        public Guid Id {get; set;}
        public string Name {get; set;}
        public DateTime  BirthDate {get;set;}
        public string Cpf {get; set;}
        public Guid DoctorId {get; set;}

        /*EF Relations*/

        public Doctor Doctor{get; set;}
    }
}