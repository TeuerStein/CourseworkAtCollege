using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkAtCollege.Models
{
    public class Client
    {

        // Основні змінні класа
        private int idClient
        {
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else idClient = value;
            }
        }

        private string firstName
        {
            set
            {
                if(value.Length <= 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else firstName = value;
            }
        }

        private string lastName
        {
            set
            {
                if(value.Length < 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else lastName = value;
            }
        }

        private string passportData
        {
            set
            {
                if(value.Length < 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else passportData = value;
            }
        }

        private string telephoneNumber
        {
            set
            {
                if(value.Length < 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else telephoneNumber = value;
            }
        }

        public Client(
            int clientIdFromConstructor,
            string firstNameFromConstructor,
            string lastNameFromConstructor,
            string passportDataFromConstructor,
            string telephoneNumberFromConstructor
        )
        {
            // Конструктор класа

            this.idClient = clientIdFromConstructor;
            this.firstName = firstNameFromConstructor;
            this.lastName = lastNameFromConstructor;
            this.passportData = passportDataFromConstructor;
            this.telephoneNumber = telephoneNumberFromConstructor;
        }
    }
}
