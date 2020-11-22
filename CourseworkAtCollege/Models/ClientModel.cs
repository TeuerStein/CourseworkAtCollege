using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkAtCollege
{
    public class Client
    {

        // Основні змінні класа
        private int idClient;

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

        private string fatherName
        {
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else fatherName = value;
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
        
        private string dateOfTheEndOfTheContract
        {
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else dateOfTheEndOfTheContract = value;
            }
        }

        public Client(
            string firstNameFromConstructor,
            string lastNameFromConstructor,
            string fatherNameFromConstructor,
            string passportDataFromConstructor,
            string telephoneNumberFromConstructor,
            string dateOfTheEndOfTheContractFromConstructor
        )
        {
            // Конструктор класа

            Random randomID = new Random();

            this.idClient = randomID.Next(0, 255);
            this.firstName = firstNameFromConstructor;
            this.lastName = lastNameFromConstructor;
            this.fatherName = fatherNameFromConstructor;
            this.passportData = passportDataFromConstructor;
            this.telephoneNumber = telephoneNumberFromConstructor;
            this.dateOfTheEndOfTheContract = dateOfTheEndOfTheContractFromConstructor;       
        }
    }
}
