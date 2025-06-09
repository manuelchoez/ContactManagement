using ContactManagemet.Cli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagemet.Cli.Services.Interfaces
{
    public interface IContactService
    {
        void AddContact(string name, string phone, string email);
        IEnumerable<Contact> GetAll();
        Contact? SearchByName(string name);
        bool ModifyContact(int id, string name, string phone, string email);
        bool DeleteContact(int id);
    }
}
