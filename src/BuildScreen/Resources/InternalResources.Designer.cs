﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuildScreen.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class InternalResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal InternalResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BuildScreen.Resources.InternalResources", typeof(InternalResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static System.Drawing.Bitmap Image_Load_16x16 {
            get {
                object obj = ResourceManager.GetObject("Image_Load_16x16", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap Image_Load_32x32 {
            get {
                object obj = ResourceManager.GetObject("Image_Load_32x32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The plugin configuration section &apos;{0}&apos; could not be found..
        /// </summary>
        internal static string PluginCouldNotFindConfigurationSection {
            get {
                return ResourceManager.GetString("PluginCouldNotFindConfigurationSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The plugin with the name &apos;{0}&apos; could not be found. Check if it&apos;s a name is valid or if it is correctly configured..
        /// </summary>
        internal static string PluginCouldNotFindPluginByName {
            get {
                return ResourceManager.GetString("PluginCouldNotFindPluginByName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press F11 for Full Screen, Ctrl+O for Options.
        /// </summary>
        internal static string ShortcutInfoEnterFullScreen {
            get {
                return ResourceManager.GetString("ShortcutInfoEnterFullScreen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press ESC to Exit Full Screen, Ctrl+O for Options.
        /// </summary>
        internal static string ShortcutInfoExitFullScreen {
            get {
                return ResourceManager.GetString("ShortcutInfoExitFullScreen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid domain.
        /// </summary>
        internal static string ValidateInvalidDomain {
            get {
                return ResourceManager.GetString("ValidateInvalidDomain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid port number.
        /// </summary>
        internal static string ValidateInvalidePortNumber {
            get {
                return ResourceManager.GetString("ValidateInvalidePortNumber", resourceCulture);
            }
        }
    }
}