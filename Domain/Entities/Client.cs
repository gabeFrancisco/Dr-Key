using System;

namespace Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF_CNPJ { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime SignDate { get; set; }

        public Client() { }

        public Client(string name, string cpf_cnpj, string phone, string email, string adress, string number, string complement, string neighborhood, string city, string state, DateTime signDate)
        {
            Name = name;
            CPF_CNPJ = cpf_cnpj;
            Phone = phone;
            Email = email;
            Adress = adress;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            SignDate = signDate;
        }

        public Client(int id, string name, string cPF_CNPJ, string phone, string email, string adress, string number, string complement, string neighborhood, string city, string state, DateTime signDate)
        {
            Id = id;
            Name = name;
            CPF_CNPJ = cPF_CNPJ;
            Phone = phone;
            Email = email;
            Adress = adress;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            SignDate = signDate;
        }
    }
}
