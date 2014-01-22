using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserEventNotifier {
    class Notifier {
        public delegate void NotifyUsersHandler(Notification notification);

        public void Notify(NotifyUsersHandler notifyUsersEvent, Notification notification) {
            notifyUsersEvent(notification);
        }
    }
}
