package com.traitement;

import java.util.ArrayList;
import java.util.List;

import javax.ejb.ActivationConfigProperty;
import javax.ejb.MessageDriven;
import javax.jms.Message;
import javax.jms.MessageListener;

import com.jms.message.CL_JMS_MessageSearch;

/**
 * Message-Driven Bean implementation class for: CL_Queue_Listener
 */
@MessageDriven(
		activationConfig = { @ActivationConfigProperty(
				propertyName = "destinationType", propertyValue = "javax.jms.Queue"), @ActivationConfigProperty(
				propertyName = "destination", propertyValue = "queue")
		}, 
		mappedName = "queue")
public class CL_Queue_Listener implements MessageListener {

    /**
     * Default constructor. 
     */
    public CL_Queue_Listener() {
        // TODO Auto-generated constructor stub
    }
	
	/**
     * @see MessageListener#onMessage(Message)
     */
    public void onMessage(Message message) {
    	CL_JMS_MessageSearch messageSearch = new CL_JMS_MessageSearch();
    	messageSearch.setFichier("Coucou tout le monde loic.vigneau@viacesi.fr");
    	CL_Traitement_Ejb traitement = new CL_Traitement_Ejb();
    	double pourcentage = traitement.Traitement(messageSearch.getFichier());
    	messageSearch.setPourcentage(pourcentage);
    	if(pourcentage>50)
    	{
	    	CL_Search_Mail searchMail = new CL_Search_Mail();
	    	List<String> results = new ArrayList<String>();
	    	results = searchMail.SearchMail(messageSearch.getFichier());
	    	String informationSecrete = null;
	    	for (String result : results)
	    	{
	    		if(informationSecrete ==null)
	    		{
	    			informationSecrete = result;
	    		}
	    		else
	    		{
	    			informationSecrete = informationSecrete + ", " + result;
	    		}
	    	}
	    	messageSearch.setInformationSecrete(informationSecrete);
	    	System.out.println(messageSearch.getInformationSecrete());
    	}
    	
    	/*System.out.println("OK");
    	if(message instanceof TextMessage) {
    		System.out.println("OK2");
    		TextMessage text = (TextMessage) message;
    		System.out.println("OK3");
    		try
    		{
    			System.out.println("OK4");
    			System.out.println(this.getClass().getName() + " : " + text.getText());
    			System.out.println("OK5");
    		}
    		catch(JMSException e) {
    			e.printStackTrace();
    		}
    	}*/
        
    }

}
