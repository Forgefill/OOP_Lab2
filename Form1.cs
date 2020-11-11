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
using System.Xml.Schema;
using System.Xml.Xsl;
using SAlgorithm;
namespace OOP__Lab2
{
    public partial class Form1 : Form
    {
        String path = "StudentDataBase.xml";
        List<Student> Info = new List<Student>();  
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        private void InitializeComboBox()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList elem = doc.SelectNodes("//Faculty");
            foreach(XmlNode faculty in elem)
            {
                XmlNodeList List1 = faculty.ChildNodes;
                foreach(XmlNode department in List1)
                {
                    XmlNodeList List2 = department.ChildNodes;
                    foreach(XmlNode group in List2)
                    {
                        XmlNodeList List3 = group.ChildNodes;
                        foreach (XmlNode Student in List3)
                        {
                            string Faculty = Student.ParentNode.ParentNode.ParentNode.Attributes.GetNamedItem("FACULTY").Value;
                            if (!FacultyComboBox.Items.Contains(Faculty))
                            {
                                FacultyComboBox.Items.Add(Faculty);
                            }
                            string Department = Student.ParentNode.ParentNode.Attributes.GetNamedItem("Name").Value;
                            if (!DepartmentComboBox.Items.Contains(Department))
                            {
                                DepartmentComboBox.Items.Add(Department);
                            }
                            string Group = Student.ParentNode.Attributes.GetNamedItem("GROUP").Value;
                            if (!GroupComboBox.Items.Contains(Group))
                            {
                                GroupComboBox.Items.Add(Group);
                            }
                            string Name = Student.Attributes.GetNamedItem("NAME").Value;
                            if (!NameComboBox.Items.Contains(Name))
                            {
                                NameComboBox.Items.Add(Name);
                            }
                            string Surname = Student.Attributes.GetNamedItem("SURNAME").Value;
                            if (!SurnameComboBox.Items.Contains(Surname))
                            {
                                SurnameComboBox.Items.Add(Surname);
                            }
                            string Rating = Student.Attributes.GetNamedItem("RATING").Value;
                            if (!RatingComboBox.Items.Contains(Rating))
                            {
                                RatingComboBox.Items.Add(Rating);
                            }
                            string Room = Student.Attributes.GetNamedItem("ROOM").Value;
                            if (!RoomComboBox.Items.Contains(Room))
                            {
                                RoomComboBox.Items.Add(Room);
                            }
                        }
                    }
                }
            }
        }
        private Student GetBestStudentType()
        {
            Student result = new Student();

            if (FacultyCheckBox.Checked) result.Faculty = FacultyComboBox.Text;
            if (DepartmentCheckBox.Checked) result.Department = DepartmentComboBox.Text;
            if (GroupCheckBox.Checked) result.Group = GroupComboBox.Text;
            if (NameCheckBox.Checked) result.Name = NameComboBox.Text;
            if (SurnameCheckBox.Checked) result.Surname = SurnameComboBox.Text;
            if (RoomCheckBox.Checked) result.Room = RoomComboBox.Text;
            if (RatingCheckBox.Checked) result.Rating = RatingComboBox.Text;

            return result;
        }
        void Output(List<Student> result)
        {
            int num = 1;
            if (result.Count == 0) richTextBox1.AppendText("There are no items that match your requirements\n");
            else
            {
                foreach (var i in result)
                {
                    richTextBox1.AppendText("Student " + num++ + ".\n");
                    richTextBox1.AppendText("Faculty: " + i.Faculty + '\n');
                    richTextBox1.AppendText("Department: " + i.Department + '\n');
                    richTextBox1.AppendText("Group: " + i.Group + '\n');
                    richTextBox1.AppendText("Name: " + i.Name + '\n');
                    richTextBox1.AppendText("Surname: " + i.Surname + '\n');
                    richTextBox1.AppendText("Rating: " + i.Rating + '\n');
                    richTextBox1.AppendText("Room: " + i.Room + '\n');
                    richTextBox1.AppendText("_________________________________" + '\n');
                }
            }
        }
        private void DoSearch()
        {
            richTextBox1.Clear();
            Student BestStudent = GetBestStudentType();

            if(SaxButton.Checked)
            {
                IStrategy Strategy = new SAX(path);
                Info = Strategy.Search(BestStudent, path);
                Output(Info);
            }
            else if(DomButton.Checked)
            {
                IStrategy Strategy = new DOM(path);
                Info = Strategy.Search(BestStudent, path);
                Output(Info);
            }
            else if(LinqButton.Checked)
            {
                IStrategy Strategy = new LINQ(path);
                Info = Strategy.Search(BestStudent, path);
                Output(Info);
            }

        }
        private void SearchButtonClick(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void FormCloseClick(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ви дійсно хочете вийти?",
                     "Важливо!", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ClearbuttonClick(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            richTextBox1.Clear();
            Info.Clear();

            FacultyCheckBox.Checked = false;
            DepartmentCheckBox.Checked = false;
            GroupCheckBox.Checked = false;
            NameCheckBox.Checked = false;
            SurnameCheckBox.Checked = false;
            RoomCheckBox.Checked = false;
            RatingCheckBox.Checked = false;

            FacultyComboBox.Text = null;
            DepartmentComboBox.Text = null;
            GroupComboBox.Text = null;
            NameComboBox.Text = null;
            SurnameComboBox.Text = null;
            RoomComboBox.Text = null;
            RatingComboBox.Text = null;
        }

        private void TransformButtonClick(object sender, EventArgs e)
        {
            CreateXMLFile(Info);
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("XSL.xsl");
            string input = @"Temp.xml";
            string result = @"info.html";
            xslt.Transform(input, result);
        }

        private void CreateXMLFile(List<Student> output)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("ResultDataBase");
            xmlDoc.AppendChild(rootNode);
            foreach(Student i in output)
            {

                XmlNode Student = xmlDoc.CreateElement("Student");
                XmlAttribute faculty = xmlDoc.CreateAttribute("FACULTY");
                XmlAttribute department = xmlDoc.CreateAttribute("DEPARTMENT");
                XmlAttribute group = xmlDoc.CreateAttribute("GROUP");
                XmlAttribute name = xmlDoc.CreateAttribute("NAME");
                XmlAttribute surname = xmlDoc.CreateAttribute("SURNAME");
                XmlAttribute rating = xmlDoc.CreateAttribute("RATING");
                XmlAttribute room = xmlDoc.CreateAttribute("ROOM");
                faculty.Value = i.Faculty;
                department.Value = i.Department;
                group.Value = i.Group;
                name.Value = i.Name;
                surname.Value = i.Surname;
                rating.Value = i.Rating;
                room.Value = i.Room;
                Student.Attributes.Append(name);
                Student.Attributes.Append(surname);
                Student.Attributes.Append(faculty);
                Student.Attributes.Append(department);
                Student.Attributes.Append(group);
                Student.Attributes.Append(rating);
                Student.Attributes.Append(room);

                rootNode.AppendChild(Student);
            }
            xmlDoc.Save("C:\\Users\\Mike Bubka\\source\\repos\\OOP__Lab2\\OOP__Lab2\\bin\\Debug\\netcoreapp3.1\\Temp.xml");
        }
    }
}
