package com.reception;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;
import javax.jws.soap.SOAPBinding;
import javax.jws.soap.SOAPBinding.Style;



@WebService
@SOAPBinding(style = Style.RPC)
public interface IWSReception {
	@WebMethod(operationName = "Message")
	String Message(@WebParam(name="texte") String texte );

	@WebMethod(operationName = "MessageJMS")
	String MessageJMS(@WebParam(name="nom")String nom,@WebParam(name="message")byte[] message, @WebParam(name="cle")String cle);

}
