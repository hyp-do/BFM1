using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968___BFM1
{
    class Helpers
    {
        public static void nullOrEmptyCheck(object sender)
        {
            var textBox = (dynamic)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.BackColor = System.Drawing.Color.LightSalmon;
            }
            else
            {
                textBox.BackColor = System.Drawing.Color.White;

            }

        }

        public static bool IsBetween<T>(T item, T start, T end)
        {
            return Comparer<T>.Default.Compare(item, start) >= 0
                && Comparer<T>.Default.Compare(item, end) <= 0;
        }
    }
}
