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
        public int clientId;

        public string firstName;

        public string lastName;

        public string fatherName;

        public string passportData;

        public string phoneNumber;

        public string dateOfTheEndOfTheContract;

        public string typeOfCar;

        public Client(
             int clientIdFromConstructor,
             string firstNameFromConstructor,
             string lastNameFromConstructor,
             string fatherNameFromConstructor,
             string passportDataFromConstructor,
             string phoneNumberFromConstructor,
             string dateOfTheEndOfTheContractFromConstructor,
             string typeOfCarFromConstructor
         )
        {
            // Конструктор класа

            this.clientId = clientIdFromConstructor;
            this.firstName = firstNameFromConstructor;
            this.lastName = lastNameFromConstructor;
            this.fatherName = fatherNameFromConstructor;
            this.passportData = passportDataFromConstructor;
            this.phoneNumber = phoneNumberFromConstructor;
            this.dateOfTheEndOfTheContract = dateOfTheEndOfTheContractFromConstructor;
            this.typeOfCar = typeOfCarFromConstructor;
        }
    }
}
