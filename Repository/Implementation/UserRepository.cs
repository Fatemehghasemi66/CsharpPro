using SharpPro.Contracts;
using SharpPro.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin = SharpPro.Models.UserLogin;

namespace SharpPro.Repository.Implementation
{
    public class UserRepository : IGenericRepository<UserLogin>
    {
        public bool AddItem(UserLogin item, out int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public UserLogin GetById(object id)
        {
            throw new NotImplementedException();
        }

        public List<UserLogin> GetIAll()
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(UserLogin item)
        {
            throw new NotImplementedException();
        }
    }
}
