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
    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the Order_Vinyl Object.
        /// </summary>
        public const uint Order_Vinyl = 14;

        /// <summary>
        /// The identifier for the Order_Client Object.
        /// </summary>
        public const uint Order_Client = 13;
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
        /// The identifier for the Client ObjectType.
        /// </summary>
        public const uint Client = 1;

        /// <summary>
        /// The identifier for the Vinyl ObjectType.
        /// </summary>
        public const uint Vinyl = 5;

        /// <summary>
        /// The identifier for the Order ObjectType.
        /// </summary>
        public const uint Order = 11;
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
        /// The identifier for the Client_ID Variable.
        /// </summary>
        public const uint Client_ID = 2;

        /// <summary>
        /// The identifier for the Client_name Variable.
        /// </summary>
        public const uint Client_name = 3;

        /// <summary>
        /// The identifier for the Client_address Variable.
        /// </summary>
        public const uint Client_address = 4;

        /// <summary>
        /// The identifier for the Vinyl_ID Variable.
        /// </summary>
        public const uint Vinyl_ID = 6;

        /// <summary>
        /// The identifier for the Vinyl_Title Variable.
        /// </summary>
        public const uint Vinyl_Title = 7;

        /// <summary>
        /// The identifier for the Vinyl_Band Variable.
        /// </summary>
        public const uint Vinyl_Band = 8;

        /// <summary>
        /// The identifier for the Vinyl_Price Variable.
        /// </summary>
        public const uint Vinyl_Price = 9;

        /// <summary>
        /// The identifier for the Vinyl_InStock Variable.
        /// </summary>
        public const uint Vinyl_InStock = 10;

        /// <summary>
        /// The identifier for the Order_ID Variable.
        /// </summary>
        public const uint Order_ID = 12;
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the Order_Vinyl Object.
        /// </summary>
        public static readonly ExpandedNodeId Order_Vinyl = new ExpandedNodeId(Dependencies.Objects.Order_Vinyl, Dependencies.Namespaces.Dependencies);

        /// <summary>
        /// The identifier for the Order_Client Object.
        /// </summary>
        public static readonly ExpandedNodeId Order_Client = new ExpandedNodeId(Dependencies.Objects.Order_Client, Dependencies.Namespaces.Dependencies);
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
        /// The identifier for the Client ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Client = new ExpandedNodeId(Dependencies.ObjectTypes.Client, Dependencies.Namespaces.Dependencies);

        /// <summary>
        /// The identifier for the Vinyl ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Vinyl = new ExpandedNodeId(Dependencies.ObjectTypes.Vinyl, Dependencies.Namespaces.Dependencies);

        /// <summary>
        /// The identifier for the Order ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Order = new ExpandedNodeId(Dependencies.ObjectTypes.Order, Dependencies.Namespaces.Dependencies);
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
        /// The identifier for the Client_ID Variable.
        /// </summary>
        public static readonly ExpandedNodeId Client_ID = new ExpandedNodeId(Dependencies.Variables.Client_ID, Dependencies.Namespaces.Dependencies);

        /// <summary>
        /// The identifier for the Client_name Variable.
        /// </summary>
        public static readonly ExpandedNodeId Client_name = new ExpandedNodeId(Dependencies.Variables.Client_name, Dependencies.Namespaces.Dependencies);

        /// <summary>
        /// The identifier for the Client_address Variable.
        /// </summary>
        public static readonly ExpandedNodeId Client_address = new ExpandedNodeId(Dependencies.Variables.Client_address, Dependencies.Namespaces.Dependencies);

        /// <summary>
        /// The identifier for the Vinyl_ID Variable.
        /// </summary>
        public static readonly ExpandedNodeId Vinyl_ID = new ExpandedNodeId(Dependencies.Variables.Vinyl_ID, Dependencies.Namespaces.Dependencies);

        /// <summary>
        /// The identifier for the Vinyl_Title Variable.
        /// </summary>
        public static readonly ExpandedNodeId Vinyl_Title = new ExpandedNodeId(Dependencies.Variables.Vinyl_Title, Dependencies.Namespaces.Dependencies);

        /// <summary>
        /// The identifier for the Vinyl_Band Variable.
        /// </summary>
        public static readonly ExpandedNodeId Vinyl_Band = new ExpandedNodeId(Dependencies.Variables.Vinyl_Band, Dependencies.Namespaces.Dependencies);

        /// <summary>
        /// The identifier for the Vinyl_Price Variable.
        /// </summary>
        public static readonly ExpandedNodeId Vinyl_Price = new ExpandedNodeId(Dependencies.Variables.Vinyl_Price, Dependencies.Namespaces.Dependencies);

        /// <summary>
        /// The identifier for the Vinyl_InStock Variable.
        /// </summary>
        public static readonly ExpandedNodeId Vinyl_InStock = new ExpandedNodeId(Dependencies.Variables.Vinyl_InStock, Dependencies.Namespaces.Dependencies);

        /// <summary>
        /// The identifier for the Order_ID Variable.
        /// </summary>
        public static readonly ExpandedNodeId Order_ID = new ExpandedNodeId(Dependencies.Variables.Order_ID, Dependencies.Namespaces.Dependencies);
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
        /// The BrowseName for the Order component.
        /// </summary>
        public const string Order = "Order";

        /// <summary>
        /// The BrowseName for the Price component.
        /// </summary>
        public const string Price = "Price";

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
        /// The URI for the Dependencies namespace (.NET code namespace is 'Dependencies').
        /// </summary>
        public const string Dependencies = "http://Helvete.eu/UA/CommServer/";

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

    #region ClientState Class
    #if (!OPCUA_EXCLUDE_ClientState)
    /// <summary>
    /// Stores an instance of the Client ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ClientState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ClientState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Dependencies.ObjectTypes.Client, Dependencies.Namespaces.Dependencies, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vSGVsdmV0ZS5ldS9VQS9Db21tU2VydmVyL/////8EYIAAAQAAAAEADgAAAENs" +
           "aWVudEluc3RhbmNlAQEBAAEBAQD/////AwAAABVgiQoCAAAAAQACAAAASUQBAQIAAC8APwIAAAAABv//" +
           "//8BAf////8AAAAAFWCJCgIAAAABAAQAAABuYW1lAQEDAAAvAD8DAAAAAAz/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAHAAAAYWRkcmVzcwEBBAAALwA/BAAAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ID Variable.
        /// </summary>
        public BaseDataVariableState<int> ID
        {
            get
            {
                return m_iD;
            }

            set
            {
                if (!Object.ReferenceEquals(m_iD, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_iD = value;
            }
        }

        /// <summary>
        /// A description for the name Variable.
        /// </summary>
        public BaseDataVariableState<string> name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <summary>
        /// A description for the address Variable.
        /// </summary>
        public BaseDataVariableState<string> address
        {
            get
            {
                return m_address;
            }

            set
            {
                if (!Object.ReferenceEquals(m_address, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_address = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_iD != null)
            {
                children.Add(m_iD);
            }

            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_address != null)
            {
                children.Add(m_address);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Dependencies.BrowseNames.ID:
                {
                    if (createOrReplace)
                    {
                        if (ID == null)
                        {
                            if (replacement == null)
                            {
                                ID = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                ID = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = ID;
                    break;
                }

                case Dependencies.BrowseNames.name:
                {
                    if (createOrReplace)
                    {
                        if (name == null)
                        {
                            if (replacement == null)
                            {
                                name = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                name = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = name;
                    break;
                }

                case Dependencies.BrowseNames.address:
                {
                    if (createOrReplace)
                    {
                        if (address == null)
                        {
                            if (replacement == null)
                            {
                                address = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                address = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = address;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<int> m_iD;
        private BaseDataVariableState<string> m_name;
        private BaseDataVariableState<string> m_address;
        #endregion
    }
    #endif
    #endregion

    #region VinylState Class
    #if (!OPCUA_EXCLUDE_VinylState)
    /// <summary>
    /// Stores an instance of the Vinyl ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class VinylState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public VinylState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Dependencies.ObjectTypes.Vinyl, Dependencies.Namespaces.Dependencies, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vSGVsdmV0ZS5ldS9VQS9Db21tU2VydmVyL/////8EYIAAAQAAAAEADQAAAFZp" +
           "bnlsSW5zdGFuY2UBAQUAAQEFAP////8FAAAAFWCJCgIAAAABAAIAAABJRAEBBgAALwA/BgAAAAAG////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEABQAAAFRpdGxlAQEHAAAvAD8HAAAAAAz/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAEAAAAQmFuZAEBCAAALwA/CAAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFBy" +
           "aWNlAQEJAAAvAD8JAAAAADL/////AQH/////AAAAABVgiQoCAAAAAQAHAAAASW5TdG9jawEBCgAALwA/" +
           "CgAAAAAG/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ID Variable.
        /// </summary>
        public BaseDataVariableState<int> ID
        {
            get
            {
                return m_iD;
            }

            set
            {
                if (!Object.ReferenceEquals(m_iD, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_iD = value;
            }
        }

        /// <summary>
        /// A description for the Title Variable.
        /// </summary>
        public BaseDataVariableState<string> Title
        {
            get
            {
                return m_title;
            }

            set
            {
                if (!Object.ReferenceEquals(m_title, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_title = value;
            }
        }

        /// <summary>
        /// A description for the Band Variable.
        /// </summary>
        public BaseDataVariableState<string> Band
        {
            get
            {
                return m_band;
            }

            set
            {
                if (!Object.ReferenceEquals(m_band, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_band = value;
            }
        }

        /// <summary>
        /// A description for the Price Variable.
        /// </summary>
        public BaseDataVariableState Price
        {
            get
            {
                return m_price;
            }

            set
            {
                if (!Object.ReferenceEquals(m_price, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_price = value;
            }
        }

        /// <summary>
        /// A description for the InStock Variable.
        /// </summary>
        public BaseDataVariableState<int> InStock
        {
            get
            {
                return m_inStock;
            }

            set
            {
                if (!Object.ReferenceEquals(m_inStock, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_inStock = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_iD != null)
            {
                children.Add(m_iD);
            }

            if (m_title != null)
            {
                children.Add(m_title);
            }

            if (m_band != null)
            {
                children.Add(m_band);
            }

            if (m_price != null)
            {
                children.Add(m_price);
            }

            if (m_inStock != null)
            {
                children.Add(m_inStock);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Dependencies.BrowseNames.ID:
                {
                    if (createOrReplace)
                    {
                        if (ID == null)
                        {
                            if (replacement == null)
                            {
                                ID = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                ID = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = ID;
                    break;
                }

                case Dependencies.BrowseNames.Title:
                {
                    if (createOrReplace)
                    {
                        if (Title == null)
                        {
                            if (replacement == null)
                            {
                                Title = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Title = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Title;
                    break;
                }

                case Dependencies.BrowseNames.Band:
                {
                    if (createOrReplace)
                    {
                        if (Band == null)
                        {
                            if (replacement == null)
                            {
                                Band = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Band = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Band;
                    break;
                }

                case Dependencies.BrowseNames.Price:
                {
                    if (createOrReplace)
                    {
                        if (Price == null)
                        {
                            if (replacement == null)
                            {
                                Price = new BaseDataVariableState(this);
                            }
                            else
                            {
                                Price = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = Price;
                    break;
                }

                case Dependencies.BrowseNames.InStock:
                {
                    if (createOrReplace)
                    {
                        if (InStock == null)
                        {
                            if (replacement == null)
                            {
                                InStock = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                InStock = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = InStock;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<int> m_iD;
        private BaseDataVariableState<string> m_title;
        private BaseDataVariableState<string> m_band;
        private BaseDataVariableState m_price;
        private BaseDataVariableState<int> m_inStock;
        #endregion
    }
    #endif
    #endregion

    #region OrderState Class
    #if (!OPCUA_EXCLUDE_OrderState)
    /// <summary>
    /// Stores an instance of the Order ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OrderState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public OrderState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Dependencies.ObjectTypes.Order, Dependencies.Namespaces.Dependencies, namespaceUris);
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
           "AQAAACAAAABodHRwOi8vSGVsdmV0ZS5ldS9VQS9Db21tU2VydmVyL/////8EYIAAAQAAAAEADQAAAE9y" +
           "ZGVySW5zdGFuY2UBAQsAAQELAP////8DAAAAFWCJCgIAAAABAAIAAABJRAEBDAAALwA/DAAAAAAG////" +
           "/wEB/////wAAAAAEYIAKAQAAAAEABQAAAFZpbnlsAQEOAAAvADoOAAAA/////wAAAAAEYIAKAQAAAAEA" +
           "BgAAAENsaWVudAEBDQAALwA6DQAAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ID Variable.
        /// </summary>
        public BaseDataVariableState<int> ID
        {
            get
            {
                return m_iD;
            }

            set
            {
                if (!Object.ReferenceEquals(m_iD, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_iD = value;
            }
        }

        /// <summary>
        /// A description for the Vinyl Object.
        /// </summary>
        public BaseObjectState Vinyl
        {
            get
            {
                return m_vinyl;
            }

            set
            {
                if (!Object.ReferenceEquals(m_vinyl, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vinyl = value;
            }
        }

        /// <summary>
        /// A description for the Client Object.
        /// </summary>
        public BaseObjectState Client
        {
            get
            {
                return m_client;
            }

            set
            {
                if (!Object.ReferenceEquals(m_client, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_client = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_iD != null)
            {
                children.Add(m_iD);
            }

            if (m_vinyl != null)
            {
                children.Add(m_vinyl);
            }

            if (m_client != null)
            {
                children.Add(m_client);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Dependencies.BrowseNames.ID:
                {
                    if (createOrReplace)
                    {
                        if (ID == null)
                        {
                            if (replacement == null)
                            {
                                ID = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                ID = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = ID;
                    break;
                }

                case Dependencies.BrowseNames.Vinyl:
                {
                    if (createOrReplace)
                    {
                        if (Vinyl == null)
                        {
                            if (replacement == null)
                            {
                                Vinyl = new BaseObjectState(this);
                            }
                            else
                            {
                                Vinyl = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Vinyl;
                    break;
                }

                case Dependencies.BrowseNames.Client:
                {
                    if (createOrReplace)
                    {
                        if (Client == null)
                        {
                            if (replacement == null)
                            {
                                Client = new BaseObjectState(this);
                            }
                            else
                            {
                                Client = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Client;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<int> m_iD;
        private BaseObjectState m_vinyl;
        private BaseObjectState m_client;
        #endregion
    }
    #endif
    #endregion
}