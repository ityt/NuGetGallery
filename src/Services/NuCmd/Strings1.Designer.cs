﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuCmd {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuCmd.Strings", typeof(Strings).Assembly);
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
        
        /// <summary>
        ///   Looks up a localized string similar to This command must be run from the NuGet Ops console with a current environment that has a Management Certificate.
        /// </summary>
        internal static string Command_RequiresManagementCert {
            get {
                return ResourceManager.GetString("Command_RequiresManagementCert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received &apos;{0} {1}&apos; response from server. TODO: Decode error details.
        /// </summary>
        internal static string Commands_HttpError {
            get {
                return ResourceManager.GetString("Commands_HttpError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using service at: {0}.
        /// </summary>
        internal static string Commands_UsingServiceUri {
            get {
                return ResourceManager.GetString("Commands_UsingServiceUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter the admin password for {0}..
        /// </summary>
        internal static string CredentialProvider_Message {
            get {
                return ResourceManager.GetString("CredentialProvider_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command groups. Type &apos;nucmd help &lt;group&gt;&apos; to see a list of commands available in that group.
        /// </summary>
        internal static string Help_CommandGroupsHeader {
            get {
                return ResourceManager.GetString("Help_CommandGroupsHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Global commands. Type &apos;nucmd help &lt;command&gt;&apos; to see detailed command help information.
        /// </summary>
        internal static string Help_GlobalCommandsHeader {
            get {
                return ResourceManager.GetString("Help_GlobalCommandsHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Commands in the &apos;{0}&apos; group. Type &apos;nucmd help {0} &lt;command&gt;&apos; to see detailed command help information.
        /// </summary>
        internal static string Help_GroupCommandsHeader {
            get {
                return ResourceManager.GetString("Help_GroupCommandsHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0} {1}&apos; is not a nucmd command..
        /// </summary>
        internal static string Help_UnknownCommand {
            get {
                return ResourceManager.GetString("Help_UnknownCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a nucmd group or command..
        /// </summary>
        internal static string Help_UnknownGroup {
            get {
                return ResourceManager.GetString("Help_UnknownGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; parameter is required.
        /// </summary>
        internal static string ParameterRequired {
            get {
                return ResourceManager.GetString("ParameterRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fatal Error: Command type &apos;{0}&apos; is not convertable to &apos;{1}&apos;..
        /// </summary>
        internal static string Program_CommandNotConvertible {
            get {
                return ResourceManager.GetString("Program_CommandNotConvertible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing command..
        /// </summary>
        internal static string Program_MissingCommand {
            get {
                return ResourceManager.GetString("Program_MissingCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command not found: &apos;{0}&apos;. Use &apos;nucmd help&apos; to list available commands..
        /// </summary>
        internal static string Program_NoSuchCommand {
            get {
                return ResourceManager.GetString("Program_NoSuchCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command &apos;{0}&apos; not found in &apos;{1}&apos; group. Use &apos;nucmd help {1}&apos; to list available commands..
        /// </summary>
        internal static string Program_NoSuchCommandInGroup {
            get {
                return ResourceManager.GetString("Program_NoSuchCommandInGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting Job Collection &apos;{1}&apos; in scheduler service &apos;{0}&apos;..
        /// </summary>
        internal static string Scheduler_ColDeleteCommand_DeletingCollection {
            get {
                return ResourceManager.GetString("Scheduler_ColDeleteCommand_DeletingCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Getting Job Collection &apos;{0}&apos; in service &apos;{1}&apos;..
        /// </summary>
        internal static string Scheduler_CollectionsCommand_GettingCollection {
            get {
                return ResourceManager.GetString("Scheduler_CollectionsCommand_GettingCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Listing available scheduler job collections in the service &apos;{0}&apos;..
        /// </summary>
        internal static string Scheduler_CollectionsCommand_ListingCollections {
            get {
                return ResourceManager.GetString("Scheduler_CollectionsCommand_ListingCollections", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created Job Collection &apos;{0}&apos; in scheduler service &apos;{1}&apos;..
        /// </summary>
        internal static string Scheduler_ColNewCommand_CreatedCollection {
            get {
                return ResourceManager.GetString("Scheduler_ColNewCommand_CreatedCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Job Collection &apos;{0}&apos; in scheduler service &apos;{1}&apos;..
        /// </summary>
        internal static string Scheduler_ColNewCommand_CreatingCollection {
            get {
                return ResourceManager.GetString("Scheduler_ColNewCommand_CreatingCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both MaxRecurrenceFrequency and MaxRecurrenceInterval must be specified if one is specified..
        /// </summary>
        internal static string Scheduler_ColNewCommand_MaxRecurrenceIncomplete {
            get {
                return ResourceManager.GetString("Scheduler_ColNewCommand_MaxRecurrenceIncomplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleted scheduler service: {0}..
        /// </summary>
        internal static string Scheduler_CsDeleteCommand_DeletedService {
            get {
                return ResourceManager.GetString("Scheduler_CsDeleteCommand_DeletedService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting scheduler service: {0}..
        /// </summary>
        internal static string Scheduler_CsDeleteCommand_DeletingService {
            get {
                return ResourceManager.GetString("Scheduler_CsDeleteCommand_DeletingService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Listing available scheduler services..
        /// </summary>
        internal static string Scheduler_CsListCommand_ListingAvailableServices {
            get {
                return ResourceManager.GetString("Scheduler_CsListCommand_ListingAvailableServices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created scheduler service: {0}..
        /// </summary>
        internal static string Scheduler_CsNewCommand_CreatedService {
            get {
                return ResourceManager.GetString("Scheduler_CsNewCommand_CreatedService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating scheduler service: {0}..
        /// </summary>
        internal static string Scheduler_CsNewCommand_CreatingService {
            get {
                return ResourceManager.GetString("Scheduler_CsNewCommand_CreatingService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Listing Jobs in Job Collection &apos;{0}/{1}&apos;..
        /// </summary>
        internal static string Scheduler_JobsCommand_ListingJobs {
            get {
                return ResourceManager.GetString("Scheduler_JobsCommand_ListingJobs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created Job &apos;{0}&apos; in Job Collection &apos;{1}/{2}&apos;..
        /// </summary>
        internal static string Scheduler_NewJobCommand_CreatedJob {
            get {
                return ResourceManager.GetString("Scheduler_NewJobCommand_CreatedJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Job &apos;{0}&apos; in Job Collection &apos;{1}/{2}&apos;..
        /// </summary>
        internal static string Scheduler_NewJobCommand_CreatingJob {
            get {
                return ResourceManager.GetString("Scheduler_NewJobCommand_CreatingJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would create job with the following definition:
        ///{0}.
        /// </summary>
        internal static string Scheduler_NewJobCommand_WouldCreateJob {
            get {
                return ResourceManager.GetString("Scheduler_NewJobCommand_WouldCreateJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuCmd Usage:
        ///  nucmd &lt;command&gt;
        ///  nucmd &lt;group&gt; &lt;command&gt;.
        /// </summary>
        internal static string Usage {
            get {
                return ResourceManager.GetString("Usage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created Invocation: {0}.
        /// </summary>
        internal static string Work_InvokeCommand_CreatedInvocation {
            get {
                return ResourceManager.GetString("Work_InvokeCommand_CreatedInvocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Invocation of {0} with no payload.
        /// </summary>
        internal static string Work_InvokeCommand_CreatingInvocation_NoPayload {
            get {
                return ResourceManager.GetString("Work_InvokeCommand_CreatingInvocation_NoPayload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Invocation of {0} with the following payload:.
        /// </summary>
        internal static string Work_InvokeCommand_CreatingInvocation_WithPayload {
            get {
                return ResourceManager.GetString("Work_InvokeCommand_CreatingInvocation_WithPayload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error deserializing payload: {0}.
        /// </summary>
        internal static string Work_InvokeCommand_PayloadInvalid {
            get {
                return ResourceManager.GetString("Work_InvokeCommand_PayloadInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fetching log data for Invocation {0}....
        /// </summary>
        internal static string Work_LogCommand_FetchingLog {
            get {
                return ResourceManager.GetString("Work_LogCommand_FetchingLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End of log for Invocation {0}.
        /// </summary>
        internal static string Work_LogCommand_RenderedLog {
            get {
                return ResourceManager.GetString("Work_LogCommand_RenderedLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log entries for Invocation {0}.
        /// </summary>
        internal static string Work_LogCommand_RenderingLog {
            get {
                return ResourceManager.GetString("Work_LogCommand_RenderingLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Purging all invocations....
        /// </summary>
        internal static string Work_PurgeCommand_PurgingAllInvocations {
            get {
                return ResourceManager.GetString("Work_PurgeCommand_PurgingAllInvocations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Purging invocations completed before {0} UTC....
        /// </summary>
        internal static string Work_PurgeCommand_PurgingInvocationsBefore {
            get {
                return ResourceManager.GetString("Work_PurgeCommand_PurgingInvocationsBefore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Completed invocation of job {0}.
        /// </summary>
        internal static string Work_RunCommand_Invoked {
            get {
                return ResourceManager.GetString("Work_RunCommand_Invoked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoking job: {0}.
        /// </summary>
        internal static string Work_RunCommand_Invoking {
            get {
                return ResourceManager.GetString("Work_RunCommand_Invoking", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown job: {0}..
        /// </summary>
        internal static string Work_RunCommand_UnknownJob {
            get {
                return ResourceManager.GetString("Work_RunCommand_UnknownJob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown stats type: {0}.
        /// </summary>
        internal static string Work_StatsCommand_UnknownStatsType {
            get {
                return ResourceManager.GetString("Work_StatsCommand_UnknownStatsType", resourceCulture);
            }
        }
    }
}