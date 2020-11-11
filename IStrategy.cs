using System;
using System.Collections.Generic;
using System.Text;

namespace OOP__Lab2
{
    interface IStrategy
    {
       List<Student> Search(Student item, string path);
    }
}
