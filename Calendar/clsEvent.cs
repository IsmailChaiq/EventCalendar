using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;
using System.Runtime;
using System.Runtime.Serialization.Formatters.Binary;

using System.IO;

namespace Calendar
{
    [Serializable]
    public class clsEvent
    {
        public static List<clsEvent> listEvent = loadEvents();
        public DateTime startDate;
        public int duree;
        public string name;
        public string infos;
        public Color color;

        public clsEvent() { }
        public clsEvent(DateTime date, string durée, string nom, string info, Color userColor)
        {
            startDate = date;
            duree = int.Parse(durée);
            name = nom;
            infos = info;
            color = userColor;
        }



        public static void saveEvents()
        {
            FileStream readEventFile = new FileStream("Events.dat", FileMode.OpenOrCreate);
            //XmlSerializer serializer = new XmlSerializer(listEvent.GetType());
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(readEventFile, listEvent);
            readEventFile.Close();
        }

        public static List<clsEvent> loadEvents()
        {
            FileStream writeEventFile = new FileStream("Events.dat", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                listEvent = (List<clsEvent>)formatter.Deserialize(writeEventFile);
            }
            catch(Exception e)
            {
                listEvent = new List<clsEvent>();
                
            }
            finally
            {
                writeEventFile.Close();
            }
            return listEvent;


        }
    }
}
