package com.traitement;

import java.util.List;
import javax.ejb.LocalBean;
import javax.ejb.Stateless;
import traitement_jpa.model.entity.Dico;

/**
 * Session Bean implementation class Verification_Mots
 */
@Stateless
@LocalBean
public class CL_Verification_Mots implements CL_Verification_MotsRemote {
    public int Verification_Mots(String mot, List<Dico> dico) {
    	/*Pattern p = Pattern.compile("[a-zA-Z]", Pattern.MULTILINE);
    	Matcher m = p.matcher(mot);*/
    	if(mot.length()<31 /*& m.find()==true*/){
			if(dico.contains(mot)==true)
			{
				return 1;
			}
			else
			{
				return 0;
			}
    	}
		return 2;
    }
}