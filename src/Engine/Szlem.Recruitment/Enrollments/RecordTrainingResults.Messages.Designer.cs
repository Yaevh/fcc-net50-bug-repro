﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Szlem.Recruitment.Enrollments {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class RecordTrainingResults_Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RecordTrainingResults_Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Szlem.Recruitment.Enrollments.RecordTrainingResults.Messages", typeof(RecordTrainingResults_Messages).Assembly);
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
        ///   Looks up a localized string similar to Candidate did not accept training invitation.
        /// </summary>
        public static string CandidateDidNotAcceptTrainingInvitation {
            get {
                return ResourceManager.GetString("CandidateDidNotAcceptTrainingInvitation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Candidate has not been invited to training.
        /// </summary>
        public static string CandidateHasNotBeenInvitedToTraining {
            get {
                return ResourceManager.GetString("CandidateHasNotBeenInvitedToTraining", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Candidate has refused training invitation.
        /// </summary>
        public static string CandidateRefusedTrainingInvitation {
            get {
                return ResourceManager.GetString("CandidateRefusedTrainingInvitation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kandydat nie przyjął zaproszenia na szkolenie, nie można oznaczyć go jako nieobecnego.
        /// </summary>
        public static string CannotRecordCandidateAsAbsentIfTheyDidNotAcceptTrainingInvitation {
            get {
                return ResourceManager.GetString("CannotRecordCandidateAsAbsentIfTheyDidNotAcceptTrainingInvitation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot record training attendance before training end.
        /// </summary>
        public static string CannotRecordTrainingAttendanceBeforeTrainingEnd {
            get {
                return ResourceManager.GetString("CannotRecordTrainingAttendanceBeforeTrainingEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot record training results for this candidate.
        /// </summary>
        public static string CannotRecordTrainingResults {
            get {
                return ResourceManager.GetString("CannotRecordTrainingResults", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the candidate was not accepted as lecturer, command must contain explanation.
        /// </summary>
        public static string IfCandidateWasNotAccepted_CommandMustContainExplanation {
            get {
                return ResourceManager.GetString("IfCandidateWasNotAccepted_CommandMustContainExplanation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This training was not selected as preferred.
        /// </summary>
        public static string TrainingNotSelectedAsPreferred {
            get {
                return ResourceManager.GetString("TrainingNotSelectedAsPreferred", resourceCulture);
            }
        }
    }
}
