package com.reception;

import javax.ejb.LocalBean;
import javax.ejb.Stateless;

import com.jms.message.CL_JMS_MessageSearch;

/**
 * Session Bean implementation class CL_Reception
 */
@Stateless
@LocalBean
public class CL_Reception implements CL_ReceptionRemote, CL_ReceptionLocal {

    /**
     * Default constructor. 
     */
    public CL_Reception() {
        // TODO Auto-generated constructor stub
    }
    
    public String Hello(CL_JMS_MessageSearch search){
    	SendMessage(search);
    	return "Message Envoyé";
    }

	public String Post() {
		// TODO Auto-generated method stub
		return "message envoyé: ";
	}

	public String Recieve() {
		// TODO Auto-generated method stub
		return "";
	}
	
	private void SendMessage(CL_JMS_MessageSearch search){	
		new CL_Queue_Sender(search);
	}



}
