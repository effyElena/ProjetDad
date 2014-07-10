package com.reception;

import java.io.UnsupportedEncodingException;

import javax.jws.WebParam;
import javax.jws.WebService;

import com.jms.message.CL_JMS_MessageSearch;
import com.sun.xml.internal.ws.util.ByteArrayBuffer;

@WebService(endpointInterface = "com.reception.IWSReception")
public class CL_WS_Reception implements IWSReception {

	@Override
	public String Message(String texte) {
		// TODO Auto-generated method stub
		return new CL_Reception().Post();
	}
	
	@Override
	public String MessageJMS(String nom , byte[] message , String cle) {
		// TODO Auto-generated method stub
		CL_JMS_MessageSearch search = new CL_JMS_MessageSearch();
		search.setNomDocument(nom);
		try {
			search.setFichier(new String(message,"UTF-8"));
		} catch (UnsupportedEncodingException e) {
			e.printStackTrace();
		}
		search.setClef(cle);
		return new CL_Reception().Hello(search);
	}
}
