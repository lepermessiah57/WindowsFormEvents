using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserEventNotifier {
    public class Notification {
        public String Text { get; set; }
        public DateTime TimeFired { get; set; }

        public override string ToString() {
            return Text + " " + TimeFired.ToString();
        }
    }
}
