using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Calendar
{
    class clsEvent
    {
        public static List<clsEvent> listEvent = new List<clsEvent>();
        public DateTime startDate;
        public int duree;
        public string name;
        public string infos;
        public Color color;

        public clsEvent(DateTime date, string durée, string nom, string info, Color userColor)
        {
            startDate = date;
            duree = int.Parse(durée );
            name = nom;
            infos = info;
            color = userColor;
        }
        
    }
}
