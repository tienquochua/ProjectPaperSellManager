#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectPaperSellManager
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PaperSellMng")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChiTietNhap(ChiTietNhap instance);
    partial void UpdateChiTietNhap(ChiTietNhap instance);
    partial void DeleteChiTietNhap(ChiTietNhap instance);
    partial void InsertChiTietXuat(ChiTietXuat instance);
    partial void UpdateChiTietXuat(ChiTietXuat instance);
    partial void DeleteChiTietXuat(ChiTietXuat instance);
    partial void InsertMatHang(MatHang instance);
    partial void UpdateMatHang(MatHang instance);
    partial void DeleteMatHang(MatHang instance);
    partial void InsertNhaCungCap(NhaCungCap instance);
    partial void UpdateNhaCungCap(NhaCungCap instance);
    partial void DeleteNhaCungCap(NhaCungCap instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    partial void InsertNhapHang(NhapHang instance);
    partial void UpdateNhapHang(NhapHang instance);
    partial void DeleteNhapHang(NhapHang instance);
    partial void InsertXuatHang(XuatHang instance);
    partial void UpdateXuatHang(XuatHang instance);
    partial void DeleteXuatHang(XuatHang instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ProjectPaperSellManager.Properties.Settings.Default.PaperSellMngConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<ChiTietNhap> ChiTietNhaps
		{
			get
			{
				return this.GetTable<ChiTietNhap>();
			}
		}
		
		public System.Data.Linq.Table<ChiTietXuat> ChiTietXuats
		{
			get
			{
				return this.GetTable<ChiTietXuat>();
			}
		}
		
		public System.Data.Linq.Table<MatHang> MatHangs
		{
			get
			{
				return this.GetTable<MatHang>();
			}
		}
		
		public System.Data.Linq.Table<NhaCungCap> NhaCungCaps
		{
			get
			{
				return this.GetTable<NhaCungCap>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
		
		public System.Data.Linq.Table<NhapHang> NhapHangs
		{
			get
			{
				return this.GetTable<NhapHang>();
			}
		}
		
		public System.Data.Linq.Table<XuatHang> XuatHangs
		{
			get
			{
				return this.GetTable<XuatHang>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietNhap")]
	public partial class ChiTietNhap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNhap;
		
		private string _MaMH;
		
		private int _SoLuong;
		
		private System.Nullable<double> _ThanhTien;
		
		private EntityRef<MatHang> _MatHang;
		
		private EntityRef<NhapHang> _NhapHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhapChanging(string value);
    partial void OnMaNhapChanged();
    partial void OnMaMHChanging(string value);
    partial void OnMaMHChanged();
    partial void OnSoLuongChanging(int value);
    partial void OnSoLuongChanged();
    partial void OnThanhTienChanging(System.Nullable<double> value);
    partial void OnThanhTienChanged();
    #endregion
		
		public ChiTietNhap()
		{
			this._MatHang = default(EntityRef<MatHang>);
			this._NhapHang = default(EntityRef<NhapHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhap", DbType="Char(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNhap
		{
			get
			{
				return this._MaNhap;
			}
			set
			{
				if ((this._MaNhap != value))
				{
					if (this._NhapHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNhapChanging(value);
					this.SendPropertyChanging();
					this._MaNhap = value;
					this.SendPropertyChanged("MaNhap");
					this.OnMaNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMH", DbType="Char(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaMH
		{
			get
			{
				return this._MaMH;
			}
			set
			{
				if ((this._MaMH != value))
				{
					if (this._MatHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaMHChanging(value);
					this.SendPropertyChanging();
					this._MaMH = value;
					this.SendPropertyChanged("MaMH");
					this.OnMaMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int NOT NULL")]
		public int SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="Float")]
		public System.Nullable<double> ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this.OnThanhTienChanging(value);
					this.SendPropertyChanging();
					this._ThanhTien = value;
					this.SendPropertyChanged("ThanhTien");
					this.OnThanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MatHang_ChiTietNhap", Storage="_MatHang", ThisKey="MaMH", OtherKey="MaMH", IsForeignKey=true)]
		public MatHang MatHang
		{
			get
			{
				return this._MatHang.Entity;
			}
			set
			{
				MatHang previousValue = this._MatHang.Entity;
				if (((previousValue != value) 
							|| (this._MatHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MatHang.Entity = null;
						previousValue.ChiTietNhaps.Remove(this);
					}
					this._MatHang.Entity = value;
					if ((value != null))
					{
						value.ChiTietNhaps.Add(this);
						this._MaMH = value.MaMH;
					}
					else
					{
						this._MaMH = default(string);
					}
					this.SendPropertyChanged("MatHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhapHang_ChiTietNhap", Storage="_NhapHang", ThisKey="MaNhap", OtherKey="MaNhap", IsForeignKey=true)]
		public NhapHang NhapHang
		{
			get
			{
				return this._NhapHang.Entity;
			}
			set
			{
				NhapHang previousValue = this._NhapHang.Entity;
				if (((previousValue != value) 
							|| (this._NhapHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhapHang.Entity = null;
						previousValue.ChiTietNhaps.Remove(this);
					}
					this._NhapHang.Entity = value;
					if ((value != null))
					{
						value.ChiTietNhaps.Add(this);
						this._MaNhap = value.MaNhap;
					}
					else
					{
						this._MaNhap = default(string);
					}
					this.SendPropertyChanged("NhapHang");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietXuat")]
	public partial class ChiTietXuat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHD;
		
		private string _MaMH;
		
		private int _SoLuong;
		
		private System.Nullable<double> _ThanhTien;
		
		private EntityRef<MatHang> _MatHang;
		
		private EntityRef<XuatHang> _XuatHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(string value);
    partial void OnMaHDChanged();
    partial void OnMaMHChanging(string value);
    partial void OnMaMHChanged();
    partial void OnSoLuongChanging(int value);
    partial void OnSoLuongChanged();
    partial void OnThanhTienChanging(System.Nullable<double> value);
    partial void OnThanhTienChanged();
    #endregion
		
		public ChiTietXuat()
		{
			this._MatHang = default(EntityRef<MatHang>);
			this._XuatHang = default(EntityRef<XuatHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", DbType="Char(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					if (this._XuatHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMH", DbType="Char(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaMH
		{
			get
			{
				return this._MaMH;
			}
			set
			{
				if ((this._MaMH != value))
				{
					if (this._MatHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaMHChanging(value);
					this.SendPropertyChanging();
					this._MaMH = value;
					this.SendPropertyChanged("MaMH");
					this.OnMaMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int NOT NULL")]
		public int SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="Float")]
		public System.Nullable<double> ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this.OnThanhTienChanging(value);
					this.SendPropertyChanging();
					this._ThanhTien = value;
					this.SendPropertyChanged("ThanhTien");
					this.OnThanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MatHang_ChiTietXuat", Storage="_MatHang", ThisKey="MaMH", OtherKey="MaMH", IsForeignKey=true)]
		public MatHang MatHang
		{
			get
			{
				return this._MatHang.Entity;
			}
			set
			{
				MatHang previousValue = this._MatHang.Entity;
				if (((previousValue != value) 
							|| (this._MatHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MatHang.Entity = null;
						previousValue.ChiTietXuats.Remove(this);
					}
					this._MatHang.Entity = value;
					if ((value != null))
					{
						value.ChiTietXuats.Add(this);
						this._MaMH = value.MaMH;
					}
					else
					{
						this._MaMH = default(string);
					}
					this.SendPropertyChanged("MatHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="XuatHang_ChiTietXuat", Storage="_XuatHang", ThisKey="MaHD", OtherKey="MaHD", IsForeignKey=true)]
		public XuatHang XuatHang
		{
			get
			{
				return this._XuatHang.Entity;
			}
			set
			{
				XuatHang previousValue = this._XuatHang.Entity;
				if (((previousValue != value) 
							|| (this._XuatHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._XuatHang.Entity = null;
						previousValue.ChiTietXuats.Remove(this);
					}
					this._XuatHang.Entity = value;
					if ((value != null))
					{
						value.ChiTietXuats.Add(this);
						this._MaHD = value.MaHD;
					}
					else
					{
						this._MaHD = default(string);
					}
					this.SendPropertyChanged("XuatHang");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MatHang")]
	public partial class MatHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaMH;
		
		private string _TenHang;
		
		private int _DonGiaNhap;
		
		private int _DonGiaBan;
		
		private string _KichThuoc;
		
		private int _DinhLuong;
		
		private System.Nullable<int> _SoLuong;
		
		private EntitySet<ChiTietNhap> _ChiTietNhaps;
		
		private EntitySet<ChiTietXuat> _ChiTietXuats;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaMHChanging(string value);
    partial void OnMaMHChanged();
    partial void OnTenHangChanging(string value);
    partial void OnTenHangChanged();
    partial void OnDonGiaNhapChanging(int value);
    partial void OnDonGiaNhapChanged();
    partial void OnDonGiaBanChanging(int value);
    partial void OnDonGiaBanChanged();
    partial void OnKichThuocChanging(string value);
    partial void OnKichThuocChanged();
    partial void OnDinhLuongChanging(int value);
    partial void OnDinhLuongChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    #endregion
		
		public MatHang()
		{
			this._ChiTietNhaps = new EntitySet<ChiTietNhap>(new Action<ChiTietNhap>(this.attach_ChiTietNhaps), new Action<ChiTietNhap>(this.detach_ChiTietNhaps));
			this._ChiTietXuats = new EntitySet<ChiTietXuat>(new Action<ChiTietXuat>(this.attach_ChiTietXuats), new Action<ChiTietXuat>(this.detach_ChiTietXuats));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMH", DbType="Char(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaMH
		{
			get
			{
				return this._MaMH;
			}
			set
			{
				if ((this._MaMH != value))
				{
					this.OnMaMHChanging(value);
					this.SendPropertyChanging();
					this._MaMH = value;
					this.SendPropertyChanged("MaMH");
					this.OnMaMHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHang", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenHang
		{
			get
			{
				return this._TenHang;
			}
			set
			{
				if ((this._TenHang != value))
				{
					this.OnTenHangChanging(value);
					this.SendPropertyChanging();
					this._TenHang = value;
					this.SendPropertyChanged("TenHang");
					this.OnTenHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGiaNhap", DbType="Int NOT NULL")]
		public int DonGiaNhap
		{
			get
			{
				return this._DonGiaNhap;
			}
			set
			{
				if ((this._DonGiaNhap != value))
				{
					this.OnDonGiaNhapChanging(value);
					this.SendPropertyChanging();
					this._DonGiaNhap = value;
					this.SendPropertyChanged("DonGiaNhap");
					this.OnDonGiaNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGiaBan", DbType="Int NOT NULL")]
		public int DonGiaBan
		{
			get
			{
				return this._DonGiaBan;
			}
			set
			{
				if ((this._DonGiaBan != value))
				{
					this.OnDonGiaBanChanging(value);
					this.SendPropertyChanging();
					this._DonGiaBan = value;
					this.SendPropertyChanged("DonGiaBan");
					this.OnDonGiaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KichThuoc", DbType="Char(30) NOT NULL", CanBeNull=false)]
		public string KichThuoc
		{
			get
			{
				return this._KichThuoc;
			}
			set
			{
				if ((this._KichThuoc != value))
				{
					this.OnKichThuocChanging(value);
					this.SendPropertyChanging();
					this._KichThuoc = value;
					this.SendPropertyChanged("KichThuoc");
					this.OnKichThuocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DinhLuong", DbType="Int NOT NULL")]
		public int DinhLuong
		{
			get
			{
				return this._DinhLuong;
			}
			set
			{
				if ((this._DinhLuong != value))
				{
					this.OnDinhLuongChanging(value);
					this.SendPropertyChanging();
					this._DinhLuong = value;
					this.SendPropertyChanged("DinhLuong");
					this.OnDinhLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MatHang_ChiTietNhap", Storage="_ChiTietNhaps", ThisKey="MaMH", OtherKey="MaMH")]
		public EntitySet<ChiTietNhap> ChiTietNhaps
		{
			get
			{
				return this._ChiTietNhaps;
			}
			set
			{
				this._ChiTietNhaps.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MatHang_ChiTietXuat", Storage="_ChiTietXuats", ThisKey="MaMH", OtherKey="MaMH")]
		public EntitySet<ChiTietXuat> ChiTietXuats
		{
			get
			{
				return this._ChiTietXuats;
			}
			set
			{
				this._ChiTietXuats.Assign(value);
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
		
		private void attach_ChiTietNhaps(ChiTietNhap entity)
		{
			this.SendPropertyChanging();
			entity.MatHang = this;
		}
		
		private void detach_ChiTietNhaps(ChiTietNhap entity)
		{
			this.SendPropertyChanging();
			entity.MatHang = null;
		}
		
		private void attach_ChiTietXuats(ChiTietXuat entity)
		{
			this.SendPropertyChanging();
			entity.MatHang = this;
		}
		
		private void detach_ChiTietXuats(ChiTietXuat entity)
		{
			this.SendPropertyChanging();
			entity.MatHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhaCungCap")]
	public partial class NhaCungCap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNCC;
		
		private string _TenNCC;
		
		private string _SDT;
		
		private EntitySet<NhapHang> _NhapHangs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNCCChanging(string value);
    partial void OnMaNCCChanged();
    partial void OnTenNCCChanging(string value);
    partial void OnTenNCCChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    #endregion
		
		public NhaCungCap()
		{
			this._NhapHangs = new EntitySet<NhapHang>(new Action<NhapHang>(this.attach_NhapHangs), new Action<NhapHang>(this.detach_NhapHangs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNCC", DbType="Char(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNCC
		{
			get
			{
				return this._MaNCC;
			}
			set
			{
				if ((this._MaNCC != value))
				{
					this.OnMaNCCChanging(value);
					this.SendPropertyChanging();
					this._MaNCC = value;
					this.SendPropertyChanged("MaNCC");
					this.OnMaNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNCC", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenNCC
		{
			get
			{
				return this._TenNCC;
			}
			set
			{
				if ((this._TenNCC != value))
				{
					this.OnTenNCCChanging(value);
					this.SendPropertyChanging();
					this._TenNCC = value;
					this.SendPropertyChanged("TenNCC");
					this.OnTenNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhaCungCap_NhapHang", Storage="_NhapHangs", ThisKey="MaNCC", OtherKey="MaNCC")]
		public EntitySet<NhapHang> NhapHangs
		{
			get
			{
				return this._NhapHangs;
			}
			set
			{
				this._NhapHangs.Assign(value);
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
		
		private void attach_NhapHangs(NhapHang entity)
		{
			this.SendPropertyChanging();
			entity.NhaCungCap = this;
		}
		
		private void detach_NhapHangs(NhapHang entity)
		{
			this.SendPropertyChanging();
			entity.NhaCungCap = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNV;
		
		private string _TenNV;
		
		private string _SDT;
		
		private EntitySet<XuatHang> _XuatHangs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNVChanging(string value);
    partial void OnMaNVChanged();
    partial void OnTenNVChanging(string value);
    partial void OnTenNVChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    #endregion
		
		public NhanVien()
		{
			this._XuatHangs = new EntitySet<XuatHang>(new Action<XuatHang>(this.attach_XuatHangs), new Action<XuatHang>(this.detach_XuatHangs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="Char(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNV", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenNV
		{
			get
			{
				return this._TenNV;
			}
			set
			{
				if ((this._TenNV != value))
				{
					this.OnTenNVChanging(value);
					this.SendPropertyChanging();
					this._TenNV = value;
					this.SendPropertyChanged("TenNV");
					this.OnTenNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_XuatHang", Storage="_XuatHangs", ThisKey="MaNV", OtherKey="MaNV")]
		public EntitySet<XuatHang> XuatHangs
		{
			get
			{
				return this._XuatHangs;
			}
			set
			{
				this._XuatHangs.Assign(value);
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
		
		private void attach_XuatHangs(XuatHang entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_XuatHangs(XuatHang entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhapHang")]
	public partial class NhapHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNhap;
		
		private string _MaNCC;
		
		private System.DateTime _NgayNhap;
		
		private EntitySet<ChiTietNhap> _ChiTietNhaps;
		
		private EntityRef<NhaCungCap> _NhaCungCap;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhapChanging(string value);
    partial void OnMaNhapChanged();
    partial void OnMaNCCChanging(string value);
    partial void OnMaNCCChanged();
    partial void OnNgayNhapChanging(System.DateTime value);
    partial void OnNgayNhapChanged();
    #endregion
		
		public NhapHang()
		{
			this._ChiTietNhaps = new EntitySet<ChiTietNhap>(new Action<ChiTietNhap>(this.attach_ChiTietNhaps), new Action<ChiTietNhap>(this.detach_ChiTietNhaps));
			this._NhaCungCap = default(EntityRef<NhaCungCap>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhap", DbType="Char(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNhap
		{
			get
			{
				return this._MaNhap;
			}
			set
			{
				if ((this._MaNhap != value))
				{
					this.OnMaNhapChanging(value);
					this.SendPropertyChanging();
					this._MaNhap = value;
					this.SendPropertyChanged("MaNhap");
					this.OnMaNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNCC", DbType="Char(30) NOT NULL", CanBeNull=false)]
		public string MaNCC
		{
			get
			{
				return this._MaNCC;
			}
			set
			{
				if ((this._MaNCC != value))
				{
					if (this._NhaCungCap.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNCCChanging(value);
					this.SendPropertyChanging();
					this._MaNCC = value;
					this.SendPropertyChanged("MaNCC");
					this.OnMaNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayNhap", DbType="DateTime NOT NULL")]
		public System.DateTime NgayNhap
		{
			get
			{
				return this._NgayNhap;
			}
			set
			{
				if ((this._NgayNhap != value))
				{
					this.OnNgayNhapChanging(value);
					this.SendPropertyChanging();
					this._NgayNhap = value;
					this.SendPropertyChanged("NgayNhap");
					this.OnNgayNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhapHang_ChiTietNhap", Storage="_ChiTietNhaps", ThisKey="MaNhap", OtherKey="MaNhap")]
		public EntitySet<ChiTietNhap> ChiTietNhaps
		{
			get
			{
				return this._ChiTietNhaps;
			}
			set
			{
				this._ChiTietNhaps.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhaCungCap_NhapHang", Storage="_NhaCungCap", ThisKey="MaNCC", OtherKey="MaNCC", IsForeignKey=true)]
		public NhaCungCap NhaCungCap
		{
			get
			{
				return this._NhaCungCap.Entity;
			}
			set
			{
				NhaCungCap previousValue = this._NhaCungCap.Entity;
				if (((previousValue != value) 
							|| (this._NhaCungCap.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhaCungCap.Entity = null;
						previousValue.NhapHangs.Remove(this);
					}
					this._NhaCungCap.Entity = value;
					if ((value != null))
					{
						value.NhapHangs.Add(this);
						this._MaNCC = value.MaNCC;
					}
					else
					{
						this._MaNCC = default(string);
					}
					this.SendPropertyChanged("NhaCungCap");
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
		
		private void attach_ChiTietNhaps(ChiTietNhap entity)
		{
			this.SendPropertyChanging();
			entity.NhapHang = this;
		}
		
		private void detach_ChiTietNhaps(ChiTietNhap entity)
		{
			this.SendPropertyChanging();
			entity.NhapHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.XuatHang")]
	public partial class XuatHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHD;
		
		private string _MaNV;
		
		private System.DateTime _NgayMua;
		
		private EntitySet<ChiTietXuat> _ChiTietXuats;
		
		private EntityRef<NhanVien> _NhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(string value);
    partial void OnMaHDChanged();
    partial void OnMaNVChanging(string value);
    partial void OnMaNVChanged();
    partial void OnNgayMuaChanging(System.DateTime value);
    partial void OnNgayMuaChanged();
    #endregion
		
		public XuatHang()
		{
			this._ChiTietXuats = new EntitySet<ChiTietXuat>(new Action<ChiTietXuat>(this.attach_ChiTietXuats), new Action<ChiTietXuat>(this.detach_ChiTietXuats));
			this._NhanVien = default(EntityRef<NhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", DbType="Char(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="Char(30) NOT NULL", CanBeNull=false)]
		public string MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayMua", DbType="DateTime NOT NULL")]
		public System.DateTime NgayMua
		{
			get
			{
				return this._NgayMua;
			}
			set
			{
				if ((this._NgayMua != value))
				{
					this.OnNgayMuaChanging(value);
					this.SendPropertyChanging();
					this._NgayMua = value;
					this.SendPropertyChanged("NgayMua");
					this.OnNgayMuaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="XuatHang_ChiTietXuat", Storage="_ChiTietXuats", ThisKey="MaHD", OtherKey="MaHD")]
		public EntitySet<ChiTietXuat> ChiTietXuats
		{
			get
			{
				return this._ChiTietXuats;
			}
			set
			{
				this._ChiTietXuats.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_XuatHang", Storage="_NhanVien", ThisKey="MaNV", OtherKey="MaNV", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.XuatHangs.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.XuatHangs.Add(this);
						this._MaNV = value.MaNV;
					}
					else
					{
						this._MaNV = default(string);
					}
					this.SendPropertyChanged("NhanVien");
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
		
		private void attach_ChiTietXuats(ChiTietXuat entity)
		{
			this.SendPropertyChanging();
			entity.XuatHang = this;
		}
		
		private void detach_ChiTietXuats(ChiTietXuat entity)
		{
			this.SendPropertyChanging();
			entity.XuatHang = null;
		}
	}
}
#pragma warning restore 1591
