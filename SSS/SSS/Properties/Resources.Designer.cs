﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSS.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SSS.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Student Created Successfully..
        /// </summary>
        public static string CreateStudent_SuccessfulMessage {
            get {
                return ResourceManager.GetString("CreateStudent_SuccessfulMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect Login Details. Please try again..
        /// </summary>
        public static string IncorrectLoginDetailsMessage {
            get {
                return ResourceManager.GetString("IncorrectLoginDetailsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password Created Successfully.
        /// </summary>
        public static string Login_CheckPassword_Password_Created_Successfully {
            get {
                return ResourceManager.GetString("Login_CheckPassword_Password_Created_Successfully", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please Insert Correct Password.
        /// </summary>
        public static string PassWordCreateDoNotMatchError {
            get {
                return ResourceManager.GetString("PassWordCreateDoNotMatchError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap PointBlankIcon {
            get {
                object obj = ResourceManager.GetObject("PointBlankIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile Update Successful..
        /// </summary>
        public static string Profile_Update_Successful {
            get {
                return ResourceManager.GetString("Profile_Update_Successful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Student Information.
        /// </summary>
        public static string SearchStudentMessageBoxHeading {
            get {
                return ResourceManager.GetString("SearchStudentMessageBoxHeading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tutor Information.
        /// </summary>
        public static string SearchTutorInformationHeading {
            get {
                return ResourceManager.GetString("SearchTutorInformationHeading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tutor Information.
        /// </summary>
        public static string SearchTutorModal_displayStudentInformation_Tutor_Information {
            get {
                return ResourceManager.GetString("SearchTutorModal_displayStudentInformation_Tutor_Information", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email Sent To New Student..
        /// </summary>
        public static string SendEmailSuccessfulMessage {
            get {
                return ResourceManager.GetString("SendEmailSuccessfulMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Added to Group Successfully..
        /// </summary>
        public static string UpdateGroupSuccess {
            get {
                return ResourceManager.GetString("UpdateGroupSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attendance Updated Successfully..
        /// </summary>
        public static string UpdateStudentAttendanceSuccess {
            get {
                return ResourceManager.GetString("UpdateStudentAttendanceSuccess", resourceCulture);
            }
        }
    }
}
