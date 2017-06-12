﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace AnperoFrontend.WebService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AnperoServiceSoap", Namespace="http://tempuri.org/")]
    public partial class AnperoService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetCommonConfigOperationCompleted;
        
        private System.Threading.SendOrPostCallback SearchProductOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSaleProductOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetProductDetaiOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AnperoService() {
            this.Url = global::AnperoFrontend.Properties.Settings.Default.AnperoFrontend_AnperoService_AnperoService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetCommonConfigCompletedEventHandler GetCommonConfigCompleted;
        
        /// <remarks/>
        public event SearchProductCompletedEventHandler SearchProductCompleted;
        
        /// <remarks/>
        public event GetSaleProductCompletedEventHandler GetSaleProductCompleted;
        
        /// <remarks/>
        public event GetProductDetaiCompletedEventHandler GetProductDetaiCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCommonConfig", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Webconfig GetCommonConfig(int storeId, string tokenKey) {
            object[] results = this.Invoke("GetCommonConfig", new object[] {
                        storeId,
                        tokenKey});
            return ((Webconfig)(results[0]));
        }
        
        /// <remarks/>
        public void GetCommonConfigAsync(int storeId, string tokenKey) {
            this.GetCommonConfigAsync(storeId, tokenKey, null);
        }
        
        /// <remarks/>
        public void GetCommonConfigAsync(int storeId, string tokenKey, object userState) {
            if ((this.GetCommonConfigOperationCompleted == null)) {
                this.GetCommonConfigOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCommonConfigOperationCompleted);
            }
            this.InvokeAsync("GetCommonConfig", new object[] {
                        storeId,
                        tokenKey}, this.GetCommonConfigOperationCompleted, userState);
        }
        
        private void OnGetCommonConfigOperationCompleted(object arg) {
            if ((this.GetCommonConfigCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCommonConfigCompleted(this, new GetCommonConfigCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SearchProduct", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SearchResult SearchProduct(int storeId, string tokenKey, string CategoryId, string parentCategoryId, string originId, int priceFrom, int priceTo, int curentPage, int pageSite, string keyWord, string order, int minPrioty) {
            object[] results = this.Invoke("SearchProduct", new object[] {
                        storeId,
                        tokenKey,
                        CategoryId,
                        parentCategoryId,
                        originId,
                        priceFrom,
                        priceTo,
                        curentPage,
                        pageSite,
                        keyWord,
                        order,
                        minPrioty});
            return ((SearchResult)(results[0]));
        }
        
        /// <remarks/>
        public void SearchProductAsync(int storeId, string tokenKey, string CategoryId, string parentCategoryId, string originId, int priceFrom, int priceTo, int curentPage, int pageSite, string keyWord, string order, int minPrioty) {
            this.SearchProductAsync(storeId, tokenKey, CategoryId, parentCategoryId, originId, priceFrom, priceTo, curentPage, pageSite, keyWord, order, minPrioty, null);
        }
        
        /// <remarks/>
        public void SearchProductAsync(int storeId, string tokenKey, string CategoryId, string parentCategoryId, string originId, int priceFrom, int priceTo, int curentPage, int pageSite, string keyWord, string order, int minPrioty, object userState) {
            if ((this.SearchProductOperationCompleted == null)) {
                this.SearchProductOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchProductOperationCompleted);
            }
            this.InvokeAsync("SearchProduct", new object[] {
                        storeId,
                        tokenKey,
                        CategoryId,
                        parentCategoryId,
                        originId,
                        priceFrom,
                        priceTo,
                        curentPage,
                        pageSite,
                        keyWord,
                        order,
                        minPrioty}, this.SearchProductOperationCompleted, userState);
        }
        
        private void OnSearchProductOperationCompleted(object arg) {
            if ((this.SearchProductCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchProductCompleted(this, new SearchProductCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSaleProduct", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ProductItem[] GetSaleProduct(int storeId, string tokenKey) {
            object[] results = this.Invoke("GetSaleProduct", new object[] {
                        storeId,
                        tokenKey});
            return ((ProductItem[])(results[0]));
        }
        
        /// <remarks/>
        public void GetSaleProductAsync(int storeId, string tokenKey) {
            this.GetSaleProductAsync(storeId, tokenKey, null);
        }
        
        /// <remarks/>
        public void GetSaleProductAsync(int storeId, string tokenKey, object userState) {
            if ((this.GetSaleProductOperationCompleted == null)) {
                this.GetSaleProductOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSaleProductOperationCompleted);
            }
            this.InvokeAsync("GetSaleProduct", new object[] {
                        storeId,
                        tokenKey}, this.GetSaleProductOperationCompleted, userState);
        }
        
        private void OnGetSaleProductOperationCompleted(object arg) {
            if ((this.GetSaleProductCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSaleProductCompleted(this, new GetSaleProductCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetProductDetai", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ProductItem GetProductDetai(int storeId, string tokenKey, int id) {
            object[] results = this.Invoke("GetProductDetai", new object[] {
                        storeId,
                        tokenKey,
                        id});
            return ((ProductItem)(results[0]));
        }
        
        /// <remarks/>
        public void GetProductDetaiAsync(int storeId, string tokenKey, int id) {
            this.GetProductDetaiAsync(storeId, tokenKey, id, null);
        }
        
        /// <remarks/>
        public void GetProductDetaiAsync(int storeId, string tokenKey, int id, object userState) {
            if ((this.GetProductDetaiOperationCompleted == null)) {
                this.GetProductDetaiOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductDetaiOperationCompleted);
            }
            this.InvokeAsync("GetProductDetai", new object[] {
                        storeId,
                        tokenKey,
                        id}, this.GetProductDetaiOperationCompleted, userState);
        }
        
        private void OnGetProductDetaiOperationCompleted(object arg) {
            if ((this.GetProductDetaiCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductDetaiCompleted(this, new GetProductDetaiCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Webconfig {
        
        private Menu[] menuListField;
        
        private string faceBookLinkField;
        
        private string skypeField;
        
        private string hotLineField;
        
        private string pageScriptField;
        
        private string footerField;
        
        private string logoField;
        
        private string descField;
        
        private ProductCategory[] productCategoryListField;
        
        private string emailField;
        
        private string addressField;
        
        /// <remarks/>
        public Menu[] MenuList {
            get {
                return this.menuListField;
            }
            set {
                this.menuListField = value;
            }
        }
        
        /// <remarks/>
        public string FaceBookLink {
            get {
                return this.faceBookLinkField;
            }
            set {
                this.faceBookLinkField = value;
            }
        }
        
        /// <remarks/>
        public string Skype {
            get {
                return this.skypeField;
            }
            set {
                this.skypeField = value;
            }
        }
        
        /// <remarks/>
        public string HotLine {
            get {
                return this.hotLineField;
            }
            set {
                this.hotLineField = value;
            }
        }
        
        /// <remarks/>
        public string PageScript {
            get {
                return this.pageScriptField;
            }
            set {
                this.pageScriptField = value;
            }
        }
        
        /// <remarks/>
        public string Footer {
            get {
                return this.footerField;
            }
            set {
                this.footerField = value;
            }
        }
        
        /// <remarks/>
        public string Logo {
            get {
                return this.logoField;
            }
            set {
                this.logoField = value;
            }
        }
        
        /// <remarks/>
        public string Desc {
            get {
                return this.descField;
            }
            set {
                this.descField = value;
            }
        }
        
        /// <remarks/>
        public ProductCategory[] ProductCategoryList {
            get {
                return this.productCategoryListField;
            }
            set {
                this.productCategoryListField = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Menu {
        
        private Menu[] chidMenuField;
        
        private int idField;
        
        private string linkField;
        
        private int parentIdField;
        
        private int priotyField;
        
        private string tittleField;
        
        /// <remarks/>
        public Menu[] ChidMenu {
            get {
                return this.chidMenuField;
            }
            set {
                this.chidMenuField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Link {
            get {
                return this.linkField;
            }
            set {
                this.linkField = value;
            }
        }
        
        /// <remarks/>
        public int ParentId {
            get {
                return this.parentIdField;
            }
            set {
                this.parentIdField = value;
            }
        }
        
        /// <remarks/>
        public int Prioty {
            get {
                return this.priotyField;
            }
            set {
                this.priotyField = value;
            }
        }
        
        /// <remarks/>
        public string Tittle {
            get {
                return this.tittleField;
            }
            set {
                this.tittleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ProductItem {
        
        private int originIDField;
        
        private string catNameField;
        
        private int parentIdField;
        
        private decimal salePriceField;
        
        private decimal priceField;
        
        private string updateTimeField;
        
        private string originNameField;
        
        private string imagesField;
        
        private string detailField;
        
        private string prNameField;
        
        private int catIDField;
        
        private string parentCatNameField;
        
        private int warrantyField;
        
        private int idField;
        
        private bool isSaleField;
        
        private int rankField;
        
        private string shortDescField;
        
        private string saleEndTimeField;
        
        private string scriptField;
        
        private string keyWordField;
        
        private bool isInstockField;
        
        private string[] imagesSlideField;
        
        /// <remarks/>
        public int OriginID {
            get {
                return this.originIDField;
            }
            set {
                this.originIDField = value;
            }
        }
        
        /// <remarks/>
        public string CatName {
            get {
                return this.catNameField;
            }
            set {
                this.catNameField = value;
            }
        }
        
        /// <remarks/>
        public int ParentId {
            get {
                return this.parentIdField;
            }
            set {
                this.parentIdField = value;
            }
        }
        
        /// <remarks/>
        public decimal SalePrice {
            get {
                return this.salePriceField;
            }
            set {
                this.salePriceField = value;
            }
        }
        
        /// <remarks/>
        public decimal Price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        public string UpdateTime {
            get {
                return this.updateTimeField;
            }
            set {
                this.updateTimeField = value;
            }
        }
        
        /// <remarks/>
        public string OriginName {
            get {
                return this.originNameField;
            }
            set {
                this.originNameField = value;
            }
        }
        
        /// <remarks/>
        public string Images {
            get {
                return this.imagesField;
            }
            set {
                this.imagesField = value;
            }
        }
        
        /// <remarks/>
        public string Detail {
            get {
                return this.detailField;
            }
            set {
                this.detailField = value;
            }
        }
        
        /// <remarks/>
        public string PrName {
            get {
                return this.prNameField;
            }
            set {
                this.prNameField = value;
            }
        }
        
        /// <remarks/>
        public int CatID {
            get {
                return this.catIDField;
            }
            set {
                this.catIDField = value;
            }
        }
        
        /// <remarks/>
        public string ParentCatName {
            get {
                return this.parentCatNameField;
            }
            set {
                this.parentCatNameField = value;
            }
        }
        
        /// <remarks/>
        public int Warranty {
            get {
                return this.warrantyField;
            }
            set {
                this.warrantyField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public bool IsSale {
            get {
                return this.isSaleField;
            }
            set {
                this.isSaleField = value;
            }
        }
        
        /// <remarks/>
        public int Rank {
            get {
                return this.rankField;
            }
            set {
                this.rankField = value;
            }
        }
        
        /// <remarks/>
        public string ShortDesc {
            get {
                return this.shortDescField;
            }
            set {
                this.shortDescField = value;
            }
        }
        
        /// <remarks/>
        public string SaleEndTime {
            get {
                return this.saleEndTimeField;
            }
            set {
                this.saleEndTimeField = value;
            }
        }
        
        /// <remarks/>
        public string Script {
            get {
                return this.scriptField;
            }
            set {
                this.scriptField = value;
            }
        }
        
        /// <remarks/>
        public string KeyWord {
            get {
                return this.keyWordField;
            }
            set {
                this.keyWordField = value;
            }
        }
        
        /// <remarks/>
        public bool IsInstock {
            get {
                return this.isInstockField;
            }
            set {
                this.isInstockField = value;
            }
        }
        
        /// <remarks/>
        public string[] ImagesSlide {
            get {
                return this.imagesSlideField;
            }
            set {
                this.imagesSlideField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SearchResult {
        
        private ProductItem[] itemField;
        
        private int resultCountField;
        
        /// <remarks/>
        public ProductItem[] Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        public int ResultCount {
            get {
                return this.resultCountField;
            }
            set {
                this.resultCountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ProductCategory {
        
        private string nameField;
        
        private int idField;
        
        private ProductCategory[] childCategoryField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public ProductCategory[] ChildCategory {
            get {
                return this.childCategoryField;
            }
            set {
                this.childCategoryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetCommonConfigCompletedEventHandler(object sender, GetCommonConfigCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCommonConfigCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCommonConfigCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Webconfig Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Webconfig)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void SearchProductCompletedEventHandler(object sender, SearchProductCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchProductCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchProductCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SearchResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SearchResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetSaleProductCompletedEventHandler(object sender, GetSaleProductCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSaleProductCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSaleProductCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProductItem[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProductItem[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetProductDetaiCompletedEventHandler(object sender, GetProductDetaiCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductDetaiCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProductDetaiCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProductItem Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProductItem)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591