using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coords
{
    public class Coords
    {
        private Decimal x, y;
        private string res = "";

        public Coords(string v)
        {
            try
            {
                var w = v.Split(',');
                if (w.Length != 2) throw new ArgumentException();
                x = Convert.ToDecimal(w[0], CultureInfo.InvariantCulture);
                y = Convert.ToDecimal(w[1], CultureInfo.InvariantCulture);
                IFormatProvider p = new CultureInfo("ru-RU", false);
                res = String.Format(p, "X: {0} Y: {1}", x, y);
            }
            catch
            {
                res = String.Format("Координаты введены в неверном формате : {0}", v);
            }
        }

        public string FineForm()
        {
            return res;
        }
    }
}