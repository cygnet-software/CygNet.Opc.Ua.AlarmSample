/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace cygnet
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint CygNetAlarmType_ShelvingState_TimedShelve = 15366;

        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint CygNetAlarmType_ShelvingState_Unshelve = 15368;

        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint CygNetAlarmType_ShelvingState_OneShotShelve = 15369;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the CvsType ObjectType.
        /// </summary>
        public const uint CvsType = 15001;

        /// <summary>
        /// The identifier for the FacilityType ObjectType.
        /// </summary>
        public const uint FacilityType = 15003;

        /// <summary>
        /// The identifier for the PointConfigurationType ObjectType.
        /// </summary>
        public const uint PointConfigurationType = 15196;

        /// <summary>
        /// The identifier for the RealtimeRecordType ObjectType.
        /// </summary>
        public const uint RealtimeRecordType = 15251;

        /// <summary>
        /// The identifier for the CygNetAlarmType ObjectType.
        /// </summary>
        public const uint CygNetAlarmType = 15260;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the CvsType_CvsDescription Variable.
        /// </summary>
        public const uint CvsType_CvsDescription = 15002;

        /// <summary>
        /// The identifier for the FacilityType_FacilitySiteService Variable.
        /// </summary>
        public const uint FacilityType_FacilitySiteService = 15004;

        /// <summary>
        /// The identifier for the FacilityType_FacilityId Variable.
        /// </summary>
        public const uint FacilityType_FacilityId = 15005;

        /// <summary>
        /// The identifier for the FacilityType_FacilitySite Variable.
        /// </summary>
        public const uint FacilityType_FacilitySite = 15006;

        /// <summary>
        /// The identifier for the FacilityType_FacilityService Variable.
        /// </summary>
        public const uint FacilityType_FacilityService = 15007;

        /// <summary>
        /// The identifier for the FacilityType_FacilityType Variable.
        /// </summary>
        public const uint FacilityType_FacilityType = 15008;

        /// <summary>
        /// The identifier for the FacilityType_FacilityDescription Variable.
        /// </summary>
        public const uint FacilityType_FacilityDescription = 15009;

        /// <summary>
        /// The identifier for the FacilityType_FacilityInfoAttribute0 Variable.
        /// </summary>
        public const uint FacilityType_FacilityInfoAttribute0 = 15010;

        /// <summary>
        /// The identifier for the FacilityType_FacilityInfoAttribute1 Variable.
        /// </summary>
        public const uint FacilityType_FacilityInfoAttribute1 = 15011;

        /// <summary>
        /// The identifier for the FacilityType_FacilityCategory Variable.
        /// </summary>
        public const uint FacilityType_FacilityCategory = 15012;

        /// <summary>
        /// The identifier for the FacilityType_FacilityIsActive Variable.
        /// </summary>
        public const uint FacilityType_FacilityIsActive = 15013;

        /// <summary>
        /// The identifier for the FacilityType_FacilitySecurityApplication Variable.
        /// </summary>
        public const uint FacilityType_FacilitySecurityApplication = 15014;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute00 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute00 = 15015;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute01 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute01 = 15016;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute02 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute02 = 15017;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute03 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute03 = 15018;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute04 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute04 = 15019;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute05 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute05 = 15020;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute06 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute06 = 15021;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute07 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute07 = 15022;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute08 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute08 = 15023;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute09 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute09 = 15024;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute10 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute10 = 15025;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute11 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute11 = 15026;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute12 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute12 = 15027;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute13 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute13 = 15028;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute14 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute14 = 15029;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute15 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute15 = 15030;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute16 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute16 = 15031;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute17 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute17 = 15032;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute18 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute18 = 15033;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute19 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute19 = 15034;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute20 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute20 = 15035;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute21 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute21 = 15036;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute22 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute22 = 15037;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute23 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute23 = 15038;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute24 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute24 = 15039;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute25 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute25 = 15040;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute26 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute26 = 15041;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute27 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute27 = 15042;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute28 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute28 = 15043;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute29 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute29 = 15044;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute30 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute30 = 15045;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute31 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute31 = 15046;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute32 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute32 = 15047;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute33 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute33 = 15048;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute34 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute34 = 15049;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute35 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute35 = 15050;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute36 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute36 = 15051;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute37 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute37 = 15052;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute38 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute38 = 15053;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute39 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTextAttribute39 = 15054;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute00 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute00 = 15055;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute01 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute01 = 15056;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute02 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute02 = 15057;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute03 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute03 = 15058;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute04 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute04 = 15059;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute05 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute05 = 15060;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute06 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute06 = 15061;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute07 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute07 = 15062;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute08 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute08 = 15063;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute09 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute09 = 15064;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute10 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute10 = 15065;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute11 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute11 = 15066;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute12 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute12 = 15067;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute13 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute13 = 15068;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute14 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute14 = 15069;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute15 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute15 = 15070;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute16 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute16 = 15071;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute17 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute17 = 15072;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute18 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute18 = 15073;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute19 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute19 = 15074;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute20 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute20 = 15075;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute21 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute21 = 15076;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute22 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute22 = 15077;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute23 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute23 = 15078;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute24 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute24 = 15079;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute25 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute25 = 15080;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute26 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute26 = 15081;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute27 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute27 = 15082;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute28 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute28 = 15083;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute29 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute29 = 15084;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute30 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute30 = 15085;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute31 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute31 = 15086;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute32 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute32 = 15087;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute33 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute33 = 15088;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute34 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute34 = 15089;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute35 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute35 = 15090;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute36 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute36 = 15091;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute37 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute37 = 15092;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute38 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute38 = 15093;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute39 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute39 = 15094;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute40 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute40 = 15095;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute41 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute41 = 15096;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute42 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute42 = 15097;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute43 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute43 = 15098;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute44 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute44 = 15099;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute45 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute45 = 15100;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute46 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute46 = 15101;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute47 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute47 = 15102;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute48 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute48 = 15103;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute49 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute49 = 15104;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute50 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute50 = 15105;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute51 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute51 = 15106;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute52 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute52 = 15107;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute53 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute53 = 15108;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute54 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute54 = 15109;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute55 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute55 = 15110;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute56 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute56 = 15111;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute57 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute57 = 15112;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute58 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute58 = 15113;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute59 Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute59 = 15114;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute00Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute00Description = 15115;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute01Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute01Description = 15116;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute02Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute02Description = 15117;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute03Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute03Description = 15118;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute04Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute04Description = 15119;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute05Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute05Description = 15120;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute06Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute06Description = 15121;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute07Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute07Description = 15122;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute08Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute08Description = 15123;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute09Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute09Description = 15124;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute10Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute10Description = 15125;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute11Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute11Description = 15126;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute12Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute12Description = 15127;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute13Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute13Description = 15128;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute14Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute14Description = 15129;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute15Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute15Description = 15130;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute16Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute16Description = 15131;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute17Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute17Description = 15132;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute18Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute18Description = 15133;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute19Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute19Description = 15134;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute20Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute20Description = 15135;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute21Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute21Description = 15136;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute22Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute22Description = 15137;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute23Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute23Description = 15138;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute24Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute24Description = 15139;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute25Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute25Description = 15140;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute26Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute26Description = 15141;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute27Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute27Description = 15142;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute28Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute28Description = 15143;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute29Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute29Description = 15144;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute30Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute30Description = 15145;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute31Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute31Description = 15146;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute32Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute32Description = 15147;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute33Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute33Description = 15148;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute34Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute34Description = 15149;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute35Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute35Description = 15150;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute36Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute36Description = 15151;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute37Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute37Description = 15152;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute38Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute38Description = 15153;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute39Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute39Description = 15154;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute40Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute40Description = 15155;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute41Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute41Description = 15156;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute42Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute42Description = 15157;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute43Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute43Description = 15158;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute44Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute44Description = 15159;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute45Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute45Description = 15160;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute46Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute46Description = 15161;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute47Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute47Description = 15162;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute48Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute48Description = 15163;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute49Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute49Description = 15164;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute50Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute50Description = 15165;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute51Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute51Description = 15166;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute52Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute52Description = 15167;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute53Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute53Description = 15168;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute54Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute54Description = 15169;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute55Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute55Description = 15170;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute56Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute56Description = 15171;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute57Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute57Description = 15172;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute58Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute58Description = 15173;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute59Description Variable.
        /// </summary>
        public const uint FacilityType_FacilityTableAttribute59Description = 15174;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute00 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute00 = 15175;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute01 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute01 = 15176;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute02 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute02 = 15177;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute03 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute03 = 15178;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute04 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute04 = 15179;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute05 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute05 = 15180;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute06 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute06 = 15181;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute07 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute07 = 15182;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute08 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute08 = 15183;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute09 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute09 = 15184;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute10 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute10 = 15185;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute11 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute11 = 15186;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute12 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute12 = 15187;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute13 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute13 = 15188;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute14 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute14 = 15189;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute15 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute15 = 15190;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute16 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute16 = 15191;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute17 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute17 = 15192;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute18 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute18 = 15193;

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute19 Variable.
        /// </summary>
        public const uint FacilityType_FacilityYesNoAttribute19 = 15194;

        /// <summary>
        /// The identifier for the FacilityType_FacilityTag Variable.
        /// </summary>
        public const uint FacilityType_FacilityTag = 15195;

        /// <summary>
        /// The identifier for the PointConfigurationType_PointDescription Variable.
        /// </summary>
        public const uint PointConfigurationType_PointDescription = 15197;

        /// <summary>
        /// The identifier for the PointConfigurationType_Units Variable.
        /// </summary>
        public const uint PointConfigurationType_Units = 15198;

        /// <summary>
        /// The identifier for the PointConfigurationType_AlternateUnits Variable.
        /// </summary>
        public const uint PointConfigurationType_AlternateUnits = 15199;

        /// <summary>
        /// The identifier for the PointConfigurationType_Tag Variable.
        /// </summary>
        public const uint PointConfigurationType_Tag = 15200;

        /// <summary>
        /// The identifier for the PointConfigurationType_TagLong Variable.
        /// </summary>
        public const uint PointConfigurationType_TagLong = 15201;

        /// <summary>
        /// The identifier for the PointConfigurationType_TagFull Variable.
        /// </summary>
        public const uint PointConfigurationType_TagFull = 15202;

        /// <summary>
        /// The identifier for the PointConfigurationType_PointId Variable.
        /// </summary>
        public const uint PointConfigurationType_PointId = 15203;

        /// <summary>
        /// The identifier for the PointConfigurationType_PointIdLong Variable.
        /// </summary>
        public const uint PointConfigurationType_PointIdLong = 15204;

        /// <summary>
        /// The identifier for the PointConfigurationType_SiteService Variable.
        /// </summary>
        public const uint PointConfigurationType_SiteService = 15205;

        /// <summary>
        /// The identifier for the PointConfigurationType_Site Variable.
        /// </summary>
        public const uint PointConfigurationType_Site = 15206;

        /// <summary>
        /// The identifier for the PointConfigurationType_Service Variable.
        /// </summary>
        public const uint PointConfigurationType_Service = 15207;

        /// <summary>
        /// The identifier for the PointConfigurationType_Facility Variable.
        /// </summary>
        public const uint PointConfigurationType_Facility = 15208;

        /// <summary>
        /// The identifier for the PointConfigurationType_UDC Variable.
        /// </summary>
        public const uint PointConfigurationType_UDC = 15209;

        /// <summary>
        /// The identifier for the PointConfigurationType_UDCDescription Variable.
        /// </summary>
        public const uint PointConfigurationType_UDCDescription = 15210;

        /// <summary>
        /// The identifier for the PointConfigurationType_System Variable.
        /// </summary>
        public const uint PointConfigurationType_System = 15211;

        /// <summary>
        /// The identifier for the PointConfigurationType_SystemDescription Variable.
        /// </summary>
        public const uint PointConfigurationType_SystemDescription = 15212;

        /// <summary>
        /// The identifier for the PointConfigurationType_PointDataType Variable.
        /// </summary>
        public const uint PointConfigurationType_PointDataType = 15213;

        /// <summary>
        /// The identifier for the PointConfigurationType_PointDataTypeDescription Variable.
        /// </summary>
        public const uint PointConfigurationType_PointDataTypeDescription = 15214;

        /// <summary>
        /// The identifier for the PointConfigurationType_Comment Variable.
        /// </summary>
        public const uint PointConfigurationType_Comment = 15215;

        /// <summary>
        /// The identifier for the PointConfigurationType_AlarmCategory Variable.
        /// </summary>
        public const uint PointConfigurationType_AlarmCategory = 15216;

        /// <summary>
        /// The identifier for the PointConfigurationType_AlarmCategoryDescription Variable.
        /// </summary>
        public const uint PointConfigurationType_AlarmCategoryDescription = 15217;

        /// <summary>
        /// The identifier for the PointConfigurationType_AnyVerifiedFlag Variable.
        /// </summary>
        public const uint PointConfigurationType_AnyVerifiedFlag = 15218;

        /// <summary>
        /// The identifier for the PointConfigurationType_VerifiedFlag1 Variable.
        /// </summary>
        public const uint PointConfigurationType_VerifiedFlag1 = 15219;

        /// <summary>
        /// The identifier for the PointConfigurationType_VerifiedFlag2 Variable.
        /// </summary>
        public const uint PointConfigurationType_VerifiedFlag2 = 15220;

        /// <summary>
        /// The identifier for the PointConfigurationType_VerifiedFlag3 Variable.
        /// </summary>
        public const uint PointConfigurationType_VerifiedFlag3 = 15221;

        /// <summary>
        /// The identifier for the PointConfigurationType_VerifiedFlag4 Variable.
        /// </summary>
        public const uint PointConfigurationType_VerifiedFlag4 = 15222;

        /// <summary>
        /// The identifier for the PointConfigurationType_VerifiedTimestamp Variable.
        /// </summary>
        public const uint PointConfigurationType_VerifiedTimestamp = 15223;

        /// <summary>
        /// The identifier for the PointConfigurationType_QuestionableFlag Variable.
        /// </summary>
        public const uint PointConfigurationType_QuestionableFlag = 15224;

        /// <summary>
        /// The identifier for the PointConfigurationType_QuestionableTimestamp Variable.
        /// </summary>
        public const uint PointConfigurationType_QuestionableTimestamp = 15225;

        /// <summary>
        /// The identifier for the PointConfigurationType_AnyUserFlag Variable.
        /// </summary>
        public const uint PointConfigurationType_AnyUserFlag = 15226;

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag1 Variable.
        /// </summary>
        public const uint PointConfigurationType_UserFlag1 = 15227;

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag2 Variable.
        /// </summary>
        public const uint PointConfigurationType_UserFlag2 = 15228;

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag3 Variable.
        /// </summary>
        public const uint PointConfigurationType_UserFlag3 = 15229;

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag4 Variable.
        /// </summary>
        public const uint PointConfigurationType_UserFlag4 = 15230;

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag5 Variable.
        /// </summary>
        public const uint PointConfigurationType_UserFlag5 = 15231;

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag6 Variable.
        /// </summary>
        public const uint PointConfigurationType_UserFlag6 = 15232;

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag7 Variable.
        /// </summary>
        public const uint PointConfigurationType_UserFlag7 = 15233;

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag8 Variable.
        /// </summary>
        public const uint PointConfigurationType_UserFlag8 = 15234;

        /// <summary>
        /// The identifier for the PointConfigurationType_Indexed1 Variable.
        /// </summary>
        public const uint PointConfigurationType_Indexed1 = 15235;

        /// <summary>
        /// The identifier for the PointConfigurationType_Indexed2 Variable.
        /// </summary>
        public const uint PointConfigurationType_Indexed2 = 15236;

        /// <summary>
        /// The identifier for the PointConfigurationType_Indexed3 Variable.
        /// </summary>
        public const uint PointConfigurationType_Indexed3 = 15237;

        /// <summary>
        /// The identifier for the PointConfigurationType_TableDriven1 Variable.
        /// </summary>
        public const uint PointConfigurationType_TableDriven1 = 15238;

        /// <summary>
        /// The identifier for the PointConfigurationType_TableDriven2 Variable.
        /// </summary>
        public const uint PointConfigurationType_TableDriven2 = 15239;

        /// <summary>
        /// The identifier for the PointConfigurationType_TableDriven3 Variable.
        /// </summary>
        public const uint PointConfigurationType_TableDriven3 = 15240;

        /// <summary>
        /// The identifier for the PointConfigurationType_GeneralData1 Variable.
        /// </summary>
        public const uint PointConfigurationType_GeneralData1 = 15241;

        /// <summary>
        /// The identifier for the PointConfigurationType_GeneralData2 Variable.
        /// </summary>
        public const uint PointConfigurationType_GeneralData2 = 15242;

        /// <summary>
        /// The identifier for the PointConfigurationType_GeneralData3 Variable.
        /// </summary>
        public const uint PointConfigurationType_GeneralData3 = 15243;

        /// <summary>
        /// The identifier for the PointConfigurationType_TableDriven1Description Variable.
        /// </summary>
        public const uint PointConfigurationType_TableDriven1Description = 15244;

        /// <summary>
        /// The identifier for the PointConfigurationType_TableDriven2Description Variable.
        /// </summary>
        public const uint PointConfigurationType_TableDriven2Description = 15245;

        /// <summary>
        /// The identifier for the PointConfigurationType_TableDriven3Description Variable.
        /// </summary>
        public const uint PointConfigurationType_TableDriven3Description = 15246;

        /// <summary>
        /// The identifier for the PointConfigurationType_LongDescription Variable.
        /// </summary>
        public const uint PointConfigurationType_LongDescription = 15247;

        /// <summary>
        /// The identifier for the PointConfigurationType_PointScheme Variable.
        /// </summary>
        public const uint PointConfigurationType_PointScheme = 15248;

        /// <summary>
        /// The identifier for the PointConfigurationType_PointSchemeDescription Variable.
        /// </summary>
        public const uint PointConfigurationType_PointSchemeDescription = 15249;

        /// <summary>
        /// The identifier for the PointConfigurationType_ExternalId Variable.
        /// </summary>
        public const uint PointConfigurationType_ExternalId = 15250;

        /// <summary>
        /// The identifier for the RealtimeRecordType_Value Variable.
        /// </summary>
        public const uint RealtimeRecordType_Value = 15252;

        /// <summary>
        /// The identifier for the RealtimeRecordType_AlternateValue Variable.
        /// </summary>
        public const uint RealtimeRecordType_AlternateValue = 15253;

        /// <summary>
        /// The identifier for the RealtimeRecordType_Timestamp Variable.
        /// </summary>
        public const uint RealtimeRecordType_Timestamp = 15254;

        /// <summary>
        /// The identifier for the RealtimeRecordType_Status Variable.
        /// </summary>
        public const uint RealtimeRecordType_Status = 15255;

        /// <summary>
        /// The identifier for the RealtimeRecordType_UserStatus Variable.
        /// </summary>
        public const uint RealtimeRecordType_UserStatus = 15256;

        /// <summary>
        /// The identifier for the RealtimeRecordType_PointStateDescription Variable.
        /// </summary>
        public const uint RealtimeRecordType_PointStateDescription = 15257;

        /// <summary>
        /// The identifier for the RealtimeRecordType_AlarmPriorityCategoryDescription Variable.
        /// </summary>
        public const uint RealtimeRecordType_AlarmPriorityCategoryDescription = 15258;

        /// <summary>
        /// The identifier for the RealtimeRecordType_AlarmConditionDescription Variable.
        /// </summary>
        public const uint RealtimeRecordType_AlarmConditionDescription = 15259;

        /// <summary>
        /// The identifier for the CygNetAlarmType_EnabledState_Id Variable.
        /// </summary>
        public const uint CygNetAlarmType_EnabledState_Id = 15278;

        /// <summary>
        /// The identifier for the CygNetAlarmType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint CygNetAlarmType_Quality_SourceTimestamp = 15287;

        /// <summary>
        /// The identifier for the CygNetAlarmType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint CygNetAlarmType_LastSeverity_SourceTimestamp = 15289;

        /// <summary>
        /// The identifier for the CygNetAlarmType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint CygNetAlarmType_Comment_SourceTimestamp = 15291;

        /// <summary>
        /// The identifier for the CygNetAlarmType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint CygNetAlarmType_AddComment_InputArguments = 15296;

        /// <summary>
        /// The identifier for the CygNetAlarmType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint CygNetAlarmType_ConditionRefresh_InputArguments = 15298;

        /// <summary>
        /// The identifier for the CygNetAlarmType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint CygNetAlarmType_ConditionRefresh2_InputArguments = 15300;

        /// <summary>
        /// The identifier for the CygNetAlarmType_AckedState_Id Variable.
        /// </summary>
        public const uint CygNetAlarmType_AckedState_Id = 15302;

        /// <summary>
        /// The identifier for the CygNetAlarmType_ConfirmedState_Id Variable.
        /// </summary>
        public const uint CygNetAlarmType_ConfirmedState_Id = 15311;

        /// <summary>
        /// The identifier for the CygNetAlarmType_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint CygNetAlarmType_Acknowledge_InputArguments = 15320;

        /// <summary>
        /// The identifier for the CygNetAlarmType_Confirm_InputArguments Variable.
        /// </summary>
        public const uint CygNetAlarmType_Confirm_InputArguments = 15322;

        /// <summary>
        /// The identifier for the CygNetAlarmType_ActiveState_Id Variable.
        /// </summary>
        public const uint CygNetAlarmType_ActiveState_Id = 15324;

        /// <summary>
        /// The identifier for the CygNetAlarmType_SuppressedState_Id Variable.
        /// </summary>
        public const uint CygNetAlarmType_SuppressedState_Id = 15334;

        /// <summary>
        /// The identifier for the CygNetAlarmType_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint CygNetAlarmType_OutOfServiceState_Id = 15343;

        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint CygNetAlarmType_ShelvingState_CurrentState = 15352;

        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint CygNetAlarmType_ShelvingState_CurrentState_Id = 15353;

        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint CygNetAlarmType_ShelvingState_LastTransition_Id = 15358;

        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint CygNetAlarmType_ShelvingState_UnshelveTime = 15365;

        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint CygNetAlarmType_ShelvingState_TimedShelve_InputArguments = 15367;

        /// <summary>
        /// The identifier for the CygNetAlarmType_SilenceState_Id Variable.
        /// </summary>
        public const uint CygNetAlarmType_SilenceState_Id = 15378;

        /// <summary>
        /// The identifier for the CygNetAlarmType_LatchedState_Id Variable.
        /// </summary>
        public const uint CygNetAlarmType_LatchedState_Id = 15391;

        /// <summary>
        /// The identifier for the CygNetAlarmType_IsSet Variable.
        /// </summary>
        public const uint CygNetAlarmType_IsSet = 15408;

        /// <summary>
        /// The identifier for the CygNetAlarmType_IsHidden Variable.
        /// </summary>
        public const uint CygNetAlarmType_IsHidden = 15409;

        /// <summary>
        /// The identifier for the CygNetAlarmType_AlarmPriorityCategoryDescription Variable.
        /// </summary>
        public const uint CygNetAlarmType_AlarmPriorityCategoryDescription = 15410;

        /// <summary>
        /// The identifier for the CygNetAlarmType_AlarmCondition Variable.
        /// </summary>
        public const uint CygNetAlarmType_AlarmCondition = 15411;

        /// <summary>
        /// The identifier for the CygNetAlarmType_PointState Variable.
        /// </summary>
        public const uint CygNetAlarmType_PointState = 15412;

        /// <summary>
        /// The identifier for the CygNetAlarmType_AlarmCategory Variable.
        /// </summary>
        public const uint CygNetAlarmType_AlarmCategory = 15413;

        /// <summary>
        /// The identifier for the CygNetAlarmType_AlarmPriorityCategory Variable.
        /// </summary>
        public const uint CygNetAlarmType_AlarmPriorityCategory = 15414;

        /// <summary>
        /// The identifier for the CygNetAlarmType_HighestAlarmPriority Variable.
        /// </summary>
        public const uint CygNetAlarmType_HighestAlarmPriority = 15415;

        /// <summary>
        /// The identifier for the CygNetAlarmType_HighestAlarmPrioritySinceAck Variable.
        /// </summary>
        public const uint CygNetAlarmType_HighestAlarmPrioritySinceAck = 15416;

        /// <summary>
        /// The identifier for the CygNetAlarmType_AlarmRecordVersion Variable.
        /// </summary>
        public const uint CygNetAlarmType_AlarmRecordVersion = 15417;

        /// <summary>
        /// The identifier for the CygNetAlarmType_AlarmPriority Variable.
        /// </summary>
        public const uint CygNetAlarmType_AlarmPriority = 15418;

        /// <summary>
        /// The identifier for the CygNetAlarmType_PointValue Variable.
        /// </summary>
        public const uint CygNetAlarmType_PointValue = 15419;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_ShelvingState_TimedShelve = new ExpandedNodeId(cygnet.Methods.CygNetAlarmType_ShelvingState_TimedShelve, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_ShelvingState_Unshelve = new ExpandedNodeId(cygnet.Methods.CygNetAlarmType_ShelvingState_Unshelve, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_ShelvingState_OneShotShelve = new ExpandedNodeId(cygnet.Methods.CygNetAlarmType_ShelvingState_OneShotShelve, cygnet.Namespaces.cygnet);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the CvsType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CvsType = new ExpandedNodeId(cygnet.ObjectTypes.CvsType, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType = new ExpandedNodeId(cygnet.ObjectTypes.FacilityType, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType = new ExpandedNodeId(cygnet.ObjectTypes.PointConfigurationType, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the RealtimeRecordType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId RealtimeRecordType = new ExpandedNodeId(cygnet.ObjectTypes.RealtimeRecordType, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType = new ExpandedNodeId(cygnet.ObjectTypes.CygNetAlarmType, cygnet.Namespaces.cygnet);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the CvsType_CvsDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId CvsType_CvsDescription = new ExpandedNodeId(cygnet.Variables.CvsType_CvsDescription, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilitySiteService Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilitySiteService = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilitySiteService, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityId Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityId = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityId, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilitySite Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilitySite = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilitySite, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityService Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityService = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityService, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityType Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityType = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityType, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityDescription = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityDescription, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityInfoAttribute0 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityInfoAttribute0 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityInfoAttribute0, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityInfoAttribute1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityInfoAttribute1 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityInfoAttribute1, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityCategory Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityCategory = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityCategory, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityIsActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityIsActive = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityIsActive, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilitySecurityApplication Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilitySecurityApplication = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilitySecurityApplication, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute00 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute00 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute00, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute01 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute01 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute01, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute02 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute02 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute02, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute03 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute03 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute03, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute04 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute04 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute04, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute05 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute05 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute05, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute06 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute06 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute06, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute07 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute07 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute07, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute08 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute08 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute08, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute09 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute09 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute09, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute10 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute10 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute10, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute11 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute11 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute11, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute12 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute12 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute12, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute13 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute13 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute13, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute14 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute14 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute14, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute15 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute15 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute15, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute16 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute16 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute16, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute17 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute17 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute17, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute18 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute18 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute18, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute19 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute19 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute19, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute20 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute20 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute20, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute21 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute21 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute21, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute22 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute22 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute22, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute23 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute23 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute23, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute24 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute24 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute24, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute25 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute25 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute25, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute26 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute26 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute26, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute27 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute27 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute27, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute28 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute28 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute28, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute29 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute29 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute29, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute30 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute30 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute30, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute31 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute31 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute31, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute32 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute32 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute32, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute33 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute33 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute33, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute34 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute34 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute34, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute35 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute35 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute35, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute36 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute36 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute36, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute37 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute37 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute37, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute38 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute38 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute38, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTextAttribute39 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTextAttribute39 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTextAttribute39, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute00 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute00 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute00, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute01 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute01 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute01, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute02 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute02 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute02, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute03 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute03 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute03, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute04 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute04 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute04, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute05 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute05 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute05, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute06 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute06 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute06, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute07 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute07 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute07, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute08 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute08 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute08, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute09 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute09 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute09, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute10 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute10 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute10, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute11 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute11 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute11, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute12 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute12 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute12, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute13 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute13 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute13, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute14 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute14 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute14, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute15 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute15 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute15, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute16 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute16 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute16, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute17 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute17 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute17, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute18 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute18 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute18, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute19 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute19 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute19, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute20 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute20 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute20, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute21 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute21 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute21, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute22 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute22 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute22, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute23 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute23 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute23, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute24 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute24 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute24, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute25 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute25 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute25, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute26 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute26 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute26, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute27 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute27 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute27, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute28 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute28 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute28, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute29 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute29 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute29, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute30 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute30 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute30, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute31 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute31 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute31, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute32 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute32 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute32, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute33 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute33 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute33, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute34 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute34 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute34, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute35 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute35 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute35, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute36 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute36 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute36, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute37 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute37 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute37, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute38 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute38 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute38, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute39 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute39 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute39, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute40 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute40 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute40, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute41 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute41 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute41, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute42 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute42 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute42, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute43 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute43 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute43, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute44 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute44 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute44, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute45 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute45 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute45, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute46 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute46 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute46, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute47 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute47 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute47, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute48 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute48 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute48, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute49 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute49 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute49, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute50 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute50 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute50, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute51 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute51 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute51, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute52 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute52 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute52, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute53 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute53 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute53, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute54 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute54 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute54, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute55 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute55 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute55, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute56 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute56 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute56, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute57 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute57 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute57, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute58 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute58 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute58, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute59 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute59 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute59, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute00Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute00Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute00Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute01Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute01Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute01Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute02Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute02Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute02Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute03Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute03Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute03Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute04Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute04Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute04Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute05Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute05Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute05Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute06Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute06Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute06Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute07Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute07Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute07Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute08Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute08Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute08Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute09Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute09Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute09Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute10Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute10Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute10Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute11Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute11Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute11Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute12Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute12Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute12Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute13Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute13Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute13Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute14Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute14Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute14Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute15Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute15Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute15Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute16Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute16Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute16Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute17Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute17Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute17Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute18Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute18Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute18Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute19Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute19Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute19Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute20Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute20Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute20Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute21Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute21Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute21Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute22Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute22Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute22Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute23Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute23Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute23Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute24Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute24Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute24Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute25Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute25Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute25Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute26Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute26Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute26Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute27Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute27Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute27Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute28Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute28Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute28Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute29Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute29Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute29Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute30Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute30Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute30Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute31Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute31Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute31Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute32Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute32Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute32Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute33Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute33Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute33Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute34Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute34Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute34Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute35Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute35Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute35Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute36Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute36Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute36Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute37Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute37Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute37Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute38Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute38Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute38Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute39Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute39Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute39Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute40Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute40Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute40Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute41Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute41Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute41Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute42Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute42Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute42Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute43Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute43Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute43Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute44Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute44Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute44Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute45Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute45Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute45Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute46Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute46Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute46Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute47Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute47Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute47Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute48Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute48Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute48Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute49Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute49Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute49Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute50Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute50Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute50Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute51Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute51Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute51Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute52Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute52Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute52Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute53Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute53Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute53Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute54Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute54Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute54Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute55Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute55Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute55Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute56Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute56Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute56Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute57Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute57Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute57Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute58Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute58Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute58Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTableAttribute59Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTableAttribute59Description = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTableAttribute59Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute00 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute00 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute00, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute01 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute01 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute01, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute02 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute02 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute02, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute03 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute03 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute03, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute04 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute04 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute04, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute05 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute05 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute05, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute06 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute06 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute06, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute07 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute07 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute07, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute08 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute08 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute08, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute09 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute09 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute09, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute10 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute10 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute10, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute11 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute11 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute11, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute12 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute12 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute12, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute13 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute13 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute13, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute14 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute14 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute14, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute15 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute15 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute15, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute16 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute16 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute16, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute17 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute17 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute17, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute18 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute18 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute18, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityYesNoAttribute19 Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityYesNoAttribute19 = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityYesNoAttribute19, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the FacilityType_FacilityTag Variable.
        /// </summary>
        public static readonly ExpandedNodeId FacilityType_FacilityTag = new ExpandedNodeId(cygnet.Variables.FacilityType_FacilityTag, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_PointDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_PointDescription = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_PointDescription, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_Units = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_Units, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_AlternateUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_AlternateUnits = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_AlternateUnits, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_Tag Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_Tag = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_Tag, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_TagLong Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_TagLong = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_TagLong, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_TagFull Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_TagFull = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_TagFull, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_PointId Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_PointId = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_PointId, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_PointIdLong Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_PointIdLong = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_PointIdLong, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_SiteService Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_SiteService = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_SiteService, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_Site Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_Site = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_Site, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_Service Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_Service = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_Service, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_Facility Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_Facility = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_Facility, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_UDC Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_UDC = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_UDC, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_UDCDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_UDCDescription = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_UDCDescription, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_System Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_System = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_System, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_SystemDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_SystemDescription = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_SystemDescription, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_PointDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_PointDataType = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_PointDataType, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_PointDataTypeDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_PointDataTypeDescription = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_PointDataTypeDescription, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_Comment = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_Comment, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_AlarmCategory Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_AlarmCategory = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_AlarmCategory, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_AlarmCategoryDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_AlarmCategoryDescription = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_AlarmCategoryDescription, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_AnyVerifiedFlag Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_AnyVerifiedFlag = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_AnyVerifiedFlag, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_VerifiedFlag1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_VerifiedFlag1 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_VerifiedFlag1, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_VerifiedFlag2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_VerifiedFlag2 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_VerifiedFlag2, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_VerifiedFlag3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_VerifiedFlag3 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_VerifiedFlag3, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_VerifiedFlag4 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_VerifiedFlag4 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_VerifiedFlag4, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_VerifiedTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_VerifiedTimestamp = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_VerifiedTimestamp, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_QuestionableFlag Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_QuestionableFlag = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_QuestionableFlag, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_QuestionableTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_QuestionableTimestamp = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_QuestionableTimestamp, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_AnyUserFlag Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_AnyUserFlag = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_AnyUserFlag, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_UserFlag1 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_UserFlag1, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_UserFlag2 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_UserFlag2, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_UserFlag3 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_UserFlag3, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag4 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_UserFlag4 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_UserFlag4, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag5 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_UserFlag5 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_UserFlag5, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag6 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_UserFlag6 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_UserFlag6, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag7 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_UserFlag7 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_UserFlag7, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_UserFlag8 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_UserFlag8 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_UserFlag8, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_Indexed1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_Indexed1 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_Indexed1, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_Indexed2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_Indexed2 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_Indexed2, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_Indexed3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_Indexed3 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_Indexed3, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_TableDriven1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_TableDriven1 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_TableDriven1, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_TableDriven2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_TableDriven2 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_TableDriven2, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_TableDriven3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_TableDriven3 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_TableDriven3, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_GeneralData1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_GeneralData1 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_GeneralData1, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_GeneralData2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_GeneralData2 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_GeneralData2, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_GeneralData3 Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_GeneralData3 = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_GeneralData3, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_TableDriven1Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_TableDriven1Description = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_TableDriven1Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_TableDriven2Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_TableDriven2Description = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_TableDriven2Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_TableDriven3Description Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_TableDriven3Description = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_TableDriven3Description, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_LongDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_LongDescription = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_LongDescription, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_PointScheme Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_PointScheme = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_PointScheme, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_PointSchemeDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_PointSchemeDescription = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_PointSchemeDescription, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the PointConfigurationType_ExternalId Variable.
        /// </summary>
        public static readonly ExpandedNodeId PointConfigurationType_ExternalId = new ExpandedNodeId(cygnet.Variables.PointConfigurationType_ExternalId, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the RealtimeRecordType_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId RealtimeRecordType_Value = new ExpandedNodeId(cygnet.Variables.RealtimeRecordType_Value, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the RealtimeRecordType_AlternateValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId RealtimeRecordType_AlternateValue = new ExpandedNodeId(cygnet.Variables.RealtimeRecordType_AlternateValue, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the RealtimeRecordType_Timestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId RealtimeRecordType_Timestamp = new ExpandedNodeId(cygnet.Variables.RealtimeRecordType_Timestamp, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the RealtimeRecordType_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId RealtimeRecordType_Status = new ExpandedNodeId(cygnet.Variables.RealtimeRecordType_Status, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the RealtimeRecordType_UserStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId RealtimeRecordType_UserStatus = new ExpandedNodeId(cygnet.Variables.RealtimeRecordType_UserStatus, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the RealtimeRecordType_PointStateDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId RealtimeRecordType_PointStateDescription = new ExpandedNodeId(cygnet.Variables.RealtimeRecordType_PointStateDescription, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the RealtimeRecordType_AlarmPriorityCategoryDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId RealtimeRecordType_AlarmPriorityCategoryDescription = new ExpandedNodeId(cygnet.Variables.RealtimeRecordType_AlarmPriorityCategoryDescription, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the RealtimeRecordType_AlarmConditionDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId RealtimeRecordType_AlarmConditionDescription = new ExpandedNodeId(cygnet.Variables.RealtimeRecordType_AlarmConditionDescription, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_EnabledState_Id = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_EnabledState_Id, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_Quality_SourceTimestamp = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_Quality_SourceTimestamp, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_LastSeverity_SourceTimestamp = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_LastSeverity_SourceTimestamp, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_Comment_SourceTimestamp = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_Comment_SourceTimestamp, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_AddComment_InputArguments = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_AddComment_InputArguments, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_ConditionRefresh_InputArguments = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_ConditionRefresh_InputArguments, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_ConditionRefresh2_InputArguments = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_ConditionRefresh2_InputArguments, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_AckedState_Id = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_AckedState_Id, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_ConfirmedState_Id = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_ConfirmedState_Id, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_Acknowledge_InputArguments = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_Acknowledge_InputArguments, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_Confirm_InputArguments = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_Confirm_InputArguments, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_ActiveState_Id = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_ActiveState_Id, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_SuppressedState_Id = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_SuppressedState_Id, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_OutOfServiceState_Id = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_OutOfServiceState_Id, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_ShelvingState_CurrentState = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_ShelvingState_CurrentState, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_ShelvingState_CurrentState_Id = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_ShelvingState_CurrentState_Id, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_ShelvingState_LastTransition_Id = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_ShelvingState_LastTransition_Id, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_ShelvingState_UnshelveTime = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_ShelvingState_UnshelveTime, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_ShelvingState_TimedShelve_InputArguments, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_SilenceState_Id = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_SilenceState_Id, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_LatchedState_Id = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_LatchedState_Id, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_IsSet Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_IsSet = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_IsSet, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_IsHidden Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_IsHidden = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_IsHidden, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_AlarmPriorityCategoryDescription Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_AlarmPriorityCategoryDescription = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_AlarmPriorityCategoryDescription, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_AlarmCondition Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_AlarmCondition = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_AlarmCondition, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_PointState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_PointState = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_PointState, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_AlarmCategory Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_AlarmCategory = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_AlarmCategory, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_AlarmPriorityCategory Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_AlarmPriorityCategory = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_AlarmPriorityCategory, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_HighestAlarmPriority Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_HighestAlarmPriority = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_HighestAlarmPriority, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_HighestAlarmPrioritySinceAck Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_HighestAlarmPrioritySinceAck = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_HighestAlarmPrioritySinceAck, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_AlarmRecordVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_AlarmRecordVersion = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_AlarmRecordVersion, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_AlarmPriority Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_AlarmPriority = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_AlarmPriority, cygnet.Namespaces.cygnet);

        /// <summary>
        /// The identifier for the CygNetAlarmType_PointValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId CygNetAlarmType_PointValue = new ExpandedNodeId(cygnet.Variables.CygNetAlarmType_PointValue, cygnet.Namespaces.cygnet);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the AlarmCategory component.
        /// </summary>
        public const string AlarmCategory = "AlarmCategory";

        /// <summary>
        /// The BrowseName for the AlarmCategoryDescription component.
        /// </summary>
        public const string AlarmCategoryDescription = "AlarmCategoryDescription";

        /// <summary>
        /// The BrowseName for the AlarmCondition component.
        /// </summary>
        public const string AlarmCondition = "AlarmCondition";

        /// <summary>
        /// The BrowseName for the AlarmConditionDescription component.
        /// </summary>
        public const string AlarmConditionDescription = "AlarmConditionDescription";

        /// <summary>
        /// The BrowseName for the AlarmPriority component.
        /// </summary>
        public const string AlarmPriority = "AlarmPriority";

        /// <summary>
        /// The BrowseName for the AlarmPriorityCategory component.
        /// </summary>
        public const string AlarmPriorityCategory = "AlarmPriorityCategory";

        /// <summary>
        /// The BrowseName for the AlarmPriorityCategoryDescription component.
        /// </summary>
        public const string AlarmPriorityCategoryDescription = "AlarmPriorityCategoryDescription";

        /// <summary>
        /// The BrowseName for the AlarmRecordVersion component.
        /// </summary>
        public const string AlarmRecordVersion = "AlarmRecordVersion";

        /// <summary>
        /// The BrowseName for the AlternateUnits component.
        /// </summary>
        public const string AlternateUnits = "AlternateUnits";

        /// <summary>
        /// The BrowseName for the AlternateValue component.
        /// </summary>
        public const string AlternateValue = "AlternateValue";

        /// <summary>
        /// The BrowseName for the AnyUserFlag component.
        /// </summary>
        public const string AnyUserFlag = "AnyUserFlag";

        /// <summary>
        /// The BrowseName for the AnyVerifiedFlag component.
        /// </summary>
        public const string AnyVerifiedFlag = "AnyVerifiedFlag";

        /// <summary>
        /// The BrowseName for the Comment component.
        /// </summary>
        public const string Comment = "Comment";

        /// <summary>
        /// The BrowseName for the CvsDescription component.
        /// </summary>
        public const string CvsDescription = "CvsDescription";

        /// <summary>
        /// The BrowseName for the CvsType component.
        /// </summary>
        public const string CvsType = "CvsType";

        /// <summary>
        /// The BrowseName for the CygNetAlarmType component.
        /// </summary>
        public const string CygNetAlarmType = "CygNetAlarmType";

        /// <summary>
        /// The BrowseName for the ExternalId component.
        /// </summary>
        public const string ExternalId = "ExternalId";

        /// <summary>
        /// The BrowseName for the Facility component.
        /// </summary>
        public const string Facility = "Facility";

        /// <summary>
        /// The BrowseName for the FacilityCategory component.
        /// </summary>
        public const string FacilityCategory = "FacilityCategory";

        /// <summary>
        /// The BrowseName for the FacilityDescription component.
        /// </summary>
        public const string FacilityDescription = "FacilityDescription";

        /// <summary>
        /// The BrowseName for the FacilityId component.
        /// </summary>
        public const string FacilityId = "FacilityId";

        /// <summary>
        /// The BrowseName for the FacilityInfoAttribute0 component.
        /// </summary>
        public const string FacilityInfoAttribute0 = "FacilityInfoAttribute0";

        /// <summary>
        /// The BrowseName for the FacilityInfoAttribute1 component.
        /// </summary>
        public const string FacilityInfoAttribute1 = "FacilityInfoAttribute1";

        /// <summary>
        /// The BrowseName for the FacilityIsActive component.
        /// </summary>
        public const string FacilityIsActive = "FacilityIsActive";

        /// <summary>
        /// The BrowseName for the FacilitySecurityApplication component.
        /// </summary>
        public const string FacilitySecurityApplication = "FacilitySecurityApplication";

        /// <summary>
        /// The BrowseName for the FacilityService component.
        /// </summary>
        public const string FacilityService = "FacilityService";

        /// <summary>
        /// The BrowseName for the FacilitySite component.
        /// </summary>
        public const string FacilitySite = "FacilitySite";

        /// <summary>
        /// The BrowseName for the FacilitySiteService component.
        /// </summary>
        public const string FacilitySiteService = "FacilitySiteService";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute00 component.
        /// </summary>
        public const string FacilityTableAttribute00 = "FacilityTableAttribute00";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute00Description component.
        /// </summary>
        public const string FacilityTableAttribute00Description = "FacilityTableAttribute00Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute01 component.
        /// </summary>
        public const string FacilityTableAttribute01 = "FacilityTableAttribute01";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute01Description component.
        /// </summary>
        public const string FacilityTableAttribute01Description = "FacilityTableAttribute01Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute02 component.
        /// </summary>
        public const string FacilityTableAttribute02 = "FacilityTableAttribute02";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute02Description component.
        /// </summary>
        public const string FacilityTableAttribute02Description = "FacilityTableAttribute02Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute03 component.
        /// </summary>
        public const string FacilityTableAttribute03 = "FacilityTableAttribute03";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute03Description component.
        /// </summary>
        public const string FacilityTableAttribute03Description = "FacilityTableAttribute03Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute04 component.
        /// </summary>
        public const string FacilityTableAttribute04 = "FacilityTableAttribute04";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute04Description component.
        /// </summary>
        public const string FacilityTableAttribute04Description = "FacilityTableAttribute04Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute05 component.
        /// </summary>
        public const string FacilityTableAttribute05 = "FacilityTableAttribute05";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute05Description component.
        /// </summary>
        public const string FacilityTableAttribute05Description = "FacilityTableAttribute05Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute06 component.
        /// </summary>
        public const string FacilityTableAttribute06 = "FacilityTableAttribute06";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute06Description component.
        /// </summary>
        public const string FacilityTableAttribute06Description = "FacilityTableAttribute06Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute07 component.
        /// </summary>
        public const string FacilityTableAttribute07 = "FacilityTableAttribute07";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute07Description component.
        /// </summary>
        public const string FacilityTableAttribute07Description = "FacilityTableAttribute07Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute08 component.
        /// </summary>
        public const string FacilityTableAttribute08 = "FacilityTableAttribute08";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute08Description component.
        /// </summary>
        public const string FacilityTableAttribute08Description = "FacilityTableAttribute08Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute09 component.
        /// </summary>
        public const string FacilityTableAttribute09 = "FacilityTableAttribute09";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute09Description component.
        /// </summary>
        public const string FacilityTableAttribute09Description = "FacilityTableAttribute09Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute10 component.
        /// </summary>
        public const string FacilityTableAttribute10 = "FacilityTableAttribute10";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute10Description component.
        /// </summary>
        public const string FacilityTableAttribute10Description = "FacilityTableAttribute10Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute11 component.
        /// </summary>
        public const string FacilityTableAttribute11 = "FacilityTableAttribute11";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute11Description component.
        /// </summary>
        public const string FacilityTableAttribute11Description = "FacilityTableAttribute11Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute12 component.
        /// </summary>
        public const string FacilityTableAttribute12 = "FacilityTableAttribute12";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute12Description component.
        /// </summary>
        public const string FacilityTableAttribute12Description = "FacilityTableAttribute12Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute13 component.
        /// </summary>
        public const string FacilityTableAttribute13 = "FacilityTableAttribute13";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute13Description component.
        /// </summary>
        public const string FacilityTableAttribute13Description = "FacilityTableAttribute13Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute14 component.
        /// </summary>
        public const string FacilityTableAttribute14 = "FacilityTableAttribute14";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute14Description component.
        /// </summary>
        public const string FacilityTableAttribute14Description = "FacilityTableAttribute14Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute15 component.
        /// </summary>
        public const string FacilityTableAttribute15 = "FacilityTableAttribute15";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute15Description component.
        /// </summary>
        public const string FacilityTableAttribute15Description = "FacilityTableAttribute15Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute16 component.
        /// </summary>
        public const string FacilityTableAttribute16 = "FacilityTableAttribute16";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute16Description component.
        /// </summary>
        public const string FacilityTableAttribute16Description = "FacilityTableAttribute16Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute17 component.
        /// </summary>
        public const string FacilityTableAttribute17 = "FacilityTableAttribute17";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute17Description component.
        /// </summary>
        public const string FacilityTableAttribute17Description = "FacilityTableAttribute17Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute18 component.
        /// </summary>
        public const string FacilityTableAttribute18 = "FacilityTableAttribute18";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute18Description component.
        /// </summary>
        public const string FacilityTableAttribute18Description = "FacilityTableAttribute18Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute19 component.
        /// </summary>
        public const string FacilityTableAttribute19 = "FacilityTableAttribute19";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute19Description component.
        /// </summary>
        public const string FacilityTableAttribute19Description = "FacilityTableAttribute19Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute20 component.
        /// </summary>
        public const string FacilityTableAttribute20 = "FacilityTableAttribute20";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute20Description component.
        /// </summary>
        public const string FacilityTableAttribute20Description = "FacilityTableAttribute20Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute21 component.
        /// </summary>
        public const string FacilityTableAttribute21 = "FacilityTableAttribute21";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute21Description component.
        /// </summary>
        public const string FacilityTableAttribute21Description = "FacilityTableAttribute21Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute22 component.
        /// </summary>
        public const string FacilityTableAttribute22 = "FacilityTableAttribute22";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute22Description component.
        /// </summary>
        public const string FacilityTableAttribute22Description = "FacilityTableAttribute22Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute23 component.
        /// </summary>
        public const string FacilityTableAttribute23 = "FacilityTableAttribute23";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute23Description component.
        /// </summary>
        public const string FacilityTableAttribute23Description = "FacilityTableAttribute23Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute24 component.
        /// </summary>
        public const string FacilityTableAttribute24 = "FacilityTableAttribute24";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute24Description component.
        /// </summary>
        public const string FacilityTableAttribute24Description = "FacilityTableAttribute24Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute25 component.
        /// </summary>
        public const string FacilityTableAttribute25 = "FacilityTableAttribute25";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute25Description component.
        /// </summary>
        public const string FacilityTableAttribute25Description = "FacilityTableAttribute25Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute26 component.
        /// </summary>
        public const string FacilityTableAttribute26 = "FacilityTableAttribute26";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute26Description component.
        /// </summary>
        public const string FacilityTableAttribute26Description = "FacilityTableAttribute26Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute27 component.
        /// </summary>
        public const string FacilityTableAttribute27 = "FacilityTableAttribute27";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute27Description component.
        /// </summary>
        public const string FacilityTableAttribute27Description = "FacilityTableAttribute27Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute28 component.
        /// </summary>
        public const string FacilityTableAttribute28 = "FacilityTableAttribute28";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute28Description component.
        /// </summary>
        public const string FacilityTableAttribute28Description = "FacilityTableAttribute28Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute29 component.
        /// </summary>
        public const string FacilityTableAttribute29 = "FacilityTableAttribute29";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute29Description component.
        /// </summary>
        public const string FacilityTableAttribute29Description = "FacilityTableAttribute29Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute30 component.
        /// </summary>
        public const string FacilityTableAttribute30 = "FacilityTableAttribute30";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute30Description component.
        /// </summary>
        public const string FacilityTableAttribute30Description = "FacilityTableAttribute30Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute31 component.
        /// </summary>
        public const string FacilityTableAttribute31 = "FacilityTableAttribute31";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute31Description component.
        /// </summary>
        public const string FacilityTableAttribute31Description = "FacilityTableAttribute31Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute32 component.
        /// </summary>
        public const string FacilityTableAttribute32 = "FacilityTableAttribute32";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute32Description component.
        /// </summary>
        public const string FacilityTableAttribute32Description = "FacilityTableAttribute32Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute33 component.
        /// </summary>
        public const string FacilityTableAttribute33 = "FacilityTableAttribute33";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute33Description component.
        /// </summary>
        public const string FacilityTableAttribute33Description = "FacilityTableAttribute33Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute34 component.
        /// </summary>
        public const string FacilityTableAttribute34 = "FacilityTableAttribute34";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute34Description component.
        /// </summary>
        public const string FacilityTableAttribute34Description = "FacilityTableAttribute34Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute35 component.
        /// </summary>
        public const string FacilityTableAttribute35 = "FacilityTableAttribute35";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute35Description component.
        /// </summary>
        public const string FacilityTableAttribute35Description = "FacilityTableAttribute35Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute36 component.
        /// </summary>
        public const string FacilityTableAttribute36 = "FacilityTableAttribute36";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute36Description component.
        /// </summary>
        public const string FacilityTableAttribute36Description = "FacilityTableAttribute36Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute37 component.
        /// </summary>
        public const string FacilityTableAttribute37 = "FacilityTableAttribute37";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute37Description component.
        /// </summary>
        public const string FacilityTableAttribute37Description = "FacilityTableAttribute37Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute38 component.
        /// </summary>
        public const string FacilityTableAttribute38 = "FacilityTableAttribute38";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute38Description component.
        /// </summary>
        public const string FacilityTableAttribute38Description = "FacilityTableAttribute38Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute39 component.
        /// </summary>
        public const string FacilityTableAttribute39 = "FacilityTableAttribute39";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute39Description component.
        /// </summary>
        public const string FacilityTableAttribute39Description = "FacilityTableAttribute39Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute40 component.
        /// </summary>
        public const string FacilityTableAttribute40 = "FacilityTableAttribute40";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute40Description component.
        /// </summary>
        public const string FacilityTableAttribute40Description = "FacilityTableAttribute40Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute41 component.
        /// </summary>
        public const string FacilityTableAttribute41 = "FacilityTableAttribute41";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute41Description component.
        /// </summary>
        public const string FacilityTableAttribute41Description = "FacilityTableAttribute41Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute42 component.
        /// </summary>
        public const string FacilityTableAttribute42 = "FacilityTableAttribute42";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute42Description component.
        /// </summary>
        public const string FacilityTableAttribute42Description = "FacilityTableAttribute42Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute43 component.
        /// </summary>
        public const string FacilityTableAttribute43 = "FacilityTableAttribute43";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute43Description component.
        /// </summary>
        public const string FacilityTableAttribute43Description = "FacilityTableAttribute43Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute44 component.
        /// </summary>
        public const string FacilityTableAttribute44 = "FacilityTableAttribute44";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute44Description component.
        /// </summary>
        public const string FacilityTableAttribute44Description = "FacilityTableAttribute44Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute45 component.
        /// </summary>
        public const string FacilityTableAttribute45 = "FacilityTableAttribute45";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute45Description component.
        /// </summary>
        public const string FacilityTableAttribute45Description = "FacilityTableAttribute45Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute46 component.
        /// </summary>
        public const string FacilityTableAttribute46 = "FacilityTableAttribute46";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute46Description component.
        /// </summary>
        public const string FacilityTableAttribute46Description = "FacilityTableAttribute46Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute47 component.
        /// </summary>
        public const string FacilityTableAttribute47 = "FacilityTableAttribute47";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute47Description component.
        /// </summary>
        public const string FacilityTableAttribute47Description = "FacilityTableAttribute47Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute48 component.
        /// </summary>
        public const string FacilityTableAttribute48 = "FacilityTableAttribute48";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute48Description component.
        /// </summary>
        public const string FacilityTableAttribute48Description = "FacilityTableAttribute48Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute49 component.
        /// </summary>
        public const string FacilityTableAttribute49 = "FacilityTableAttribute49";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute49Description component.
        /// </summary>
        public const string FacilityTableAttribute49Description = "FacilityTableAttribute49Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute50 component.
        /// </summary>
        public const string FacilityTableAttribute50 = "FacilityTableAttribute50";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute50Description component.
        /// </summary>
        public const string FacilityTableAttribute50Description = "FacilityTableAttribute50Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute51 component.
        /// </summary>
        public const string FacilityTableAttribute51 = "FacilityTableAttribute51";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute51Description component.
        /// </summary>
        public const string FacilityTableAttribute51Description = "FacilityTableAttribute51Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute52 component.
        /// </summary>
        public const string FacilityTableAttribute52 = "FacilityTableAttribute52";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute52Description component.
        /// </summary>
        public const string FacilityTableAttribute52Description = "FacilityTableAttribute52Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute53 component.
        /// </summary>
        public const string FacilityTableAttribute53 = "FacilityTableAttribute53";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute53Description component.
        /// </summary>
        public const string FacilityTableAttribute53Description = "FacilityTableAttribute53Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute54 component.
        /// </summary>
        public const string FacilityTableAttribute54 = "FacilityTableAttribute54";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute54Description component.
        /// </summary>
        public const string FacilityTableAttribute54Description = "FacilityTableAttribute54Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute55 component.
        /// </summary>
        public const string FacilityTableAttribute55 = "FacilityTableAttribute55";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute55Description component.
        /// </summary>
        public const string FacilityTableAttribute55Description = "FacilityTableAttribute55Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute56 component.
        /// </summary>
        public const string FacilityTableAttribute56 = "FacilityTableAttribute56";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute56Description component.
        /// </summary>
        public const string FacilityTableAttribute56Description = "FacilityTableAttribute56Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute57 component.
        /// </summary>
        public const string FacilityTableAttribute57 = "FacilityTableAttribute57";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute57Description component.
        /// </summary>
        public const string FacilityTableAttribute57Description = "FacilityTableAttribute57Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute58 component.
        /// </summary>
        public const string FacilityTableAttribute58 = "FacilityTableAttribute58";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute58Description component.
        /// </summary>
        public const string FacilityTableAttribute58Description = "FacilityTableAttribute58Description";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute59 component.
        /// </summary>
        public const string FacilityTableAttribute59 = "FacilityTableAttribute59";

        /// <summary>
        /// The BrowseName for the FacilityTableAttribute59Description component.
        /// </summary>
        public const string FacilityTableAttribute59Description = "FacilityTableAttribute59Description";

        /// <summary>
        /// The BrowseName for the FacilityTag component.
        /// </summary>
        public const string FacilityTag = "FacilityTag";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute00 component.
        /// </summary>
        public const string FacilityTextAttribute00 = "FacilityTextAttribute00";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute01 component.
        /// </summary>
        public const string FacilityTextAttribute01 = "FacilityTextAttribute01";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute02 component.
        /// </summary>
        public const string FacilityTextAttribute02 = "FacilityTextAttribute02";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute03 component.
        /// </summary>
        public const string FacilityTextAttribute03 = "FacilityTextAttribute03";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute04 component.
        /// </summary>
        public const string FacilityTextAttribute04 = "FacilityTextAttribute04";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute05 component.
        /// </summary>
        public const string FacilityTextAttribute05 = "FacilityTextAttribute05";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute06 component.
        /// </summary>
        public const string FacilityTextAttribute06 = "FacilityTextAttribute06";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute07 component.
        /// </summary>
        public const string FacilityTextAttribute07 = "FacilityTextAttribute07";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute08 component.
        /// </summary>
        public const string FacilityTextAttribute08 = "FacilityTextAttribute08";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute09 component.
        /// </summary>
        public const string FacilityTextAttribute09 = "FacilityTextAttribute09";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute10 component.
        /// </summary>
        public const string FacilityTextAttribute10 = "FacilityTextAttribute10";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute11 component.
        /// </summary>
        public const string FacilityTextAttribute11 = "FacilityTextAttribute11";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute12 component.
        /// </summary>
        public const string FacilityTextAttribute12 = "FacilityTextAttribute12";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute13 component.
        /// </summary>
        public const string FacilityTextAttribute13 = "FacilityTextAttribute13";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute14 component.
        /// </summary>
        public const string FacilityTextAttribute14 = "FacilityTextAttribute14";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute15 component.
        /// </summary>
        public const string FacilityTextAttribute15 = "FacilityTextAttribute15";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute16 component.
        /// </summary>
        public const string FacilityTextAttribute16 = "FacilityTextAttribute16";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute17 component.
        /// </summary>
        public const string FacilityTextAttribute17 = "FacilityTextAttribute17";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute18 component.
        /// </summary>
        public const string FacilityTextAttribute18 = "FacilityTextAttribute18";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute19 component.
        /// </summary>
        public const string FacilityTextAttribute19 = "FacilityTextAttribute19";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute20 component.
        /// </summary>
        public const string FacilityTextAttribute20 = "FacilityTextAttribute20";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute21 component.
        /// </summary>
        public const string FacilityTextAttribute21 = "FacilityTextAttribute21";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute22 component.
        /// </summary>
        public const string FacilityTextAttribute22 = "FacilityTextAttribute22";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute23 component.
        /// </summary>
        public const string FacilityTextAttribute23 = "FacilityTextAttribute23";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute24 component.
        /// </summary>
        public const string FacilityTextAttribute24 = "FacilityTextAttribute24";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute25 component.
        /// </summary>
        public const string FacilityTextAttribute25 = "FacilityTextAttribute25";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute26 component.
        /// </summary>
        public const string FacilityTextAttribute26 = "FacilityTextAttribute26";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute27 component.
        /// </summary>
        public const string FacilityTextAttribute27 = "FacilityTextAttribute27";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute28 component.
        /// </summary>
        public const string FacilityTextAttribute28 = "FacilityTextAttribute28";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute29 component.
        /// </summary>
        public const string FacilityTextAttribute29 = "FacilityTextAttribute29";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute30 component.
        /// </summary>
        public const string FacilityTextAttribute30 = "FacilityTextAttribute30";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute31 component.
        /// </summary>
        public const string FacilityTextAttribute31 = "FacilityTextAttribute31";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute32 component.
        /// </summary>
        public const string FacilityTextAttribute32 = "FacilityTextAttribute32";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute33 component.
        /// </summary>
        public const string FacilityTextAttribute33 = "FacilityTextAttribute33";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute34 component.
        /// </summary>
        public const string FacilityTextAttribute34 = "FacilityTextAttribute34";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute35 component.
        /// </summary>
        public const string FacilityTextAttribute35 = "FacilityTextAttribute35";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute36 component.
        /// </summary>
        public const string FacilityTextAttribute36 = "FacilityTextAttribute36";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute37 component.
        /// </summary>
        public const string FacilityTextAttribute37 = "FacilityTextAttribute37";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute38 component.
        /// </summary>
        public const string FacilityTextAttribute38 = "FacilityTextAttribute38";

        /// <summary>
        /// The BrowseName for the FacilityTextAttribute39 component.
        /// </summary>
        public const string FacilityTextAttribute39 = "FacilityTextAttribute39";

        /// <summary>
        /// The BrowseName for the FacilityType component.
        /// </summary>
        public const string FacilityType = "FacilityType";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute00 component.
        /// </summary>
        public const string FacilityYesNoAttribute00 = "FacilityYesNoAttribute00";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute01 component.
        /// </summary>
        public const string FacilityYesNoAttribute01 = "FacilityYesNoAttribute01";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute02 component.
        /// </summary>
        public const string FacilityYesNoAttribute02 = "FacilityYesNoAttribute02";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute03 component.
        /// </summary>
        public const string FacilityYesNoAttribute03 = "FacilityYesNoAttribute03";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute04 component.
        /// </summary>
        public const string FacilityYesNoAttribute04 = "FacilityYesNoAttribute04";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute05 component.
        /// </summary>
        public const string FacilityYesNoAttribute05 = "FacilityYesNoAttribute05";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute06 component.
        /// </summary>
        public const string FacilityYesNoAttribute06 = "FacilityYesNoAttribute06";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute07 component.
        /// </summary>
        public const string FacilityYesNoAttribute07 = "FacilityYesNoAttribute07";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute08 component.
        /// </summary>
        public const string FacilityYesNoAttribute08 = "FacilityYesNoAttribute08";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute09 component.
        /// </summary>
        public const string FacilityYesNoAttribute09 = "FacilityYesNoAttribute09";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute10 component.
        /// </summary>
        public const string FacilityYesNoAttribute10 = "FacilityYesNoAttribute10";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute11 component.
        /// </summary>
        public const string FacilityYesNoAttribute11 = "FacilityYesNoAttribute11";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute12 component.
        /// </summary>
        public const string FacilityYesNoAttribute12 = "FacilityYesNoAttribute12";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute13 component.
        /// </summary>
        public const string FacilityYesNoAttribute13 = "FacilityYesNoAttribute13";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute14 component.
        /// </summary>
        public const string FacilityYesNoAttribute14 = "FacilityYesNoAttribute14";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute15 component.
        /// </summary>
        public const string FacilityYesNoAttribute15 = "FacilityYesNoAttribute15";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute16 component.
        /// </summary>
        public const string FacilityYesNoAttribute16 = "FacilityYesNoAttribute16";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute17 component.
        /// </summary>
        public const string FacilityYesNoAttribute17 = "FacilityYesNoAttribute17";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute18 component.
        /// </summary>
        public const string FacilityYesNoAttribute18 = "FacilityYesNoAttribute18";

        /// <summary>
        /// The BrowseName for the FacilityYesNoAttribute19 component.
        /// </summary>
        public const string FacilityYesNoAttribute19 = "FacilityYesNoAttribute19";

        /// <summary>
        /// The BrowseName for the GeneralData1 component.
        /// </summary>
        public const string GeneralData1 = "GeneralData1";

        /// <summary>
        /// The BrowseName for the GeneralData2 component.
        /// </summary>
        public const string GeneralData2 = "GeneralData2";

        /// <summary>
        /// The BrowseName for the GeneralData3 component.
        /// </summary>
        public const string GeneralData3 = "GeneralData3";

        /// <summary>
        /// The BrowseName for the HighestAlarmPriority component.
        /// </summary>
        public const string HighestAlarmPriority = "HighestAlarmPriority";

        /// <summary>
        /// The BrowseName for the HighestAlarmPrioritySinceAck component.
        /// </summary>
        public const string HighestAlarmPrioritySinceAck = "HighestAlarmPrioritySinceAck";

        /// <summary>
        /// The BrowseName for the Indexed1 component.
        /// </summary>
        public const string Indexed1 = "Indexed1";

        /// <summary>
        /// The BrowseName for the Indexed2 component.
        /// </summary>
        public const string Indexed2 = "Indexed2";

        /// <summary>
        /// The BrowseName for the Indexed3 component.
        /// </summary>
        public const string Indexed3 = "Indexed3";

        /// <summary>
        /// The BrowseName for the IsHidden component.
        /// </summary>
        public const string IsHidden = "IsHidden";

        /// <summary>
        /// The BrowseName for the IsSet component.
        /// </summary>
        public const string IsSet = "IsSet";

        /// <summary>
        /// The BrowseName for the LongDescription component.
        /// </summary>
        public const string LongDescription = "LongDescription";

        /// <summary>
        /// The BrowseName for the PointConfigurationType component.
        /// </summary>
        public const string PointConfigurationType = "PointConfigurationType";

        /// <summary>
        /// The BrowseName for the PointDataType component.
        /// </summary>
        public const string PointDataType = "PointDataType";

        /// <summary>
        /// The BrowseName for the PointDataTypeDescription component.
        /// </summary>
        public const string PointDataTypeDescription = "PointDataTypeDescription";

        /// <summary>
        /// The BrowseName for the PointDescription component.
        /// </summary>
        public const string PointDescription = "PointDescription";

        /// <summary>
        /// The BrowseName for the PointId component.
        /// </summary>
        public const string PointId = "PointId";

        /// <summary>
        /// The BrowseName for the PointIdLong component.
        /// </summary>
        public const string PointIdLong = "PointIdLong";

        /// <summary>
        /// The BrowseName for the PointScheme component.
        /// </summary>
        public const string PointScheme = "PointScheme";

        /// <summary>
        /// The BrowseName for the PointSchemeDescription component.
        /// </summary>
        public const string PointSchemeDescription = "PointSchemeDescription";

        /// <summary>
        /// The BrowseName for the PointState component.
        /// </summary>
        public const string PointState = "PointState";

        /// <summary>
        /// The BrowseName for the PointStateDescription component.
        /// </summary>
        public const string PointStateDescription = "PointStateDescription";

        /// <summary>
        /// The BrowseName for the PointValue component.
        /// </summary>
        public const string PointValue = "PointValue";

        /// <summary>
        /// The BrowseName for the QuestionableFlag component.
        /// </summary>
        public const string QuestionableFlag = "QuestionableFlag";

        /// <summary>
        /// The BrowseName for the QuestionableTimestamp component.
        /// </summary>
        public const string QuestionableTimestamp = "QuestionableTimestamp";

        /// <summary>
        /// The BrowseName for the RealtimeRecordType component.
        /// </summary>
        public const string RealtimeRecordType = "RealtimeRecordType";

        /// <summary>
        /// The BrowseName for the Service component.
        /// </summary>
        public const string Service = "Service";

        /// <summary>
        /// The BrowseName for the Site component.
        /// </summary>
        public const string Site = "Site";

        /// <summary>
        /// The BrowseName for the SiteService component.
        /// </summary>
        public const string SiteService = "SiteService";

        /// <summary>
        /// The BrowseName for the Status component.
        /// </summary>
        public const string Status = "Status";

        /// <summary>
        /// The BrowseName for the System component.
        /// </summary>
        public const string System = "System";

        /// <summary>
        /// The BrowseName for the SystemDescription component.
        /// </summary>
        public const string SystemDescription = "SystemDescription";

        /// <summary>
        /// The BrowseName for the TableDriven1 component.
        /// </summary>
        public const string TableDriven1 = "TableDriven1";

        /// <summary>
        /// The BrowseName for the TableDriven1Description component.
        /// </summary>
        public const string TableDriven1Description = "TableDriven1Description";

        /// <summary>
        /// The BrowseName for the TableDriven2 component.
        /// </summary>
        public const string TableDriven2 = "TableDriven2";

        /// <summary>
        /// The BrowseName for the TableDriven2Description component.
        /// </summary>
        public const string TableDriven2Description = "TableDriven2Description";

        /// <summary>
        /// The BrowseName for the TableDriven3 component.
        /// </summary>
        public const string TableDriven3 = "TableDriven3";

        /// <summary>
        /// The BrowseName for the TableDriven3Description component.
        /// </summary>
        public const string TableDriven3Description = "TableDriven3Description";

        /// <summary>
        /// The BrowseName for the Tag component.
        /// </summary>
        public const string Tag = "Tag";

        /// <summary>
        /// The BrowseName for the TagFull component.
        /// </summary>
        public const string TagFull = "TagFull";

        /// <summary>
        /// The BrowseName for the TagLong component.
        /// </summary>
        public const string TagLong = "TagLong";

        /// <summary>
        /// The BrowseName for the Timestamp component.
        /// </summary>
        public const string Timestamp = "Timestamp";

        /// <summary>
        /// The BrowseName for the UDC component.
        /// </summary>
        public const string UDC = "UDC";

        /// <summary>
        /// The BrowseName for the UDCDescription component.
        /// </summary>
        public const string UDCDescription = "UDCDescription";

        /// <summary>
        /// The BrowseName for the Units component.
        /// </summary>
        public const string Units = "Units";

        /// <summary>
        /// The BrowseName for the UserFlag1 component.
        /// </summary>
        public const string UserFlag1 = "UserFlag1";

        /// <summary>
        /// The BrowseName for the UserFlag2 component.
        /// </summary>
        public const string UserFlag2 = "UserFlag2";

        /// <summary>
        /// The BrowseName for the UserFlag3 component.
        /// </summary>
        public const string UserFlag3 = "UserFlag3";

        /// <summary>
        /// The BrowseName for the UserFlag4 component.
        /// </summary>
        public const string UserFlag4 = "UserFlag4";

        /// <summary>
        /// The BrowseName for the UserFlag5 component.
        /// </summary>
        public const string UserFlag5 = "UserFlag5";

        /// <summary>
        /// The BrowseName for the UserFlag6 component.
        /// </summary>
        public const string UserFlag6 = "UserFlag6";

        /// <summary>
        /// The BrowseName for the UserFlag7 component.
        /// </summary>
        public const string UserFlag7 = "UserFlag7";

        /// <summary>
        /// The BrowseName for the UserFlag8 component.
        /// </summary>
        public const string UserFlag8 = "UserFlag8";

        /// <summary>
        /// The BrowseName for the UserStatus component.
        /// </summary>
        public const string UserStatus = "UserStatus";

        /// <summary>
        /// The BrowseName for the Value component.
        /// </summary>
        public const string Value = "Value";

        /// <summary>
        /// The BrowseName for the VerifiedFlag1 component.
        /// </summary>
        public const string VerifiedFlag1 = "VerifiedFlag1";

        /// <summary>
        /// The BrowseName for the VerifiedFlag2 component.
        /// </summary>
        public const string VerifiedFlag2 = "VerifiedFlag2";

        /// <summary>
        /// The BrowseName for the VerifiedFlag3 component.
        /// </summary>
        public const string VerifiedFlag3 = "VerifiedFlag3";

        /// <summary>
        /// The BrowseName for the VerifiedFlag4 component.
        /// </summary>
        public const string VerifiedFlag4 = "VerifiedFlag4";

        /// <summary>
        /// The BrowseName for the VerifiedTimestamp component.
        /// </summary>
        public const string VerifiedTimestamp = "VerifiedTimestamp";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the cygnet namespace (.NET code namespace is 'cygnet').
        /// </summary>
        public const string cygnet = "https://weatherford.com/UA/cygnet/";

        /// <summary>
        /// The URI for the cygnetXsd namespace (.NET code namespace is 'cygnet').
        /// </summary>
        public const string cygnetXsd = "https://weatherford.com/UA/cygnet/2020/09/Types.xsd";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion
}
