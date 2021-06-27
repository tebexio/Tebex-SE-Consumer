using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using VRage.Plugins;

namespace DemoEventHandler
{
    public class PluginConfiguration : IPluginConfiguration
    {
        public void Save(string userDataPath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PluginConfiguration));
            
            string configFile = Path.Combine(userDataPath, "DemoEventHandler.cfg");
            using(StreamWriter stream = new StreamWriter(configFile, false, Encoding.UTF8))
            {
                serializer.Serialize(stream, this);
            }
        }
    }
}
