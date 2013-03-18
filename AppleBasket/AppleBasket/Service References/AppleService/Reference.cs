﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace AppleBasket.AppleService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TableServiceEntity", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.StorageClient")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(AppleBasket.AppleService.Apple))]
    public partial class TableServiceEntity : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string PartitionKeyField;
        
        private string RowKeyField;
        
        private System.DateTime TimestampField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PartitionKey {
            get {
                return this.PartitionKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.PartitionKeyField, value) != true)) {
                    this.PartitionKeyField = value;
                    this.RaisePropertyChanged("PartitionKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RowKey {
            get {
                return this.RowKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.RowKeyField, value) != true)) {
                    this.RowKeyField = value;
                    this.RaisePropertyChanged("RowKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Timestamp {
            get {
                return this.TimestampField;
            }
            set {
                if ((this.TimestampField.Equals(value) != true)) {
                    this.TimestampField = value;
                    this.RaisePropertyChanged("Timestamp");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Apple", Namespace="http://schemas.datacontract.org/2004/07/AppleService")]
    public partial class Apple : AppleBasket.AppleService.TableServiceEntity {
        
        private int AppleCountField;
        
        private int Applecount1Field;
        
        private double LatitudeField;
        
        private double LongitudeField;
        
        private bool ReservedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AppleCount {
            get {
                return this.AppleCountField;
            }
            set {
                if ((this.AppleCountField.Equals(value) != true)) {
                    this.AppleCountField = value;
                    this.RaisePropertyChanged("AppleCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Applecount")]
        public int Applecount1 {
            get {
                return this.Applecount1Field;
            }
            set {
                if ((this.Applecount1Field.Equals(value) != true)) {
                    this.Applecount1Field = value;
                    this.RaisePropertyChanged("Applecount1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Latitude {
            get {
                return this.LatitudeField;
            }
            set {
                if ((this.LatitudeField.Equals(value) != true)) {
                    this.LatitudeField = value;
                    this.RaisePropertyChanged("Latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Longitude {
            get {
                return this.LongitudeField;
            }
            set {
                if ((this.LongitudeField.Equals(value) != true)) {
                    this.LongitudeField = value;
                    this.RaisePropertyChanged("Longitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Reserved {
            get {
                return this.ReservedField;
            }
            set {
                if ((this.ReservedField.Equals(value) != true)) {
                    this.ReservedField = value;
                    this.RaisePropertyChanged("Reserved");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AppleService.IAppleService")]
    public interface IAppleService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IAppleService/AddApple", ReplyAction="http://tempuri.org/IAppleService/AddAppleResponse")]
        System.IAsyncResult BeginAddApple(AppleBasket.AppleService.Apple apple, System.AsyncCallback callback, object asyncState);
        
        bool EndAddApple(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IAppleService/ReserveApple", ReplyAction="http://tempuri.org/IAppleService/ReserveAppleResponse")]
        System.IAsyncResult BeginReserveApple(AppleBasket.AppleService.Apple apple, System.AsyncCallback callback, object asyncState);
        
        bool EndReserveApple(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IAppleService/AddSubscription", ReplyAction="http://tempuri.org/IAppleService/AddSubscriptionResponse")]
        System.IAsyncResult BeginAddSubscription(string subscription, System.AsyncCallback callback, object asyncState);
        
        bool EndAddSubscription(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IAppleService/GetApples", ReplyAction="http://tempuri.org/IAppleService/GetApplesResponse")]
        System.IAsyncResult BeginGetApples(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<AppleBasket.AppleService.Apple> EndGetApples(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAppleServiceChannel : AppleBasket.AppleService.IAppleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddAppleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public AddAppleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReserveAppleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ReserveAppleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddSubscriptionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public AddSubscriptionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetApplesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetApplesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<AppleBasket.AppleService.Apple> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<AppleBasket.AppleService.Apple>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AppleServiceClient : System.ServiceModel.ClientBase<AppleBasket.AppleService.IAppleService>, AppleBasket.AppleService.IAppleService {
        
        private BeginOperationDelegate onBeginAddAppleDelegate;
        
        private EndOperationDelegate onEndAddAppleDelegate;
        
        private System.Threading.SendOrPostCallback onAddAppleCompletedDelegate;
        
        private BeginOperationDelegate onBeginReserveAppleDelegate;
        
        private EndOperationDelegate onEndReserveAppleDelegate;
        
        private System.Threading.SendOrPostCallback onReserveAppleCompletedDelegate;
        
        private BeginOperationDelegate onBeginAddSubscriptionDelegate;
        
        private EndOperationDelegate onEndAddSubscriptionDelegate;
        
        private System.Threading.SendOrPostCallback onAddSubscriptionCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetApplesDelegate;
        
        private EndOperationDelegate onEndGetApplesDelegate;
        
        private System.Threading.SendOrPostCallback onGetApplesCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public AppleServiceClient() {
        }
        
        public AppleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AppleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<AddAppleCompletedEventArgs> AddAppleCompleted;
        
        public event System.EventHandler<ReserveAppleCompletedEventArgs> ReserveAppleCompleted;
        
        public event System.EventHandler<AddSubscriptionCompletedEventArgs> AddSubscriptionCompleted;
        
        public event System.EventHandler<GetApplesCompletedEventArgs> GetApplesCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult AppleBasket.AppleService.IAppleService.BeginAddApple(AppleBasket.AppleService.Apple apple, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAddApple(apple, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool AppleBasket.AppleService.IAppleService.EndAddApple(System.IAsyncResult result) {
            return base.Channel.EndAddApple(result);
        }
        
        private System.IAsyncResult OnBeginAddApple(object[] inValues, System.AsyncCallback callback, object asyncState) {
            AppleBasket.AppleService.Apple apple = ((AppleBasket.AppleService.Apple)(inValues[0]));
            return ((AppleBasket.AppleService.IAppleService)(this)).BeginAddApple(apple, callback, asyncState);
        }
        
        private object[] OnEndAddApple(System.IAsyncResult result) {
            bool retVal = ((AppleBasket.AppleService.IAppleService)(this)).EndAddApple(result);
            return new object[] {
                    retVal};
        }
        
        private void OnAddAppleCompleted(object state) {
            if ((this.AddAppleCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.AddAppleCompleted(this, new AddAppleCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void AddAppleAsync(AppleBasket.AppleService.Apple apple) {
            this.AddAppleAsync(apple, null);
        }
        
        public void AddAppleAsync(AppleBasket.AppleService.Apple apple, object userState) {
            if ((this.onBeginAddAppleDelegate == null)) {
                this.onBeginAddAppleDelegate = new BeginOperationDelegate(this.OnBeginAddApple);
            }
            if ((this.onEndAddAppleDelegate == null)) {
                this.onEndAddAppleDelegate = new EndOperationDelegate(this.OnEndAddApple);
            }
            if ((this.onAddAppleCompletedDelegate == null)) {
                this.onAddAppleCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAddAppleCompleted);
            }
            base.InvokeAsync(this.onBeginAddAppleDelegate, new object[] {
                        apple}, this.onEndAddAppleDelegate, this.onAddAppleCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult AppleBasket.AppleService.IAppleService.BeginReserveApple(AppleBasket.AppleService.Apple apple, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginReserveApple(apple, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool AppleBasket.AppleService.IAppleService.EndReserveApple(System.IAsyncResult result) {
            return base.Channel.EndReserveApple(result);
        }
        
        private System.IAsyncResult OnBeginReserveApple(object[] inValues, System.AsyncCallback callback, object asyncState) {
            AppleBasket.AppleService.Apple apple = ((AppleBasket.AppleService.Apple)(inValues[0]));
            return ((AppleBasket.AppleService.IAppleService)(this)).BeginReserveApple(apple, callback, asyncState);
        }
        
        private object[] OnEndReserveApple(System.IAsyncResult result) {
            bool retVal = ((AppleBasket.AppleService.IAppleService)(this)).EndReserveApple(result);
            return new object[] {
                    retVal};
        }
        
        private void OnReserveAppleCompleted(object state) {
            if ((this.ReserveAppleCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ReserveAppleCompleted(this, new ReserveAppleCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ReserveAppleAsync(AppleBasket.AppleService.Apple apple) {
            this.ReserveAppleAsync(apple, null);
        }
        
        public void ReserveAppleAsync(AppleBasket.AppleService.Apple apple, object userState) {
            if ((this.onBeginReserveAppleDelegate == null)) {
                this.onBeginReserveAppleDelegate = new BeginOperationDelegate(this.OnBeginReserveApple);
            }
            if ((this.onEndReserveAppleDelegate == null)) {
                this.onEndReserveAppleDelegate = new EndOperationDelegate(this.OnEndReserveApple);
            }
            if ((this.onReserveAppleCompletedDelegate == null)) {
                this.onReserveAppleCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnReserveAppleCompleted);
            }
            base.InvokeAsync(this.onBeginReserveAppleDelegate, new object[] {
                        apple}, this.onEndReserveAppleDelegate, this.onReserveAppleCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult AppleBasket.AppleService.IAppleService.BeginAddSubscription(string subscription, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAddSubscription(subscription, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool AppleBasket.AppleService.IAppleService.EndAddSubscription(System.IAsyncResult result) {
            return base.Channel.EndAddSubscription(result);
        }
        
        private System.IAsyncResult OnBeginAddSubscription(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string subscription = ((string)(inValues[0]));
            return ((AppleBasket.AppleService.IAppleService)(this)).BeginAddSubscription(subscription, callback, asyncState);
        }
        
        private object[] OnEndAddSubscription(System.IAsyncResult result) {
            bool retVal = ((AppleBasket.AppleService.IAppleService)(this)).EndAddSubscription(result);
            return new object[] {
                    retVal};
        }
        
        private void OnAddSubscriptionCompleted(object state) {
            if ((this.AddSubscriptionCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.AddSubscriptionCompleted(this, new AddSubscriptionCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void AddSubscriptionAsync(string subscription) {
            this.AddSubscriptionAsync(subscription, null);
        }
        
        public void AddSubscriptionAsync(string subscription, object userState) {
            if ((this.onBeginAddSubscriptionDelegate == null)) {
                this.onBeginAddSubscriptionDelegate = new BeginOperationDelegate(this.OnBeginAddSubscription);
            }
            if ((this.onEndAddSubscriptionDelegate == null)) {
                this.onEndAddSubscriptionDelegate = new EndOperationDelegate(this.OnEndAddSubscription);
            }
            if ((this.onAddSubscriptionCompletedDelegate == null)) {
                this.onAddSubscriptionCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAddSubscriptionCompleted);
            }
            base.InvokeAsync(this.onBeginAddSubscriptionDelegate, new object[] {
                        subscription}, this.onEndAddSubscriptionDelegate, this.onAddSubscriptionCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult AppleBasket.AppleService.IAppleService.BeginGetApples(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetApples(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<AppleBasket.AppleService.Apple> AppleBasket.AppleService.IAppleService.EndGetApples(System.IAsyncResult result) {
            return base.Channel.EndGetApples(result);
        }
        
        private System.IAsyncResult OnBeginGetApples(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((AppleBasket.AppleService.IAppleService)(this)).BeginGetApples(callback, asyncState);
        }
        
        private object[] OnEndGetApples(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<AppleBasket.AppleService.Apple> retVal = ((AppleBasket.AppleService.IAppleService)(this)).EndGetApples(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetApplesCompleted(object state) {
            if ((this.GetApplesCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetApplesCompleted(this, new GetApplesCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetApplesAsync() {
            this.GetApplesAsync(null);
        }
        
        public void GetApplesAsync(object userState) {
            if ((this.onBeginGetApplesDelegate == null)) {
                this.onBeginGetApplesDelegate = new BeginOperationDelegate(this.OnBeginGetApples);
            }
            if ((this.onEndGetApplesDelegate == null)) {
                this.onEndGetApplesDelegate = new EndOperationDelegate(this.OnEndGetApples);
            }
            if ((this.onGetApplesCompletedDelegate == null)) {
                this.onGetApplesCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetApplesCompleted);
            }
            base.InvokeAsync(this.onBeginGetApplesDelegate, null, this.onEndGetApplesDelegate, this.onGetApplesCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override AppleBasket.AppleService.IAppleService CreateChannel() {
            return new AppleServiceClientChannel(this);
        }
        
        private class AppleServiceClientChannel : ChannelBase<AppleBasket.AppleService.IAppleService>, AppleBasket.AppleService.IAppleService {
            
            public AppleServiceClientChannel(System.ServiceModel.ClientBase<AppleBasket.AppleService.IAppleService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginAddApple(AppleBasket.AppleService.Apple apple, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = apple;
                System.IAsyncResult _result = base.BeginInvoke("AddApple", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndAddApple(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("AddApple", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginReserveApple(AppleBasket.AppleService.Apple apple, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = apple;
                System.IAsyncResult _result = base.BeginInvoke("ReserveApple", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndReserveApple(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("ReserveApple", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginAddSubscription(string subscription, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = subscription;
                System.IAsyncResult _result = base.BeginInvoke("AddSubscription", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndAddSubscription(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("AddSubscription", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetApples(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetApples", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<AppleBasket.AppleService.Apple> EndGetApples(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<AppleBasket.AppleService.Apple> _result = ((System.Collections.ObjectModel.ObservableCollection<AppleBasket.AppleService.Apple>)(base.EndInvoke("GetApples", _args, result)));
                return _result;
            }
        }
    }
}
