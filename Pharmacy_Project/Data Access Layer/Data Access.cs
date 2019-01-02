using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Data_Access
    {
        public Pharmacy_ContextDataContext PharmacyContext = new Pharmacy_ContextDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Farhana Najnin\Desktop\c#\Pharmacy_Project\Pharmacy_Project\Data Access Layer\PharmacyDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        public List<object> GetMedicineList()
        {
            var x = from mi in PharmacyContext.Medicine_infos select mi;
          
            List<object> o = new List<object> ();
            o.AddRange (x.ToList());
            return o;
        }


        public object GetMedicine( string n )
        {
            var x = from a in PharmacyContext.Medicine_infos
                where a.Medicine_Name == n
                select a;

            object o = x.ToList ();
            return o;
        }

        public void AddMedicine( string name, string gname,double price,int quantity )
        {
            Medicine_info medicineInfo = new Medicine_info();
            medicineInfo.Medicine_Name = name;
            medicineInfo.Generic_Name = gname;
            medicineInfo.Price = price;
            medicineInfo.Quantity = quantity;

            PharmacyContext.Medicine_infos.InsertOnSubmit(medicineInfo);
            PharmacyContext.SubmitChanges ();

        }

        public void DeleteMedicine(int i)
        {
            var m = from a in PharmacyContext.Medicine_infos
                where a.Medicine_Id == i
                select a;
            Medicine_info obj = PharmacyContext.Medicine_infos.Single(x => x.Medicine_Id == i);
            PharmacyContext.Medicine_infos.DeleteOnSubmit(obj);
            PharmacyContext.SubmitChanges();
        }

        public void UpdateMedicine( int i, double p,int q)
        {
            Medicine_info medicineInfo = PharmacyContext.Medicine_infos.Single(x => x.Medicine_Id == i); //select *from medicine_info where medicine_id=i LIMIT 1
            medicineInfo.Price = p;
            medicineInfo.Quantity = q;
            PharmacyContext.SubmitChanges ();
        }

        public List<object> GetEmployeeList( )
        {
            var x = from mi in PharmacyContext.Employee_Infos select mi;

            List<object> o = new List<object> ();
            o.AddRange (x.ToList ());
            return o;
        }


        public object GetEmployee( string n )
        {
            var x = from a in PharmacyContext.Employee_Infos
                where a.Employee_Name == n
                select a;
            object o = x.ToList ();
            return o;
        }

        public void AddEmployee( string name, string password, string bloodGroup, string gender )
        {
            Employee_Info employeeInfo = new Employee_Info();
            employeeInfo.Employee_Name = name;
            employeeInfo.Password = password;
            employeeInfo.Blood_Group = bloodGroup;
            employeeInfo.Gender = gender;


            PharmacyContext.Employee_Infos.InsertOnSubmit (employeeInfo);
            PharmacyContext.SubmitChanges ();

        }

        public void DeleteEmployee( int i )
        {
            var m = from a in PharmacyContext.Employee_Infos
                where a.Id == i
                select a;
            Employee_Info obj = PharmacyContext.Employee_Infos.Single (x => x.Id == i);
            PharmacyContext.Employee_Infos.DeleteOnSubmit (obj);
            PharmacyContext.SubmitChanges ();
        }

        public void UpdateEmployee( int i, string name, string password, string bloodGroup, string gender )
        {
            Employee_Info employeeInfo = PharmacyContext.Employee_Infos.Single (x => x.Id == i); //select *from medicine_info where medicine_id=i LIMIT 1
            employeeInfo.Employee_Name = name;
            employeeInfo.Password = password;
            employeeInfo.Blood_Group = bloodGroup;
            employeeInfo.Gender = gender;
            PharmacyContext.SubmitChanges ();
        }
        public object SearchEmployee( string name)
        {

            var x = from a in PharmacyContext.Employee_Infos
                where a.Employee_Name == name 
                select a;
            object o = x.ToList();
            return o;

        }
    }
}
