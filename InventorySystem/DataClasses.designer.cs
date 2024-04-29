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

namespace InventorySystem
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="InventoryManagement")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertstaff(staff instance);
    partial void Updatestaff(staff instance);
    partial void Deletestaff(staff instance);
    partial void Insertitemtype(itemtype instance);
    partial void Updateitemtype(itemtype instance);
    partial void Deleteitemtype(itemtype instance);
    partial void Insertinventory(inventory instance);
    partial void Updateinventory(inventory instance);
    partial void Deleteinventory(inventory instance);
    partial void InsertstaffRole(staffRole instance);
    partial void UpdatestaffRole(staffRole instance);
    partial void DeletestaffRole(staffRole instance);
    partial void Insertstock(stock instance);
    partial void Updatestock(stock instance);
    partial void Deletestock(stock instance);
    partial void InsertstaffStatus(staffStatus instance);
    partial void UpdatestaffStatus(staffStatus instance);
    partial void DeletestaffStatus(staffStatus instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::InventorySystem.Properties.Settings.Default.InventoryManagementConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<staff> staffs
		{
			get
			{
				return this.GetTable<staff>();
			}
		}
		
		public System.Data.Linq.Table<itemtype> itemtypes
		{
			get
			{
				return this.GetTable<itemtype>();
			}
		}
		
		public System.Data.Linq.Table<inventory> inventories
		{
			get
			{
				return this.GetTable<inventory>();
			}
		}
		
		public System.Data.Linq.Table<staffRole> staffRoles
		{
			get
			{
				return this.GetTable<staffRole>();
			}
		}
		
		public System.Data.Linq.Table<stock> stocks
		{
			get
			{
				return this.GetTable<stock>();
			}
		}
		
		public System.Data.Linq.Table<staffStatus> staffStatus
		{
			get
			{
				return this.GetTable<staffStatus>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.staff")]
	public partial class staff : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _staff_ID;
		
		private string _staff_Name;
		
		private string _staff_Username;
		
		private string _staff_Pass;
		
		private string _staffRole_ID;
		
		private string _staffStatus_ID;
		
		private EntitySet<inventory> _inventories;
		
		private EntityRef<staffRole> _staffRole;
		
		private EntityRef<staffStatus> _staffStatus;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onstaff_IDChanging(string value);
    partial void Onstaff_IDChanged();
    partial void Onstaff_NameChanging(string value);
    partial void Onstaff_NameChanged();
    partial void Onstaff_UsernameChanging(string value);
    partial void Onstaff_UsernameChanged();
    partial void Onstaff_PassChanging(string value);
    partial void Onstaff_PassChanged();
    partial void OnstaffRole_IDChanging(string value);
    partial void OnstaffRole_IDChanged();
    partial void OnstaffStatus_IDChanging(string value);
    partial void OnstaffStatus_IDChanged();
    #endregion
		
		public staff()
		{
			this._inventories = new EntitySet<inventory>(new Action<inventory>(this.attach_inventories), new Action<inventory>(this.detach_inventories));
			this._staffRole = default(EntityRef<staffRole>);
			this._staffStatus = default(EntityRef<staffStatus>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_staff_ID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string staff_ID
		{
			get
			{
				return this._staff_ID;
			}
			set
			{
				if ((this._staff_ID != value))
				{
					this.Onstaff_IDChanging(value);
					this.SendPropertyChanging();
					this._staff_ID = value;
					this.SendPropertyChanged("staff_ID");
					this.Onstaff_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_staff_Name", DbType="VarChar(50)")]
		public string staff_Name
		{
			get
			{
				return this._staff_Name;
			}
			set
			{
				if ((this._staff_Name != value))
				{
					this.Onstaff_NameChanging(value);
					this.SendPropertyChanging();
					this._staff_Name = value;
					this.SendPropertyChanged("staff_Name");
					this.Onstaff_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_staff_Username", DbType="VarChar(50)")]
		public string staff_Username
		{
			get
			{
				return this._staff_Username;
			}
			set
			{
				if ((this._staff_Username != value))
				{
					this.Onstaff_UsernameChanging(value);
					this.SendPropertyChanging();
					this._staff_Username = value;
					this.SendPropertyChanged("staff_Username");
					this.Onstaff_UsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_staff_Pass", DbType="VarChar(50)")]
		public string staff_Pass
		{
			get
			{
				return this._staff_Pass;
			}
			set
			{
				if ((this._staff_Pass != value))
				{
					this.Onstaff_PassChanging(value);
					this.SendPropertyChanging();
					this._staff_Pass = value;
					this.SendPropertyChanged("staff_Pass");
					this.Onstaff_PassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_staffRole_ID", DbType="Char(10)")]
		public string staffRole_ID
		{
			get
			{
				return this._staffRole_ID;
			}
			set
			{
				if ((this._staffRole_ID != value))
				{
					if (this._staffRole.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnstaffRole_IDChanging(value);
					this.SendPropertyChanging();
					this._staffRole_ID = value;
					this.SendPropertyChanged("staffRole_ID");
					this.OnstaffRole_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_staffStatus_ID", DbType="Char(10)")]
		public string staffStatus_ID
		{
			get
			{
				return this._staffStatus_ID;
			}
			set
			{
				if ((this._staffStatus_ID != value))
				{
					if (this._staffStatus.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnstaffStatus_IDChanging(value);
					this.SendPropertyChanging();
					this._staffStatus_ID = value;
					this.SendPropertyChanged("staffStatus_ID");
					this.OnstaffStatus_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="staff_inventory", Storage="_inventories", ThisKey="staff_ID", OtherKey="staff_ID")]
		public EntitySet<inventory> inventories
		{
			get
			{
				return this._inventories;
			}
			set
			{
				this._inventories.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="staffRole_staff", Storage="_staffRole", ThisKey="staffRole_ID", OtherKey="staffRole_ID", IsForeignKey=true)]
		public staffRole staffRole
		{
			get
			{
				return this._staffRole.Entity;
			}
			set
			{
				staffRole previousValue = this._staffRole.Entity;
				if (((previousValue != value) 
							|| (this._staffRole.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._staffRole.Entity = null;
						previousValue.staffs.Remove(this);
					}
					this._staffRole.Entity = value;
					if ((value != null))
					{
						value.staffs.Add(this);
						this._staffRole_ID = value.staffRole_ID;
					}
					else
					{
						this._staffRole_ID = default(string);
					}
					this.SendPropertyChanged("staffRole");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="staffStatus_staff", Storage="_staffStatus", ThisKey="staffStatus_ID", OtherKey="staffStatus_ID", IsForeignKey=true)]
		public staffStatus staffStatus
		{
			get
			{
				return this._staffStatus.Entity;
			}
			set
			{
				staffStatus previousValue = this._staffStatus.Entity;
				if (((previousValue != value) 
							|| (this._staffStatus.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._staffStatus.Entity = null;
						previousValue.staffs.Remove(this);
					}
					this._staffStatus.Entity = value;
					if ((value != null))
					{
						value.staffs.Add(this);
						this._staffStatus_ID = value.staffStatus_ID;
					}
					else
					{
						this._staffStatus_ID = default(string);
					}
					this.SendPropertyChanged("staffStatus");
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
		
		private void attach_inventories(inventory entity)
		{
			this.SendPropertyChanging();
			entity.staff = this;
		}
		
		private void detach_inventories(inventory entity)
		{
			this.SendPropertyChanging();
			entity.staff = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.itemtype")]
	public partial class itemtype : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _type_ID;
		
		private string _type_Desc;
		
		private EntitySet<inventory> _inventories;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ontype_IDChanging(string value);
    partial void Ontype_IDChanged();
    partial void Ontype_DescChanging(string value);
    partial void Ontype_DescChanged();
    #endregion
		
		public itemtype()
		{
			this._inventories = new EntitySet<inventory>(new Action<inventory>(this.attach_inventories), new Action<inventory>(this.detach_inventories));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type_ID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string type_ID
		{
			get
			{
				return this._type_ID;
			}
			set
			{
				if ((this._type_ID != value))
				{
					this.Ontype_IDChanging(value);
					this.SendPropertyChanging();
					this._type_ID = value;
					this.SendPropertyChanged("type_ID");
					this.Ontype_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type_Desc", DbType="VarChar(50)")]
		public string type_Desc
		{
			get
			{
				return this._type_Desc;
			}
			set
			{
				if ((this._type_Desc != value))
				{
					this.Ontype_DescChanging(value);
					this.SendPropertyChanging();
					this._type_Desc = value;
					this.SendPropertyChanged("type_Desc");
					this.Ontype_DescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="itemtype_inventory", Storage="_inventories", ThisKey="type_ID", OtherKey="type_ID")]
		public EntitySet<inventory> inventories
		{
			get
			{
				return this._inventories;
			}
			set
			{
				this._inventories.Assign(value);
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
		
		private void attach_inventories(inventory entity)
		{
			this.SendPropertyChanging();
			entity.itemtype = this;
		}
		
		private void detach_inventories(inventory entity)
		{
			this.SendPropertyChanging();
			entity.itemtype = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.inventory")]
	public partial class inventory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _inventory_ID;
		
		private string _inventory_Name;
		
		private string _stock_ID;
		
		private int _inventory_Quantity;
		
		private string _type_ID;
		
		private System.Nullable<int> _inventory_Price;
		
		private string _staff_ID;
		
		private string _inventory_Remark;
		
		private System.Nullable<System.DateTime> _inventory_Date;
		
		private EntityRef<itemtype> _itemtype;
		
		private EntityRef<staff> _staff;
		
		private EntityRef<stock> _stock;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oninventory_IDChanging(string value);
    partial void Oninventory_IDChanged();
    partial void Oninventory_NameChanging(string value);
    partial void Oninventory_NameChanged();
    partial void Onstock_IDChanging(string value);
    partial void Onstock_IDChanged();
    partial void Oninventory_QuantityChanging(int value);
    partial void Oninventory_QuantityChanged();
    partial void Ontype_IDChanging(string value);
    partial void Ontype_IDChanged();
    partial void Oninventory_PriceChanging(System.Nullable<int> value);
    partial void Oninventory_PriceChanged();
    partial void Onstaff_IDChanging(string value);
    partial void Onstaff_IDChanged();
    partial void Oninventory_RemarkChanging(string value);
    partial void Oninventory_RemarkChanged();
    partial void Oninventory_DateChanging(System.Nullable<System.DateTime> value);
    partial void Oninventory_DateChanged();
    #endregion
		
		public inventory()
		{
			this._itemtype = default(EntityRef<itemtype>);
			this._staff = default(EntityRef<staff>);
			this._stock = default(EntityRef<stock>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inventory_ID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string inventory_ID
		{
			get
			{
				return this._inventory_ID;
			}
			set
			{
				if ((this._inventory_ID != value))
				{
					this.Oninventory_IDChanging(value);
					this.SendPropertyChanging();
					this._inventory_ID = value;
					this.SendPropertyChanged("inventory_ID");
					this.Oninventory_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inventory_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string inventory_Name
		{
			get
			{
				return this._inventory_Name;
			}
			set
			{
				if ((this._inventory_Name != value))
				{
					this.Oninventory_NameChanging(value);
					this.SendPropertyChanging();
					this._inventory_Name = value;
					this.SendPropertyChanged("inventory_Name");
					this.Oninventory_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stock_ID", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string stock_ID
		{
			get
			{
				return this._stock_ID;
			}
			set
			{
				if ((this._stock_ID != value))
				{
					if (this._stock.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onstock_IDChanging(value);
					this.SendPropertyChanging();
					this._stock_ID = value;
					this.SendPropertyChanged("stock_ID");
					this.Onstock_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inventory_Quantity", DbType="Int NOT NULL")]
		public int inventory_Quantity
		{
			get
			{
				return this._inventory_Quantity;
			}
			set
			{
				if ((this._inventory_Quantity != value))
				{
					this.Oninventory_QuantityChanging(value);
					this.SendPropertyChanging();
					this._inventory_Quantity = value;
					this.SendPropertyChanged("inventory_Quantity");
					this.Oninventory_QuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type_ID", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string type_ID
		{
			get
			{
				return this._type_ID;
			}
			set
			{
				if ((this._type_ID != value))
				{
					if (this._itemtype.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ontype_IDChanging(value);
					this.SendPropertyChanging();
					this._type_ID = value;
					this.SendPropertyChanged("type_ID");
					this.Ontype_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inventory_Price", DbType="Int")]
		public System.Nullable<int> inventory_Price
		{
			get
			{
				return this._inventory_Price;
			}
			set
			{
				if ((this._inventory_Price != value))
				{
					this.Oninventory_PriceChanging(value);
					this.SendPropertyChanging();
					this._inventory_Price = value;
					this.SendPropertyChanged("inventory_Price");
					this.Oninventory_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_staff_ID", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string staff_ID
		{
			get
			{
				return this._staff_ID;
			}
			set
			{
				if ((this._staff_ID != value))
				{
					if (this._staff.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onstaff_IDChanging(value);
					this.SendPropertyChanging();
					this._staff_ID = value;
					this.SendPropertyChanged("staff_ID");
					this.Onstaff_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inventory_Remark", DbType="VarChar(50)")]
		public string inventory_Remark
		{
			get
			{
				return this._inventory_Remark;
			}
			set
			{
				if ((this._inventory_Remark != value))
				{
					this.Oninventory_RemarkChanging(value);
					this.SendPropertyChanging();
					this._inventory_Remark = value;
					this.SendPropertyChanged("inventory_Remark");
					this.Oninventory_RemarkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inventory_Date", DbType="Date")]
		public System.Nullable<System.DateTime> inventory_Date
		{
			get
			{
				return this._inventory_Date;
			}
			set
			{
				if ((this._inventory_Date != value))
				{
					this.Oninventory_DateChanging(value);
					this.SendPropertyChanging();
					this._inventory_Date = value;
					this.SendPropertyChanged("inventory_Date");
					this.Oninventory_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="itemtype_inventory", Storage="_itemtype", ThisKey="type_ID", OtherKey="type_ID", IsForeignKey=true)]
		public itemtype itemtype
		{
			get
			{
				return this._itemtype.Entity;
			}
			set
			{
				itemtype previousValue = this._itemtype.Entity;
				if (((previousValue != value) 
							|| (this._itemtype.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._itemtype.Entity = null;
						previousValue.inventories.Remove(this);
					}
					this._itemtype.Entity = value;
					if ((value != null))
					{
						value.inventories.Add(this);
						this._type_ID = value.type_ID;
					}
					else
					{
						this._type_ID = default(string);
					}
					this.SendPropertyChanged("itemtype");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="staff_inventory", Storage="_staff", ThisKey="staff_ID", OtherKey="staff_ID", IsForeignKey=true)]
		public staff staff
		{
			get
			{
				return this._staff.Entity;
			}
			set
			{
				staff previousValue = this._staff.Entity;
				if (((previousValue != value) 
							|| (this._staff.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._staff.Entity = null;
						previousValue.inventories.Remove(this);
					}
					this._staff.Entity = value;
					if ((value != null))
					{
						value.inventories.Add(this);
						this._staff_ID = value.staff_ID;
					}
					else
					{
						this._staff_ID = default(string);
					}
					this.SendPropertyChanged("staff");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="stock_inventory", Storage="_stock", ThisKey="stock_ID", OtherKey="stock_ID", IsForeignKey=true)]
		public stock stock
		{
			get
			{
				return this._stock.Entity;
			}
			set
			{
				stock previousValue = this._stock.Entity;
				if (((previousValue != value) 
							|| (this._stock.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._stock.Entity = null;
						previousValue.inventories.Remove(this);
					}
					this._stock.Entity = value;
					if ((value != null))
					{
						value.inventories.Add(this);
						this._stock_ID = value.stock_ID;
					}
					else
					{
						this._stock_ID = default(string);
					}
					this.SendPropertyChanged("stock");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.staffRole")]
	public partial class staffRole : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _staffRole_ID;
		
		private string _staffRole_Desc;
		
		private EntitySet<staff> _staffs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnstaffRole_IDChanging(string value);
    partial void OnstaffRole_IDChanged();
    partial void OnstaffRole_DescChanging(string value);
    partial void OnstaffRole_DescChanged();
    #endregion
		
		public staffRole()
		{
			this._staffs = new EntitySet<staff>(new Action<staff>(this.attach_staffs), new Action<staff>(this.detach_staffs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_staffRole_ID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string staffRole_ID
		{
			get
			{
				return this._staffRole_ID;
			}
			set
			{
				if ((this._staffRole_ID != value))
				{
					this.OnstaffRole_IDChanging(value);
					this.SendPropertyChanging();
					this._staffRole_ID = value;
					this.SendPropertyChanged("staffRole_ID");
					this.OnstaffRole_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_staffRole_Desc", DbType="VarChar(50)")]
		public string staffRole_Desc
		{
			get
			{
				return this._staffRole_Desc;
			}
			set
			{
				if ((this._staffRole_Desc != value))
				{
					this.OnstaffRole_DescChanging(value);
					this.SendPropertyChanging();
					this._staffRole_Desc = value;
					this.SendPropertyChanged("staffRole_Desc");
					this.OnstaffRole_DescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="staffRole_staff", Storage="_staffs", ThisKey="staffRole_ID", OtherKey="staffRole_ID")]
		public EntitySet<staff> staffs
		{
			get
			{
				return this._staffs;
			}
			set
			{
				this._staffs.Assign(value);
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
		
		private void attach_staffs(staff entity)
		{
			this.SendPropertyChanging();
			entity.staffRole = this;
		}
		
		private void detach_staffs(staff entity)
		{
			this.SendPropertyChanging();
			entity.staffRole = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.stock")]
	public partial class stock : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _stock_ID;
		
		private string _stock_Desc;
		
		private EntitySet<inventory> _inventories;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onstock_IDChanging(string value);
    partial void Onstock_IDChanged();
    partial void Onstock_DescChanging(string value);
    partial void Onstock_DescChanged();
    #endregion
		
		public stock()
		{
			this._inventories = new EntitySet<inventory>(new Action<inventory>(this.attach_inventories), new Action<inventory>(this.detach_inventories));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stock_ID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string stock_ID
		{
			get
			{
				return this._stock_ID;
			}
			set
			{
				if ((this._stock_ID != value))
				{
					this.Onstock_IDChanging(value);
					this.SendPropertyChanging();
					this._stock_ID = value;
					this.SendPropertyChanged("stock_ID");
					this.Onstock_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stock_Desc", DbType="VarChar(50)")]
		public string stock_Desc
		{
			get
			{
				return this._stock_Desc;
			}
			set
			{
				if ((this._stock_Desc != value))
				{
					this.Onstock_DescChanging(value);
					this.SendPropertyChanging();
					this._stock_Desc = value;
					this.SendPropertyChanged("stock_Desc");
					this.Onstock_DescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="stock_inventory", Storage="_inventories", ThisKey="stock_ID", OtherKey="stock_ID")]
		public EntitySet<inventory> inventories
		{
			get
			{
				return this._inventories;
			}
			set
			{
				this._inventories.Assign(value);
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
		
		private void attach_inventories(inventory entity)
		{
			this.SendPropertyChanging();
			entity.stock = this;
		}
		
		private void detach_inventories(inventory entity)
		{
			this.SendPropertyChanging();
			entity.stock = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.staffStatus")]
	public partial class staffStatus : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _staffStatus_ID;
		
		private string _staffStatus_Desc;
		
		private EntitySet<staff> _staffs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnstaffStatus_IDChanging(string value);
    partial void OnstaffStatus_IDChanged();
    partial void OnstaffStatus_DescChanging(string value);
    partial void OnstaffStatus_DescChanged();
    #endregion
		
		public staffStatus()
		{
			this._staffs = new EntitySet<staff>(new Action<staff>(this.attach_staffs), new Action<staff>(this.detach_staffs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_staffStatus_ID", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string staffStatus_ID
		{
			get
			{
				return this._staffStatus_ID;
			}
			set
			{
				if ((this._staffStatus_ID != value))
				{
					this.OnstaffStatus_IDChanging(value);
					this.SendPropertyChanging();
					this._staffStatus_ID = value;
					this.SendPropertyChanged("staffStatus_ID");
					this.OnstaffStatus_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_staffStatus_Desc", DbType="VarChar(50)")]
		public string staffStatus_Desc
		{
			get
			{
				return this._staffStatus_Desc;
			}
			set
			{
				if ((this._staffStatus_Desc != value))
				{
					this.OnstaffStatus_DescChanging(value);
					this.SendPropertyChanging();
					this._staffStatus_Desc = value;
					this.SendPropertyChanged("staffStatus_Desc");
					this.OnstaffStatus_DescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="staffStatus_staff", Storage="_staffs", ThisKey="staffStatus_ID", OtherKey="staffStatus_ID")]
		public EntitySet<staff> staffs
		{
			get
			{
				return this._staffs;
			}
			set
			{
				this._staffs.Assign(value);
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
		
		private void attach_staffs(staff entity)
		{
			this.SendPropertyChanging();
			entity.staffStatus = this;
		}
		
		private void detach_staffs(staff entity)
		{
			this.SendPropertyChanging();
			entity.staffStatus = null;
		}
	}
}
#pragma warning restore 1591
