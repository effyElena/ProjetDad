package com.reception;

import javax.jms.Connection;
import javax.jms.ConnectionFactory;
import javax.jms.JMSException;
import javax.jms.Message;
import javax.jms.MessageProducer;
import javax.jms.Queue;
import javax.jms.Session;
import javax.jms.TextMessage;
import javax.naming.Context;
import javax.naming.InitialContext;
import javax.naming.NamingException;

import com.jms.message.CL_JMS_MessageSearch;

public class CL_Queue_Sender {

	private static final String CONNECTION_FACTORY = "jms/Connection";
    private static final String CONNECTION_QUEUE = "jms/queue";
 
    /**
     * @param args
     */
    public CL_Queue_Sender(CL_JMS_MessageSearch search ) {
        ConnectionFactory connectionFactory = null;
        Connection connection = null;
        //Get the JNDI Context
        try {
            Context jndiContext = new InitialContext();
             
            //Create the Connection Factory
            connectionFactory = (ConnectionFactory) jndiContext.lookup(CL_Queue_Sender.CONNECTION_FACTORY);
            connection = connectionFactory.createConnection();
             
            //Create the session
            //Session session = connection.createSession(false, Session.AUTO_ACKNOWLEDGE);
            Session session = connection.createSession(true, 0);
            
            //Initialize Message Producer
            MessageProducer producer = null;
             
            //Call methods to send publish messages
            publishToQueue(producer, jndiContext, session, search);
             
            System.out.println("Messages Sent!!! cle: "+search.getClef() );
            
            session.close();
        } catch (NamingException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        } catch (JMSException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }finally{
            try {
                if(connection != null){
                	
                    connection.close();
                }
            } catch (JMSException e) {
                e.printStackTrace();
            }
        }
    }
     
     
    private static void publishToQueue(MessageProducer producer, Context jndiContext, Session session, CL_JMS_MessageSearch search) throws NamingException, JMSException{
        //Create new Queue
        Queue queue = (Queue) jndiContext.lookup(CL_Queue_Sender.CONNECTION_QUEUE);
         
        //Create Message Producer
        producer = session.createProducer(queue);
         
        //Send TextMessage
        Message message = session.createObjectMessage(search);
        
        producer.send(message);
    }

	
}