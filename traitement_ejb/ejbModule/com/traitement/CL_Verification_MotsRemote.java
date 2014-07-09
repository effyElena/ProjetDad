package com.traitement;

import javax.ejb.Remote;
import javax.persistence.EntityManager;

@Remote
public interface CL_Verification_MotsRemote {
	
	public boolean Verification_Mots(String mot, EntityManager em);
	
}
