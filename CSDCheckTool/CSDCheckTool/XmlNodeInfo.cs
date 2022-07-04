using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSDCheckTool
{
    public class XmlNodeInfo
    {
        public string name;
        public Vector2 size;
        public Vector2 anchorPoint;
        public Vector2 position;
        public Vector2 scale;
        public string node_path;


        public XmlNodeInfo(XmlElement xmlNode)
        {
            name = xmlNode.GetAttribute("Name");

        }
        
    }
}
