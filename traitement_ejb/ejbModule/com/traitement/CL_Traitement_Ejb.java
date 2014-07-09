package com.traitement;

import java.util.Scanner;

import javax.ejb.LocalBean;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;

/**
 * Session Bean implementation class Traitement_Ejb
 */
@Stateless
@LocalBean
public class CL_Traitement_Ejb implements CL_Traitement_EjbRemote {

    /**
     * Default constructor. 
     */
    public CL_Traitement_Ejb() {
		
    }
    public double Traitement(String decode, String clef, EntityManager em){
    	int nbMotTotal = 0, nbMot = 0;
		Scanner scanner = new Scanner(decode);
		CL_Verification_Mots verif = new CL_Verification_Mots();
		while(scanner.hasNext()){
			boolean bool = false;
			boolean init = true;
			System.out.println("Clef:"+clef+" Vérification");
			for(int i =0; i<5; i++)
			{
				if(verif.Verification_Mots(scanner.next().replace(".", ""), em) && (init || bool))
				{
					nbMot++;
					bool = true;
					init = false;
				}
				else
				{
					bool = false;
				}
			}
			if(verif.Verification_Mots(scanner.next().replace(".", ""), em) && bool)
			{
				nbMot++;
				bool = true;
			}
			nbMotTotal++;
		}
		scanner.close();
		return ((double)nbMot*100)/(double)nbMotTotal;
    }
}
