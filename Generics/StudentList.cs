using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class StudentList
    {
        private StudentList[] arr;

        public StudentList()
        {
            arr = new StudentList[0];

        }
        public void Add(StudentList student )
        {

            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = student;
        }
        public void GetAll()
        {

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
}   }
