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
using Dependencies;
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
        /// The identifier for the SOrder_Vinyl Variable.
        /// </summary>
        public const uint SOrder_Vinyl = 20;

        /// <summary>
        /// The identifier for the SOrder_ID Variable.
        /// </summary>
        public const uint SOrder_ID = 21;

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
        /// The identifier for the SOrder_Vinyl Variable.
        /// </summary>
        public static readonly NodeId SOrder_Vinyl = new NodeId(Dependencies.Variables.SOrder_Vinyl);

        /// <summary>
        /// The identifier for the SOrder_ID Variable.
        /// </summary>
        public static readonly NodeId SOrder_ID = new NodeId(Dependencies.Variables.SOrder_ID);

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

        /// <summary>
        /// The URI for the Helvete namespace (.NET code namespace is 'Dependencies').
        /// </summary>
        public const string Helvete = "http://Helvete.org/UA/";
    }
    #endregion

    #region SClientState Class
    #if (!OPCUA_EXCLUDE_SClientState)
    /// <summary>
    /// Stores an instance of the SClient ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SClientState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SClientState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Dependencies.ObjectTypes.SClient, Dependencies.Namespaces.Helvete, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAABYAAABodHRwOi8vSGVsdmV0ZS5vcmcvVUEv/////wRggAABAAAAAQAPAAAAU0NsaWVudEluc3Rh" +
           "bmNlAQEJAAEBCQD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region SVinylState Class
    #if (!OPCUA_EXCLUDE_SVinylState)
    /// <summary>
    /// Stores an instance of the SVinyl ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SVinylState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SVinylState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Dependencies.ObjectTypes.SVinyl, Dependencies.Namespaces.Helvete, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAABYAAABodHRwOi8vSGVsdmV0ZS5vcmcvVUEv/////wRggAABAAAAAQAOAAAAU1ZpbnlsSW5zdGFu" +
           "Y2UBAQ0AAQENAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region SOrderState Class
    #if (!OPCUA_EXCLUDE_SOrderState)
    /// <summary>
    /// Stores an instance of the SOrder ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SOrderState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SOrderState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Dependencies.ObjectTypes.SOrder, Dependencies.Namespaces.Helvete, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAABYAAABodHRwOi8vSGVsdmV0ZS5vcmcvVUEv/////wRggAABAAAAAQAOAAAAU09yZGVySW5zdGFu" +
           "Y2UBARMAAQETAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}