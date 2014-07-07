package com.traitement;

import javax.ejb.Remote;

@Remote
public interface CL_Verification_MotsRemote {
	
	public boolean Verification_Mots(String mot);
	
}
