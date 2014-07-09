package com.traitement;

import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

import javax.annotation.PostConstruct;
import javax.annotation.PreDestroy;
import javax.ejb.ActivationConfigProperty;
import javax.ejb.MessageDriven;
import javax.jms.JMSException;
import javax.jms.Message;
import javax.jms.MessageListener;
import javax.jms.ObjectMessage;
import javax.jms.TextMessage;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.PersistenceContext;
import javax.persistence.PersistenceUnit;

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
	@PersistenceContext(unitName = "traitement_jpa")
	private EntityManager em;
    /**
     * Default constructor. 
     */
    public CL_Queue_Listener() {
    	
    }
	
    /*@PostConstruct
    public void init () {
    	this.em.flush();
    }*/
    
    @PreDestroy
    public void reset () {
    	this.em.close();
    }
    
	/**
     * @see MessageListener#onMessage(Message)
     */
    public void onMessage(Message message) {
    	List<String> results = new ArrayList<String>();
    	if(message instanceof ObjectMessage) {
    		try {
    		ObjectMessage searchMessage = (ObjectMessage) message;
    		CL_JMS_MessageSearch messageSearch;
			
				messageSearch = (CL_JMS_MessageSearch) searchMessage.getObject();
    		System.out.println("Traitement de la clef :"+messageSearch.getClef()+" contenu:"+messageSearch.getFichier());
        	CL_Traitement_Ejb traitement = new CL_Traitement_Ejb();
        	double pourcentage = traitement.Traitement(messageSearch.getFichier(), messageSearch.getClef(), em);
        	messageSearch.setPourcentage(pourcentage);
        	if(pourcentage>=30)
        	{
    	    	CL_Search_Mail searchMail = new CL_Search_Mail();
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
        	}
        	if(messageSearch.getInformationSecrete() != null)
        	{
        		System.out.println("Nom :"+messageSearch.getNomDocument()+" - Clef :"+messageSearch.getClef()+" - Pourcent:"+messageSearch.getPourcentage()+" - Info:"+messageSearch.getInformationSecrete());
        	}
        	else //if(messageSearch.getPourcentage()>=30)
        	{
        		
    			System.out.println("Nom :"+messageSearch.getNomDocument()+" - Clef :"+messageSearch.getClef()+" - Pourcent:"+messageSearch.getPourcentage());
        		
        	}

			} catch (JMSException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} finally {
				results = null;
			}
        
    	}
    }
}
