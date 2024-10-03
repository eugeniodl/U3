﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificacionesForm
{
    // Implementación para SMS (SRP)
    internal class SMSNotificationService : INotificationService
    {
        public void Send(string message)
        {
            // Aquí iría la lógica real de envío de sms
            MessageBox.Show("Enviando SMS: " + message);
        }
    }
}
