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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Midterm")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertInStock(InStock instance);
    partial void UpdateInStock(InStock instance);
    partial void DeleteInStock(InStock instance);
    partial void InsertInventory(Inventory instance);
    partial void UpdateInventory(Inventory instance);
    partial void DeleteInventory(Inventory instance);
    partial void InsertItemType(ItemType instance);
    partial void UpdateItemType(ItemType instance);
    partial void DeleteItemType(ItemType instance);
    partial void InsertStaffRole(StaffRole instance);
    partial void UpdateStaffRole(StaffRole instance);
    partial void DeleteStaffRole(StaffRole instance);
    partial void InsertStaff(Staff instance);
    partial void UpdateStaff(Staff instance);
    partial void DeleteStaff(Staff instance);
    partial void InsertStaffStatus(StaffStatus instance);
    partial void UpdateStaffStatus(StaffStatus instance);
    partial void DeleteStaffStatus(StaffStatus instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::InventorySystem.Properties.Settings.Default.MidtermConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<InStock> InStocks
		{
			get
			{
				return this.GetTable<InStock>();
			}
		}
		
		public System.Data.Linq.Table<Inventory> Inventories
		{
			get
			{
				return this.GetTable<Inventory>();
			}
		}
		
		public System.Data.Linq.Table<ItemType> ItemTypes
		{
			get
			{
				return this.GetTable<ItemType>();
			}
		}
		
		public System.Data.Linq.Table<StaffRole> StaffRoles
		{
			get
			{
				return this.GetTable<StaffRole>();
			}
		}
		
		public System.Data.Linq.Table<Staff> Staffs
		{
			get
			{
				return this.GetTable<Staff>();
			}
		}
		
		public System.Data.Linq.Table<StaffStatus> StaffStatus
		{
			get
			{
				return this.GetTable<StaffStatus>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.InStock")]
	public partial class InStock : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _InStock_ID;
		
		private string _InStock_Desc;
		
		private EntitySet<Inventory> _Inventories;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnInStock_IDChanging(string value);
    partial void OnInStock_IDChanged();
    partial void OnInStock_DescChanging(string value);
    partial void OnInStock_DescChanged();
    #endregion
		
		public InStock()
		{
			this._Inventories = new EntitySet<Inventory>(new Action<Inventory>(this.attach_Inventories), new Action<Inventory>(this.detach_Inventories));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InStock_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string InStock_ID
		{
			get
			{
				return this._InStock_ID;
			}
			set
			{
				if ((this._InStock_ID != value))
				{
					this.OnInStock_IDChanging(value);
					this.SendPropertyChanging();
					this._InStock_ID = value;
					this.SendPropertyChanged("InStock_ID");
					this.OnInStock_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InStock_Desc", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string InStock_Desc
		{
			get
			{
				return this._InStock_Desc;
			}
			set
			{
				if ((this._InStock_Desc != value))
				{
					this.OnInStock_DescChanging(value);
					this.SendPropertyChanging();
					this._InStock_Desc = value;
					this.SendPropertyChanged("InStock_Desc");
					this.OnInStock_DescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="InStock_Inventory", Storage="_Inventories", ThisKey="InStock_ID", OtherKey="InStock_ID")]
		public EntitySet<Inventory> Inventories
		{
			get
			{
				return this._Inventories;
			}
			set
			{
				this._Inventories.Assign(value);
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
		
		private void attach_Inventories(Inventory entity)
		{
			this.SendPropertyChanging();
			entity.InStock = this;
		}
		
		private void detach_Inventories(Inventory entity)
		{
			this.SendPropertyChanging();
			entity.InStock = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Inventory")]
	public partial class Inventory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Inventory_ID;
		
		private string _Item_Name;
		
		private string _InStock_ID;
		
		private System.Nullable<int> _AmountOfStock;
		
		private string _ItemType_ID;
		
		private System.Nullable<int> _ItemCost;
		
		private string _Staff_ID;
		
		private string _Inventory_Remarks;
		
		private System.DateTime _Date_Checked;
		
		private EntityRef<InStock> _InStock;
		
		private EntityRef<ItemType> _ItemType;
		
		private EntityRef<Staff> _Staff;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnInventory_IDChanging(string value);
    partial void OnInventory_IDChanged();
    partial void OnItem_NameChanging(string value);
    partial void OnItem_NameChanged();
    partial void OnInStock_IDChanging(string value);
    partial void OnInStock_IDChanged();
    partial void OnAmountOfStockChanging(System.Nullable<int> value);
    partial void OnAmountOfStockChanged();
    partial void OnItemType_IDChanging(string value);
    partial void OnItemType_IDChanged();
    partial void OnItemCostChanging(System.Nullable<int> value);
    partial void OnItemCostChanged();
    partial void OnStaff_IDChanging(string value);
    partial void OnStaff_IDChanged();
    partial void OnInventory_RemarksChanging(string value);
    partial void OnInventory_RemarksChanged();
    partial void OnDate_CheckedChanging(System.DateTime value);
    partial void OnDate_CheckedChanged();
    #endregion
		
		public Inventory()
		{
			this._InStock = default(EntityRef<InStock>);
			this._ItemType = default(EntityRef<ItemType>);
			this._Staff = default(EntityRef<Staff>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Inventory_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Inventory_ID
		{
			get
			{
				return this._Inventory_ID;
			}
			set
			{
				if ((this._Inventory_ID != value))
				{
					this.OnInventory_IDChanging(value);
					this.SendPropertyChanging();
					this._Inventory_ID = value;
					this.SendPropertyChanged("Inventory_ID");
					this.OnInventory_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Item_Name
		{
			get
			{
				return this._Item_Name;
			}
			set
			{
				if ((this._Item_Name != value))
				{
					this.OnItem_NameChanging(value);
					this.SendPropertyChanging();
					this._Item_Name = value;
					this.SendPropertyChanged("Item_Name");
					this.OnItem_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InStock_ID", DbType="VarChar(50)")]
		public string InStock_ID
		{
			get
			{
				return this._InStock_ID;
			}
			set
			{
				if ((this._InStock_ID != value))
				{
					if (this._InStock.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnInStock_IDChanging(value);
					this.SendPropertyChanging();
					this._InStock_ID = value;
					this.SendPropertyChanged("InStock_ID");
					this.OnInStock_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AmountOfStock", DbType="Int")]
		public System.Nullable<int> AmountOfStock
		{
			get
			{
				return this._AmountOfStock;
			}
			set
			{
				if ((this._AmountOfStock != value))
				{
					this.OnAmountOfStockChanging(value);
					this.SendPropertyChanging();
					this._AmountOfStock = value;
					this.SendPropertyChanged("AmountOfStock");
					this.OnAmountOfStockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemType_ID", DbType="VarChar(50)")]
		public string ItemType_ID
		{
			get
			{
				return this._ItemType_ID;
			}
			set
			{
				if ((this._ItemType_ID != value))
				{
					if (this._ItemType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnItemType_IDChanging(value);
					this.SendPropertyChanging();
					this._ItemType_ID = value;
					this.SendPropertyChanged("ItemType_ID");
					this.OnItemType_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemCost", DbType="Int")]
		public System.Nullable<int> ItemCost
		{
			get
			{
				return this._ItemCost;
			}
			set
			{
				if ((this._ItemCost != value))
				{
					this.OnItemCostChanging(value);
					this.SendPropertyChanging();
					this._ItemCost = value;
					this.SendPropertyChanged("ItemCost");
					this.OnItemCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Staff_ID", DbType="VarChar(50)")]
		public string Staff_ID
		{
			get
			{
				return this._Staff_ID;
			}
			set
			{
				if ((this._Staff_ID != value))
				{
					if (this._Staff.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStaff_IDChanging(value);
					this.SendPropertyChanging();
					this._Staff_ID = value;
					this.SendPropertyChanged("Staff_ID");
					this.OnStaff_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Inventory_Remarks", DbType="VarChar(50)")]
		public string Inventory_Remarks
		{
			get
			{
				return this._Inventory_Remarks;
			}
			set
			{
				if ((this._Inventory_Remarks != value))
				{
					this.OnInventory_RemarksChanging(value);
					this.SendPropertyChanging();
					this._Inventory_Remarks = value;
					this.SendPropertyChanged("Inventory_Remarks");
					this.OnInventory_RemarksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date_Checked", DbType="Date NOT NULL")]
		public System.DateTime Date_Checked
		{
			get
			{
				return this._Date_Checked;
			}
			set
			{
				if ((this._Date_Checked != value))
				{
					this.OnDate_CheckedChanging(value);
					this.SendPropertyChanging();
					this._Date_Checked = value;
					this.SendPropertyChanged("Date_Checked");
					this.OnDate_CheckedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="InStock_Inventory", Storage="_InStock", ThisKey="InStock_ID", OtherKey="InStock_ID", IsForeignKey=true)]
		public InStock InStock
		{
			get
			{
				return this._InStock.Entity;
			}
			set
			{
				InStock previousValue = this._InStock.Entity;
				if (((previousValue != value) 
							|| (this._InStock.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._InStock.Entity = null;
						previousValue.Inventories.Remove(this);
					}
					this._InStock.Entity = value;
					if ((value != null))
					{
						value.Inventories.Add(this);
						this._InStock_ID = value.InStock_ID;
					}
					else
					{
						this._InStock_ID = default(string);
					}
					this.SendPropertyChanged("InStock");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ItemType_Inventory", Storage="_ItemType", ThisKey="ItemType_ID", OtherKey="ItemType_ID", IsForeignKey=true)]
		public ItemType ItemType
		{
			get
			{
				return this._ItemType.Entity;
			}
			set
			{
				ItemType previousValue = this._ItemType.Entity;
				if (((previousValue != value) 
							|| (this._ItemType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ItemType.Entity = null;
						previousValue.Inventories.Remove(this);
					}
					this._ItemType.Entity = value;
					if ((value != null))
					{
						value.Inventories.Add(this);
						this._ItemType_ID = value.ItemType_ID;
					}
					else
					{
						this._ItemType_ID = default(string);
					}
					this.SendPropertyChanged("ItemType");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Staff_Inventory", Storage="_Staff", ThisKey="Staff_ID", OtherKey="Staff_ID", IsForeignKey=true)]
		public Staff Staff
		{
			get
			{
				return this._Staff.Entity;
			}
			set
			{
				Staff previousValue = this._Staff.Entity;
				if (((previousValue != value) 
							|| (this._Staff.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Staff.Entity = null;
						previousValue.Inventories.Remove(this);
					}
					this._Staff.Entity = value;
					if ((value != null))
					{
						value.Inventories.Add(this);
						this._Staff_ID = value.Staff_ID;
					}
					else
					{
						this._Staff_ID = default(string);
					}
					this.SendPropertyChanged("Staff");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ItemType")]
	public partial class ItemType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ItemType_ID;
		
		private string _ItemType_Desc;
		
		private EntitySet<Inventory> _Inventories;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemType_IDChanging(string value);
    partial void OnItemType_IDChanged();
    partial void OnItemType_DescChanging(string value);
    partial void OnItemType_DescChanged();
    #endregion
		
		public ItemType()
		{
			this._Inventories = new EntitySet<Inventory>(new Action<Inventory>(this.attach_Inventories), new Action<Inventory>(this.detach_Inventories));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemType_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ItemType_ID
		{
			get
			{
				return this._ItemType_ID;
			}
			set
			{
				if ((this._ItemType_ID != value))
				{
					this.OnItemType_IDChanging(value);
					this.SendPropertyChanging();
					this._ItemType_ID = value;
					this.SendPropertyChanged("ItemType_ID");
					this.OnItemType_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemType_Desc", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ItemType_Desc
		{
			get
			{
				return this._ItemType_Desc;
			}
			set
			{
				if ((this._ItemType_Desc != value))
				{
					this.OnItemType_DescChanging(value);
					this.SendPropertyChanging();
					this._ItemType_Desc = value;
					this.SendPropertyChanged("ItemType_Desc");
					this.OnItemType_DescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ItemType_Inventory", Storage="_Inventories", ThisKey="ItemType_ID", OtherKey="ItemType_ID")]
		public EntitySet<Inventory> Inventories
		{
			get
			{
				return this._Inventories;
			}
			set
			{
				this._Inventories.Assign(value);
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
		
		private void attach_Inventories(Inventory entity)
		{
			this.SendPropertyChanging();
			entity.ItemType = this;
		}
		
		private void detach_Inventories(Inventory entity)
		{
			this.SendPropertyChanging();
			entity.ItemType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StaffRole")]
	public partial class StaffRole : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _StaffRole_ID;
		
		private string _StaffRole_Desc;
		
		private EntitySet<Staff> _Staffs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStaffRole_IDChanging(string value);
    partial void OnStaffRole_IDChanged();
    partial void OnStaffRole_DescChanging(string value);
    partial void OnStaffRole_DescChanged();
    #endregion
		
		public StaffRole()
		{
			this._Staffs = new EntitySet<Staff>(new Action<Staff>(this.attach_Staffs), new Action<Staff>(this.detach_Staffs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StaffRole_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string StaffRole_ID
		{
			get
			{
				return this._StaffRole_ID;
			}
			set
			{
				if ((this._StaffRole_ID != value))
				{
					this.OnStaffRole_IDChanging(value);
					this.SendPropertyChanging();
					this._StaffRole_ID = value;
					this.SendPropertyChanged("StaffRole_ID");
					this.OnStaffRole_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StaffRole_Desc", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string StaffRole_Desc
		{
			get
			{
				return this._StaffRole_Desc;
			}
			set
			{
				if ((this._StaffRole_Desc != value))
				{
					this.OnStaffRole_DescChanging(value);
					this.SendPropertyChanging();
					this._StaffRole_Desc = value;
					this.SendPropertyChanged("StaffRole_Desc");
					this.OnStaffRole_DescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="StaffRole_Staff", Storage="_Staffs", ThisKey="StaffRole_ID", OtherKey="StaffRole_ID")]
		public EntitySet<Staff> Staffs
		{
			get
			{
				return this._Staffs;
			}
			set
			{
				this._Staffs.Assign(value);
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
		
		private void attach_Staffs(Staff entity)
		{
			this.SendPropertyChanging();
			entity.StaffRole = this;
		}
		
		private void detach_Staffs(Staff entity)
		{
			this.SendPropertyChanging();
			entity.StaffRole = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Staff")]
	public partial class Staff : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Staff_ID;
		
		private string _Staff_Name;
		
		private string _Staff_Username;
		
		private string _Staff_Password;
		
		private string _StaffRole_ID;
		
		private string _StaffStatus_ID;
		
		private EntitySet<Inventory> _Inventories;
		
		private EntityRef<StaffRole> _StaffRole;
		
		private EntityRef<StaffStatus> _StaffStatus;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStaff_IDChanging(string value);
    partial void OnStaff_IDChanged();
    partial void OnStaff_NameChanging(string value);
    partial void OnStaff_NameChanged();
    partial void OnStaff_UsernameChanging(string value);
    partial void OnStaff_UsernameChanged();
    partial void OnStaff_PasswordChanging(string value);
    partial void OnStaff_PasswordChanged();
    partial void OnStaffRole_IDChanging(string value);
    partial void OnStaffRole_IDChanged();
    partial void OnStaffStatus_IDChanging(string value);
    partial void OnStaffStatus_IDChanged();
    #endregion
		
		public Staff()
		{
			this._Inventories = new EntitySet<Inventory>(new Action<Inventory>(this.attach_Inventories), new Action<Inventory>(this.detach_Inventories));
			this._StaffRole = default(EntityRef<StaffRole>);
			this._StaffStatus = default(EntityRef<StaffStatus>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Staff_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Staff_ID
		{
			get
			{
				return this._Staff_ID;
			}
			set
			{
				if ((this._Staff_ID != value))
				{
					this.OnStaff_IDChanging(value);
					this.SendPropertyChanging();
					this._Staff_ID = value;
					this.SendPropertyChanged("Staff_ID");
					this.OnStaff_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Staff_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Staff_Name
		{
			get
			{
				return this._Staff_Name;
			}
			set
			{
				if ((this._Staff_Name != value))
				{
					this.OnStaff_NameChanging(value);
					this.SendPropertyChanging();
					this._Staff_Name = value;
					this.SendPropertyChanged("Staff_Name");
					this.OnStaff_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Staff_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Staff_Username
		{
			get
			{
				return this._Staff_Username;
			}
			set
			{
				if ((this._Staff_Username != value))
				{
					this.OnStaff_UsernameChanging(value);
					this.SendPropertyChanging();
					this._Staff_Username = value;
					this.SendPropertyChanged("Staff_Username");
					this.OnStaff_UsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Staff_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Staff_Password
		{
			get
			{
				return this._Staff_Password;
			}
			set
			{
				if ((this._Staff_Password != value))
				{
					this.OnStaff_PasswordChanging(value);
					this.SendPropertyChanging();
					this._Staff_Password = value;
					this.SendPropertyChanged("Staff_Password");
					this.OnStaff_PasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StaffRole_ID", DbType="VarChar(50)")]
		public string StaffRole_ID
		{
			get
			{
				return this._StaffRole_ID;
			}
			set
			{
				if ((this._StaffRole_ID != value))
				{
					if (this._StaffRole.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStaffRole_IDChanging(value);
					this.SendPropertyChanging();
					this._StaffRole_ID = value;
					this.SendPropertyChanged("StaffRole_ID");
					this.OnStaffRole_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StaffStatus_ID", DbType="VarChar(50)")]
		public string StaffStatus_ID
		{
			get
			{
				return this._StaffStatus_ID;
			}
			set
			{
				if ((this._StaffStatus_ID != value))
				{
					if (this._StaffStatus.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStaffStatus_IDChanging(value);
					this.SendPropertyChanging();
					this._StaffStatus_ID = value;
					this.SendPropertyChanged("StaffStatus_ID");
					this.OnStaffStatus_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Staff_Inventory", Storage="_Inventories", ThisKey="Staff_ID", OtherKey="Staff_ID")]
		public EntitySet<Inventory> Inventories
		{
			get
			{
				return this._Inventories;
			}
			set
			{
				this._Inventories.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="StaffRole_Staff", Storage="_StaffRole", ThisKey="StaffRole_ID", OtherKey="StaffRole_ID", IsForeignKey=true)]
		public StaffRole StaffRole
		{
			get
			{
				return this._StaffRole.Entity;
			}
			set
			{
				StaffRole previousValue = this._StaffRole.Entity;
				if (((previousValue != value) 
							|| (this._StaffRole.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._StaffRole.Entity = null;
						previousValue.Staffs.Remove(this);
					}
					this._StaffRole.Entity = value;
					if ((value != null))
					{
						value.Staffs.Add(this);
						this._StaffRole_ID = value.StaffRole_ID;
					}
					else
					{
						this._StaffRole_ID = default(string);
					}
					this.SendPropertyChanged("StaffRole");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="StaffStatus_Staff", Storage="_StaffStatus", ThisKey="StaffStatus_ID", OtherKey="StaffStatus_ID", IsForeignKey=true)]
		public StaffStatus StaffStatus
		{
			get
			{
				return this._StaffStatus.Entity;
			}
			set
			{
				StaffStatus previousValue = this._StaffStatus.Entity;
				if (((previousValue != value) 
							|| (this._StaffStatus.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._StaffStatus.Entity = null;
						previousValue.Staffs.Remove(this);
					}
					this._StaffStatus.Entity = value;
					if ((value != null))
					{
						value.Staffs.Add(this);
						this._StaffStatus_ID = value.StaffStatus_ID;
					}
					else
					{
						this._StaffStatus_ID = default(string);
					}
					this.SendPropertyChanged("StaffStatus");
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
		
		private void attach_Inventories(Inventory entity)
		{
			this.SendPropertyChanging();
			entity.Staff = this;
		}
		
		private void detach_Inventories(Inventory entity)
		{
			this.SendPropertyChanging();
			entity.Staff = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StaffStatus")]
	public partial class StaffStatus : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _StaffStatus_ID;
		
		private string _StaffStatus_Desc;
		
		private EntitySet<Staff> _Staffs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStaffStatus_IDChanging(string value);
    partial void OnStaffStatus_IDChanged();
    partial void OnStaffStatus_DescChanging(string value);
    partial void OnStaffStatus_DescChanged();
    #endregion
		
		public StaffStatus()
		{
			this._Staffs = new EntitySet<Staff>(new Action<Staff>(this.attach_Staffs), new Action<Staff>(this.detach_Staffs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StaffStatus_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string StaffStatus_ID
		{
			get
			{
				return this._StaffStatus_ID;
			}
			set
			{
				if ((this._StaffStatus_ID != value))
				{
					this.OnStaffStatus_IDChanging(value);
					this.SendPropertyChanging();
					this._StaffStatus_ID = value;
					this.SendPropertyChanged("StaffStatus_ID");
					this.OnStaffStatus_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StaffStatus_Desc", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string StaffStatus_Desc
		{
			get
			{
				return this._StaffStatus_Desc;
			}
			set
			{
				if ((this._StaffStatus_Desc != value))
				{
					this.OnStaffStatus_DescChanging(value);
					this.SendPropertyChanging();
					this._StaffStatus_Desc = value;
					this.SendPropertyChanged("StaffStatus_Desc");
					this.OnStaffStatus_DescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="StaffStatus_Staff", Storage="_Staffs", ThisKey="StaffStatus_ID", OtherKey="StaffStatus_ID")]
		public EntitySet<Staff> Staffs
		{
			get
			{
				return this._Staffs;
			}
			set
			{
				this._Staffs.Assign(value);
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
		
		private void attach_Staffs(Staff entity)
		{
			this.SendPropertyChanging();
			entity.StaffStatus = this;
		}
		
		private void detach_Staffs(Staff entity)
		{
			this.SendPropertyChanging();
			entity.StaffStatus = null;
		}
	}
}
#pragma warning restore 1591
