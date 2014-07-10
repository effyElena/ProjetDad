package org.tempuri;

public class I_SERVCProxy implements org.tempuri.I_SERVC {
  private String _endpoint = null;
  private org.tempuri.I_SERVC i_SERVC = null;
  
  public I_SERVCProxy() {
    _initI_SERVCProxy();
  }
  
  public I_SERVCProxy(String endpoint) {
    _endpoint = endpoint;
    _initI_SERVCProxy();
  }
  
  private void _initI_SERVCProxy() {
    try {
      i_SERVC = (new org.tempuri.CL_SERVCLocator()).gethttp();
      if (i_SERVC != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)i_SERVC)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)i_SERVC)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (i_SERVC != null)
      ((javax.xml.rpc.Stub)i_SERVC)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.I_SERVC getI_SERVC() {
    if (i_SERVC == null)
      _initI_SERVCProxy();
    return i_SERVC;
  }
  
  public org.datacontract.schemas._2004._07.Dad_server_component_Server_component.STG m_service(org.datacontract.schemas._2004._07.Dad_server_component_Server_component.STG msg) throws java.rmi.RemoteException{
    if (i_SERVC == null)
      _initI_SERVCProxy();
    return i_SERVC.m_service(msg);
  }
  
  public void file(org.datacontract.schemas._2004._07.Dad_server_component_Server_component.FILE file) throws java.rmi.RemoteException{
    if (i_SERVC == null)
      _initI_SERVCProxy();
    i_SERVC.file(file);
  }
  
  
}