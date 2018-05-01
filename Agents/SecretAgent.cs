using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agents
{
    class SecretAgent
    {
        private string realName = "Herb Jones";
        private string Alias = "Dash Martin";
        private string correctPassword = "correctname";
        private string fakePassword = "fakename";

        public void AgentGreeting(string secretName)
        {
           if (secretName == correctPassword)
            {
               MessageBox.Show(String.Format("Prawdziwe imię tajniaka to : {0}", realName), "Komunikat");
            }
            else if(secretName == fakePassword)
            {
                MessageBox.Show(String.Format("Prawdziwe imię i nazwisko tajniaka to : {0}" , Alias), "Komunikat");
            }
            else
            {
                MessageBox.Show("Wprowadź odpowiednie hasło ,by uzyskać dostęp do nazwy agenta", "Komunikat");
            }
        }
    }
}
