package com.jms.message;

import java.io.Serializable;

public class JMSMesageSearch implements Serializable {

	private String clef;
	
	private String fichier;
	
	private String nomDocument;
	
	private String informationSecrete;
	
	private double percent;
	
	public void setClef(String clef){
		this.clef = clef;
	}
	
	public String geClef(){
		return this.clef;
	}
	
	public void setFichier(String fichier) {
		this.fichier = fichier;
	}
	
	public String getFichier(){
		return this.fichier;
	}
	
	public void setNomDocuement(String nomDocument){
		this.nomDocument = nomDocument;
	}
	
	public String getNomDocuement(){
		return this.nomDocument;
	}
	
	public void setInformationSecrete(String informationSecrete)
	{
		this.informationSecrete = informationSecrete;
	}
	
	public String getInformationSecrete(){
		return this.informationSecrete;
	}
}
