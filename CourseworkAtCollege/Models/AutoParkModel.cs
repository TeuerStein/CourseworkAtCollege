using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkAtCollege
{
    public class AutoParkModel
    {

        // Основні змінні класа
        private int idOfCar
        {
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else idOfCar = value;
            }
        }

        private string carColor
        {
            set
            {
                if(value.Length <= 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else carColor = value;
            }
        }
        private string carName
        {
            set
            {
                if(value.Length <= 0)
                {
                    throw new ArgumentException("Введіть дані. Поле не може бути порожнім.");
                }
                else carName = value;
            }
        }

        public AutoParkModel(
            int idCarFromConstructor,
            string colorCarFromConstructor,
            string nameCarFromConstructor
        )
        {
            // Конструктор класа

            this.idOfCar = idCarFromConstructor;
            this.carColor = colorCarFromConstructor;
            this.carName = nameCarFromConstructor;
        }
    }
}
