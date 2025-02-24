<Query Kind="Statements" />

class Entreprise{
	private string nomEntreprise;
	private int[] Employé;
	
	public  Entreprise (string nomEntreprise,int[] Employé)
	{
		AjouterEmployé(Employé);
		AfficherEmployé().Dump();
	}
	
	public void AjouterEmployé(int[] Employé)
	{
		Employé = new int();
	}
	
	public void AfficherEmployé()
	{
		nomEntreprise.Dump();
		Employé.Dump("Liste d'employés: ");
	}
		
	
}