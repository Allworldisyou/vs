using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AboutXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowMxl();
        }
        List<Message> list=new List<Message>();
        public void ShowMxl()
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load("Address.xml");
            XmlNode root = myXml.DocumentElement;

            foreach (XmlNode item in root.ChildNodes)
            {
                MessageInfo ms = new MessageInfo();
                ms.Street = root.Attributes["name"].Value.ToString();
                foreach (XmlNode item1 in item.ChildNodes)
                {
                    ms.Committee = item.Attributes["name"].Value.ToString();
                    foreach (XmlNode item2 in item1.ChildNodes)
                    {
                        ms.Building = item1.Attributes["name"].Value.ToString();
                        foreach (XmlNode item3 in item2.ChildNodes)
                        {
                            ms.Huisnummer = item3.InnerText;
                            
                        }
                       
                    }
                   
                }
               list.Add(ms);
            }
        }



        #region 树状菜单获取
        public void intrv()
        {
           
            TreeNode node = null;
           
            foreach (Message item in list)
            {
                if (node==null)
                {
                    node = new TreeNode(item.Street);
                    treeView1.Nodes.Add(node);
                }
               
               TreeNode tn = new TreeNode(item.Committee);
                node.Nodes.Add(tn);
                TreeNode tn2 = new TreeNode(item.Building);
                tn.Nodes.Add(tn2);
                TreeNode tn3 = new TreeNode(item.Huisnummer);
                tn2.Nodes.Add(tn3);
                
            }
        }
        #endregion



         
        }


    }
}
}