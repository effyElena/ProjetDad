package com.traitement;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import javax.ejb.LocalBean;
import javax.ejb.Stateless;

/**
 * Session Bean implementation class Search_Mail
 */
@Stateless
@LocalBean
public class CL_Search_Mail implements CL_Search_MailRemote {
    /**
     * Default constructor. 
     */
    public CL_Search_Mail() {
    	
    }
    
    public List<String> SearchMail(String decode){
//    	try {
    	List<String> retour = new ArrayList<String>();
			Scanner scanner = new Scanner(decode);
			while (scanner.hasNext()) { 
				Pattern p = Pattern.compile("[-0-9a-zA-Z.+_+-]+@[-0-9a-zA-Z.+_]+\\.[a-zA-Z]{2,4}", Pattern.MULTILINE); 						
				Matcher m = p.matcher(scanner.next());
				while (m.find()) 
				{ 
				   retour.add(m.group());
				} 
			}
			scanner.close();
//		} 
//		catch (Exception e) { 
//			System.out.println(e.toString()); 
//		}
			System.out.println("SearchMail "+retour);
		return retour;
    }
}
