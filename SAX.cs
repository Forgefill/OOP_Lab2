using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Xml;

namespace OOP__Lab2
{
    class SAX : IStrategy
    {
        string path;
        public SAX(string path)
        {
            this.path = path;
        }

        public List<Student> Search(Student item, string path)
        {
            List<Student> result = new List<Student>();
            var FileReader = new XmlTextReader(path);
            string Faculty = null;
            string Department = null;
            string Group = null;
            while (FileReader.Read())
            {

                if (FileReader.Name == "Faculty")
                {
                    while (FileReader.MoveToNextAttribute())
                    {
                        if (FileReader.Name == "FACULTY")
                        {
                            if (item.Faculty != null && item.Faculty != FileReader.Value) FileReader.Skip();
                            else
                            {
                                Faculty = FileReader.Value;
                            }
                        }
                    }
                }
                else if (FileReader.Name == "Department")
                {
                    while (FileReader.MoveToNextAttribute())
                    {
                        if (FileReader.Name == "Name")
                        {
                            if (item.Department != null && item.Department != FileReader.Value) FileReader.Skip();
                            else
                            {
                                Department = FileReader.Value;
                            }
                        }
                    }
                }
                else if (FileReader.Name == "Group")
                {
                    while (FileReader.MoveToNextAttribute())
                    {
                        if (FileReader.Name == "GROUP")
                        {
                            if (item.Group != null && item.Group != FileReader.Value) FileReader.Skip();
                            else
                            {
                                Group = FileReader.Value;
                            }
                        }
                    }
                }
                else if (FileReader.Name == "Student")
                {
                    Student temp = new Student();
                    temp.Faculty = Faculty;
                    temp.Department = Department;
                    temp.Group = Group;
                    while (FileReader.MoveToNextAttribute())
                    {
                        switch (FileReader.Name)
                        {
                            case "NAME":
                                if (item.Name != null && item.Name != FileReader.Value) FileReader.Skip();
                                else
                                {
                                    temp.Name = FileReader.Value;
                                }
                                break;
                            case "SURNAME":
                                if (item.Surname != null && item.Surname != FileReader.Value) FileReader.Skip();
                                else
                                {
                                    temp.Surname = FileReader.Value;
                                }
                                break;
                            case "RATING":
                                if (item.Rating != null && item.Rating != FileReader.Value) FileReader.Skip();
                                else
                                {
                                    temp.Rating = FileReader.Value;
                                }
                                break;
                            case "ROOM":
                                if (item.Room != null && item.Room != FileReader.Value) FileReader.Skip();
                                else
                                {
                                    temp.Room = FileReader.Value;
                                }
                                break;
                        }
                    }
                    if (temp.Room != null) result.Add(temp);
                }

            }
            FileReader.Close();
            return result;
        }
    }
}
