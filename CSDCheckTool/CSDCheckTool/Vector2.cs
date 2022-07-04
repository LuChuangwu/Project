using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSDCheckTool
{
    public struct Vector2
    {
        public float x;
        public float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static  Vector2 GetValueByeXmlNode(XmlElement xmlNode)
        {
            Vector2 vector2 = new Vector2(0, 0);
            foreach (XmlAttribute item in xmlNode.Attributes)
            {
                if (item.Name.ToLower().Contains("x"))
                {
                    vector2.x = float.Parse(item.Value);
                }
                if (item.Name.ToLower().Contains("y"))
                {
                    vector2.y = float.Parse(item.Value);
                }
            }
            return vector2;
        }

    }
}
