// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SolutionAssemblyInfo.cs" company="Orchestra development team">
//   Copyright (c) 2008 - 2014 Orchestra development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


#pragma warning disable 1699    // 1699 = Use command line option '/keyfile' or appropriate project settings instead of 'AssemblyKeyFile'

using System.Runtime.InteropServices;
using System;
using System.Reflection;
using System.Resources;

// Shared assembly info that is common for all assemblies of this project

////[assembly: AssemblyTitle("DEFINED IN ACTUAL ASSEMBLYINFO")]
////[assembly: AssemblyProduct("DEFINED IN ACTUAL ASSEMBLYINFO")]
////[assembly: AssemblyDescription("DEFINED IN ACTUAL ASSEMBLYINFO")]

[assembly: AssemblyCompany("Orcomp")]
[assembly: AssemblyCopyright("Copyright � Orcomp 2013 - 2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en-US")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion("0.1")]
[assembly: AssemblyInformationalVersion("0.1, manual release via Visual Studio build")]
[assembly: ComVisible(false)]

#if DEBUG

[assembly: AssemblyConfiguration("NET45, Debug")]

#else

[assembly: AssemblyConfiguration("NET45, Release")]

#endif

// CLS compliant
#if !NETFX_CORE

[assembly: CLSCompliant(true)]

#endif