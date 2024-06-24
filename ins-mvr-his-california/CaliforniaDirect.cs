// ---------------------------------------------------------------------------------
// Copyright (C) Microsoft Corporation. All rights reserved.
//---------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Microsoft� Host Integration Server 
//     Design Tool Version: 11.00.2020
//
//     Changes to this file may cause incorrect behavior and will be lost
//     if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Runtime.Serialization;
using Microsoft.HostIntegration.TI;
namespace California
{
                // ------------  Interfaces (1) ------------ 
                [Guid("3abe99d0-df7a-4477-84c3-c31f3f62e735")]
                #region CustomTI properties
                [CustomTI("07257F3B-FB76-11CF-B949-00A0C9034817", 1)]
                [CustomTI("07257F25-FB76-11CF-B949-00A0C9034817", "{55185CC7-42BA-4926-9F8B-513139CA7A61}")]
                [CustomTI("9A404503-2324-4ef1-BC9C-3892D6701C7D", "11.00.2020")]
                [CustomTI("07257000-0000-0000-0000-00A0C9034817", 0)]
                [CustomTI("AD4F6286-0000-0000-0054-0540EBC8CB29", 0)]
                #endregion
                public interface IDMV
                {
                        [DispId(2)]
                        #region CustomTI properties
                        [CustomTI("07257F26-FB76-11CF-B949-00A0C9034817", 24)]
                        [CustomTI("07257F21-FB76-11CF-B949-00A0C9034817", 0)]
                        [CustomTI("07257F16-FB76-11CF-B949-00A0C9034817", "DMV2")]
                        [CustomTI("07257F59-FB76-11CF-B949-00A0C9034817", 0)]
                        [CustomTI("07257F5C-FB76-11CF-B949-00A0C9034817", 0)]
                        [CustomTI("07257F5A-FB76-11CF-B949-00A0C9034817", 0)]
                        [CustomTI("07257F41-FB76-11CF-B949-00A0C9034817", 256)]
                        [CustomTI("07257F72-FB76-11CF-B949-00A0C9034817", 1)]
                        [CustomTI("07257F0F-FB76-11CF-B949-00A0C9034817", 0xee)]
                        [CustomTI("07257F10-FB76-11CF-B949-00A0C9034817", 0xfa0)]
                        [CustomTI("07257F35-FB76-11CF-B949-00A0C9034817", 0xee)]
                        [CustomTI("07257F36-FB76-11CF-B949-00A0C9034817", 0)]
                        #endregion
                        void DMV2(
                                #region CustomTI properties
                                [CustomTI("07257F22-FB76-11CF-B949-00A0C9034817", 1)]
                                [CustomTI("07257FCE-FB76-11CF-B949-00A0C9034817", 0xee)]
                                #endregion
                                byte[] INQUIRY,
                                #region CustomTI properties
                                [CustomTI("07257F32-FB76-11CF-B949-00A0C9034817", 0x1)]
                                [CustomTI("07257F22-FB76-11CF-B949-00A0C9034817", 1)]
                                [CustomTI("07257FCE-FB76-11CF-B949-00A0C9034817", 0xfa0)]
                                #endregion
                                out byte[] RESPONSE
                                , 
                                #region CustomTI properties
                                [CustomTI("07257F45-FB76-11CF-B949-00A0C9034817", 1)]
                                #endregion
                                ref  Microsoft.HostIntegration.TI.ClientContext clientContext
                        );
                        [DispId(0x7ffffffa)]
                        void UpdateContextInfo(ref  Microsoft.HostIntegration.TI.ClientContext clientContext);
                        [DispId(0x7ffffff9)]
                        void ClosePersistentConnection(ref  Microsoft.HostIntegration.TI.ClientContext clientContext);
                }
                #region implementation
                [Guid("6b2bc1e1-7761-4eaa-9b2a-136f453e6e35")]
                [CustomTI("ClassID", "6b2bc1e1-7761-4eaa-9b2a-136f453e6e35")]
                [ProgId("California.DMV.1")]
                #region CustomTI properties
                [CustomTI("17093CC6-9BD2-11cf-AA4F-304BF89C0001", 0)]
                #endregion
                public class DMV: IDMV
                {
                        public void UpdateContextInfo(ref  Microsoft.HostIntegration.TI.ClientContext clientContext)
                        {
                                TBGen __TBGen__ = new TBGen();
                                __TBGen__.UpdateContextInfo(ref clientContext);
                        }
                        public void ClosePersistentConnection(ref  Microsoft.HostIntegration.TI.ClientContext clientContext)
                        {
                                TBGen __TBGen__ = new TBGen();
                                __TBGen__.ClosePersistentConnection(ref clientContext);
                        }
                        static DMV()
                        {
                        }
                        public void DMV2(
                                byte[] INQUIRY,
                                out byte[] RESPONSE
                        ){
                                 Microsoft.HostIntegration.TI.ClientContext clientContext = null;
                                DMV2(
                                 INQUIRY,
                                out  RESPONSE
                        , ref clientContext);
                        }
                        [DispId(2)]
                        public void DMV2(
                                byte[] INQUIRY,
                                out byte[] RESPONSE
                        , ref  Microsoft.HostIntegration.TI.ClientContext clientContext
                        ){
                                const int __dispID__ = 2;
                                object [] __inarray__ = new object [2]; 
                                __inarray__[0] = INQUIRY;
                                object[] __outarray__;
                                TBGen __TBGen__ = new TBGen();
                                object __retVal__ = null;
                                __retVal__ = __TBGen__.Invoke(this.GetType(), __dispID__,ref clientContext, __inarray__, out __outarray__);
                                RESPONSE = (byte[]) __outarray__[1];
                                return;
                        }
                }
                #endregion
}
