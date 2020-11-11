using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Xml;

namespace OOP__Lab2
{
    class DOM  : IStrategy
    {
        XmlDocument doc = new XmlDocument();
        public DOM(string path)
        {
            doc.Load(path);
        }

        public List<Student> Search(Student item, string path)
        {
            List<Student> result = new List<Student>();
            string Xpath = CreateXPath(item);
            var elements = doc.SelectNodes(Xpath);

            foreach (XmlNode i in elements)
            {
                Student temp = new Student();
                temp.Faculty = i.ParentNode.ParentNode.ParentNode.Attributes.GetNamedItem("FACULTY").Value;
                temp.Department = i.ParentNode.ParentNode.Attributes.GetNamedItem("Name").Value;
                temp.Group = i.ParentNode.Attributes.GetNamedItem("GROUP").Value;
                temp.Name = i.Attributes.GetNamedItem("NAME").Value;
                temp.Surname = i.Attributes.GetNamedItem("SURNAME").Value;
                temp.Rating = i.Attributes.GetNamedItem("RATING").Value;
                temp.Room = i.Attributes.GetNamedItem("ROOM").Value;
                result.Add(temp);
            }

            return result;
        }

        private string CreateXPath(Student item)
        {
            List<string> attributes = new List<string>();
            string Xpath = "/";
            string Att = "";
            if (item.Faculty != null) Xpath += "/Faculty[@FACULTY =\"" + item.Faculty + "\"]";
            else
            {
                Xpath += "/Faculty";
            }
            if (item.Department != null) Xpath += "/Department[@Name =\"" + item.Department + "\"]";
            else
            {
                Xpath += "/Department";
            }
            if (item.Group != null) Xpath += "/Group[@GROUP =\"" + item.Group + "\"]";
            else
            {
                Xpath += "/Group";
            }

            if (item.Name != null) attributes.Add("@NAME =\"" + item.Name + "\"");
            if (item.Surname != null) attributes.Add("@SURNAME =\"" + item.Surname + "\"");
            if (item.Rating != null) attributes.Add("@RATING =\"" + item.Rating + "\"");
            if (item.Room != null) attributes.Add("@ROOM =\"" + item.Room + "\"");
            for(int i = 0; i < attributes.Count; ++i)
            {
                if (i == 0) Att += attributes[i];
                else Att += " and " + attributes[i]; 
            }

            if (attributes.Count != 0) Xpath += "/Student[" + Att + "]";
            else Xpath += "/Student";

            return Xpath;
        }
    }
}
