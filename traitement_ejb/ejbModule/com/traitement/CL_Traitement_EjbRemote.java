package com.traitement;

import javax.ejb.Remote;
import javax.persistence.EntityManager;

@Remote
public interface CL_Traitement_EjbRemote {
	
	public double Traitement(String decode, String clef, EntityManager em);

}
