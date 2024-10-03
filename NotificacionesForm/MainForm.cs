using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificacionesForm
{
    public partial class MainForm : Form
    {
        private readonly UserService _userService;
        private NotificationManager _notificationManager;

        public MainForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // SRP: Solo se encarga de agregar usuarios
            string username = txtUsuario.Text;
            _userService.AddUser(username);
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            // DIP: Se puede cambiar el tipo de notificación sin modificar esta parte del código
            _notificationManager = new NotificationManager(new EmailNotificationService());
            string message = txtMensaje.Text;
            _notificationManager.Notify(message);
        }

        private void btnEnviarSMS_Click(object sender, EventArgs e)
        {
            _notificationManager = new NotificationManager(new SMSNotificationService());
            string message = txtMensaje.Text;
            _notificationManager.Notify(message);
        }
    }
}
