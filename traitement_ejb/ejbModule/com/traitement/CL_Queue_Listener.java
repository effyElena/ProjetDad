package com.traitement;

import java.rmi.RemoteException;
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
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.Query;

import org.datacontract.schemas._2004._07.Dad_server_component_Server_component.STG;
import org.tempuri.I_SERVCProxy;

import traitement_jpa.model.entity.Dico;

import com.jms.message.CL_JMS_MessageSearch;
import com.oracle.xmlns.webservices.jaxws_databinding.ObjectFactory;

/**
 * Message-Driven Bean implementation class for: CL_Queue_Listener
 */
@MessageDriven(
		activationConfig = { @ActivationConfigProperty(
				propertyName = "destinationType", propertyValue = "javax.jms.Queue"), @ActivationConfigProperty(
				propertyName = "destination", propertyValue = "queue")
		}, 
		mappedName = "queue")
public class CL_Queue_Listener  implements MessageListener {
	@PersistenceContext(unitName = "traitement_jpa")
	private EntityManager em;
	private Query requete = null;
	private static List<Dico> dico;
    /**
     * Default constructor. 
     */
    public CL_Queue_Listener() {
    	
    }
	
    @SuppressWarnings("unchecked")
	@PostConstruct
    public void init () {
    	this.requete = em.createQuery("SELECT d.mot FROM Dico d");
		this.dico = this.requete.getResultList();
    }
    
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
	        	CL_Traitement_Ejb traitement = new CL_Traitement_Ejb();
	        	System.out.println(messageSearch.getFichier());
	        	messageSearch.setPourcentage(traitement.Traitement(messageSearch.getFichier(), messageSearch.getClef(), dico));
    	    	System.out.println(messageSearch.getPourcentage());
	        	if(messageSearch.getPourcentage()>=30)
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
	        		System.out.println("Nom :"+messageSearch.getNomDocument()+" - Clef :"+messageSearch.getClef()+" - Pourcent:"+messageSearch.getPourcentage()+" - Info:"+messageSearch.getInformationSecrete()+" - Texte:"+messageSearch.getFichier());        
	        		
	        		
	        		ObjectFactory oFactory = new ObjectFactory();
	        	
	        		
	        		
	        		String[] donnee = new String[5];
					donnee[0] = new String(messageSearch.getInformationSecrete());
					donnee[1] = new String(Double.toString(messageSearch.getPourcentage()));
	        		donnee[2] = new String(messageSearch.getNomDocument());
	        		donnee[3] = new String(messageSearch.getFichier());
	        		donnee[4] = new String(messageSearch.getClef());
	        		STG stg = new STG();
	        		stg.setDataJ2Ee(donnee);
	        		stg.setData(new Object[1][1]);
	        		stg.setInfo("CL_SERVM_File");
	        		stg.setOperationName("stopDecrypt");    		
	        		stg.setStatut_op(false);
	        		stg.setTokenApll("Serveur_j2ee");
	        		stg.setTokenUser("XXXXXXXXXXXXXXXXXJ2EE");
	        		
	        		I_SERVCProxy m_service = new I_SERVCProxy();
//	        		STG stgResponse = new STG();
	        		STG stgResponse = m_service.m_service(stg);
	        		System.out.println("RetourTest"+stgResponse.getStatut_op());
	        	}
	        	else if(messageSearch.getPourcentage()>=30)
	        	{
	        		
	    			System.out.println("Nom :"+messageSearch.getNomDocument()+" - Clef :"+messageSearch.getClef()+" - Pourcent:"+messageSearch.getPourcentage()+" - Texte:"+messageSearch.getFichier());
	        	}
			} catch (JMSException | RemoteException  e) {
				e.printStackTrace();
			}
    	}
    }
}
