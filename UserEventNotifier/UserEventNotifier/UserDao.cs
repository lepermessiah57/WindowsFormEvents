using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserEventNotifier {
    class UserDao {
        public List<User> AllUsers() {
            List<User> users = new List<User>();

            users.Add(new User { Name = "Bob", Online = true});
            users.Add(new User { Name = "Bill", Online = false });
            users.Add(new User { Name = "Duck", Online = true });
            users.Add(new User { Name = "George", Online = false });
            users.Add(new User { Name = "Phil", Online = true });
            users.Add(new User { Name = "Wayne", Online = false }); 
            users.Add(new User { Name = "Matt", Online = true });
            return users;
        } 
    }
}
