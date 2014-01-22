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
    public partial class UsersForm : Form {
        public UsersForm() {
            InitializeComponent();
        }

        private List<User> users; 

        public virtual void ReceiveMessage(Notification notification) {
            users.Where(u=>u.Online).Select(u=>u).ToList().ForEach(u=> u.AddNotification(notification));

            dgvUsers.DataSource = users;
            dgvUsers.Refresh();
        }

        private void UsersForm_Load(object sender, EventArgs e) {
            users = new UserDao().AllUsers();
            dgvUsers.DataSource = users;
        }
    }
}
