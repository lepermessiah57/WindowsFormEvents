using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserEventNotifier {
    public class User {
        public String Name { get; set; }

//        public List<Notification> Notifications {
//            get;
//            private set;
//        };
        public String Notification { get; set; }

        public Boolean Online { get; set; }

        public User() {
//            Notifications = new List<Notification>();
            Notification = "";
        }

        public void AddNotification(Notification notification) {
//            Notifications.Add(notification);
            Notification += " " + notification.ToString();
        }
    }   

}
