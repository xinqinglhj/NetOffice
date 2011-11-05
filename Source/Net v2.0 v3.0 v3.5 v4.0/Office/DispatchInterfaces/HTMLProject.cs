//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface HTMLProject SupportByLibrary Office, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Office", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class HTMLProject : _IMsoDispObj
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(HTMLProject);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLProject(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLProject(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLProject(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLProject() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLProject(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoHTMLProjectState State
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "State", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoHTMLProjectState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.HTMLProjectItems HTMLProjectItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HTMLProjectItems", paramsArray);
				NetOffice.OfficeApi.HTMLProjectItems newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.HTMLProjectItems.LateBindingApiWrapperType) as NetOffice.OfficeApi.HTMLProjectItems;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Refresh">bool Refresh</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void RefreshProject(bool refresh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(refresh);
			Invoker.Method(this, "RefreshProject", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Refresh">bool Refresh</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void RefreshDocument(bool refresh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(refresh);
			Invoker.Method(this, "RefreshDocument", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="OpenKind">NetOffice.OfficeApi.Enums.MsoHTMLProjectOpen OpenKind</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public void Open(NetOffice.OfficeApi.Enums.MsoHTMLProjectOpen openKind)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(openKind);
			Invoker.Method(this, "Open", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}