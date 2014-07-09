package com.traitement;

import java.util.List;

import javax.ejb.Remote;

@Remote
public interface CL_Search_MailRemote {

	public List<String> SearchMail(String decode);
	
}
