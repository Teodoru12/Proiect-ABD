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

namespace projectbaze
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="magazin")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategorie(Categorie instance);
    partial void UpdateCategorie(Categorie instance);
    partial void DeleteCategorie(Categorie instance);
    partial void Insertcomenzi3(comenzi3 instance);
    partial void Updatecomenzi3(comenzi3 instance);
    partial void Deletecomenzi3(comenzi3 instance);
    partial void InsertUseri(Useri instance);
    partial void UpdateUseri(Useri instance);
    partial void DeleteUseri(Useri instance);
    partial void InsertShipper(Shipper instance);
    partial void UpdateShipper(Shipper instance);
    partial void DeleteShipper(Shipper instance);
    partial void InsertPTco(PTco instance);
    partial void UpdatePTco(PTco instance);
    partial void DeletePTco(PTco instance);
    partial void InsertProduse(Produse instance);
    partial void UpdateProduse(Produse instance);
    partial void DeleteProduse(Produse instance);
    partial void InsertShipper1(Shipper1 instance);
    partial void UpdateShipper1(Shipper1 instance);
    partial void DeleteShipper1(Shipper1 instance);
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::projectbaze.Properties.Settings.Default.magazinConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Categorie> Categories
		{
			get
			{
				return this.GetTable<Categorie>();
			}
		}
		
		public System.Data.Linq.Table<comenzi3> comenzi3s
		{
			get
			{
				return this.GetTable<comenzi3>();
			}
		}
		
		public System.Data.Linq.Table<Useri> Useris
		{
			get
			{
				return this.GetTable<Useri>();
			}
		}
		
		public System.Data.Linq.Table<Shipper> Shippers
		{
			get
			{
				return this.GetTable<Shipper>();
			}
		}
		
		public System.Data.Linq.Table<PTco> PTcos
		{
			get
			{
				return this.GetTable<PTco>();
			}
		}
		
		public System.Data.Linq.Table<Produse> Produses
		{
			get
			{
				return this.GetTable<Produse>();
			}
		}
		
		public System.Data.Linq.Table<Shipper1> Shipper1s
		{
			get
			{
				return this.GetTable<Shipper1>();
			}
		}
		
		public System.Data.Linq.Table<comenzi2> comenzi2s
		{
			get
			{
				return this.GetTable<comenzi2>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.inserare")]
		public int inserare([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> userid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> shipperid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> suma)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, userid, shipperid, suma);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UPDATESHIPPER")]
		public int UPDATESHIPPER([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> shipperid)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), shipperid);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UPDATEsum")]
		public int UPDATEsum([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> userid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> shipperid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> suma)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, userid, shipperid, suma);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UPDATEPRICEQ")]
		public int UPDATEPRICEQ()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categorie")]
	public partial class Categorie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_categorie;
		
		private string _Nume;
		
		private EntitySet<Produse> _Produses;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_categorieChanging(int value);
    partial void OnID_categorieChanged();
    partial void OnNumeChanging(string value);
    partial void OnNumeChanged();
    #endregion
		
		public Categorie()
		{
			this._Produses = new EntitySet<Produse>(new Action<Produse>(this.attach_Produses), new Action<Produse>(this.detach_Produses));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_categorie", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID_categorie
		{
			get
			{
				return this._ID_categorie;
			}
			set
			{
				if ((this._ID_categorie != value))
				{
					this.OnID_categorieChanging(value);
					this.SendPropertyChanging();
					this._ID_categorie = value;
					this.SendPropertyChanged("ID_categorie");
					this.OnID_categorieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nume", DbType="VarChar(50)")]
		public string Nume
		{
			get
			{
				return this._Nume;
			}
			set
			{
				if ((this._Nume != value))
				{
					this.OnNumeChanging(value);
					this.SendPropertyChanging();
					this._Nume = value;
					this.SendPropertyChanged("Nume");
					this.OnNumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categorie_Produse", Storage="_Produses", ThisKey="ID_categorie", OtherKey="Categorie_id")]
		public EntitySet<Produse> Produses
		{
			get
			{
				return this._Produses;
			}
			set
			{
				this._Produses.Assign(value);
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
		
		private void attach_Produses(Produse entity)
		{
			this.SendPropertyChanging();
			entity.Categorie = this;
		}
		
		private void detach_Produses(Produse entity)
		{
			this.SendPropertyChanging();
			entity.Categorie = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.comenzi3")]
	public partial class comenzi3 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<int> _id;
		
		private System.Nullable<int> _user_id;
		
		private System.Nullable<int> _shipper_id;
		
		private System.Nullable<int> _suma;
		
		private int _id2;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Nullable<int> value);
    partial void OnidChanged();
    partial void Onuser_idChanging(System.Nullable<int> value);
    partial void Onuser_idChanged();
    partial void Onshipper_idChanging(System.Nullable<int> value);
    partial void Onshipper_idChanged();
    partial void OnsumaChanging(System.Nullable<int> value);
    partial void OnsumaChanged();
    partial void Onid2Changing(int value);
    partial void Onid2Changed();
    #endregion
		
		public comenzi3()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int")]
		public System.Nullable<int> id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int")]
		public System.Nullable<int> user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_shipper_id", DbType="Int")]
		public System.Nullable<int> shipper_id
		{
			get
			{
				return this._shipper_id;
			}
			set
			{
				if ((this._shipper_id != value))
				{
					this.Onshipper_idChanging(value);
					this.SendPropertyChanging();
					this._shipper_id = value;
					this.SendPropertyChanged("shipper_id");
					this.Onshipper_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_suma", DbType="Int")]
		public System.Nullable<int> suma
		{
			get
			{
				return this._suma;
			}
			set
			{
				if ((this._suma != value))
				{
					this.OnsumaChanging(value);
					this.SendPropertyChanging();
					this._suma = value;
					this.SendPropertyChanged("suma");
					this.OnsumaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id2", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id2
		{
			get
			{
				return this._id2;
			}
			set
			{
				if ((this._id2 != value))
				{
					this.Onid2Changing(value);
					this.SendPropertyChanging();
					this._id2 = value;
					this.SendPropertyChanged("id2");
					this.Onid2Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Useri")]
	public partial class Useri : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Username;
		
		private string _Parola;
		
		private string _email;
		
		private string _adresa;
		
		private string _Administrator;
		
		private string _Telefon;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnParolaChanging(string value);
    partial void OnParolaChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnadresaChanging(string value);
    partial void OnadresaChanged();
    partial void OnAdministratorChanging(string value);
    partial void OnAdministratorChanged();
    partial void OnTelefonChanging(string value);
    partial void OnTelefonChanged();
    #endregion
		
		public Useri()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Parola", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Parola
		{
			get
			{
				return this._Parola;
			}
			set
			{
				if ((this._Parola != value))
				{
					this.OnParolaChanging(value);
					this.SendPropertyChanging();
					this._Parola = value;
					this.SendPropertyChanged("Parola");
					this.OnParolaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(255)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adresa", DbType="VarChar(255)")]
		public string adresa
		{
			get
			{
				return this._adresa;
			}
			set
			{
				if ((this._adresa != value))
				{
					this.OnadresaChanging(value);
					this.SendPropertyChanging();
					this._adresa = value;
					this.SendPropertyChanged("adresa");
					this.OnadresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Administrator", DbType="VarChar(255)")]
		public string Administrator
		{
			get
			{
				return this._Administrator;
			}
			set
			{
				if ((this._Administrator != value))
				{
					this.OnAdministratorChanging(value);
					this.SendPropertyChanging();
					this._Administrator = value;
					this.SendPropertyChanged("Administrator");
					this.OnAdministratorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefon", DbType="VarChar(10)")]
		public string Telefon
		{
			get
			{
				return this._Telefon;
			}
			set
			{
				if ((this._Telefon != value))
				{
					this.OnTelefonChanging(value);
					this.SendPropertyChanging();
					this._Telefon = value;
					this.SendPropertyChanged("Telefon");
					this.OnTelefonChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Shippers")]
	public partial class Shipper : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_shipper;
		
		private string _Nume;
		
		private string _Telefon;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_shipperChanging(int value);
    partial void OnID_shipperChanged();
    partial void OnNumeChanging(string value);
    partial void OnNumeChanged();
    partial void OnTelefonChanging(string value);
    partial void OnTelefonChanged();
    #endregion
		
		public Shipper()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_shipper", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID_shipper
		{
			get
			{
				return this._ID_shipper;
			}
			set
			{
				if ((this._ID_shipper != value))
				{
					this.OnID_shipperChanging(value);
					this.SendPropertyChanging();
					this._ID_shipper = value;
					this.SendPropertyChanged("ID_shipper");
					this.OnID_shipperChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nume", DbType="VarChar(50)")]
		public string Nume
		{
			get
			{
				return this._Nume;
			}
			set
			{
				if ((this._Nume != value))
				{
					this.OnNumeChanging(value);
					this.SendPropertyChanging();
					this._Nume = value;
					this.SendPropertyChanged("Nume");
					this.OnNumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefon", DbType="VarChar(10)")]
		public string Telefon
		{
			get
			{
				return this._Telefon;
			}
			set
			{
				if ((this._Telefon != value))
				{
					this.OnTelefonChanging(value);
					this.SendPropertyChanging();
					this._Telefon = value;
					this.SendPropertyChanged("Telefon");
					this.OnTelefonChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PTcos")]
	public partial class PTco : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _Nume;
		
		private System.Nullable<int> _Pret;
		
		private System.Nullable<int> _Cantitta;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnNumeChanging(string value);
    partial void OnNumeChanged();
    partial void OnPretChanging(System.Nullable<int> value);
    partial void OnPretChanged();
    partial void OnCantittaChanging(System.Nullable<int> value);
    partial void OnCantittaChanged();
    #endregion
		
		public PTco()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nume", DbType="NChar(50)")]
		public string Nume
		{
			get
			{
				return this._Nume;
			}
			set
			{
				if ((this._Nume != value))
				{
					this.OnNumeChanging(value);
					this.SendPropertyChanging();
					this._Nume = value;
					this.SendPropertyChanged("Nume");
					this.OnNumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pret", DbType="Int")]
		public System.Nullable<int> Pret
		{
			get
			{
				return this._Pret;
			}
			set
			{
				if ((this._Pret != value))
				{
					this.OnPretChanging(value);
					this.SendPropertyChanging();
					this._Pret = value;
					this.SendPropertyChanged("Pret");
					this.OnPretChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantitta", DbType="Int")]
		public System.Nullable<int> Cantitta
		{
			get
			{
				return this._Cantitta;
			}
			set
			{
				if ((this._Cantitta != value))
				{
					this.OnCantittaChanging(value);
					this.SendPropertyChanging();
					this._Cantitta = value;
					this.SendPropertyChanged("Cantitta");
					this.OnCantittaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Produse")]
	public partial class Produse : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_produs;
		
		private string _Nume;
		
		private int _Pret;
		
		private string _Descriere;
		
		private System.Nullable<int> _Cantitate;
		
		private System.Nullable<int> _Categorie_id;
		
		private EntityRef<Categorie> _Categorie;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_produsChanging(int value);
    partial void OnId_produsChanged();
    partial void OnNumeChanging(string value);
    partial void OnNumeChanged();
    partial void OnPretChanging(int value);
    partial void OnPretChanged();
    partial void OnDescriereChanging(string value);
    partial void OnDescriereChanged();
    partial void OnCantitateChanging(System.Nullable<int> value);
    partial void OnCantitateChanged();
    partial void OnCategorie_idChanging(System.Nullable<int> value);
    partial void OnCategorie_idChanged();
    #endregion
		
		public Produse()
		{
			this._Categorie = default(EntityRef<Categorie>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_produs", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_produs
		{
			get
			{
				return this._Id_produs;
			}
			set
			{
				if ((this._Id_produs != value))
				{
					this.OnId_produsChanging(value);
					this.SendPropertyChanging();
					this._Id_produs = value;
					this.SendPropertyChanged("Id_produs");
					this.OnId_produsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nume", DbType="NChar(50)")]
		public string Nume
		{
			get
			{
				return this._Nume;
			}
			set
			{
				if ((this._Nume != value))
				{
					this.OnNumeChanging(value);
					this.SendPropertyChanging();
					this._Nume = value;
					this.SendPropertyChanged("Nume");
					this.OnNumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pret", DbType="Int NOT NULL")]
		public int Pret
		{
			get
			{
				return this._Pret;
			}
			set
			{
				if ((this._Pret != value))
				{
					this.OnPretChanging(value);
					this.SendPropertyChanging();
					this._Pret = value;
					this.SendPropertyChanged("Pret");
					this.OnPretChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descriere", DbType="VarChar(50)")]
		public string Descriere
		{
			get
			{
				return this._Descriere;
			}
			set
			{
				if ((this._Descriere != value))
				{
					this.OnDescriereChanging(value);
					this.SendPropertyChanging();
					this._Descriere = value;
					this.SendPropertyChanged("Descriere");
					this.OnDescriereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantitate", DbType="Int")]
		public System.Nullable<int> Cantitate
		{
			get
			{
				return this._Cantitate;
			}
			set
			{
				if ((this._Cantitate != value))
				{
					this.OnCantitateChanging(value);
					this.SendPropertyChanging();
					this._Cantitate = value;
					this.SendPropertyChanged("Cantitate");
					this.OnCantitateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Categorie_id", DbType="Int")]
		public System.Nullable<int> Categorie_id
		{
			get
			{
				return this._Categorie_id;
			}
			set
			{
				if ((this._Categorie_id != value))
				{
					if (this._Categorie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategorie_idChanging(value);
					this.SendPropertyChanging();
					this._Categorie_id = value;
					this.SendPropertyChanged("Categorie_id");
					this.OnCategorie_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categorie_Produse", Storage="_Categorie", ThisKey="Categorie_id", OtherKey="ID_categorie", IsForeignKey=true)]
		public Categorie Categorie
		{
			get
			{
				return this._Categorie.Entity;
			}
			set
			{
				Categorie previousValue = this._Categorie.Entity;
				if (((previousValue != value) 
							|| (this._Categorie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Categorie.Entity = null;
						previousValue.Produses.Remove(this);
					}
					this._Categorie.Entity = value;
					if ((value != null))
					{
						value.Produses.Add(this);
						this._Categorie_id = value.ID_categorie;
					}
					else
					{
						this._Categorie_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Categorie");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Shippers")]
	public partial class Shipper1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_shipper;
		
		private string _Nume;
		
		private string _Telefon;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_shipperChanging(int value);
    partial void OnID_shipperChanged();
    partial void OnNumeChanging(string value);
    partial void OnNumeChanged();
    partial void OnTelefonChanging(string value);
    partial void OnTelefonChanged();
    #endregion
		
		public Shipper1()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_shipper", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID_shipper
		{
			get
			{
				return this._ID_shipper;
			}
			set
			{
				if ((this._ID_shipper != value))
				{
					this.OnID_shipperChanging(value);
					this.SendPropertyChanging();
					this._ID_shipper = value;
					this.SendPropertyChanged("ID_shipper");
					this.OnID_shipperChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nume", DbType="VarChar(50)")]
		public string Nume
		{
			get
			{
				return this._Nume;
			}
			set
			{
				if ((this._Nume != value))
				{
					this.OnNumeChanging(value);
					this.SendPropertyChanging();
					this._Nume = value;
					this.SendPropertyChanged("Nume");
					this.OnNumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefon", DbType="VarChar(10)")]
		public string Telefon
		{
			get
			{
				return this._Telefon;
			}
			set
			{
				if ((this._Telefon != value))
				{
					this.OnTelefonChanging(value);
					this.SendPropertyChanging();
					this._Telefon = value;
					this.SendPropertyChanged("Telefon");
					this.OnTelefonChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.comenzi2")]
	public partial class comenzi2
	{
		
		private int _id;
		
		private System.Nullable<int> _user_id;
		
		private System.Nullable<int> _shipper_id;
		
		private System.Nullable<int> _suma;
		
		public comenzi2()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int")]
		public System.Nullable<int> user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this._user_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_shipper_id", DbType="Int")]
		public System.Nullable<int> shipper_id
		{
			get
			{
				return this._shipper_id;
			}
			set
			{
				if ((this._shipper_id != value))
				{
					this._shipper_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_suma", DbType="Int")]
		public System.Nullable<int> suma
		{
			get
			{
				return this._suma;
			}
			set
			{
				if ((this._suma != value))
				{
					this._suma = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
