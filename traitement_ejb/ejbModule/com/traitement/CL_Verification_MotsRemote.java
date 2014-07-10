package com.traitement;

import java.util.List;

import javax.ejb.Remote;
import traitement_jpa.model.entity.Dico;

@Remote
public interface CL_Verification_MotsRemote {
	
	public int Verification_Mots(String mot, List<Dico> dico);
	
}
