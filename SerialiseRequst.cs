using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RepairRequests2
{
    public class SerialiseRequst
    {
        public BinaryFormatter binaryFormatter = new BinaryFormatter();
        public void SerialiseListOfRequst(List<Request> ListOfRequst)
        {
            using (var file = new FileStream("text.json", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(file, ListOfRequst);
            }
        }

        public List<Request> DeserializeListOfRequest()
        {
            using (var file = new FileStream("text.json", FileMode.OpenOrCreate))
            {
                return binaryFormatter.Deserialize(file) as List<Request>;
            }
        }
    }
}
