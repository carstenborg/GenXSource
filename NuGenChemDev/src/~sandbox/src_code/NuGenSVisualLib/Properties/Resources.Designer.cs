﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGenSVisualLib.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGenSVisualLib.Properties.Resources", typeof(Resources).Assembly);
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
        
        internal static System.Drawing.Bitmap Arrow {
            get {
                object obj = ResourceManager.GetObject("Arrow", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;recordingSettings width=&quot;640&quot; height=&quot;400&quot; codec=&quot;XVid&quot; fps=&quot;25&quot; /&gt;.
        /// </summary>
        internal static string defaultRecSettings {
            get {
                return ResourceManager.GetString("defaultRecSettings", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap greentick_32 {
            get {
                object obj = ResourceManager.GetObject("greentick_32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to float4 lightClr	:register(c0);
        ///float4 lightDir	:register(c1);
        ///float4 lightA	:register(c2);
        ///float4 eyePos	:register(c3);
        ///
        ///float4 matA		:register(c4);
        ///float4 matE		:register(c5);
        ///float4 matD		:register(c6);
        ///float4 matS		:register(c7);
        ///
        ///struct p2f {
        ///	float4 Position		: TEXCOORD0;
        ///	float4 Normal		: TEXCOORD1;
        ///};
        ///
        ///float4 main(in p2f IN)	: COLOR0
        ///{
        ///	float3 P = IN.Position;
        ///	float3 N = normalize(IN.Normal);
        ///	
        ///	// compute emissive
        ///	float3 emissive = matE.xyz;
        ///	
        ///	// compute ambient
        ///	float3 am [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PPL_fragment {
            get {
                return ResourceManager.GetString("PPL_fragment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to float4x4 mvpMatrix;
        ///
        ///struct v2p {
        ///	float4 Position	: POSITION;
        ///	float3 Normal	: NORMAL;
        ///};
        ///
        ///struct p2f {
        ///	float4 Position		: POSITION;
        ///	float3 ObjectPos	: TEXCOORD0;
        ///	float3 Normal		: TEXCOORD1;
        ///};
        ///
        ///void main(in v2p IN, out p2f OUT)
        ///{
        ///	OUT.Position = mul(IN.Position, mvpMatrix);
        ///	OUT.ObjectPos = IN.Position.xyz;
        ///	OUT.Normal = IN.Normal;
        ///}.
        /// </summary>
        internal static string PPL_vertex {
            get {
                return ResourceManager.GetString("PPL_vertex", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap redcross_32 {
            get {
                object obj = ResourceManager.GetObject("redcross_32", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}