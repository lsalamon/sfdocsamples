﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.3615
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace Fwk.SocialNetworks.Facebook { 
    using System.Xml.Serialization;
    
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://api.facebook.com/1.0/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://api.facebook.com/1.0/", IsNullable=false)]
    public partial class fql_query_response {
        
        private stream_post[] stream_postField;
        
        private user userField;
         
        private comment[] commentField;
        
        private thread[] threadField;
        
        private message[] messageField;
        
        private page pageField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("stream_post")]
        public stream_post[] stream_post {
            get {
                return this.stream_postField;
            }
            set {
                this.stream_postField = value;
            }
        }
        
        /// <comentarios/>
        public user user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("comment")]
        public comment[] comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("thread")]
        public thread[] thread {
            get {
                return this.threadField;
            }
            set {
                this.threadField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public message[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <comentarios/>
        public page page {
            get {
                return this.pageField;
            }
            set {
                this.pageField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.facebook.com/1.0/")]
    public partial class stream_post {
        
        private string updated_timeField;
        
        private string post_idField;
        
        private string created_timeField;
        
        private string actor_idField;
        
        private string target_idField;
        
        private string permalinkField;
        
        private string messageField;
        
        private string app_idField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string updated_time {
            get {
                return this.updated_timeField;
            }
            set {
                this.updated_timeField = value;
            }
        }
        
        /// <comentarios/>
        public string post_id {
            get {
                return this.post_idField;
            }
            set {
                this.post_idField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string created_time {
            get {
                return this.created_timeField;
            }
            set {
                this.created_timeField = value;
            }
        }
        
        /// <comentarios/>
        public string actor_id {
            get {
                return this.actor_idField;
            }
            set {
                this.actor_idField = value;
            }
        }
        
        /// <comentarios/>
        public string target_id {
            get {
                return this.target_idField;
            }
            set {
                this.target_idField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string permalink {
            get {
                return this.permalinkField;
            }
            set {
                this.permalinkField = value;
            }
        }
        
        /// <comentarios/>
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <comentarios/>
        public string app_id {
            get {
                return this.app_idField;
            }
            set {
                this.app_idField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.facebook.com/1.0/")]
    public partial class page {
        
        private string nameField;
        
        private string page_idField;
        
        private string pic_smallField;
        
        /// <comentarios/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <comentarios/>
        public string page_id {
            get {
                return this.page_idField;
            }
            set {
                this.page_idField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string pic_small {
            get {
                return this.pic_smallField;
            }
            set {
                this.pic_smallField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.facebook.com/1.0/")]
    public partial class message {
        
        private string message_idField;
        
        private string thread_idField;
        
        private string author_idField;
        
        private string bodyField;
        
        private string created_timeField;
        
        /// <comentarios/>
        public string message_id {
            get {
                return this.message_idField;
            }
            set {
                this.message_idField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string thread_id {
            get {
                return this.thread_idField;
            }
            set {
                this.thread_idField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string author_id {
            get {
                return this.author_idField;
            }
            set {
                this.author_idField = value;
            }
        }
        
        /// <comentarios/>
        public string body {
            get {
                return this.bodyField;
            }
            set {
                this.bodyField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string created_time {
            get {
                return this.created_timeField;
            }
            set {
                this.created_timeField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.facebook.com/1.0/")]
    public partial class thread {
        
        private string thread_idField;
        
        private string[] recipientsField;
        
        private string folder_idField;
        
        private string subjectField;
        
        private string message_countField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string thread_id {
            get {
                return this.thread_idField;
            }
            set {
                this.thread_idField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("uid", DataType="integer", IsNullable=false)]
        public string[] recipients {
            get {
                return this.recipientsField;
            }
            set {
                this.recipientsField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string folder_id {
            get {
                return this.folder_idField;
            }
            set {
                this.folder_idField = value;
            }
        }
        
        /// <comentarios/>
        public string subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string message_count {
            get {
                return this.message_countField;
            }
            set {
                this.message_countField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.facebook.com/1.0/")]
    public partial class comment {
        
        private string fromidField;
        
        private string timeField;
        
        private string textField;
        
        private string idField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string fromid {
            get {
                return this.fromidField;
            }
            set {
                this.fromidField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string time {
            get {
                return this.timeField;
            }
            set {
                this.timeField = value;
            }
        }
        
        /// <comentarios/>
        public string text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <comentarios/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://api.facebook.com/1.0/")]
    public partial class user {
        
        private string uidField;
        
        private string nameField;
        
        private string usernameField;
        
        private string pic_smallField;
        
        /// <comentarios/>
        public string uid {
            get {
                return this.uidField;
            }
            set {
                this.uidField = value;
            }
        }
        
        /// <comentarios/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <comentarios/>
        public string username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string pic_small {
            get {
                return this.pic_smallField;
            }
            set {
                this.pic_smallField = value;
            }
        }
    }
}