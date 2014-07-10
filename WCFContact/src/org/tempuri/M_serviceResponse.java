/**
 * M_serviceResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class M_serviceResponse  implements java.io.Serializable {
    private org.datacontract.schemas._2004._07.Dad_server_component_Server_component.STG m_serviceResult;

    public M_serviceResponse() {
    }

    public M_serviceResponse(
           org.datacontract.schemas._2004._07.Dad_server_component_Server_component.STG m_serviceResult) {
           this.m_serviceResult = m_serviceResult;
    }


    /**
     * Gets the m_serviceResult value for this M_serviceResponse.
     * 
     * @return m_serviceResult
     */
    public org.datacontract.schemas._2004._07.Dad_server_component_Server_component.STG getM_serviceResult() {
        return m_serviceResult;
    }


    /**
     * Sets the m_serviceResult value for this M_serviceResponse.
     * 
     * @param m_serviceResult
     */
    public void setM_serviceResult(org.datacontract.schemas._2004._07.Dad_server_component_Server_component.STG m_serviceResult) {
        this.m_serviceResult = m_serviceResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof M_serviceResponse)) return false;
        M_serviceResponse other = (M_serviceResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.m_serviceResult==null && other.getM_serviceResult()==null) || 
             (this.m_serviceResult!=null &&
              this.m_serviceResult.equals(other.getM_serviceResult())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getM_serviceResult() != null) {
            _hashCode += getM_serviceResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(M_serviceResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">m_serviceResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("m_serviceResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "m_serviceResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "STG"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}
