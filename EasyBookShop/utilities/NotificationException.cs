using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop.utilities
{
    public class NotificationException:Exception
    {
        public enum AlertType 
        {
            SUCCESS,
            UNSUCCESS
        }

        public string message { get; set; }
        public AlertType alertType { get;  set; }

        public NotificationException(string notifMsg,AlertType alertType)
        {
            message = notifMsg;
            this.alertType = alertType;
        }
    }
}
