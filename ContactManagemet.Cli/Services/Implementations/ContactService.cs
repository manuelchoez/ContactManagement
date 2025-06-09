using ContactManagemet.Cli.Models;
using ContactManagemet.Cli.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagemet.Cli.Services.Implementations
{
    public class ContactService : IContactService
    {
        private readonly List<Contact> _contacts = new();
        private int _lastId = 0;

        public void AddContact(string name, string phone, string email)
        {
            Contact newContact = new Contact
            {
                Id = ++_lastId,
                Name = name,
                Phone = phone,
                Email = email
            };
            _contacts.Add(newContact);
        }

        public bool DeleteContact(int id) => _contacts.RemoveAll(c => c.Id == id) > 0;     
        public bool ModifyContact(int id, string name, string phone, string email)
        {
            int contact = _contacts.FindIndex(c => c.Id == id);
            if (contact == -1)
            {
                return false; 
            }
            var updateContact = _contacts[contact] with
            {
                Name = name,
                Phone = phone,
                Email = email
            };
            _contacts[contact] = updateContact;
            return true; 
        }

        public IEnumerable<Contact> GetAll() => _contacts;
        public Contact? SearchByName(string name) => _contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

      

      
    }
}
