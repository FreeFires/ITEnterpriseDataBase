using System;
using System.Windows.Forms;

namespace ITEnterprDataBase
{
    public class CheckInputNum
    {
        // Перевырка вводу лише цифр (пароль, палета)    
        
        public void checkInputNumber(KeyPressEventArgs e)
            {
                char num = e.KeyChar;
                if (!Char.IsDigit(num) && num != 8)
                {
                    e.Handled = true;
                }
            }
    }
}
