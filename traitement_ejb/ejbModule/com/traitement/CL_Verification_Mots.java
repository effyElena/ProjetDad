package com.traitement;

import java.util.List;

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
	@PersistenceContext(unitName = "traitement_jpa")
	private EntityManagerFactory emf;
	private EntityManager em;
	private Query requete = null;
	
    public boolean Verification_Mots(String mot) {
    	emf = Persistence.createEntityManagerFactory("traitement_jpa");
    	this.em = this.emf.createEntityManager();
    	this.em.flush();
		this.requete = this.em.createQuery("SELECT d FROM Dico d WHERE d.mot=:mot");
		this.requete.setParameter("mot", mot);
		List<Dico> dico = this.requete.getResultList();
		if(dico.size() != 0)
		{
			em.close();
			return true;
		}
		else
		{
			em.close();
			return false;
		}
    }
}
