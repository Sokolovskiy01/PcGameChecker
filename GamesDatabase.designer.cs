﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PcGameChecker
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GamesDatabase")]
	public partial class GamesDatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPlatform(Platform instance);
    partial void UpdatePlatform(Platform instance);
    partial void DeletePlatform(Platform instance);
    partial void InsertGame(Game instance);
    partial void UpdateGame(Game instance);
    partial void DeleteGame(Game instance);
    partial void InsertGameToPlatform(GameToPlatform instance);
    partial void UpdateGameToPlatform(GameToPlatform instance);
    partial void DeleteGameToPlatform(GameToPlatform instance);
    #endregion
		
		public GamesDatabaseDataContext() : 
				base(global::PcGameChecker.Properties.Settings.Default.GamesDatabaseConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public GamesDatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GamesDatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GamesDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GamesDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Platform> Platforms
		{
			get
			{
				return this.GetTable<Platform>();
			}
		}
		
		public System.Data.Linq.Table<Game> Games
		{
			get
			{
				return this.GetTable<Game>();
			}
		}
		
		public System.Data.Linq.Table<GameToPlatform> GameToPlatforms
		{
			get
			{
				return this.GetTable<GameToPlatform>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Platform")]
	public partial class Platform : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Subname;
		
		private System.Data.Linq.Binary _Icon;
		
		private EntitySet<GameToPlatform> _GameToPlatforms;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSubnameChanging(string value);
    partial void OnSubnameChanged();
    partial void OnIconChanging(System.Data.Linq.Binary value);
    partial void OnIconChanged();
    #endregion
		
		public Platform()
		{
			this._GameToPlatforms = new EntitySet<GameToPlatform>(new Action<GameToPlatform>(this.attach_GameToPlatforms), new Action<GameToPlatform>(this.detach_GameToPlatforms));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subname", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string Subname
		{
			get
			{
				return this._Subname;
			}
			set
			{
				if ((this._Subname != value))
				{
					this.OnSubnameChanging(value);
					this.SendPropertyChanging();
					this._Subname = value;
					this.SendPropertyChanged("Subname");
					this.OnSubnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Icon", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Icon
		{
			get
			{
				return this._Icon;
			}
			set
			{
				if ((this._Icon != value))
				{
					this.OnIconChanging(value);
					this.SendPropertyChanging();
					this._Icon = value;
					this.SendPropertyChanged("Icon");
					this.OnIconChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Platform_GameToPlatform", Storage="_GameToPlatforms", ThisKey="Id", OtherKey="PlatformId")]
		public EntitySet<GameToPlatform> GameToPlatforms
		{
			get
			{
				return this._GameToPlatforms;
			}
			set
			{
				this._GameToPlatforms.Assign(value);
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
		
		private void attach_GameToPlatforms(GameToPlatform entity)
		{
			this.SendPropertyChanging();
			entity.Platform = this;
		}
		
		private void detach_GameToPlatforms(GameToPlatform entity)
		{
			this.SendPropertyChanging();
			entity.Platform = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Game")]
	public partial class Game : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Genre;
		
		private string _Description;
		
		private System.DateTime _Release;
		
		private string _MetacriticsCheckLink;
		
		private int _MetacriticsCritics;
		
		private decimal _MetacriticsUserScore;
		
		private System.Data.Linq.Binary _Poster;
		
		private System.Data.Linq.Binary _Icon;
		
		private string _MinOS;
		
		private int _MinOSArchitecture;
		
		private int _MinDiskSpace;
		
		private int _MinRAM;
		
		private string _MinProcesorName;
		
		private int _MinProcessorCores;
		
		private int _MinProcessorThreads;
		
		private int _MinProcessorClock;
		
		private string _MinGPUName;
		
		private int _MinGPUClock;
		
		private int _MinGPUMemoryClock;
		
		private int _MinGPUMemoryCapacity;
		
		private int _MinGPUBusWidth;
		
		private string _MinGPUMemoryType;
		
		private string _MinGPUDirectX;
		
		private int _MinGPUShaderUnitCount;
		
		private int _MinGPUROPCount;
		
		private int _MinGPUTMUCount;
		
		private System.Nullable<int> _RecRAM;
		
		private string _RecProcesorName;
		
		private System.Nullable<int> _RecProcessorCores;
		
		private System.Nullable<int> _RecProcessorThreads;
		
		private System.Nullable<int> _RecProcessorClock;
		
		private string _RecGPUName;
		
		private System.Nullable<int> _RecGPUClock;
		
		private System.Nullable<int> _RecGPUMemoryClock;
		
		private System.Nullable<int> _RecGPUMemoryCapacity;
		
		private System.Nullable<int> _RecGPUBusWidth;
		
		private string _RecGPUMemoryType;
		
		private string _RecGPUDirectX;
		
		private System.Nullable<int> _RecGPUShaderUnitCount;
		
		private System.Nullable<int> _RecGPUROPCount;
		
		private System.Nullable<int> _RecGPUTMUCount;
		
		private EntitySet<GameToPlatform> _GameToPlatforms;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnGenreChanging(string value);
    partial void OnGenreChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnReleaseChanging(System.DateTime value);
    partial void OnReleaseChanged();
    partial void OnMetacriticsCheckLinkChanging(string value);
    partial void OnMetacriticsCheckLinkChanged();
    partial void OnMetacriticsCriticsChanging(int value);
    partial void OnMetacriticsCriticsChanged();
    partial void OnMetacriticsUserScoreChanging(decimal value);
    partial void OnMetacriticsUserScoreChanged();
    partial void OnPosterChanging(System.Data.Linq.Binary value);
    partial void OnPosterChanged();
    partial void OnIconChanging(System.Data.Linq.Binary value);
    partial void OnIconChanged();
    partial void OnMinOSChanging(string value);
    partial void OnMinOSChanged();
    partial void OnMinOSArchitectureChanging(int value);
    partial void OnMinOSArchitectureChanged();
    partial void OnMinDiskSpaceChanging(int value);
    partial void OnMinDiskSpaceChanged();
    partial void OnMinRAMChanging(int value);
    partial void OnMinRAMChanged();
    partial void OnMinProcesorNameChanging(string value);
    partial void OnMinProcesorNameChanged();
    partial void OnMinProcessorCoresChanging(int value);
    partial void OnMinProcessorCoresChanged();
    partial void OnMinProcessorThreadsChanging(int value);
    partial void OnMinProcessorThreadsChanged();
    partial void OnMinProcessorClockChanging(int value);
    partial void OnMinProcessorClockChanged();
    partial void OnMinGPUNameChanging(string value);
    partial void OnMinGPUNameChanged();
    partial void OnMinGPUClockChanging(int value);
    partial void OnMinGPUClockChanged();
    partial void OnMinGPUMemoryClockChanging(int value);
    partial void OnMinGPUMemoryClockChanged();
    partial void OnMinGPUMemoryCapacityChanging(int value);
    partial void OnMinGPUMemoryCapacityChanged();
    partial void OnMinGPUBusWidthChanging(int value);
    partial void OnMinGPUBusWidthChanged();
    partial void OnMinGPUMemoryTypeChanging(string value);
    partial void OnMinGPUMemoryTypeChanged();
    partial void OnMinGPUDirectXChanging(string value);
    partial void OnMinGPUDirectXChanged();
    partial void OnMinGPUShaderUnitCountChanging(int value);
    partial void OnMinGPUShaderUnitCountChanged();
    partial void OnMinGPUROPCountChanging(int value);
    partial void OnMinGPUROPCountChanged();
    partial void OnMinGPUTMUCountChanging(int value);
    partial void OnMinGPUTMUCountChanged();
    partial void OnRecRAMChanging(System.Nullable<int> value);
    partial void OnRecRAMChanged();
    partial void OnRecProcesorNameChanging(string value);
    partial void OnRecProcesorNameChanged();
    partial void OnRecProcessorCoresChanging(System.Nullable<int> value);
    partial void OnRecProcessorCoresChanged();
    partial void OnRecProcessorThreadsChanging(System.Nullable<int> value);
    partial void OnRecProcessorThreadsChanged();
    partial void OnRecProcessorClockChanging(System.Nullable<int> value);
    partial void OnRecProcessorClockChanged();
    partial void OnRecGPUNameChanging(string value);
    partial void OnRecGPUNameChanged();
    partial void OnRecGPUClockChanging(System.Nullable<int> value);
    partial void OnRecGPUClockChanged();
    partial void OnRecGPUMemoryClockChanging(System.Nullable<int> value);
    partial void OnRecGPUMemoryClockChanged();
    partial void OnRecGPUMemoryCapacityChanging(System.Nullable<int> value);
    partial void OnRecGPUMemoryCapacityChanged();
    partial void OnRecGPUBusWidthChanging(System.Nullable<int> value);
    partial void OnRecGPUBusWidthChanged();
    partial void OnRecGPUMemoryTypeChanging(string value);
    partial void OnRecGPUMemoryTypeChanged();
    partial void OnRecGPUDirectXChanging(string value);
    partial void OnRecGPUDirectXChanged();
    partial void OnRecGPUShaderUnitCountChanging(System.Nullable<int> value);
    partial void OnRecGPUShaderUnitCountChanged();
    partial void OnRecGPUROPCountChanging(System.Nullable<int> value);
    partial void OnRecGPUROPCountChanged();
    partial void OnRecGPUTMUCountChanging(System.Nullable<int> value);
    partial void OnRecGPUTMUCountChanged();
    #endregion
		
		public Game()
		{
			this._GameToPlatforms = new EntitySet<GameToPlatform>(new Action<GameToPlatform>(this.attach_GameToPlatforms), new Action<GameToPlatform>(this.detach_GameToPlatforms));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genre", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string Genre
		{
			get
			{
				return this._Genre;
			}
			set
			{
				if ((this._Genre != value))
				{
					this.OnGenreChanging(value);
					this.SendPropertyChanging();
					this._Genre = value;
					this.SendPropertyChanged("Genre");
					this.OnGenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Release", DbType="Date NOT NULL")]
		public System.DateTime Release
		{
			get
			{
				return this._Release;
			}
			set
			{
				if ((this._Release != value))
				{
					this.OnReleaseChanging(value);
					this.SendPropertyChanging();
					this._Release = value;
					this.SendPropertyChanged("Release");
					this.OnReleaseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MetacriticsCheckLink", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string MetacriticsCheckLink
		{
			get
			{
				return this._MetacriticsCheckLink;
			}
			set
			{
				if ((this._MetacriticsCheckLink != value))
				{
					this.OnMetacriticsCheckLinkChanging(value);
					this.SendPropertyChanging();
					this._MetacriticsCheckLink = value;
					this.SendPropertyChanged("MetacriticsCheckLink");
					this.OnMetacriticsCheckLinkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MetacriticsCritics", DbType="Int NOT NULL")]
		public int MetacriticsCritics
		{
			get
			{
				return this._MetacriticsCritics;
			}
			set
			{
				if ((this._MetacriticsCritics != value))
				{
					this.OnMetacriticsCriticsChanging(value);
					this.SendPropertyChanging();
					this._MetacriticsCritics = value;
					this.SendPropertyChanged("MetacriticsCritics");
					this.OnMetacriticsCriticsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MetacriticsUserScore", DbType="Decimal(3,1) NOT NULL")]
		public decimal MetacriticsUserScore
		{
			get
			{
				return this._MetacriticsUserScore;
			}
			set
			{
				if ((this._MetacriticsUserScore != value))
				{
					this.OnMetacriticsUserScoreChanging(value);
					this.SendPropertyChanging();
					this._MetacriticsUserScore = value;
					this.SendPropertyChanged("MetacriticsUserScore");
					this.OnMetacriticsUserScoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Poster", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Poster
		{
			get
			{
				return this._Poster;
			}
			set
			{
				if ((this._Poster != value))
				{
					this.OnPosterChanging(value);
					this.SendPropertyChanging();
					this._Poster = value;
					this.SendPropertyChanged("Poster");
					this.OnPosterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Icon", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Icon
		{
			get
			{
				return this._Icon;
			}
			set
			{
				if ((this._Icon != value))
				{
					this.OnIconChanging(value);
					this.SendPropertyChanging();
					this._Icon = value;
					this.SendPropertyChanged("Icon");
					this.OnIconChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinOS", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string MinOS
		{
			get
			{
				return this._MinOS;
			}
			set
			{
				if ((this._MinOS != value))
				{
					this.OnMinOSChanging(value);
					this.SendPropertyChanging();
					this._MinOS = value;
					this.SendPropertyChanged("MinOS");
					this.OnMinOSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinOSArchitecture", DbType="Int NOT NULL")]
		public int MinOSArchitecture
		{
			get
			{
				return this._MinOSArchitecture;
			}
			set
			{
				if ((this._MinOSArchitecture != value))
				{
					this.OnMinOSArchitectureChanging(value);
					this.SendPropertyChanging();
					this._MinOSArchitecture = value;
					this.SendPropertyChanged("MinOSArchitecture");
					this.OnMinOSArchitectureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinDiskSpace", DbType="Int NOT NULL")]
		public int MinDiskSpace
		{
			get
			{
				return this._MinDiskSpace;
			}
			set
			{
				if ((this._MinDiskSpace != value))
				{
					this.OnMinDiskSpaceChanging(value);
					this.SendPropertyChanging();
					this._MinDiskSpace = value;
					this.SendPropertyChanged("MinDiskSpace");
					this.OnMinDiskSpaceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinRAM", DbType="Int NOT NULL")]
		public int MinRAM
		{
			get
			{
				return this._MinRAM;
			}
			set
			{
				if ((this._MinRAM != value))
				{
					this.OnMinRAMChanging(value);
					this.SendPropertyChanging();
					this._MinRAM = value;
					this.SendPropertyChanged("MinRAM");
					this.OnMinRAMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinProcesorName", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string MinProcesorName
		{
			get
			{
				return this._MinProcesorName;
			}
			set
			{
				if ((this._MinProcesorName != value))
				{
					this.OnMinProcesorNameChanging(value);
					this.SendPropertyChanging();
					this._MinProcesorName = value;
					this.SendPropertyChanged("MinProcesorName");
					this.OnMinProcesorNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinProcessorCores", DbType="Int NOT NULL")]
		public int MinProcessorCores
		{
			get
			{
				return this._MinProcessorCores;
			}
			set
			{
				if ((this._MinProcessorCores != value))
				{
					this.OnMinProcessorCoresChanging(value);
					this.SendPropertyChanging();
					this._MinProcessorCores = value;
					this.SendPropertyChanged("MinProcessorCores");
					this.OnMinProcessorCoresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinProcessorThreads", DbType="Int NOT NULL")]
		public int MinProcessorThreads
		{
			get
			{
				return this._MinProcessorThreads;
			}
			set
			{
				if ((this._MinProcessorThreads != value))
				{
					this.OnMinProcessorThreadsChanging(value);
					this.SendPropertyChanging();
					this._MinProcessorThreads = value;
					this.SendPropertyChanged("MinProcessorThreads");
					this.OnMinProcessorThreadsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinProcessorClock", DbType="Int NOT NULL")]
		public int MinProcessorClock
		{
			get
			{
				return this._MinProcessorClock;
			}
			set
			{
				if ((this._MinProcessorClock != value))
				{
					this.OnMinProcessorClockChanging(value);
					this.SendPropertyChanging();
					this._MinProcessorClock = value;
					this.SendPropertyChanged("MinProcessorClock");
					this.OnMinProcessorClockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinGPUName", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string MinGPUName
		{
			get
			{
				return this._MinGPUName;
			}
			set
			{
				if ((this._MinGPUName != value))
				{
					this.OnMinGPUNameChanging(value);
					this.SendPropertyChanging();
					this._MinGPUName = value;
					this.SendPropertyChanged("MinGPUName");
					this.OnMinGPUNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinGPUClock", DbType="Int NOT NULL")]
		public int MinGPUClock
		{
			get
			{
				return this._MinGPUClock;
			}
			set
			{
				if ((this._MinGPUClock != value))
				{
					this.OnMinGPUClockChanging(value);
					this.SendPropertyChanging();
					this._MinGPUClock = value;
					this.SendPropertyChanged("MinGPUClock");
					this.OnMinGPUClockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinGPUMemoryClock", DbType="Int NOT NULL")]
		public int MinGPUMemoryClock
		{
			get
			{
				return this._MinGPUMemoryClock;
			}
			set
			{
				if ((this._MinGPUMemoryClock != value))
				{
					this.OnMinGPUMemoryClockChanging(value);
					this.SendPropertyChanging();
					this._MinGPUMemoryClock = value;
					this.SendPropertyChanged("MinGPUMemoryClock");
					this.OnMinGPUMemoryClockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinGPUMemoryCapacity", DbType="Int NOT NULL")]
		public int MinGPUMemoryCapacity
		{
			get
			{
				return this._MinGPUMemoryCapacity;
			}
			set
			{
				if ((this._MinGPUMemoryCapacity != value))
				{
					this.OnMinGPUMemoryCapacityChanging(value);
					this.SendPropertyChanging();
					this._MinGPUMemoryCapacity = value;
					this.SendPropertyChanged("MinGPUMemoryCapacity");
					this.OnMinGPUMemoryCapacityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinGPUBusWidth", DbType="Int NOT NULL")]
		public int MinGPUBusWidth
		{
			get
			{
				return this._MinGPUBusWidth;
			}
			set
			{
				if ((this._MinGPUBusWidth != value))
				{
					this.OnMinGPUBusWidthChanging(value);
					this.SendPropertyChanging();
					this._MinGPUBusWidth = value;
					this.SendPropertyChanged("MinGPUBusWidth");
					this.OnMinGPUBusWidthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinGPUMemoryType", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string MinGPUMemoryType
		{
			get
			{
				return this._MinGPUMemoryType;
			}
			set
			{
				if ((this._MinGPUMemoryType != value))
				{
					this.OnMinGPUMemoryTypeChanging(value);
					this.SendPropertyChanging();
					this._MinGPUMemoryType = value;
					this.SendPropertyChanged("MinGPUMemoryType");
					this.OnMinGPUMemoryTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinGPUDirectX", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string MinGPUDirectX
		{
			get
			{
				return this._MinGPUDirectX;
			}
			set
			{
				if ((this._MinGPUDirectX != value))
				{
					this.OnMinGPUDirectXChanging(value);
					this.SendPropertyChanging();
					this._MinGPUDirectX = value;
					this.SendPropertyChanged("MinGPUDirectX");
					this.OnMinGPUDirectXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinGPUShaderUnitCount", DbType="Int NOT NULL")]
		public int MinGPUShaderUnitCount
		{
			get
			{
				return this._MinGPUShaderUnitCount;
			}
			set
			{
				if ((this._MinGPUShaderUnitCount != value))
				{
					this.OnMinGPUShaderUnitCountChanging(value);
					this.SendPropertyChanging();
					this._MinGPUShaderUnitCount = value;
					this.SendPropertyChanged("MinGPUShaderUnitCount");
					this.OnMinGPUShaderUnitCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinGPUROPCount", DbType="Int NOT NULL")]
		public int MinGPUROPCount
		{
			get
			{
				return this._MinGPUROPCount;
			}
			set
			{
				if ((this._MinGPUROPCount != value))
				{
					this.OnMinGPUROPCountChanging(value);
					this.SendPropertyChanging();
					this._MinGPUROPCount = value;
					this.SendPropertyChanged("MinGPUROPCount");
					this.OnMinGPUROPCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinGPUTMUCount", DbType="Int NOT NULL")]
		public int MinGPUTMUCount
		{
			get
			{
				return this._MinGPUTMUCount;
			}
			set
			{
				if ((this._MinGPUTMUCount != value))
				{
					this.OnMinGPUTMUCountChanging(value);
					this.SendPropertyChanging();
					this._MinGPUTMUCount = value;
					this.SendPropertyChanged("MinGPUTMUCount");
					this.OnMinGPUTMUCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecRAM", DbType="Int")]
		public System.Nullable<int> RecRAM
		{
			get
			{
				return this._RecRAM;
			}
			set
			{
				if ((this._RecRAM != value))
				{
					this.OnRecRAMChanging(value);
					this.SendPropertyChanging();
					this._RecRAM = value;
					this.SendPropertyChanged("RecRAM");
					this.OnRecRAMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecProcesorName", DbType="NVarChar(128)")]
		public string RecProcesorName
		{
			get
			{
				return this._RecProcesorName;
			}
			set
			{
				if ((this._RecProcesorName != value))
				{
					this.OnRecProcesorNameChanging(value);
					this.SendPropertyChanging();
					this._RecProcesorName = value;
					this.SendPropertyChanged("RecProcesorName");
					this.OnRecProcesorNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecProcessorCores", DbType="Int")]
		public System.Nullable<int> RecProcessorCores
		{
			get
			{
				return this._RecProcessorCores;
			}
			set
			{
				if ((this._RecProcessorCores != value))
				{
					this.OnRecProcessorCoresChanging(value);
					this.SendPropertyChanging();
					this._RecProcessorCores = value;
					this.SendPropertyChanged("RecProcessorCores");
					this.OnRecProcessorCoresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecProcessorThreads", DbType="Int")]
		public System.Nullable<int> RecProcessorThreads
		{
			get
			{
				return this._RecProcessorThreads;
			}
			set
			{
				if ((this._RecProcessorThreads != value))
				{
					this.OnRecProcessorThreadsChanging(value);
					this.SendPropertyChanging();
					this._RecProcessorThreads = value;
					this.SendPropertyChanged("RecProcessorThreads");
					this.OnRecProcessorThreadsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecProcessorClock", DbType="Int")]
		public System.Nullable<int> RecProcessorClock
		{
			get
			{
				return this._RecProcessorClock;
			}
			set
			{
				if ((this._RecProcessorClock != value))
				{
					this.OnRecProcessorClockChanging(value);
					this.SendPropertyChanging();
					this._RecProcessorClock = value;
					this.SendPropertyChanged("RecProcessorClock");
					this.OnRecProcessorClockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecGPUName", DbType="NVarChar(128)")]
		public string RecGPUName
		{
			get
			{
				return this._RecGPUName;
			}
			set
			{
				if ((this._RecGPUName != value))
				{
					this.OnRecGPUNameChanging(value);
					this.SendPropertyChanging();
					this._RecGPUName = value;
					this.SendPropertyChanged("RecGPUName");
					this.OnRecGPUNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecGPUClock", DbType="Int")]
		public System.Nullable<int> RecGPUClock
		{
			get
			{
				return this._RecGPUClock;
			}
			set
			{
				if ((this._RecGPUClock != value))
				{
					this.OnRecGPUClockChanging(value);
					this.SendPropertyChanging();
					this._RecGPUClock = value;
					this.SendPropertyChanged("RecGPUClock");
					this.OnRecGPUClockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecGPUMemoryClock", DbType="Int")]
		public System.Nullable<int> RecGPUMemoryClock
		{
			get
			{
				return this._RecGPUMemoryClock;
			}
			set
			{
				if ((this._RecGPUMemoryClock != value))
				{
					this.OnRecGPUMemoryClockChanging(value);
					this.SendPropertyChanging();
					this._RecGPUMemoryClock = value;
					this.SendPropertyChanged("RecGPUMemoryClock");
					this.OnRecGPUMemoryClockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecGPUMemoryCapacity", DbType="Int")]
		public System.Nullable<int> RecGPUMemoryCapacity
		{
			get
			{
				return this._RecGPUMemoryCapacity;
			}
			set
			{
				if ((this._RecGPUMemoryCapacity != value))
				{
					this.OnRecGPUMemoryCapacityChanging(value);
					this.SendPropertyChanging();
					this._RecGPUMemoryCapacity = value;
					this.SendPropertyChanged("RecGPUMemoryCapacity");
					this.OnRecGPUMemoryCapacityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecGPUBusWidth", DbType="Int")]
		public System.Nullable<int> RecGPUBusWidth
		{
			get
			{
				return this._RecGPUBusWidth;
			}
			set
			{
				if ((this._RecGPUBusWidth != value))
				{
					this.OnRecGPUBusWidthChanging(value);
					this.SendPropertyChanging();
					this._RecGPUBusWidth = value;
					this.SendPropertyChanged("RecGPUBusWidth");
					this.OnRecGPUBusWidthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecGPUMemoryType", DbType="NVarChar(16)")]
		public string RecGPUMemoryType
		{
			get
			{
				return this._RecGPUMemoryType;
			}
			set
			{
				if ((this._RecGPUMemoryType != value))
				{
					this.OnRecGPUMemoryTypeChanging(value);
					this.SendPropertyChanging();
					this._RecGPUMemoryType = value;
					this.SendPropertyChanged("RecGPUMemoryType");
					this.OnRecGPUMemoryTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecGPUDirectX", DbType="NVarChar(16)")]
		public string RecGPUDirectX
		{
			get
			{
				return this._RecGPUDirectX;
			}
			set
			{
				if ((this._RecGPUDirectX != value))
				{
					this.OnRecGPUDirectXChanging(value);
					this.SendPropertyChanging();
					this._RecGPUDirectX = value;
					this.SendPropertyChanged("RecGPUDirectX");
					this.OnRecGPUDirectXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecGPUShaderUnitCount", DbType="Int")]
		public System.Nullable<int> RecGPUShaderUnitCount
		{
			get
			{
				return this._RecGPUShaderUnitCount;
			}
			set
			{
				if ((this._RecGPUShaderUnitCount != value))
				{
					this.OnRecGPUShaderUnitCountChanging(value);
					this.SendPropertyChanging();
					this._RecGPUShaderUnitCount = value;
					this.SendPropertyChanged("RecGPUShaderUnitCount");
					this.OnRecGPUShaderUnitCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecGPUROPCount", DbType="Int")]
		public System.Nullable<int> RecGPUROPCount
		{
			get
			{
				return this._RecGPUROPCount;
			}
			set
			{
				if ((this._RecGPUROPCount != value))
				{
					this.OnRecGPUROPCountChanging(value);
					this.SendPropertyChanging();
					this._RecGPUROPCount = value;
					this.SendPropertyChanged("RecGPUROPCount");
					this.OnRecGPUROPCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecGPUTMUCount", DbType="Int")]
		public System.Nullable<int> RecGPUTMUCount
		{
			get
			{
				return this._RecGPUTMUCount;
			}
			set
			{
				if ((this._RecGPUTMUCount != value))
				{
					this.OnRecGPUTMUCountChanging(value);
					this.SendPropertyChanging();
					this._RecGPUTMUCount = value;
					this.SendPropertyChanged("RecGPUTMUCount");
					this.OnRecGPUTMUCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Game_GameToPlatform", Storage="_GameToPlatforms", ThisKey="Id", OtherKey="GameId")]
		public EntitySet<GameToPlatform> GameToPlatforms
		{
			get
			{
				return this._GameToPlatforms;
			}
			set
			{
				this._GameToPlatforms.Assign(value);
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
		
		private void attach_GameToPlatforms(GameToPlatform entity)
		{
			this.SendPropertyChanging();
			entity.Game = this;
		}
		
		private void detach_GameToPlatforms(GameToPlatform entity)
		{
			this.SendPropertyChanging();
			entity.Game = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GameToPlatform")]
	public partial class GameToPlatform : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _GameId;
		
		private int _PlatformId;
		
		private EntityRef<Game> _Game;
		
		private EntityRef<Platform> _Platform;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnGameIdChanging(int value);
    partial void OnGameIdChanged();
    partial void OnPlatformIdChanging(int value);
    partial void OnPlatformIdChanged();
    #endregion
		
		public GameToPlatform()
		{
			this._Game = default(EntityRef<Game>);
			this._Platform = default(EntityRef<Platform>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameId", DbType="Int NOT NULL")]
		public int GameId
		{
			get
			{
				return this._GameId;
			}
			set
			{
				if ((this._GameId != value))
				{
					if (this._Game.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGameIdChanging(value);
					this.SendPropertyChanging();
					this._GameId = value;
					this.SendPropertyChanged("GameId");
					this.OnGameIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlatformId", DbType="Int NOT NULL")]
		public int PlatformId
		{
			get
			{
				return this._PlatformId;
			}
			set
			{
				if ((this._PlatformId != value))
				{
					if (this._Platform.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPlatformIdChanging(value);
					this.SendPropertyChanging();
					this._PlatformId = value;
					this.SendPropertyChanged("PlatformId");
					this.OnPlatformIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Game_GameToPlatform", Storage="_Game", ThisKey="GameId", OtherKey="Id", IsForeignKey=true)]
		public Game Game
		{
			get
			{
				return this._Game.Entity;
			}
			set
			{
				Game previousValue = this._Game.Entity;
				if (((previousValue != value) 
							|| (this._Game.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Game.Entity = null;
						previousValue.GameToPlatforms.Remove(this);
					}
					this._Game.Entity = value;
					if ((value != null))
					{
						value.GameToPlatforms.Add(this);
						this._GameId = value.Id;
					}
					else
					{
						this._GameId = default(int);
					}
					this.SendPropertyChanged("Game");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Platform_GameToPlatform", Storage="_Platform", ThisKey="PlatformId", OtherKey="Id", IsForeignKey=true)]
		public Platform Platform
		{
			get
			{
				return this._Platform.Entity;
			}
			set
			{
				Platform previousValue = this._Platform.Entity;
				if (((previousValue != value) 
							|| (this._Platform.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Platform.Entity = null;
						previousValue.GameToPlatforms.Remove(this);
					}
					this._Platform.Entity = value;
					if ((value != null))
					{
						value.GameToPlatforms.Add(this);
						this._PlatformId = value.Id;
					}
					else
					{
						this._PlatformId = default(int);
					}
					this.SendPropertyChanged("Platform");
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