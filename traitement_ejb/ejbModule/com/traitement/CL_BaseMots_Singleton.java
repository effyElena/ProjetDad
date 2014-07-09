package com.traitement;

import java.util.List;

import javax.ejb.Singleton;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.Query;

import traitement_jpa.model.entity.Dico;

public class CL_BaseMots_Singleton {
	private static CL_BaseMots_Singleton INSTANCE = null;
	@PersistenceContext(unitName = "traitement_jpa")
	private EntityManager em;
	private Query requete = null;
	List<Dico> dico;
	
	protected CL_BaseMots_Singleton(){
		this.requete = em.createQuery("SELECT d.mot FROM Dico d");
		dico = this.requete.getResultList();
		this.em.close();
	}
	
	public static CL_BaseMots_Singleton getInstance(){
		if(INSTANCE == null)
		{ 	
			INSTANCE = new CL_BaseMots_Singleton();	
		}
		return INSTANCE;
	}
}