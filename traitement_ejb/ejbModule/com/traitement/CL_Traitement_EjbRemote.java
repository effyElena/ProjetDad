package com.traitement;

import javax.ejb.Remote;

@Remote
public interface CL_Traitement_EjbRemote {
	
	public double Traitement(String decode);

}
