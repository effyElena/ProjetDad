/**
 * FILE.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.datacontract.schemas._2004._07.Dad_server_component_Server_component;

public class FILE  implements java.io.Serializable {
    private java.lang.String content;

    private java.lang.String file_code;

    private java.util.Calendar file_date;

    private java.lang.String file_email;

    private java.lang.String file_name;

    private java.lang.String file_url;

    private java.lang.Integer state;

    private org.apache.axis.types.Id id;  // attribute

    private org.apache.axis.types.IDRef ref;  // attribute

    public FILE() {
    }

    public FILE(
           java.lang.String content,
           java.lang.String file_code,
           java.util.Calendar file_date,
           java.lang.String file_email,
           java.lang.String file_name,
           java.lang.String file_url,
           java.lang.Integer state,
           org.apache.axis.types.Id id,
           org.apache.axis.types.IDRef ref) {
           this.content = content;
           this.file_code = file_code;
           this.file_date = file_date;
           this.file_email = file_email;
           this.file_name = file_name;
           this.file_url = file_url;
           this.state = state;
           this.id = id;
           this.ref = ref;
    }


    /**
     * Gets the content value for this FILE.
     * 
     * @return content
     */
    public java.lang.String getContent() {
        return content;
    }


    /**
     * Sets the content value for this FILE.
     * 
     * @param content
     */
    public void setContent(java.lang.String content) {
        this.content = content;
    }


    /**
     * Gets the file_code value for this FILE.
     * 
     * @return file_code
     */
    public java.lang.String getFile_code() {
        return file_code;
    }


    /**
     * Sets the file_code value for this FILE.
     * 
     * @param file_code
     */
    public void setFile_code(java.lang.String file_code) {
        this.file_code = file_code;
    }


    /**
     * Gets the file_date value for this FILE.
     * 
     * @return file_date
     */
    public java.util.Calendar getFile_date() {
        return file_date;
    }


    /**
     * Sets the file_date value for this FILE.
     * 
     * @param file_date
     */
    public void setFile_date(java.util.Calendar file_date) {
        this.file_date = file_date;
    }


    /**
     * Gets the file_email value for this FILE.
     * 
     * @return file_email
     */
    public java.lang.String getFile_email() {
        return file_email;
    }


    /**
     * Sets the file_email value for this FILE.
     * 
     * @param file_email
     */
    public void setFile_email(java.lang.String file_email) {
        this.file_email = file_email;
    }


    /**
     * Gets the file_name value for this FILE.
     * 
     * @return file_name
     */
    public java.lang.String getFile_name() {
        return file_name;
    }


    /**
     * Sets the file_name value for this FILE.
     * 
     * @param file_name
     */
    public void setFile_name(java.lang.String file_name) {
        this.file_name = file_name;
    }


    /**
     * Gets the file_url value for this FILE.
     * 
     * @return file_url
     */
    public java.lang.String getFile_url() {
        return file_url;
    }


    /**
     * Sets the file_url value for this FILE.
     * 
     * @param file_url
     */
    public void setFile_url(java.lang.String file_url) {
        this.file_url = file_url;
    }


    /**
     * Gets the state value for this FILE.
     * 
     * @return state
     */
    public java.lang.Integer getState() {
        return state;
    }


    /**
     * Sets the state value for this FILE.
     * 
     * @param state
     */
    public void setState(java.lang.Integer state) {
        this.state = state;
    }


    /**
     * Gets the id value for this FILE.
     * 
     * @return id
     */
    public org.apache.axis.types.Id getId() {
        return id;
    }


    /**
     * Sets the id value for this FILE.
     * 
     * @param id
     */
    public void setId(org.apache.axis.types.Id id) {
        this.id = id;
    }


    /**
     * Gets the ref value for this FILE.
     * 
     * @return ref
     */
    public org.apache.axis.types.IDRef getRef() {
        return ref;
    }


    /**
     * Sets the ref value for this FILE.
     * 
     * @param ref
     */
    public void setRef(org.apache.axis.types.IDRef ref) {
        this.ref = ref;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof FILE)) return false;
        FILE other = (FILE) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.content==null && other.getContent()==null) || 
             (this.content!=null &&
              this.content.equals(other.getContent()))) &&
            ((this.file_code==null && other.getFile_code()==null) || 
             (this.file_code!=null &&
              this.file_code.equals(other.getFile_code()))) &&
            ((this.file_date==null && other.getFile_date()==null) || 
             (this.file_date!=null &&
              this.file_date.equals(other.getFile_date()))) &&
            ((this.file_email==null && other.getFile_email()==null) || 
             (this.file_email!=null &&
              this.file_email.equals(other.getFile_email()))) &&
            ((this.file_name==null && other.getFile_name()==null) || 
             (this.file_name!=null &&
              this.file_name.equals(other.getFile_name()))) &&
            ((this.file_url==null && other.getFile_url()==null) || 
             (this.file_url!=null &&
              this.file_url.equals(other.getFile_url()))) &&
            ((this.state==null && other.getState()==null) || 
             (this.state!=null &&
              this.state.equals(other.getState()))) &&
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
        if (getContent() != null) {
            _hashCode += getContent().hashCode();
        }
        if (getFile_code() != null) {
            _hashCode += getFile_code().hashCode();
        }
        if (getFile_date() != null) {
            _hashCode += getFile_date().hashCode();
        }
        if (getFile_email() != null) {
            _hashCode += getFile_email().hashCode();
        }
        if (getFile_name() != null) {
            _hashCode += getFile_name().hashCode();
        }
        if (getFile_url() != null) {
            _hashCode += getFile_url().hashCode();
        }
        if (getState() != null) {
            _hashCode += getState().hashCode();
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
        new org.apache.axis.description.TypeDesc(FILE.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "FILE"));
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
        elemField.setFieldName("content");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "content"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("file_code");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "file_code"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("file_date");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "file_date"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "dateTime"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("file_email");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "file_email"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("file_name");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "file_name"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("file_url");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "file_url"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("state");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Dad_server_component.Server_component", "state"));
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
