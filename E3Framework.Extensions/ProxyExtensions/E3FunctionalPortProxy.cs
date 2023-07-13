using e3;
using E3Framework.Abstractions.ProxyClasses;

namespace E3Framework.Extensions.ProxyExtensions
{
    /// <summary>
    /// Proxy class (generated for E3.series 2015.1613)
    /// </summary>
     public static class E3FunctionalPortProxy
    {
        public static int CreateExt<T>(this ProxyBase<T> proxyRef,int fuId, string name) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.Create(fuId, name);
        }

        public static int DeleteExt<T>(this ProxyBase<T> proxyRef) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.Delete();
        }

        public static int GetConnectedPortsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetConnectedPorts(ref ids);
        }

        public static string GetConnectorNameExt<T>(this ProxyBase<T> proxyRef) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetConnectorName();
        }

        public static int GetConnectorPinIDExt<T>(this ProxyBase<T> proxyRef) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetConnectorPinID();
        }

        public static int GetFunctionalUnitIdExt<T>(this ProxyBase<T> proxyRef) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetFunctionalUnitId();
        }

        public static int GetIdExt<T>(this ProxyBase<T> proxyRef) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetId();
        }

        public static string GetNameExt<T>(this ProxyBase<T> proxyRef) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetName();
        }

        public static int GetNodeIDExt<T>(this ProxyBase<T> proxyRef) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetNodeID();
        }

        public static int GetPinIDExt<T>(this ProxyBase<T> proxyRef) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetPinID();
        }

        public static string GetPinNameExt<T>(this ProxyBase<T> proxyRef) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetPinName();
        }

        public static int GetPortTypeExt<T>(this ProxyBase<T> proxyRef) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetPortType();
        }

        public static int GetSignalEquivExt<T>(this ProxyBase<T> proxyRef) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetSignalEquiv();
        }

        public static int GetSignalEqvPortsExt<T>(this ProxyBase<T> proxyRef,ref object ids) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetSignalEqvPorts(ref ids);
        }

        public static string GetSignalNameExt<T>(this ProxyBase<T> proxyRef) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetSignalName();
        }

        public static string GetTranslatedSignalNameExt<T>(this ProxyBase<T> proxyRef) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetTranslatedSignalName();
        }

        public static int GetUserDefinedExt<T>(this ProxyBase<T> proxyRef) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.GetUserDefined();
        }

        public static string SetConnectorNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.SetConnectorName(name);
        }

        public static int SetConnectorPinIDExt<T>(this ProxyBase<T> proxyRef,int id) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.SetConnectorPinID(id);
        }

        public static int SetIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.SetId(id);
        }

        public static int SetNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.SetName(name);
        }

        public static int SetNodeIdExt<T>(this ProxyBase<T> proxyRef,int id) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.SetNodeId(id);
        }

        public static int SetPinIDExt<T>(this ProxyBase<T> proxyRef,int id) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.SetPinID(id);
        }

        public static string SetPinNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.SetPinName(name);
        }

        public static int SetPortTypeExt<T>(this ProxyBase<T> proxyRef,int type) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.SetPortType(type);
        }

        public static int SetSignalEquivExt<T>(this ProxyBase<T> proxyRef,int signalequiv) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.SetSignalEquiv(signalequiv);
        }

        public static int SetSignalNameExt<T>(this ProxyBase<T> proxyRef,string name) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.SetSignalName(name);
        }

        public static int SetUserDefinedExt<T>(this ProxyBase<T> proxyRef,int type = 1) where T : IFunctionalPortInterface
        {
            return proxyRef.Instance.SetUserDefined(type);
        }
        
    }
}