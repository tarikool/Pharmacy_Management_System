using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class Medicine
    {
        string medicineName;
        string genericName;
        double price;
        int quantity;

        Data_Access dataAccess = new Data_Access();

        public string Medicine_Name
        {
            set { this.medicineName = value; }
            get { return this.medicineName; }
        }

        public string Generic_Name
        {
            set { this.genericName = value; }
            get { return this.genericName; }
        }

        public double Price
        {
            set { this.price = value; }
            get { return this.price; }
        }

        public int Quantity
        {
            set { this.quantity = value; }
            get { return this.quantity; }
        }

        public List<object> GetMedicineList( )
        {
            List<object> getMedicineList = dataAccess.GetMedicineList();

            return getMedicineList.ToList ();
        }

        public object GetMedicine( string n )
        {
            object p = dataAccess.GetMedicine(n);

            return p;
        }

        public void AddMedicine( string n, string gn, double p, int q )
        {
            dataAccess.AddMedicine(n,gn,p,q);
        }


        public void UpdateMedicine( int i ,double p ,int q)
        {
            dataAccess.UpdateMedicine(i,p,q);
        }
        public void DeleteMedicine(int i)
        {
            dataAccess.DeleteMedicine(i);
        }

    }
}