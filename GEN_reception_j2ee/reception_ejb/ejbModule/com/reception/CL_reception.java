package com.reception;

import javax.ejb.LocalBean;
import javax.ejb.Stateless;

/**
 * Session Bean implementation class CL_reception
 */
@Stateless
@LocalBean
public class CL_reception implements CL_receptionRemote, CL_receptionLocal {

    /**
     * Default constructor. 
     */
    public CL_reception() {
        // TODO Auto-generated constructor stub
    }

}