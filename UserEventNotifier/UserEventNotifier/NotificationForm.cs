using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserEventNotifier {
    public partial class NotificationForm : Form {
        private UsersForm _usersForm; 
        public NotificationForm() {
            InitializeComponent();
            this._usersForm = new UsersForm();
            this._usersForm.Visible = true;
        }

        private void btnSend_Click(object sender, EventArgs e) {
            Notification notification = new Notification {Text = txtNotificationMessage.Text, TimeFired = DateTime.Now};
            new Notifier().Notify(this._usersForm.ReceiveMessage, notification);
        }

    }
}
