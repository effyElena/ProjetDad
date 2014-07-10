package com.traitement;

import java.util.List;

import javax.ejb.Remote;

import traitement_jpa.model.entity.Dico;

@Remote
public interface CL_Traitement_EjbRemote {
	
	public double Traitement(String decode, String clef, List<Dico> dico);

}
