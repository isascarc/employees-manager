using System;
using System.Drawing;
using System.IO;

namespace ManagerEmployees
{
    public enum QuantityExport { All, This, Specific }

    public enum TypeExport { document, worksheet, slide, pdf, html, DbAccesss, DbSQL, ASP, Xml, Text }
    public static class Settings
    {
        public static string path { set; get; }
        public static int NumFilesToSave { set; get; }
        public static string Lang { set; get; }
        public static int NumMinutes { set; get; }
        public static bool save { set; get; }
        public static string DotFile { set; get; }
        public static bool FileOpen { set; get; }
        //Realy
        public static bool OpenAuto { set; get; }
        public static bool AbsoluteDelete { set; get; }
        public static string Password { set; get; }
        public static void LoadSettings()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("settings.set");
                OpenAuto = lines[0] == "0";
                AbsoluteDelete = lines[1] == "0";
                Password = lines[2];
            }
            catch { }
        }
        public static string  GetFileBytes(string fileName)
        {
            byte[] fileBytes;
            string s = "";
            using (StreamReader stream = new StreamReader (fileName))
            {
                s = stream.ReadToEnd();
                
            }

            return s;
        }
    }
      
    public class CreateNewFile
    {
        public static bool TypeThisSQL { get; set; }
        public static string Location { get; set; }
        public static string NameFile { get; set; }
    }

    public class EmployeeTemp
    {
        public static employee TempEmp { get; set; }
        public static int NumEmployee { get; set; }
    }

    public class EmpToExport
    {
        public static string Path { get; set; }
        public static string fileName { get; set; }
        public static TypeExport ExpTo { get; set; }
        public static QuantityExport TypeToExport { get; set; }
        public static object[] EmpsToExport { get; set; }
        // checkBoxs
        public static bool OpenInEnd { get; set; }
        public static bool ToArchive { get; set; }
        public static bool SendMail { get; set; }
    }
    public class employee
    {
        public int _ID { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public DateTime birth;
        public DateTime startWork;
        public string Status { get; set; }
        public string Childs { get; set; }
        public string ID { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        //public string pelephone { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public string Duty { get; set; }
        public string Remarks { get; set; }
        public string stringOfImage { get; set; }
        public int salary { get; set; }
        public employee(object[] arr)
        {
            _ID= Convert.ToInt32(arr[0].ToString());
            name = arr[1].ToString();
            family = arr[2].ToString();
            ID = arr[3].ToString();
            DateTime.TryParse(arr[3].ToString(), out  birth);
            Childs = arr[4].ToString();
            City = arr[5].ToString();
            Address = arr[6].ToString();
            Telephone = arr[7].ToString();
            Mail = arr[8].ToString();
            Duty = arr[9].ToString();
            Remarks = arr[10].ToString();
            Status = arr[12].ToString();
            DateTime.TryParse(arr[11].ToString(), out  startWork);
            stringOfImage = arr[0].ToString();
            //salary = int.Parse(arr[14].ToString());
        }
       
        public string[] ToArray()
        {
            string[] ret = new string[12] { name, family, Status, Childs, ID, City, Address, Telephone,Telephone, Mail, Duty, Remarks};
            return ret;
        }

        //public employee(string Name, string Family, string Birth, string StartWork, string Status, string Childs, string ID, string City,
        //    string Address, string Pelephone, string Telephone, string Mail, string Duty, string Remarks, string StringOfImage)
        //{
        //    name = Name;
        //    family = Family;
        //    status = Status;
        //    childs = Childs;
        //    id = ID;
        //    city = City;
        //    address = Address;
        //    pelephone = Pelephone;
        //    telephone = Telephone;
        //    mail = Mail;
        //    duty = Duty;
        //    remarks = Remarks;
        //    stringOfImage = StringOfImage;
        //    DateTime.TryParse(Birth, out  birth);
        //    DateTime.TryParse(StartWork, out  startWork);
        //}
       
    }
}