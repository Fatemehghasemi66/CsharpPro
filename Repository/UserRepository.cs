using CsharpPro.Contracts;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Repository
{
    internal class UserRepository : IGenericRepository<User>
    {
        public bool AddItem(User item)
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
