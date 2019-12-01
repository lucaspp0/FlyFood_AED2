using FlyFoodGit.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyFoodGit.repository.Interface
{
    public interface IUserDao
    {
        Boolean Create(User user);
        Boolean Update(User user);
        Boolean Delete(User user);
        Boolean Insert(User user);
        User select(int id);
        List<User> select();


    }
}
