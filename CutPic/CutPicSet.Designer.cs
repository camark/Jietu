﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CutPic {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    public sealed partial class CutPicSet : global::System.Configuration.ApplicationSettingsBase {
        
        private static CutPicSet defaultInstance = ((CutPicSet)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new CutPicSet())));
        
        public static CutPicSet Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int KeyNumber {
            get {
                return ((int)(this["KeyNumber"]));
            }
            set {
                this["KeyNumber"] = value;
            }
        }
    }
}
