using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;

namespace Module6SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp._id = 101;
            emp._name = "Bob";
            string filePath = "C:\\Users\\Steven\\Desktop\\MSSA\\Microsoft-Software-and-Systems-Academy-Repo\\20483C.Programming in C#\\Week6\\Day7\\DummyFile.txt";

            //Second Step: choose how to seralize the data 

            //Binary Serialization
            FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bn = new BinaryFormatter();
            bn.Serialize(fileStream, emp); // Where and what you want to serailize
            fileStream.Close();

            //Binary Deserialization
            FileStream fileStream1 = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
            Employee emp1;
            emp1 = (Employee)bn.Deserialize(fileStream1);
            fileStream1.Close();
            Console.WriteLine("Deserizalied data: ");
            Console.WriteLine($"Emp Id: {emp._id}, Emp Name: {emp._name}");


            Console.WriteLine("------------------------");

            //XML Serialization

            SoapFormatter soapFormatter = new SoapFormatter();
            FileStream fileStreamxml = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            soapFormatter.Serialize(fileStreamxml, emp);
            fileStreamxml.Close();

            //XML Desiralization

            FileStream bufferxml = File.OpenRead(filePath);
            Employee exml = soapFormatter.Deserialize(bufferxml) as Employee;
            bufferxml.Close();
            Console.WriteLine("XML Deserizalied data: ");
            Console.WriteLine($"Emp Id: {exml._id}, Emp Name: {exml._name}");


            Console.WriteLine("------------------------");

            //JSON Serialization
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(emp.GetType());
            FileStream jsonBuffer = File.Create(filePath);
            jsonSerializer.WriteObject(jsonBuffer, emp);
            jsonBuffer.Close();

            //JSON Deserialization
            FileStream jsonBuffered = File.OpenRead(filePath);
            Employee jsonEmp = jsonSerializer.ReadObject(jsonBuffered) as Employee;
            jsonBuffered.Close();
            Console.WriteLine("Deserizalied data: ");
            Console.WriteLine($"Emp Id: {emp._id}, Emp Name: {emp._name}");


            /*DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(eobj.GetType());
            FileStream jsonbuffer = File.Create(@"C:\Users\JackA\MSSA\Week 6\File\jsondata.txt");
            jsonSerializer.WriteObject(jsonbuffer, eobj);
            jsonbuffer.Close();
            FileStream jsonbufferread = File.OpenRead(@"C:\Users\JackA\MSSA\Week 6\File\jsondata.txt");
            Emp jsonobj = jsonSerializer.ReadObject(jsonbuffer) as Emp;
            jsonbufferread.Close();*/


            Console.ReadLine();
        }
    }
}
