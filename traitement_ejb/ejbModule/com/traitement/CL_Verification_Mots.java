package com.traitement;

import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import javax.ejb.LocalBean;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.PersistenceContext;
import javax.persistence.Query;

import traitement_jpa.model.entity.Dico;

/**
 * Session Bean implementation class Verification_Mots
 */
@Stateless
@LocalBean
public class CL_Verification_Mots implements CL_Verification_MotsRemote {
	private Query requete = null;
	
    public boolean Verification_Mots(String mot, EntityManager em) {
    	Pattern p = Pattern.compile("[a-zA-Z]", Pattern.MULTILINE);
    	Matcher m = p.matcher(mot);
    	if(mot.length()<25 && m.find()==true){
			this.requete = em.createQuery("SELECT d.mot FROM Dico d WHERE d.mot=:mot");
			this.requete.setParameter("mot", mot);
			List<Dico> dico = this.requete.getResultList();
			if(dico.size() != 0)
			{
				return true;
			}
			else
			{
				return false;
			}
			
    	}
		return false;
    }
}
