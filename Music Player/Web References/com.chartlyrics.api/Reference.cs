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

namespace Music_Player.com.chartlyrics.api {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="apiv1Soap", Namespace="http://api.chartlyrics.com/")]
    public partial class apiv1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SearchLyricOperationCompleted;
        
        private System.Threading.SendOrPostCallback SearchLyricTextOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetLyricOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddLyricOperationCompleted;
        
        private System.Threading.SendOrPostCallback SearchLyricDirectOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public apiv1() {
            this.Url = global::Music_Player.Properties.Settings.Default.Music_Player_com_chartlyrics_api_apiv1;
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
        public event SearchLyricCompletedEventHandler SearchLyricCompleted;
        
        /// <remarks/>
        public event SearchLyricTextCompletedEventHandler SearchLyricTextCompleted;
        
        /// <remarks/>
        public event GetLyricCompletedEventHandler GetLyricCompleted;
        
        /// <remarks/>
        public event AddLyricCompletedEventHandler AddLyricCompleted;
        
        /// <remarks/>
        public event SearchLyricDirectCompletedEventHandler SearchLyricDirectCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://api.chartlyrics.com/SearchLyric", RequestNamespace="http://api.chartlyrics.com/", ResponseNamespace="http://api.chartlyrics.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SearchLyricResult[] SearchLyric(string artist, string song) {
            object[] results = this.Invoke("SearchLyric", new object[] {
                        artist,
                        song});
            return ((SearchLyricResult[])(results[0]));
        }
        
        /// <remarks/>
        public void SearchLyricAsync(string artist, string song) {
            this.SearchLyricAsync(artist, song, null);
        }
        
        /// <remarks/>
        public void SearchLyricAsync(string artist, string song, object userState) {
            if ((this.SearchLyricOperationCompleted == null)) {
                this.SearchLyricOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchLyricOperationCompleted);
            }
            this.InvokeAsync("SearchLyric", new object[] {
                        artist,
                        song}, this.SearchLyricOperationCompleted, userState);
        }
        
        private void OnSearchLyricOperationCompleted(object arg) {
            if ((this.SearchLyricCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchLyricCompleted(this, new SearchLyricCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://api.chartlyrics.com/SearchLyricText", RequestNamespace="http://api.chartlyrics.com/", ResponseNamespace="http://api.chartlyrics.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SearchLyricResult[] SearchLyricText(string lyricText) {
            object[] results = this.Invoke("SearchLyricText", new object[] {
                        lyricText});
            return ((SearchLyricResult[])(results[0]));
        }
        
        /// <remarks/>
        public void SearchLyricTextAsync(string lyricText) {
            this.SearchLyricTextAsync(lyricText, null);
        }
        
        /// <remarks/>
        public void SearchLyricTextAsync(string lyricText, object userState) {
            if ((this.SearchLyricTextOperationCompleted == null)) {
                this.SearchLyricTextOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchLyricTextOperationCompleted);
            }
            this.InvokeAsync("SearchLyricText", new object[] {
                        lyricText}, this.SearchLyricTextOperationCompleted, userState);
        }
        
        private void OnSearchLyricTextOperationCompleted(object arg) {
            if ((this.SearchLyricTextCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchLyricTextCompleted(this, new SearchLyricTextCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://api.chartlyrics.com/GetLyric", RequestNamespace="http://api.chartlyrics.com/", ResponseNamespace="http://api.chartlyrics.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GetLyricResult GetLyric(int lyricId, string lyricCheckSum) {
            object[] results = this.Invoke("GetLyric", new object[] {
                        lyricId,
                        lyricCheckSum});
            return ((GetLyricResult)(results[0]));
        }
        
        /// <remarks/>
        public void GetLyricAsync(int lyricId, string lyricCheckSum) {
            this.GetLyricAsync(lyricId, lyricCheckSum, null);
        }
        
        /// <remarks/>
        public void GetLyricAsync(int lyricId, string lyricCheckSum, object userState) {
            if ((this.GetLyricOperationCompleted == null)) {
                this.GetLyricOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetLyricOperationCompleted);
            }
            this.InvokeAsync("GetLyric", new object[] {
                        lyricId,
                        lyricCheckSum}, this.GetLyricOperationCompleted, userState);
        }
        
        private void OnGetLyricOperationCompleted(object arg) {
            if ((this.GetLyricCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetLyricCompleted(this, new GetLyricCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://api.chartlyrics.com/AddLyric", RequestNamespace="http://api.chartlyrics.com/", ResponseNamespace="http://api.chartlyrics.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddLyric(int trackId, string trackCheckSum, string lyric, string email) {
            object[] results = this.Invoke("AddLyric", new object[] {
                        trackId,
                        trackCheckSum,
                        lyric,
                        email});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddLyricAsync(int trackId, string trackCheckSum, string lyric, string email) {
            this.AddLyricAsync(trackId, trackCheckSum, lyric, email, null);
        }
        
        /// <remarks/>
        public void AddLyricAsync(int trackId, string trackCheckSum, string lyric, string email, object userState) {
            if ((this.AddLyricOperationCompleted == null)) {
                this.AddLyricOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddLyricOperationCompleted);
            }
            this.InvokeAsync("AddLyric", new object[] {
                        trackId,
                        trackCheckSum,
                        lyric,
                        email}, this.AddLyricOperationCompleted, userState);
        }
        
        private void OnAddLyricOperationCompleted(object arg) {
            if ((this.AddLyricCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddLyricCompleted(this, new AddLyricCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://api.chartlyrics.com/SearchLyricDirect", RequestNamespace="http://api.chartlyrics.com/", ResponseNamespace="http://api.chartlyrics.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GetLyricResult SearchLyricDirect(string artist, string song) {
            object[] results = this.Invoke("SearchLyricDirect", new object[] {
                        artist,
                        song});
            return ((GetLyricResult)(results[0]));
        }
        
        /// <remarks/>
        public void SearchLyricDirectAsync(string artist, string song) {
            this.SearchLyricDirectAsync(artist, song, null);
        }
        
        /// <remarks/>
        public void SearchLyricDirectAsync(string artist, string song, object userState) {
            if ((this.SearchLyricDirectOperationCompleted == null)) {
                this.SearchLyricDirectOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSearchLyricDirectOperationCompleted);
            }
            this.InvokeAsync("SearchLyricDirect", new object[] {
                        artist,
                        song}, this.SearchLyricDirectOperationCompleted, userState);
        }
        
        private void OnSearchLyricDirectOperationCompleted(object arg) {
            if ((this.SearchLyricDirectCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SearchLyricDirectCompleted(this, new SearchLyricDirectCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.chartlyrics.com/")]
    public partial class SearchLyricResult {
        
        private string trackChecksumField;
        
        private int trackIdField;
        
        private string lyricChecksumField;
        
        private int lyricIdField;
        
        private string songUrlField;
        
        private string artistUrlField;
        
        private string artistField;
        
        private string songField;
        
        private int songRankField;
        
        /// <remarks/>
        public string TrackChecksum {
            get {
                return this.trackChecksumField;
            }
            set {
                this.trackChecksumField = value;
            }
        }
        
        /// <remarks/>
        public int TrackId {
            get {
                return this.trackIdField;
            }
            set {
                this.trackIdField = value;
            }
        }
        
        /// <remarks/>
        public string LyricChecksum {
            get {
                return this.lyricChecksumField;
            }
            set {
                this.lyricChecksumField = value;
            }
        }
        
        /// <remarks/>
        public int LyricId {
            get {
                return this.lyricIdField;
            }
            set {
                this.lyricIdField = value;
            }
        }
        
        /// <remarks/>
        public string SongUrl {
            get {
                return this.songUrlField;
            }
            set {
                this.songUrlField = value;
            }
        }
        
        /// <remarks/>
        public string ArtistUrl {
            get {
                return this.artistUrlField;
            }
            set {
                this.artistUrlField = value;
            }
        }
        
        /// <remarks/>
        public string Artist {
            get {
                return this.artistField;
            }
            set {
                this.artistField = value;
            }
        }
        
        /// <remarks/>
        public string Song {
            get {
                return this.songField;
            }
            set {
                this.songField = value;
            }
        }
        
        /// <remarks/>
        public int SongRank {
            get {
                return this.songRankField;
            }
            set {
                this.songRankField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.chartlyrics.com/")]
    public partial class GetLyricResult {
        
        private string trackChecksumField;
        
        private int trackIdField;
        
        private string lyricChecksumField;
        
        private int lyricIdField;
        
        private string lyricSongField;
        
        private string lyricArtistField;
        
        private string lyricUrlField;
        
        private string lyricCovertArtUrlField;
        
        private int lyricRankField;
        
        private string lyricCorrectUrlField;
        
        private string lyricField;
        
        /// <remarks/>
        public string TrackChecksum {
            get {
                return this.trackChecksumField;
            }
            set {
                this.trackChecksumField = value;
            }
        }
        
        /// <remarks/>
        public int TrackId {
            get {
                return this.trackIdField;
            }
            set {
                this.trackIdField = value;
            }
        }
        
        /// <remarks/>
        public string LyricChecksum {
            get {
                return this.lyricChecksumField;
            }
            set {
                this.lyricChecksumField = value;
            }
        }
        
        /// <remarks/>
        public int LyricId {
            get {
                return this.lyricIdField;
            }
            set {
                this.lyricIdField = value;
            }
        }
        
        /// <remarks/>
        public string LyricSong {
            get {
                return this.lyricSongField;
            }
            set {
                this.lyricSongField = value;
            }
        }
        
        /// <remarks/>
        public string LyricArtist {
            get {
                return this.lyricArtistField;
            }
            set {
                this.lyricArtistField = value;
            }
        }
        
        /// <remarks/>
        public string LyricUrl {
            get {
                return this.lyricUrlField;
            }
            set {
                this.lyricUrlField = value;
            }
        }
        
        /// <remarks/>
        public string LyricCovertArtUrl {
            get {
                return this.lyricCovertArtUrlField;
            }
            set {
                this.lyricCovertArtUrlField = value;
            }
        }
        
        /// <remarks/>
        public int LyricRank {
            get {
                return this.lyricRankField;
            }
            set {
                this.lyricRankField = value;
            }
        }
        
        /// <remarks/>
        public string LyricCorrectUrl {
            get {
                return this.lyricCorrectUrlField;
            }
            set {
                this.lyricCorrectUrlField = value;
            }
        }
        
        /// <remarks/>
        public string Lyric {
            get {
                return this.lyricField;
            }
            set {
                this.lyricField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void SearchLyricCompletedEventHandler(object sender, SearchLyricCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchLyricCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchLyricCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SearchLyricResult[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SearchLyricResult[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void SearchLyricTextCompletedEventHandler(object sender, SearchLyricTextCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchLyricTextCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchLyricTextCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SearchLyricResult[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SearchLyricResult[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetLyricCompletedEventHandler(object sender, GetLyricCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetLyricCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetLyricCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetLyricResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetLyricResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void AddLyricCompletedEventHandler(object sender, AddLyricCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddLyricCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddLyricCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void SearchLyricDirectCompletedEventHandler(object sender, SearchLyricDirectCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SearchLyricDirectCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SearchLyricDirectCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetLyricResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetLyricResult)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591