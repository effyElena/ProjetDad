package com.traitement;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import javax.ejb.LocalBean;
import javax.ejb.Stateless;

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
    public double Traitement(String decode){
    	int nbMotTotal = 0;
		int nbMot = 0;
		List<String> mots = new ArrayList<String>();
		Scanner scanner = new Scanner(decode);
		while(scanner.hasNext()){
			mots.add(scanner.next().replace(".", ""));
			nbMotTotal++;
		}
		scanner.close();
		CL_Verification_Mots verif = new CL_Verification_Mots();
		for(String mot : mots){
			if(verif.Verification_Mots(mot) == true)
			{
				nbMot++;
			}
		}
		double nombreMot = nbMot;
		double nombreMotTotal = nbMotTotal;
		double calc = nombreMot/nombreMotTotal;
		double percent = calc*100;
		return percent;	
    }

}
