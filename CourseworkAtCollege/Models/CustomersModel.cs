using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkAtCollege.Models
{
    public class Customers
    {

        // Основні змінні класа
        private int idCustomer
        {
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else idCustomer = value;
            }
        }

        string idClient
        {
            set
            {
                if(value.Length <= 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else idClient = value;
            }
        }

        string idCar
        {
            set
            {
                if(value.Length <= 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else idCar = value;
            }
        }

        string idContract
        {
            set
            {
                if(value.Length <= 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else idContract = value;
            }
        }

        public Customers()
        {
        }
        public Customers(
            int idCustomerFromConstructor,
            string idClientFromConstructor,
            string idCarFromConstructor,
            string idContractFromConstructor
        )
        {
            // Конструктор класа

            this.idCustomer = idCustomerFromConstructor;
            this.idClient = idClientFromConstructor;
            this.idCar = idCarFromConstructor;
            this.idContract = idContractFromConstructor;
        }
    }
}
