using StudentManager.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Blo
{
    class ObjectInOut
    {
        private const string DATA_FILE = "StudentManager.SM";
        public static int Save(DataContext dataContext)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(DATA_FILE, FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, dataContext);
                stream.Close();

            }
            catch (Exception ex)
            {

                return -1;
            }
            return 1;
        }

        public static DataContext Read()
        {
            DataContext objnew = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(DATA_FILE, FileMode.Open, FileAccess.Read);
                objnew = (DataContext)formatter.Deserialize(stream);
            }
            catch (Exception ex)
            {
                return null;
            }

            return objnew;
        }
    }
}
