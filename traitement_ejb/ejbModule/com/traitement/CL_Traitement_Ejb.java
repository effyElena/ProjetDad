package com.traitement;

import java.util.List;
import java.util.Scanner;

import javax.ejb.LocalBean;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;

import traitement_jpa.model.entity.Dico;

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
    
    public double Traitement(String decode, String clef, List<Dico> dico){
    	int nbMotTotal = 0, nbMot = 0;
		Scanner scanner = new Scanner(decode);
		CL_Verification_Mots verif = new CL_Verification_Mots();
		int retour = 0;
		while(scanner.hasNext() && retour !=2){
			//boolean bool = false;
			//boolean init = true;
			//for(int i =0; i<5; i++)
			//{
				/*if(scanner.hasNext())
				{*/
			retour = verif.Verification_Mots(scanner.next().replace(".", ""), dico);
					if(retour == 1 /*&& (init || bool)*/)
					{
						nbMot++;
						/*bool = true;
						init = false;*/
					}
					/*else
					{
						bool = false;
					}*/
				//}
			//}
			/*if(verif.Verification_Mots(scanner.next().replace(".", ""), dico) && bool)
			{
				nbMot++;
				bool = true;
			}*/
			nbMotTotal++;
		}
		scanner.close();
		if (retour == 0 || retour == 1)
		{
			return ((double)nbMot*100)/(double)nbMotTotal;
		}
		else
		{
			return 0;
		}
    }
}
