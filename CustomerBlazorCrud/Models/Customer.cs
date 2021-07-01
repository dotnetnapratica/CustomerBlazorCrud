using System;
using System.ComponentModel.DataAnnotations;

namespace CustomerBlazorCrud.Models
{
    public class Customer
    {
        public Customer()
        {
        }

        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Digite um email válido.")]
        public string Email { get; set; }

        public void New()
        {
            Id = Guid.NewGuid();
        }

        public void Save(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
