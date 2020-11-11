using OOP__Lab2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
namespace SAlgorithm
{
    class LINQ : IStrategy
    {
        XDocument doc = new XDocument();
        public LINQ(string path)
        {
            doc = XDocument.Load(path);
            
        }

        public List<Student> Search(Student student, string path)
        {

            List<Student> result = new List<Student>();
            List<XElement> data = (from val in doc.Descendants("Student")
                                   where
                                   ((student.Faculty == null || student.Faculty == val.Parent.Parent.Parent.Attribute("FACULTY").Value) &&
                                   (student.Department == null || student.Department == val.Parent.Parent.Attribute("Name").Value) &&
                                   (student.Group == null || student.Group == val.Parent.Attribute("GROUP").Value) &&
                                   (student.Name == null || student.Name == val.Attribute("NAME").Value) &&
                                   (student.Surname == null || student.Surname == val.Attribute("SURNAME").Value) &&
                                   (student.Rating == null || student.Rating == val.Attribute("RATING").Value) &&
                                   (student.Room == null || student.Room == val.Attribute("ROOM").Value))
                                   select val).ToList();
            foreach(var i in data)
            {
                Student temp  = new Student();
                temp.Faculty = i.Parent.Parent.Parent.Attribute("FACULTY").Value;
                temp.Department = i.Parent.Parent.Attribute("Name").Value;
                temp.Group = i.Parent.Attribute("GROUP").Value;
                temp.Name = i.Attribute("NAME").Value;
                temp.Surname = i.Attribute("SURNAME").Value;
                temp.Rating = i.Attribute("RATING").Value;
                temp.Room = i.Attribute("ROOM").Value;
                result.Add(temp);
            }

            return result;
        }
    }
}
