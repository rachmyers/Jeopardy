using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Classes
{
    /// <summary>
    /// This class is used to deserialize the XML file so the nodes can be used as objects
    /// </summary>
    class XMLSerializer
    {
        /// <summary>
        /// This class takes a generic object T, deserializes it, and then reads it
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public T Deserialize<T>(string input) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }

    }
}
