﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Access_Layer
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PharmacyDB")]
	public partial class Pharmacy_ContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer_Info(Customer_Info instance);
    partial void UpdateCustomer_Info(Customer_Info instance);
    partial void DeleteCustomer_Info(Customer_Info instance);
    partial void InsertEmployee_Info(Employee_Info instance);
    partial void UpdateEmployee_Info(Employee_Info instance);
    partial void DeleteEmployee_Info(Employee_Info instance);
    partial void InsertMedicine_info(Medicine_info instance);
    partial void UpdateMedicine_info(Medicine_info instance);
    partial void DeleteMedicine_info(Medicine_info instance);
    #endregion
		
		public Pharmacy_ContextDataContext() : 
				base(global::Data_Access_Layer.Properties.Settings.Default.PharmacyDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Pharmacy_ContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Pharmacy_ContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Pharmacy_ContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Pharmacy_ContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer_Info> Customer_Infos
		{
			get
			{
				return this.GetTable<Customer_Info>();
			}
		}
		
		public System.Data.Linq.Table<Employee_Info> Employee_Infos
		{
			get
			{
				return this.GetTable<Employee_Info>();
			}
		}
		
		public System.Data.Linq.Table<Medicine_info> Medicine_infos
		{
			get
			{
				return this.GetTable<Medicine_info>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer_Info")]
	public partial class Customer_Info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Customer_Id;
		
		private string _Phone_Number;
		
		private int _Medicine_Id;
		
		private int _Total_Amount;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomer_IdChanging(int value);
    partial void OnCustomer_IdChanged();
    partial void OnPhone_NumberChanging(string value);
    partial void OnPhone_NumberChanged();
    partial void OnMedicine_IdChanging(int value);
    partial void OnMedicine_IdChanged();
    partial void OnTotal_AmountChanging(int value);
    partial void OnTotal_AmountChanged();
    #endregion
		
		public Customer_Info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Customer_Id", DbType="Int NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Customer_Id
		{
			get
			{
				return this._Customer_Id;
			}
			set
			{
				if ((this._Customer_Id != value))
				{
					this.OnCustomer_IdChanging(value);
					this.SendPropertyChanging();
					this._Customer_Id = value;
					this.SendPropertyChanged("Customer_Id");
					this.OnCustomer_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone_Number", DbType="VarChar(50)")]
		public string Phone_Number
		{
			get
			{
				return this._Phone_Number;
			}
			set
			{
				if ((this._Phone_Number != value))
				{
					this.OnPhone_NumberChanging(value);
					this.SendPropertyChanging();
					this._Phone_Number = value;
					this.SendPropertyChanged("Phone_Number");
					this.OnPhone_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Medicine_Id", DbType="Int NOT NULL")]
		public int Medicine_Id
		{
			get
			{
				return this._Medicine_Id;
			}
			set
			{
				if ((this._Medicine_Id != value))
				{
					this.OnMedicine_IdChanging(value);
					this.SendPropertyChanging();
					this._Medicine_Id = value;
					this.SendPropertyChanged("Medicine_Id");
					this.OnMedicine_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total_Amount", DbType="Int NOT NULL")]
		public int Total_Amount
		{
			get
			{
				return this._Total_Amount;
			}
			set
			{
				if ((this._Total_Amount != value))
				{
					this.OnTotal_AmountChanging(value);
					this.SendPropertyChanging();
					this._Total_Amount = value;
					this.SendPropertyChanged("Total_Amount");
					this.OnTotal_AmountChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee_Info")]
	public partial class Employee_Info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Employee_Name;
		
		private string _Password;
		
		private string _Blood_Group;
		
		private string _Gender;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmployee_NameChanging(string value);
    partial void OnEmployee_NameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnBlood_GroupChanging(string value);
    partial void OnBlood_GroupChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    #endregion
		
		public Employee_Info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Employee_Name
		{
			get
			{
				return this._Employee_Name;
			}
			set
			{
				if ((this._Employee_Name != value))
				{
					this.OnEmployee_NameChanging(value);
					this.SendPropertyChanging();
					this._Employee_Name = value;
					this.SendPropertyChanged("Employee_Name");
					this.OnEmployee_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Blood_Group", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string Blood_Group
		{
			get
			{
				return this._Blood_Group;
			}
			set
			{
				if ((this._Blood_Group != value))
				{
					this.OnBlood_GroupChanging(value);
					this.SendPropertyChanging();
					this._Blood_Group = value;
					this.SendPropertyChanged("Blood_Group");
					this.OnBlood_GroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Medicine_info")]
	public partial class Medicine_info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Medicine_Id;
		
		private string _Medicine_Name;
		
		private string _Generic_Name;
		
		private double _Price;
		
		private int _Quantity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMedicine_IdChanging(int value);
    partial void OnMedicine_IdChanged();
    partial void OnMedicine_NameChanging(string value);
    partial void OnMedicine_NameChanged();
    partial void OnGeneric_NameChanging(string value);
    partial void OnGeneric_NameChanged();
    partial void OnPriceChanging(double value);
    partial void OnPriceChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    #endregion
		
		public Medicine_info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Medicine_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Medicine_Id
		{
			get
			{
				return this._Medicine_Id;
			}
			set
			{
				if ((this._Medicine_Id != value))
				{
					this.OnMedicine_IdChanging(value);
					this.SendPropertyChanging();
					this._Medicine_Id = value;
					this.SendPropertyChanged("Medicine_Id");
					this.OnMedicine_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Medicine_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Medicine_Name
		{
			get
			{
				return this._Medicine_Name;
			}
			set
			{
				if ((this._Medicine_Name != value))
				{
					this.OnMedicine_NameChanging(value);
					this.SendPropertyChanging();
					this._Medicine_Name = value;
					this.SendPropertyChanged("Medicine_Name");
					this.OnMedicine_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Generic_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Generic_Name
		{
			get
			{
				return this._Generic_Name;
			}
			set
			{
				if ((this._Generic_Name != value))
				{
					this.OnGeneric_NameChanging(value);
					this.SendPropertyChanging();
					this._Generic_Name = value;
					this.SendPropertyChanged("Generic_Name");
					this.OnGeneric_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float NOT NULL")]
		public double Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591