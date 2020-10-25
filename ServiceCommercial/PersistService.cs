using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel.Design.Serialization;

namespace ServiceCommercial
{
    class PersistService
    {
        public PersistService()
        {

        }

        static public void Save(Service s, string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, s);
            file.Close();
        }

        static public Service Load(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            var loadService = (Service)bf.Deserialize(file);
            file.Close();
            return loadService;
        }
    }
}
