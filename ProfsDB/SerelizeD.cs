using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProfsDB
{
    class SerelizeD
    {

        public static void SrelD(object _ser, string path)
        {
            BinaryFormatter binFormat = new BinaryFormatter();

            using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, _ser);
                fStream.Dispose();
            }
        }
    }
    class DeserelzeD
    {
        public static object DeserD(string path)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var _Des = (object)binFormat.Deserialize(fs);
                fs.Close();
                fs.Dispose();
                return _Des;


            }
        }
    }
}
