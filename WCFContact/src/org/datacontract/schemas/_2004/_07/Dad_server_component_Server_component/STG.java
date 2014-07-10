/**
 * STG.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.datacontract.schemas._2004._07.Dad_server_component_Server_component;

public class STG  implements java.io.Serializable {
    private java.lang.Object[][] data;

    private java.lang.String[] dataJ2Ee;

    private java.lang.String info;

    private java.lang.String operationName;

    private java.lang.Boolean statut_op;

    private java.lang.String tokenApll;

    private java.lang.String tokenUser;

    private java.lang.Integer userId;

    private org.apache.axis.types.Id id;  // attribute

    private org.apache.axis.types.IDRef ref;  // attribute

    public STG() {
    }

    public STG(
           java.lang.Object[][] data,
           java.lang.String[] dataJ2Ee,
           java.lang.String info,
           java.lang.String operationName,
           java.lang.Boolean statut_op,
           java.lang.String tokenApll,
           java.lang.String tokenUser,
           java.lang.Integer userId,
           org.apache.axis.types.Id id,
           org.apache.axis.types.IDRef ref) {
           this.data = data;
           this.dataJ2Ee = dataJ2Ee;
           this.info = info;
           this.operationName = operationName;
           this.statut_op = statut_op;
           this.tokenApll = tokenApll;
           this.tokenUser = tokenUser;
           this.userId = userId;
           this.id = id;
           this.ref = ref;
    }


    /**
     * Gets the data value for this STG.
     * 
     * @return data
     */
    public java.lang.Object[][] getData() {
        return data;
    }


    /**
     * Sets the data value for this STG.
     * 
     * @param data
     */
    public void setData(java.lang.Object[][] data) {
        this.data = data;
    }


    /**
     * Gets the dataJ2Ee value for this STG.
     * 
     * @return dataJ2Ee
     */
    public java.lang.String[] getDataJ2Ee() {
        return dataJ2Ee;
    }


    /**
     * Sets the dataJ2Ee value for this STG.
     * 
     * @param dataJ2Ee
     */
    public void setDataJ2Ee(java.lang.String[] dataJ2Ee) {
        this.dataJ2Ee = dataJ2Ee;
    }


    /**
     * Gets the info value for this STG.
     * 
     * @return info
     */
    public java.lang.String getInfo() {
        return info;
    }


    /**
     * Sets the info value for this STG.
     * 
     * @param info
     */
    public void setInfo(java.lang.String info) {
        this.info = info;
    }


    /**
     * Gets the operationName value for this STG.
     * 
     * @return operationName
     */
    public java.lang.String getOperationName() {
        return operationName;
    }


    /**
     * Sets the operationName value for this STG.
     * 
     * @param operationName
     */
    public void setOperationName(java.lang.String operationName) {
        this.operationName = operationName;
    }


    /**
     * Gets the statut_op value for this STG.
     * 
     * @return statut_op
     */
    public java.lang.Boolean getStatut_op() {
        return statut_op;
    }


    /**
     * Sets the statut_op value for this STG.
     * 
     * @param statut_op
     */
    public void setStatut_op(java.lang.Boolean statut_op) {
        this.statut_op = statut_op;
    }


    /**
     * Gets the tokenApll value for this STG.
     * 
     * @return tokenApll
     */
    public java.lang.String getTokenApll() {
        return tokenApll;
    }


    /**
     * Sets the tokenApll value for this STG.
     * 
     * @param tokenApll
     */
    public void setTokenApll(java.lang.String tokenApll) {
        this.tokenApll = tokenApll;
    }


    /**
     * Gets the tokenUser value for this STG.
     * 
     * @return tokenUser
     */
    public java.lang.String getTokenUser() {
        return tokenUser;
    }


    /**
     * Sets the tokenUser value for this STG.
     * 
     * @param tokenUser
     */
    public void setTokenUser(java.lang.String tokenUser) {
        this.tokenUser = tokenUser;
    }


    /**
     * Gets the userId value for this STG.
     * 
     * @return userId
     */
    public java.lang.Integer getUserId() {
        return userId;
    }


    /**
     * Sets the userId value for this STG.
     * 
     * @param userId
     */
    public void setUserId(java.lang.Integer userId) {
        this.userId = userId;
    }


    /**
     * Gets the id value for this STG.
     * 
     * @return id
     */
    public org.apache.axis.types.Id getId() {
        return id;
    }


    /**
     * Sets the id value for this STG.
     * 
     * @param id
     */
    public void setId(org.apache.axis.types.Id id) {
        this.id = id;
    }


    /**
     * Gets the ref value for this STG.
     * 
     * @return ref
     */
    public org.apache.axis.types.IDRef getRef() {
        return ref;
    }


    /**
     * Sets the ref value for this STG.
     * 
     * @param ref
     */
    public void setRef(org.apache.axis.types.IDRef ref) {
        this.ref = ref;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof STG)) return false;
        STG other = (STG) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.data==null && other.getData()==null) || 
             (this.data!=null &&
              java.util.Arrays.equals(this.data, other.getData()))) &&
            ((this.dataJ2Ee==null && other.getDataJ2Ee()==null) || 
             (this.dataJ2Ee!=null &&
              java.util.Arrays.equals(this.dataJ2Ee, other.getDataJ2Ee()))) &&
            ((this.info==null && other.getInfo()==null) || 
             (this.info!=null &&
              this.info.equals(other.getInfo()))) &&
            ((this.operationName==null && other.getOperationName()==null) || 
             (this.operationName!=null &&
              this.operationName.equals(other.getOperationName()))) &&
            ((this.statut_op==null && other.getStatut_op()==null) || 
             (this.statut_op!=null &&
              this.statut_op.equals(other.getStatut_op()))) &&
            ((this.tokenApll==null && other.getTokenApll()==null) || 
             (this.tokenApll!=null &&
              this.tokenApll.equals(other.getTokenApll()))) &&
            ((this.tokenUser==null && other.getTokenUser()==null) || 
             (this.tokenUser!=null &&
              this.tokenUser.equals(other.getTokenUser()))) &&
            ((this.userId==null && other.getUserId()==null) || 
             (this.userId!=null &&
              this.userId.equals(other.getUserId()))) &&
            ((this.id==null && other.getId()==null) || 
             (this.id!=null &&
              this.id.equals(other.getId()))) &&
            ((this.ref==null && other.getRef()==null) || 
             (this.ref!=null &&
              this.ref.equals(other.getRef())));
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
        if (getData() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getData());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getData(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
        }
        if (getDataJ2Ee() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getDataJ2Ee());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getDataJ2Ee(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
        }
        if (getInfo() != null) {
            _hashCode += getInfo().hashCode();
        }
        if (getOperationName() != null) {
            _hashCode += getOperationName().hashCode();
        }
        if (getStatut_op() != null) {
            _hashCode += getStatut_op().hashCode();
        }
        if (getTokenApll() != null) {
            _hashCode += getTokenApll().hashCode();
        }
        if (getTokenUser() != null) {
            _hashCode += getTokenUser().hashCode();
        }
        if (getUserId() != null) {
            _hashCode += getUserId().hashCode();
        }
        if (getId() != null) {
            _hashCode += getId().hashCode();
        }
        if (getRef() != null) {
            _hashCode += getRef().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(STG.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "STG"));
        org.apache.axis.description.AttributeDesc attrField = new org.apache.axis.description.AttributeDesc();
        attrField.setFieldName("id");
        attrField.setXmlName(new javax.xml.namespace.QName("http://schemas.microsoft.com/2003/10/Serialization/", "Id"));
        attrField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "ID"));
        typeDesc.addFieldDesc(attrField);
        attrField = new org.apache.axis.description.AttributeDesc();
        attrField.setFieldName("ref");
        attrField.setXmlName(new javax.xml.namespace.QName("http://schemas.microsoft.com/2003/10/Serialization/", "Ref"));
        attrField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "IDREF"));
        typeDesc.addFieldDesc(attrField);
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("data");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "data"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://schemas.microsoft.com/2003/10/Serialization/Arrays", "ArrayOfanyType"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        elemField.setItemQName(new javax.xml.namespace.QName("http://schemas.microsoft.com/2003/10/Serialization/Arrays", "ArrayOfanyType"));
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("dataJ2Ee");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "dataJ2ee"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        elemField.setItemQName(new javax.xml.namespace.QName("http://schemas.microsoft.com/2003/10/Serialization/Arrays", "string"));
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("info");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "info"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("operationName");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "operationName"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("statut_op");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "statut_op"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "boolean"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("tokenApll");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "tokenApll"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("tokenUser");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "tokenUser"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("userId");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "userId"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
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
