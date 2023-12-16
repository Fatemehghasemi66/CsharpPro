using CsharpPro.Contracts;
using CsharpPro.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = CsharpPro.Models.User;

namespace CsharpPro.Repository
{
    public class UserRepository : IGenericRepository<User>
    {

        public readonly string jsonDataStr = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"FileData","User.json"));
        public static List<User> user = new List<User>();

        public UserRepository()
        {
           user = JsonConvert.DeserializeObject<List<User>>(jsonDataStr);

        }
        public bool AddItem(User item)
        {
            user.Add(item);
            return true;
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
            return user;
        }

        public bool UpdateItem(User item)
        {
            throw new NotImplementedException();
        }
    }
}
