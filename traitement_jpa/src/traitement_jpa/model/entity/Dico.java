package traitement_jpa.model.entity;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the dico database table.
 * 
 */
@Entity
@NamedQuery(name="Dico.findAll", query="SELECT d FROM Dico d")
public class Dico implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.AUTO)
	@Column(name="id")
	private int id;

	@Column(name="def")
	private String def;

	@Column(name="mot")
	private String mot;

	public Dico() {
	}

	public int getId() {
		return this.id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getDef() {
		return this.def;
	}

	public void setDef(String def) {
		this.def = def;
	}

	public String getMot() {
		return this.mot;
	}

	public void setMot(String mot) {
		this.mot = mot;
	}

}