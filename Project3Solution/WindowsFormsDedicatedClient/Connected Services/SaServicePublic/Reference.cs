﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsDedicatedClient.SaServicePublic {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ad", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WindowsFormsDedicatedClient.SaServicePublic.Ad[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WindowsFormsDedicatedClient.SaServicePublic.Post))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WindowsFormsDedicatedClient.SaServicePublic.User))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WindowsFormsDedicatedClient.SaServicePublic.Location))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WindowsFormsDedicatedClient.SaServicePublic.LocationType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WindowsFormsDedicatedClient.SaServicePublic.Price))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WindowsFormsDedicatedClient.SaServicePublic.PriceType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WindowsFormsDedicatedClient.SaServicePublic.AdType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WindowsFormsDedicatedClient.SaServicePublic.Comment[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WindowsFormsDedicatedClient.SaServicePublic.Comment))]
    public partial class Ad : WindowsFormsDedicatedClient.SaServicePublic.Post {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object CategoriesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> EventDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ExpDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsDedicatedClient.SaServicePublic.Location LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsDedicatedClient.SaServicePublic.Price PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsDedicatedClient.SaServicePublic.User ReservedByField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsDedicatedClient.SaServicePublic.AdType TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ViewsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Categories {
            get {
                return this.CategoriesField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriesField, value) != true)) {
                    this.CategoriesField = value;
                    this.RaisePropertyChanged("Categories");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> EventDate {
            get {
                return this.EventDateField;
            }
            set {
                if ((this.EventDateField.Equals(value) != true)) {
                    this.EventDateField = value;
                    this.RaisePropertyChanged("EventDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ExpDate {
            get {
                return this.ExpDateField;
            }
            set {
                if ((this.ExpDateField.Equals(value) != true)) {
                    this.ExpDateField = value;
                    this.RaisePropertyChanged("ExpDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsDedicatedClient.SaServicePublic.Location Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsDedicatedClient.SaServicePublic.Price Price {
            get {
                return this.PriceField;
            }
            set {
                if ((object.ReferenceEquals(this.PriceField, value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsDedicatedClient.SaServicePublic.User ReservedBy {
            get {
                return this.ReservedByField;
            }
            set {
                if ((object.ReferenceEquals(this.ReservedByField, value) != true)) {
                    this.ReservedByField = value;
                    this.RaisePropertyChanged("ReservedBy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsDedicatedClient.SaServicePublic.AdType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Views {
            get {
                return this.ViewsField;
            }
            set {
                if ((this.ViewsField.Equals(value) != true)) {
                    this.ViewsField = value;
                    this.RaisePropertyChanged("Views");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Post", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WindowsFormsDedicatedClient.SaServicePublic.Comment))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WindowsFormsDedicatedClient.SaServicePublic.Ad))]
    public partial class Post : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsDedicatedClient.SaServicePublic.User AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DatePostedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageSourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> LastEditedField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsDedicatedClient.SaServicePublic.User Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DatePosted {
            get {
                return this.DatePostedField;
            }
            set {
                if ((this.DatePostedField.Equals(value) != true)) {
                    this.DatePostedField = value;
                    this.RaisePropertyChanged("DatePosted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageSource {
            get {
                return this.ImageSourceField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageSourceField, value) != true)) {
                    this.ImageSourceField = value;
                    this.RaisePropertyChanged("ImageSource");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> LastEdited {
            get {
                return this.LastEditedField;
            }
            set {
                if ((this.LastEditedField.Equals(value) != true)) {
                    this.LastEditedField = value;
                    this.RaisePropertyChanged("LastEdited");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BoostsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateRegisteredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PasswordHashField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PictureURLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ReservationsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] SaltField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Boosts {
            get {
                return this.BoostsField;
            }
            set {
                if ((this.BoostsField.Equals(value) != true)) {
                    this.BoostsField = value;
                    this.RaisePropertyChanged("Boosts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateRegistered {
            get {
                return this.DateRegisteredField;
            }
            set {
                if ((this.DateRegisteredField.Equals(value) != true)) {
                    this.DateRegisteredField = value;
                    this.RaisePropertyChanged("DateRegistered");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] PasswordHash {
            get {
                return this.PasswordHashField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordHashField, value) != true)) {
                    this.PasswordHashField = value;
                    this.RaisePropertyChanged("PasswordHash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PictureURL {
            get {
                return this.PictureURLField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureURLField, value) != true)) {
                    this.PictureURLField = value;
                    this.RaisePropertyChanged("PictureURL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Reservations {
            get {
                return this.ReservationsField;
            }
            set {
                if ((this.ReservationsField.Equals(value) != true)) {
                    this.ReservationsField = value;
                    this.RaisePropertyChanged("Reservations");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Salt {
            get {
                return this.SaltField;
            }
            set {
                if ((object.ReferenceEquals(this.SaltField, value) != true)) {
                    this.SaltField = value;
                    this.RaisePropertyChanged("Salt");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Comment", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Comment : WindowsFormsDedicatedClient.SaServicePublic.Post {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IndentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReplyIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Indent {
            get {
                return this.IndentField;
            }
            set {
                if ((this.IndentField.Equals(value) != true)) {
                    this.IndentField = value;
                    this.RaisePropertyChanged("Indent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReplyId {
            get {
                return this.ReplyIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ReplyIdField, value) != true)) {
                    this.ReplyIdField = value;
                    this.RaisePropertyChanged("ReplyId");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Location", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Location : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsDedicatedClient.SaServicePublic.Location ParentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsDedicatedClient.SaServicePublic.LocationType TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsDedicatedClient.SaServicePublic.Location Parent {
            get {
                return this.ParentField;
            }
            set {
                if ((object.ReferenceEquals(this.ParentField, value) != true)) {
                    this.ParentField = value;
                    this.RaisePropertyChanged("Parent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsDedicatedClient.SaServicePublic.LocationType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Price", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Price : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HighField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LowField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsDedicatedClient.SaServicePublic.PriceType TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int High {
            get {
                return this.HighField;
            }
            set {
                if ((this.HighField.Equals(value) != true)) {
                    this.HighField = value;
                    this.RaisePropertyChanged("High");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Low {
            get {
                return this.LowField;
            }
            set {
                if ((this.LowField.Equals(value) != true)) {
                    this.LowField = value;
                    this.RaisePropertyChanged("Low");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsDedicatedClient.SaServicePublic.PriceType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LocationType", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    public enum LocationType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Country = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Region = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        City = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Area = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Address = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PriceType", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    public enum PriceType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Range = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Free = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unspecified = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Bid = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AdType", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    public enum AdType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Other = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        All = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Selling = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Buying = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ServiceRequest = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ServiceOffer = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Event = 6,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SaServicePublic.IAuthService")]
    public interface IAuthService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Login", ReplyAction="http://tempuri.org/IAuthService/LoginResponse")]
        bool Login(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Login", ReplyAction="http://tempuri.org/IAuthService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Register", ReplyAction="http://tempuri.org/IAuthService/RegisterResponse")]
        bool Register(string email, string name, string password, string pictureUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Register", ReplyAction="http://tempuri.org/IAuthService/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(string email, string name, string password, string pictureUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/GetAds", ReplyAction="http://tempuri.org/IAuthService/GetAdsResponse")]
        WindowsFormsDedicatedClient.SaServicePublic.Ad[] GetAds(int skip, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/GetAds", ReplyAction="http://tempuri.org/IAuthService/GetAdsResponse")]
        System.Threading.Tasks.Task<WindowsFormsDedicatedClient.SaServicePublic.Ad[]> GetAdsAsync(int skip, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/GetAdsWithinLocation", ReplyAction="http://tempuri.org/IAuthService/GetAdsWithinLocationResponse")]
        WindowsFormsDedicatedClient.SaServicePublic.Ad[] GetAdsWithinLocation(int skip, int amount, string location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/GetAdsWithinLocation", ReplyAction="http://tempuri.org/IAuthService/GetAdsWithinLocationResponse")]
        System.Threading.Tasks.Task<WindowsFormsDedicatedClient.SaServicePublic.Ad[]> GetAdsWithinLocationAsync(int skip, int amount, string location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/FindAds", ReplyAction="http://tempuri.org/IAuthService/FindAdsResponse")]
        WindowsFormsDedicatedClient.SaServicePublic.Ad[] FindAds(int skip, int amount, string location, string searchQuery, WindowsFormsDedicatedClient.SaServicePublic.AdType type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/FindAds", ReplyAction="http://tempuri.org/IAuthService/FindAdsResponse")]
        System.Threading.Tasks.Task<WindowsFormsDedicatedClient.SaServicePublic.Ad[]> FindAdsAsync(int skip, int amount, string location, string searchQuery, WindowsFormsDedicatedClient.SaServicePublic.AdType type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/GetAdReplies", ReplyAction="http://tempuri.org/IAuthService/GetAdRepliesResponse")]
        WindowsFormsDedicatedClient.SaServicePublic.Comment[] GetAdReplies(int skip, int amount, string adId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/GetAdReplies", ReplyAction="http://tempuri.org/IAuthService/GetAdRepliesResponse")]
        System.Threading.Tasks.Task<WindowsFormsDedicatedClient.SaServicePublic.Comment[]> GetAdRepliesAsync(int skip, int amount, string adId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/GetAd", ReplyAction="http://tempuri.org/IAuthService/GetAdResponse")]
        WindowsFormsDedicatedClient.SaServicePublic.Ad GetAd(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/GetAd", ReplyAction="http://tempuri.org/IAuthService/GetAdResponse")]
        System.Threading.Tasks.Task<WindowsFormsDedicatedClient.SaServicePublic.Ad> GetAdAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthServiceChannel : WindowsFormsDedicatedClient.SaServicePublic.IAuthService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthServiceClient : System.ServiceModel.ClientBase<WindowsFormsDedicatedClient.SaServicePublic.IAuthService>, WindowsFormsDedicatedClient.SaServicePublic.IAuthService {
        
        public AuthServiceClient() {
        }
        
        public AuthServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Login(string email, string password) {
            return base.Channel.Login(email, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string email, string password) {
            return base.Channel.LoginAsync(email, password);
        }
        
        public bool Register(string email, string name, string password, string pictureUrl) {
            return base.Channel.Register(email, name, password, pictureUrl);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(string email, string name, string password, string pictureUrl) {
            return base.Channel.RegisterAsync(email, name, password, pictureUrl);
        }
        
        public WindowsFormsDedicatedClient.SaServicePublic.Ad[] GetAds(int skip, int amount) {
            return base.Channel.GetAds(skip, amount);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsDedicatedClient.SaServicePublic.Ad[]> GetAdsAsync(int skip, int amount) {
            return base.Channel.GetAdsAsync(skip, amount);
        }
        
        public WindowsFormsDedicatedClient.SaServicePublic.Ad[] GetAdsWithinLocation(int skip, int amount, string location) {
            return base.Channel.GetAdsWithinLocation(skip, amount, location);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsDedicatedClient.SaServicePublic.Ad[]> GetAdsWithinLocationAsync(int skip, int amount, string location) {
            return base.Channel.GetAdsWithinLocationAsync(skip, amount, location);
        }
        
        public WindowsFormsDedicatedClient.SaServicePublic.Ad[] FindAds(int skip, int amount, string location, string searchQuery, WindowsFormsDedicatedClient.SaServicePublic.AdType type) {
            return base.Channel.FindAds(skip, amount, location, searchQuery, type);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsDedicatedClient.SaServicePublic.Ad[]> FindAdsAsync(int skip, int amount, string location, string searchQuery, WindowsFormsDedicatedClient.SaServicePublic.AdType type) {
            return base.Channel.FindAdsAsync(skip, amount, location, searchQuery, type);
        }
        
        public WindowsFormsDedicatedClient.SaServicePublic.Comment[] GetAdReplies(int skip, int amount, string adId) {
            return base.Channel.GetAdReplies(skip, amount, adId);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsDedicatedClient.SaServicePublic.Comment[]> GetAdRepliesAsync(int skip, int amount, string adId) {
            return base.Channel.GetAdRepliesAsync(skip, amount, adId);
        }
        
        public WindowsFormsDedicatedClient.SaServicePublic.Ad GetAd(string id) {
            return base.Channel.GetAd(id);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsDedicatedClient.SaServicePublic.Ad> GetAdAsync(string id) {
            return base.Channel.GetAdAsync(id);
        }
    }
}
