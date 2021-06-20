/* ========================================================================
 * Copyright (c) 2005-2016 The OPC Foundation, Inc. All rights reserved.
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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Dependencies
{
    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the SClient ObjectType.
        /// </summary>
        public const uint SClient = 9;

        /// <summary>
        /// The identifier for the SVinyl ObjectType.
        /// </summary>
        public const uint SVinyl = 13;

        /// <summary>
        /// The identifier for the SOrder ObjectType.
        /// </summary>
        public const uint SOrder = 19;
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
        /// The identifier for the SClient_ID Variable.
        /// </summary>
        public const uint SClient_ID = 10;

        /// <summary>
        /// The identifier for the SClient_name Variable.
        /// </summary>
        public const uint SClient_name = 11;

        /// <summary>
        /// The identifier for the SClient_address Variable.
        /// </summary>
        public const uint SClient_address = 12;

        /// <summary>
        /// The identifier for the SVinyl_ID Variable.
        /// </summary>
        public const uint SVinyl_ID = 14;

        /// <summary>
        /// The identifier for the SVinyl_Title Variable.
        /// </summary>
        public const uint SVinyl_Title = 15;

        /// <summary>
        /// The identifier for the SVinyl_Band Variable.
        /// </summary>
        public const uint SVinyl_Band = 16;

        /// <summary>
        /// The identifier for the SVinyl_Price Variable.
        /// </summary>
        public const uint SVinyl_Price = 17;

        /// <summary>
        /// The identifier for the SVinyl_InStock Variable.
        /// </summary>
        public const uint SVinyl_InStock = 18;

        /// <summary>
        /// The identifier for the SOrder_ID Variable.
        /// </summary>
        public const uint SOrder_ID = 20;

        /// <summary>
        /// The identifier for the SOrder_Vinyl Variable.
        /// </summary>
        public const uint SOrder_Vinyl = 21;

        /// <summary>
        /// The identifier for the SOrder_Client Variable.
        /// </summary>
        public const uint SOrder_Client = 22;
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
        /// The identifier for the SClient ObjectType.
        /// </summary>
        public static readonly NodeId SClient = new NodeId(Dependencies.ObjectTypes.SClient);

        /// <summary>
        /// The identifier for the SVinyl ObjectType.
        /// </summary>
        public static readonly NodeId SVinyl = new NodeId(Dependencies.ObjectTypes.SVinyl);

        /// <summary>
        /// The identifier for the SOrder ObjectType.
        /// </summary>
        public static readonly NodeId SOrder = new NodeId(Dependencies.ObjectTypes.SOrder);
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
        /// The identifier for the SClient_ID Variable.
        /// </summary>
        public static readonly NodeId SClient_ID = new NodeId(Dependencies.Variables.SClient_ID);

        /// <summary>
        /// The identifier for the SClient_name Variable.
        /// </summary>
        public static readonly NodeId SClient_name = new NodeId(Dependencies.Variables.SClient_name);

        /// <summary>
        /// The identifier for the SClient_address Variable.
        /// </summary>
        public static readonly NodeId SClient_address = new NodeId(Dependencies.Variables.SClient_address);

        /// <summary>
        /// The identifier for the SVinyl_ID Variable.
        /// </summary>
        public static readonly NodeId SVinyl_ID = new NodeId(Dependencies.Variables.SVinyl_ID);

        /// <summary>
        /// The identifier for the SVinyl_Title Variable.
        /// </summary>
        public static readonly NodeId SVinyl_Title = new NodeId(Dependencies.Variables.SVinyl_Title);

        /// <summary>
        /// The identifier for the SVinyl_Band Variable.
        /// </summary>
        public static readonly NodeId SVinyl_Band = new NodeId(Dependencies.Variables.SVinyl_Band);

        /// <summary>
        /// The identifier for the SVinyl_Price Variable.
        /// </summary>
        public static readonly NodeId SVinyl_Price = new NodeId(Dependencies.Variables.SVinyl_Price);

        /// <summary>
        /// The identifier for the SVinyl_InStock Variable.
        /// </summary>
        public static readonly NodeId SVinyl_InStock = new NodeId(Dependencies.Variables.SVinyl_InStock);

        /// <summary>
        /// The identifier for the SOrder_ID Variable.
        /// </summary>
        public static readonly NodeId SOrder_ID = new NodeId(Dependencies.Variables.SOrder_ID);

        /// <summary>
        /// The identifier for the SOrder_Vinyl Variable.
        /// </summary>
        public static readonly NodeId SOrder_Vinyl = new NodeId(Dependencies.Variables.SOrder_Vinyl);

        /// <summary>
        /// The identifier for the SOrder_Client Variable.
        /// </summary>
        public static readonly NodeId SOrder_Client = new NodeId(Dependencies.Variables.SOrder_Client);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the address component.
        /// </summary>
        public const string address = "address";

        /// <summary>
        /// The BrowseName for the Band component.
        /// </summary>
        public const string Band = "Band";

        /// <summary>
        /// The BrowseName for the Client component.
        /// </summary>
        public const string Client = "Client";

        /// <summary>
        /// The BrowseName for the ID component.
        /// </summary>
        public const string ID = "ID";

        /// <summary>
        /// The BrowseName for the InStock component.
        /// </summary>
        public const string InStock = "InStock";

        /// <summary>
        /// The BrowseName for the name component.
        /// </summary>
        public const string name = "name";

        /// <summary>
        /// The BrowseName for the Price component.
        /// </summary>
        public const string Price = "Price";

        /// <summary>
        /// The BrowseName for the SClient component.
        /// </summary>
        public const string SClient = "SClient";

        /// <summary>
        /// The BrowseName for the SOrder component.
        /// </summary>
        public const string SOrder = "SOrder";

        /// <summary>
        /// The BrowseName for the SVinyl component.
        /// </summary>
        public const string SVinyl = "SVinyl";

        /// <summary>
        /// The BrowseName for the Title component.
        /// </summary>
        public const string Title = "Title";

        /// <summary>
        /// The BrowseName for the Vinyl component.
        /// </summary>
        public const string Vinyl = "Vinyl";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the ua namespace (.NET code namespace is 'Dependencies').
        /// </summary>
        public const string ua = "http://opcfoundation.org/UA/";
    }
    #endregion

}