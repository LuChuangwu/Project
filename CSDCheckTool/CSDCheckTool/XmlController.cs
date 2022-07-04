using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CSDCheckTool
{
    public class XmlController
    {
        //public static  List<string> csd_path = new List<string>();
     
        private XmlDocument xmlDocument = new XmlDocument();

        public void LoadXmL(string heng_path)
        {
            xmlDocument.Load(heng_path);
        }
        //public T GetAllChildren<T>(XmlNodeList nodeList, Action action)
        //{
        //    foreach (XmlElement item in nodeList)
        //    {
        //       return action(item) ;
        //        if (true)
        //        {

        //        }
        //    }
        //}
       

      




    }
}
