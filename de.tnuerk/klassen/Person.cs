using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LernsituationOOP
{
    class Person
    {
        public Person(string name, DateTime geburtsdatum, string adresse, string email, int telefonnummer)
        {
            Name = name;
            Geburtsdatum = geburtsdatum;
            Adresse = adresse;
            _Email = email;
            Telefonnummer = telefonnummer;
        }

        public string Name { get; set; }

        public DateTime Geburtsdatum { get; set; }

        public string Adresse { get; set; }

        private string _Email;

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                if (new MailAddress(_Email).Address == _Email)
                    _Email = value;
                else
                {
                    _Email = "Keine E-Mail";
                    MessageBox.Show(new FormatException("Keine E-Mail").Message);
                }
            }
        }

        public int Telefonnummer { get; set; }
    }
}
