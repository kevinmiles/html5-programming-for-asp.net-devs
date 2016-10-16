﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace SampleAppMVC.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class UserDbEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new UserDbEntities object using the connection string found in the 'UserDbEntities' section of the application configuration file.
        /// </summary>
        public UserDbEntities() : base("name=UserDbEntities", "UserDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new UserDbEntities object.
        /// </summary>
        public UserDbEntities(string connectionString) : base(connectionString, "UserDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new UserDbEntities object.
        /// </summary>
        public UserDbEntities(EntityConnection connection) : base(connection, "UserDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="UserDbModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static User CreateUser(global::System.Int32 id)
        {
            User user = new User();
            user.Id = id;
            return user;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String DisplayName
        {
            get
            {
                return _DisplayName;
            }
            set
            {
                OnDisplayNameChanging(value);
                ReportPropertyChanging("DisplayName");
                _DisplayName = StructuralObject.SetValidValue(value, true, "DisplayName");
                ReportPropertyChanged("DisplayName");
                OnDisplayNameChanged();
            }
        }
        private global::System.String _DisplayName;
        partial void OnDisplayNameChanging(global::System.String value);
        partial void OnDisplayNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, true, "Email");
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, true, "Password");
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String BlogUrl
        {
            get
            {
                return _BlogUrl;
            }
            set
            {
                OnBlogUrlChanging(value);
                ReportPropertyChanging("BlogUrl");
                _BlogUrl = StructuralObject.SetValidValue(value, true, "BlogUrl");
                ReportPropertyChanged("BlogUrl");
                OnBlogUrlChanged();
            }
        }
        private global::System.String _BlogUrl;
        partial void OnBlogUrlChanging(global::System.String value);
        partial void OnBlogUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Bio
        {
            get
            {
                return _Bio;
            }
            set
            {
                OnBioChanging(value);
                ReportPropertyChanging("Bio");
                _Bio = StructuralObject.SetValidValue(value, true, "Bio");
                ReportPropertyChanged("Bio");
                OnBioChanged();
            }
        }
        private global::System.String _Bio;
        partial void OnBioChanging(global::System.String value);
        partial void OnBioChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> CreatedDate
        {
            get
            {
                return _CreatedDate;
            }
            set
            {
                OnCreatedDateChanging(value);
                ReportPropertyChanging("CreatedDate");
                _CreatedDate = StructuralObject.SetValidValue(value, "CreatedDate");
                ReportPropertyChanged("CreatedDate");
                OnCreatedDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _CreatedDate;
        partial void OnCreatedDateChanging(Nullable<global::System.DateTime> value);
        partial void OnCreatedDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Age
        {
            get
            {
                return _Age;
            }
            set
            {
                OnAgeChanging(value);
                ReportPropertyChanging("Age");
                _Age = StructuralObject.SetValidValue(value, "Age");
                ReportPropertyChanged("Age");
                OnAgeChanged();
            }
        }
        private Nullable<global::System.Int32> _Age;
        partial void OnAgeChanging(Nullable<global::System.Int32> value);
        partial void OnAgeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Income
        {
            get
            {
                return _Income;
            }
            set
            {
                OnIncomeChanging(value);
                ReportPropertyChanging("Income");
                _Income = StructuralObject.SetValidValue(value, "Income");
                ReportPropertyChanged("Income");
                OnIncomeChanged();
            }
        }
        private Nullable<global::System.Decimal> _Income;
        partial void OnIncomeChanging(Nullable<global::System.Decimal> value);
        partial void OnIncomeChanged();

        #endregion

    }

    #endregion

}