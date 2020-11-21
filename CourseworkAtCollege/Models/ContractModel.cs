using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkAtCollege.Models
{
    public class ContractModel
    {

        // Основні змінні класа
        private int idContract
        {
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else idContract = value;
            }
        }

        private DateTime dateOfSignin
        {
            set
            {
                if(value == null)
                {
                    throw new ArgumentException("Помилка! Поле дати не може бути порожнім.");
                    Console.WriteLine("Error, field of date can't be empty!");
                }
                else dateOfSignin = value;
            }
        }

        private DateTime dealdineOfSignin
        {
            set
            {
                if(value == null)
                {
                    throw new ArgumentException("Помилка! Поле дати не може бути порожнім.");
                    Console.WriteLine("Error, field of date can't be empty!");
                }
                else dealdineOfSignin = value;
            }
        }

        public ContractModel(
            int idContractFromConstructor,
            DateTime dateOfSigninFromConstructor,
            DateTime dealdineOfSigninFromConstructor
        )
        {
            // Конструктор класа

            this.idContract = idContractFromConstructor;
            this.dateOfSignin = dateOfSigninFromConstructor;
            this.dealdineOfSignin = dealdineOfSigninFromConstructor;
        }
    }
}
