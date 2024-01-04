using SharpPro.Contracts;
using SharpPro.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = SharpPro.Models.User;

namespace SharpPro.Repository.Implementation
{
    public class UserRepository : IGenericRepository<User>
    {
        public bool AddItem(User item, out int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public User GetById(object id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetIAll()
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(User item)
        {
            throw new NotImplementedException();
        }
    }
}
