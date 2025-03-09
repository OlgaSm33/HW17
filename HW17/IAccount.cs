using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    public interface IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        // метод для вычисления процентной ставки
        void CalculateInterest();
    }
}
