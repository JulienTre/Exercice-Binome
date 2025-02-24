<Query Kind="Statements" />










class Employé{
	private string _Nom;
	private string _Prenom;
	private int _Id;
	private DateOnly _DateEmbauche;
	
	
	public Employé(string Nom, string Prenom, int Id, DateOnly DateEmbauche){
		
		SetNom(Nom);
		SetPrenom(Prenom);
		SetId(Id);
		SetDateEmbauche(DateEmbauche);
	}
	
	public string Nom => _Nom;
	public string Prenom => _Prenom;
	public int Id => _Id;
	public DateOnly DateEmbauche => _DateEmbauche;
	
	public void SetNom(string Nom){
		_Nom=Nom;
	}

	public void SetPrenom(string Prenom)
	{
		_Prenom = Prenom;
	}
	
	public void SetId(int id){
		_Id=Id;
	}
	
	public void SetDateEmbauche(DateOnly DateEmbauche){
		_DateEmbauche=DateEmbauche;
	}
	
	public int CalculerAncienneté(){
		 
		 DateOnly date =new (2025,2,24);
		
		
		
		int dates = date.Year - DateEmbauche.Year;
		
		return dates;
	}
	
	
	
	public void AfficherInfos()
	{
		("Entreprise : High-Tech").Dump();
		("ID : "+ Id).Dump();
		("Nom : "+ Nom).Dump();
		("Prenom : "+ Prenom).Dump();
		("Date d'embauche : "+ DateEmbauche).Dump();
	}
	
}